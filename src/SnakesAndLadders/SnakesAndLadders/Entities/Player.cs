using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakesAndLadders.Entities
{
    public class Player
    {
        public int CurrentSquare { get; internal set; }
        public string Name { get; set; }

        internal Player()
        {
            CurrentSquare = 1;
            Name = string.Empty;
        }
    }
}
