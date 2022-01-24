using SnakesAndLadders.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakesAndLadders.Entities
{
    public class Rule
    {
        public RuleType Type { get;set;}
        public int StartPosition { get; set; }
        public int EndPosition { get; set; }
    }
}
