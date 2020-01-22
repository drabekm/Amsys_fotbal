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
        int playerCount;
        int currentPlayerIndex = 0;
        int nextPlayerIndex = 1;
        bool checkLetter, checkTwoLetters, checkSyllable, repeatWords;

        public Game(List<string> playerNames, bool checkLetter, bool checkTwoLetters, bool checkSyllable, bool repeatWords)
        {
            //Aply settings
            this.checkLetter = checkLetter;
            this.checkTwoLetters = checkTwoLetters;
            this.checkSyllable = checkSyllable;
            this.repeatWords = repeatWords;


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


        public bool CheckInput()
        {
            return true;
        }

        public string GenerateHelp()
        {
            return "";
        }

        public void MoveToNextPlayer()
        {
            currentPlayerIndex = (currentPlayerIndex + 1) % playerCount;
            nextPlayerIndex = (currentPlayerIndex + 1) % playerCount;            
        }

        public string GetCurrentPlayerInfo()
        {
            return players[currentPlayerIndex].Name + ": " + players[currentPlayerIndex].Score;
        }
        public string GetNextPlayerInfo()
        {
            return players[nextPlayerIndex].Name + ": " + players[nextPlayerIndex].Score;
        }

    }
}
