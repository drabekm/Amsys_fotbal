using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amsys_fotbal
{
    public class Game
    {

        List<Player> players = new List<Player>();
        
        //Game dictionary
        SortedSet<string> wordSet;
        string previousWord = "";

        int playerCount;
        int currentPlayerIndex = 0;
        int nextPlayerIndex = 1;


        //Settings
        bool checkLetter, checkTwoLetters, checkSyllable, repeatWords;

        public Game(List<string> playerNames, bool checkLetter, bool checkTwoLetters, bool checkSyllable, bool repeatWords, SortedSet<string> wordSet)
        {
            //Aply settings
            this.checkLetter = checkLetter;
            this.checkTwoLetters = checkTwoLetters;
            this.checkSyllable = checkSyllable;
            this.repeatWords = repeatWords;

            //Save the game wordset
            this.wordSet = wordSet;

            //Create players
            playerCount = playerNames.Count;
            foreach (string name in playerNames)
            {
                //TODO: Check if player is cpu
                Player newPlayer = new Player(name);
                players.Add(newPlayer);
            }
        }


        /// <summary>
        /// Checks which players are still playing and haven't given up.
        /// </summary>
        /// <returns>Num of active players</returns>
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
        /// <returns></returns>
        public bool CheckInput(string word)
        {
            bool isInputValid = false;

            //Check if the word is in the wordset
            if (!wordSet.Contains(word))
            {
                return false;
            }
            //Check last letter
            if(checkLetter && previousWord != "")
            {
                char a = word[0];
                char b = previousWord[previousWord.Length - 1];
                if (word[0] == previousWord[previousWord.Length - 1])
                    isInputValid = true;
            }
            //lopata
            //    tabačenka
            //Check last two letters
            if(checkTwoLetters && previousWord != "")
            {
                if(word[0] == previousWord[previousWord.Length - 2] &&
                   word[1] == previousWord[previousWord.Length - 1])
                {
                    isInputValid = true;
                }
            }
            //TODO: check syllables

            //PreviousWord being empty indicates game just started and there isn't anything
            //to compare the current word aginst
            if(previousWord == "")
            { 
                previousWord = word;
                return true;
            }
            return isInputValid;
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
    }
}
