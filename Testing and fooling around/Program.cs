using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Testing_and_fooling_around
{
    class Board
    {
        public string colour;
        public string PerminatePos;

        public Board()
        {
            colour = "White";
            PerminatePos = "A1";
        }
    }
    class Chestpiece
    {
        public string colour;
        public string CurrentPos;

        public Chestpiece()
        {
            colour = "White";
            CurrentPos = "A1";
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Chestpiece Tower = new Chestpiece();
            Tower.colour = "Red";

            

            for (int j = 32; j > 0; j--)
            {
                if (j % 2 == 0)
                {
                    for (int i = 32; i > 0; i--)
                    {
                        if (i % 4 == 0)
                        {
                            for (int k = 2; i > 0; i--)
                            {
                                Console.BackgroundColor = ConsoleColor.White;
                                Console.Write("  ");
                            }
                        }
                        else
                        {
                            for (int k = 2; i > 0; i--)
                            {
                                Console.BackgroundColor = ConsoleColor.Black;
                                Console.Write("  ");
                            }
                        }
                    }
                    Console.WriteLine("");
                }
                else
                {
                    for (int i = 32; i > 0; i--)
                    {
                        if (i % 4 == 0)
                        {
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.Write("  ");
                        }
                        else
                        {
                            Console.BackgroundColor = ConsoleColor.White;
                            Console.Write("  ");
                        }
                    }
                    Console.WriteLine("");
                }
            }

            Console.ReadKey();
            //thread that checks the colour of a object and changes the board colour acordingly
            //passive and active state for pieces --> passive (black and white); active (colourful)
            */

            string g = "A1";
            string e = "A2";
            for(int i = 0; i !=1;)
            {

                Console.WriteLine("Hanase~ Ara, Ara{0}"[g].CompareTo(e));




            }





        }

        static void ColourChanger(string colour)
        {
            switch (colour)
            {
                case "White":
                    Console.BackgroundColor = ConsoleColor.White;
                    break;
                case "Red":
                    Console.BackgroundColor = ConsoleColor.Red;
                    break;
                case "Black":
                    Console.BackgroundColor = ConsoleColor.Black;
                    break;
            }
        }

    }
}
