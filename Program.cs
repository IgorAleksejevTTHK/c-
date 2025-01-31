using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta oma nimi ja vajuta enter");
            string name = Console.ReadLine();

            if (name !="")
            {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Tere, " + name);
            }
            else
            {

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("error");
            Console.Beep();
            Console.Beep();
            Console.Beep();
            }
            }
        }
    }
