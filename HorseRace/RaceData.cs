using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseRace
{
    public static class RaceData
    {
        public static int NumberOfHorses;

        public static string[] HorseNames =
        {
            "Horsen Around","Hoofy Heart", "Gaits of Hell",
            "Whatshesaid", "Talk Derby to Me", "Walk of Shame",
            "Odor in the Court", "Bored Bronco", "Mane Attraction",
            "Foalin Around","Equine Intervention","Fifty Bales of Hay",
            "Whinny the Horseshoe","Long Face", "Just Mare-ied"
        };

        public static ConsoleColor[] HorseColors =
        {
            ConsoleColor.Red, ConsoleColor.Green, ConsoleColor.Yellow, ConsoleColor.White, ConsoleColor.Cyan, ConsoleColor.Gray,ConsoleColor.Magenta,
            ConsoleColor.DarkCyan, ConsoleColor.DarkMagenta, ConsoleColor.DarkGreen, ConsoleColor.DarkRed, ConsoleColor.DarkBlue, ConsoleColor.DarkYellow
        };
    }
}
