using System;
using System.Collections.Generic;

namespace A1NVS
{
    class Program
    {
        public static List<int> Numbers = new List<int>();
        
        static void Main(string[] args)
        {
           if (args.Length == 0)
            {
                RandomNumber rn = new RandomNumber();
                for(int i = 0; i < 20; i++)
                {
                    Numbers.Add(rn.RandomInt(0, 100));                     
                }
            }             
        }
    }
}
