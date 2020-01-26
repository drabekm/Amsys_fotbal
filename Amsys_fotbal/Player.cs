using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amsys_fotbal
{
    public class Player
    {
        public Player(string name)
        {
            this.name = name;
            IsPlaying = true;
        }

        public void GiveUp()
        {
            isPlaying = false;
        }

        private string name = "";
        public string Name { get { return name; } protected set { name = value; } }

        private int score = 0;
        public int Score { get; set; }

        private bool isPlaying = true;
        public bool IsPlaying { get { return isPlaying; } protected set { isPlaying = value; } }



    }
}
