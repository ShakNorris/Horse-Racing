using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace HorseRace
{
    public class Horse
    {
        public string Name { get; set; }
        private int Lane { get; set; }
        private ConsoleColor HorseColor { get; set; }
        private int Gallop { get; set; }
        public static int Place { get; set; }

        private int TrackLength = 50;
        static Random rand = new Random();

        public Horse(string Name, int Lane, ConsoleColor HorseColor)
        {
            this.Name = Name;
            this.Lane = Lane;
            this.HorseColor = HorseColor;
        }

        public void Run()
        {
            DateTime start = DateTime.Now;

            for (int i = 0; i < TrackLength; i++)
            {
                Gallop++;

                lock (rand)
                {
                    Console.ForegroundColor = HorseColor;
                    Console.SetCursorPosition(0, Lane * 2);
                    Console.Write(new String(' ', Console.BufferWidth));
                    Console.SetCursorPosition(Gallop, Lane * 2);
                    Console.Write("o");
                }

                Thread.Sleep(10 * 25 + rand.Next(500));
            }

            lock (rand)
            {
                DateTime finish = DateTime.Now;
                TimeSpan time = finish - start;
                string runTime = time.TotalSeconds.ToString();

                Console.SetCursorPosition(0, 13 + Place);
                Console.ForegroundColor = HorseColor;
                Place++;
                Console.WriteLine($"{Place}. {Name} - {runTime}");

                if (Place == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.SetCursorPosition(25, Place);
                    Console.Write("The winner is ");
                    Console.ForegroundColor = HorseColor;
                    Console.Write($"{Name}!");
                }
            }

        }
    }
}
