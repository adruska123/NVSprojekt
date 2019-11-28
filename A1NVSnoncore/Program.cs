using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1NVSnoncore
{
    class Program
    {
        public static List<int> Numbers = new List<int>();

        static void Main(string[] args)
        {

            if (args.Length == 0)
            {
                RandomNumber rn = new RandomNumber();
                for (int i = 0; i < 20; i++)
                {
                    Numbers.Add(rn.RandomInt(0, 100));
                }
            }
            else if (!(int.TryParse(args[0], out int yeff)))
            {
                string argument = args[0];
                if (argument[1] != ':')
                {
                    Console.WriteLine("Nespravny vstup.");
                }
                else
                {
                    string suborCisla = System.IO.File.ReadAllText(args[0]);
                    string[] cisla = suborCisla.Split(' ');
                    foreach (string stringNumber in cisla)
                    {
                        Numbers.Add(Convert.ToInt32(stringNumber));
                    }
                }
            }
            else
            {
                for (int i = 0; i < args.Length; i++)
                {
                    string stringNumber = args[i];
                    Numbers.Add(Convert.ToInt32(stringNumber));
                }
            }


            Menu.VypisMenu();
            Console.ReadKey();

        }
    }
}