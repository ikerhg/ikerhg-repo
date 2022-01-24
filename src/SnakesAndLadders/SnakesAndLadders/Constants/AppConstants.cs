using SnakesAndLadders.Entities;
using SnakesAndLadders.Enums;
using System.Collections.Generic;

namespace SnakesAndLadders.Constants
{
    internal static class AppConstants
    {
        public const int LastPosition = 100;

        public static Dictionary<int, Rule> Rules = new Dictionary<int, Rule>()
        {
            { 2, new Rule(){ Type = RuleType.Ladder, StartPosition = 2, EndPosition = 38  } },
            { 16, new Rule(){ Type = RuleType.Snake, StartPosition = 16, EndPosition=6  } },
            { 7, new Rule(){ Type = RuleType.Ladder, StartPosition = 7, EndPosition=14  } },
            { 8, new Rule(){ Type = RuleType.Ladder, StartPosition = 8, EndPosition=31  } },
            { 49, new Rule(){ Type = RuleType.Snake, StartPosition = 49, EndPosition=11  } },
            { 15, new Rule(){ Type = RuleType.Ladder, StartPosition = 15, EndPosition=26  } },
            { 19, new Rule(){ Type = RuleType.Ladder, StartPosition = 19, EndPosition=62  } },
            { 21, new Rule(){ Type = RuleType.Ladder, StartPosition = 21, EndPosition=42  } },
            { 46, new Rule(){ Type = RuleType.Snake, StartPosition = 46, EndPosition=25  } },
            { 28, new Rule(){ Type = RuleType.Ladder, StartPosition = 28, EndPosition=84  } },
            { 36, new Rule(){ Type = RuleType.Ladder, StartPosition = 36, EndPosition=44  } },
            { 51, new Rule(){ Type = RuleType.Ladder, StartPosition = 51, EndPosition=67  } },
            { 74, new Rule(){ Type = RuleType.Snake, StartPosition = 74, EndPosition=53  } },
            { 64, new Rule(){ Type = RuleType.Snake, StartPosition = 64, EndPosition=60  } },
            { 89, new Rule(){ Type = RuleType.Snake, StartPosition = 89, EndPosition=68  } },
            { 71, new Rule(){ Type = RuleType.Ladder, StartPosition = 71, EndPosition=91  } },
            { 95, new Rule(){ Type = RuleType.Snake, StartPosition = 95, EndPosition=75  } },
            { 78, new Rule(){ Type = RuleType.Ladder, StartPosition = 78, EndPosition=98  } },
            { 99, new Rule(){ Type = RuleType.Snake, StartPosition = 99, EndPosition=80  } },
            { 87, new Rule(){ Type = RuleType.Ladder, StartPosition = 87, EndPosition=94  } },
            { 92, new Rule(){ Type = RuleType.Snake, StartPosition = 92, EndPosition=88  } },
        };
    }
}
