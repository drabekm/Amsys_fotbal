using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amsys_fotbal
{
    public class ComputerPlayer : Player
    {
        SortedSet<string> words;
        SortedSet<string> usedWords;
        Random rng;
        public ComputerPlayer(string name, SortedSet<string> words, SortedSet<string> usedWords) : base(name)
        {
            this.words = words;
            this.usedWords = usedWords;
            rng = new Random();
        }

        
        /// <summary>
        /// "Guesses" a word that starts with "firstLetter" from dictionary "words". 
        /// It also handles checking if the word repeating is allowed
        /// </summary>
        /// <param name="firstLetter">First letter </param>
        /// <returns>First fit word from word dictionary</returns>
        public string GuessWord(char firstLetter)
        {
            foreach (string word in words)
            {
                if (word[0] == firstLetter)
                {
                    if (usedWords != null) //If usedWords is null it means game allows repeating words
                    {
                        if (!this.usedWords.Contains(word))
                        {
                            usedWords.Add(word);
                            return word;
                        }
                    }
                    else
                    {
                        return word;
                    }
                }
            }
            this.IsPlaying = false;
            return "";
        }

    }
}
