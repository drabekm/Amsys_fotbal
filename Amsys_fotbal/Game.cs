using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Amsys_fotbal
{
    public class Game
    {

        List<Player> players = new List<Player>();

        
        SortedSet<string> wordSet; // dictionary of allowed words
        public SortedSet<string> WordSet { get { return wordSet; } private set { wordSet = value; } }

        public SortedSet<string> usedWordsSet; // dictionary of used words
        public SortedSet<string> UsedWordSet { get { return usedWordsSet; } private set { usedWordsSet = value; } }
        

        
        string previousWord = ""; // word entered by a previous player
        public string PreviousWord { get { return previousWord; } set { previousWord = value; } }

        int playerCount;
        int currentPlayerIndex = 0;
        int nextPlayerIndex = 1;


        //Settings
        bool checkLetter, checkTwoLetters, checkSyllable, repeatWords;

        bool gameOver = false;
        public bool GameOver { get; set; }


        public Game(List<string> playerNames, bool checkLetter, bool checkTwoLetters, bool checkSyllable, bool repeatWords, SortedSet<string> wordSet)
        {
            //Save the game wordset
            this.WordSet = wordSet;

            //Aply settings
            this.checkLetter = checkLetter;
            this.checkTwoLetters = checkTwoLetters;
            this.checkSyllable = checkSyllable;
            this.repeatWords = repeatWords;
            if (!repeatWords) 
            {
                this.UsedWordSet = new SortedSet<string>();
            }

            //Create players
            playerCount = playerNames.Count;
            foreach (string name in playerNames)
            {
                //TODO: Check if player is cpu
                if (name.StartsWith("CPU"))
                {
                    ComputerPlayer newComputerPlayer = new ComputerPlayer(name, wordSet, usedWordsSet);
                    players.Add(newComputerPlayer);
                }
                else
                {
                    Player newPlayer = new Player(name);
                    players.Add(newPlayer);
                }   
            }                       
        }

        /// <summary>
        /// Returns the current player
        /// </summary>
        /// <returns>Current player instantce</returns>
        public Player GetCurrentPlayer()
        {
            return players[currentPlayerIndex];
        }


        /// <summary>
        /// Checks which players are still playing and haven't given up.
        /// </summary>
        /// <returns>Count of active players</returns>
        public int ActivePlayerCount()
        {
            int activePlayers = 0;
            for(int i = 0; i < players.Count; i++)
            {
                if (players[i].IsPlaying)
                { 
                    activePlayers++;
                }
            }
            return activePlayers;
        }

        /// <summary>
        /// Checks if the player input is in the provided dictionary of words
        /// </summary>
        /// <returns>True if word passed the tests</returns>
        public bool CheckInput(string word)
        {
            bool isInputValid = false;

            //PreviousWord being empty indicates game just started and there isn't anything
            //to compare the current word aginst
            if (PreviousWord == "")
            {
                PreviousWord = word;
                return true;
            }

            //Check if the word is in the wordset
            if (!wordSet.Contains(word))
            {
                MessageBox.Show("Slovo není ve slovníku");
                return false;
            }
            //Check last letter
            if(checkLetter && PreviousWord != "")
            {
                if (word[0] == PreviousWord[PreviousWord.Length - 1])
                    isInputValid = true;
            }
            //Check last two letters
            if(checkTwoLetters && PreviousWord != "")
            {
                if(word[0] == PreviousWord[PreviousWord.Length - 2] &&
                   word[1] == PreviousWord[PreviousWord.Length - 1])
                {
                    isInputValid = true;
                }
            }
            //Check syllables
            if(checkSyllable && PreviousWord != "")
            {
                string oldWordLastSyllable = FindSyllable(PreviousWord, false);
                string newWordFirstSyllable = FindSyllable(word, true);
                if (oldWordLastSyllable.Equals(newWordFirstSyllable))
                {
                    isInputValid = true;
                }
            }

            //Check repeating words
            if(!repeatWords)
            {
                if(usedWordsSet.Contains(word))
                {
                    isInputValid = false;
                }

                if(isInputValid) //If the word is still valid. Add it to the used words set
                {
                    usedWordsSet.Add(word);
                }
            }

           

            if(isInputValid)
            {
                PreviousWord = word;
            }

            if(!isInputValid)
            {
                MessageBox.Show("Slovo neprošlo testy");
            }

            return isInputValid;
        }

        /// <summary>
        /// Finds syllables in a given word and returns either the first one or the last one 
        /// depending on the bool value
        /// </summary>
        /// <param name="word">Word to separate into syllables</param>
        /// <param name="returnFirstSyllable">Returns first syllable if true, last if false</param>
        /// <returns></returns>
        public string FindSyllable(string word, bool returnFirstSyllable)
        {
            //It took me a while to figure out a simple way on how to divide words into syllables
            //It doesn't work perfectly but it's good enough for like 50% of words

            //Everything after the seccond last vowel is a last syllable
            //Everything before the first vovwel including the vowel is a first syllable
            try
            {
                string vowels = "aáeéěiíoóuúů";
                int seccondLastVowelIndex = -1;
                int lastVowelIndex = -1;
                for (int i = 0; i < word.Length; i++)
                {
                    char letter = word[i];


                    if (vowels.Contains(letter))
                    {
                        //Returns the first syllable
                        //(From beggining to the first syllable
                        if (returnFirstSyllable)
                        {
                            return word.Substring(0, i + 1);
                        }

                        if (lastVowelIndex == -1) //First detected vowel
                        {
                            lastVowelIndex = i;
                        }
                        else //Seccond + detected vowel
                        {
                            seccondLastVowelIndex = lastVowelIndex;
                            lastVowelIndex = i;
                        }
                    }
                }

                //Returns the last syllable
                
                return word.Substring(seccondLastVowelIndex + 1);
            }
            catch
            {
                return "";
            }
        }

        /// <summary>
        /// Removes 5 points from the current player and returns 3 letters into the input box
        /// to help guide the player to the correct answer
        /// </summary>
        /// <returns>Returns a 3 letter string </returns>
        public string GenerateHelp()
        {
            //TODO
            return "";
        }

        /// <summary>
        /// Moves the current player and next player indexes by one
        /// </summary>
        public void MoveToNextPlayer()
        {
            currentPlayerIndex = (currentPlayerIndex + 1) % playerCount;
            nextPlayerIndex = (currentPlayerIndex + 1) % playerCount;

            //If current player isn't active (player used the give up button) move to another player
            if (!players[currentPlayerIndex].IsPlaying)
                MoveToNextPlayer();
        }

        /// <summary>
        /// Returns information about current player
        /// </summary>
        /// <returns>Returns players name and score in a string</returns>
        public string GetCurrentPlayerInfo()
        {
            return players[currentPlayerIndex].Name + ": " + players[currentPlayerIndex].Score;
        }

        /// <summary>
        /// Returns information about next player
        /// </summary>
        /// <returns>Returns players name and score in a string</returns>
        public string GetNextPlayerInfo()
        {
            return players[nextPlayerIndex].Name + ": " + players[nextPlayerIndex].Score;
        }

        /// <summary>
        /// Incements players score depending on the lenght of his word
        /// </summary>
        /// <param name="word">Players input</param>
        public void AddCurrentPlayersPoints(string word)
        {
            players[currentPlayerIndex].Score += word.Length;
        }

        /// <summary>
        /// Incements players score by value
        /// </summary>
        /// <param name="value">Value to add</param>
        public void AddCurrentPlayersPoints(int value)
        {
            players[currentPlayerIndex].Score += value;
        }

        /// <summary>
        /// Decrements players score by value
        /// </summary>
        /// /// <param name="value">Value to remove</param>
        public void SubtractCurrentPlayerPoints(int value)
        {
            players[currentPlayerIndex].Score -= value;
        }

        /// <summary>
        /// Changes the current players atribut "isPlaying" to false
        /// making him not participating in the game anymore.
        /// 
        /// Game also checks if there's atleast one human player still playing.
        /// If no, it changes games "gameOver" atribute to true
        /// </summary>
        public void MakeCurrentPlayerGiveUp()
        {
            players[currentPlayerIndex].GiveUp();

            //Check if there is enough players still playing
            int playingPlayersCount = 0;
            foreach (Player player in players)
            {

                if (player.IsPlaying && player.GetType() == typeof(Player))
                {
                    playingPlayersCount++;
                }
            }
            if(playingPlayersCount < 1)
            {
                //If there's less than one human players playing. 
                //The game is over and it's time to show gameover screen
                GameOver = true;
            }
        }

        /// <summary>
        /// Returns an array of player information in format "Name" : "Score"
        /// </summary>
        /// <returns>String array with player names and scores in each line</returns>
        public string[] GetPlayerNames()
        {
            string[] playerNames = new string[this.playerCount];
            for(int i = 0; i < playerCount; i++)
            {
                playerNames[i] = players[i].Name + " : " + players[i].Score; 
            }

            return playerNames;
        }

        /// <summary>
        /// Finds the human player with highest score
        /// </summary>
        /// <returns>Best players name</returns>
        public string GetBestPlayerName()
        {
            int maxScore = int.MinValue;
            int maxScoreIndex = 0;

            for(int i = 0; i < players.Count; i++)
            {
                if(players[i].Score > maxScore && players[i].GetType() == typeof(Player))
                {
                    maxScore = players[i].Score;
                    maxScoreIndex = i;
                }
            }
            return players[maxScoreIndex].Name + " : " + players[maxScoreIndex].Score;
        }

       
    }
}
