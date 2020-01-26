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

        

        public string GuessWord(char firstLetter)
        {
            foreach (string word in words)
            {
                if (word[0] == firstLetter)
                {
                    if (usedWords != null)
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
