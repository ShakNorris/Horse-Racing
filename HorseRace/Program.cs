using System;
using System.Collections.Generic;
using System.Threading;
using System.Linq;

namespace HorseRace
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many horses do you want to have in the race? ");
            RaceData.NumberOfHorses = Convert.ToInt32(Console.ReadLine());
            var horses = new List<Horse>();
            var threads = new List<Thread>();

            Random rand = new Random();
            RaceData.HorseNames = RaceData.HorseNames.OrderBy(x => rand.Next()).ToArray();
            RaceData.HorseColors = RaceData.HorseColors.OrderBy(x => rand.Next()).ToArray();

            for (int i = 0; i < RaceData.NumberOfHorses; i++)
            {
                horses.Add(new Horse(RaceData.HorseNames[i], i + 1, RaceData.HorseColors[i]));
            }
            for (int i = 0; i < RaceData.NumberOfHorses; i++)
            {
                threads.Add(new Thread(new ThreadStart(horses[i].Run)));
            }
            foreach(var x in threads)
            {
                x.Start();
            }

            Console.ReadKey();
        }
    }
}
