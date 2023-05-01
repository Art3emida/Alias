using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALIAS
{
    public class PlayerInfo
    {
        public string Name { get; private set; }
        public int Score { get; set; }

        public PlayerInfo(string name, int score)
        {
            Name = name;
            Score = score;            
        }
    }
}