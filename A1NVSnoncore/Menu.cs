using System;
using System.Collections.Generic;
using System.Text;

namespace A1NVSnoncore
{
    class Menu
    {
        public static void VypisMenu()
        {
            Console.WriteLine("1)Informacie o najmensom prvku.");
            Console.WriteLine("2)Informacie o najvacsom prvku.");
            Console.WriteLine("3)Zoradit pole (1. algoritmus)");
            Console.WriteLine("4)Zoradit pole (2. algoritmus)");
            Console.WriteLine("5)Zoradit pole (3. algoritmus)");

            Console.Write("Vasa volba: ");
            int volba = Convert.ToInt32(Console.ReadLine());
            switch (volba)
            {
                case 1:
                    NajmensieCislo();
                    break;
                case 2:
                    NajvacsieCislo();
                    break;
                case 3:
                    PrvyAlgo();
                    break;
                case 4:
                    DruhyAlgo();
                    break;
                case 5:
                    TretiAlgo();
                    break;
            }
        }
        /// <summary>
        /// Najmensie cislo v poli
        /// </summary>
        private static void NajmensieCislo()
        {
            int NajmensieCislo = Program.Numbers[0];
            int Index = 0;
            for (int i = 0; i < Program.Numbers.Count; i++)
            {
                if (Program.Numbers[i] < NajmensieCislo)
                {
                    NajmensieCislo = Program.Numbers[i];
                    Index = i;
                }
            }
            Console.WriteLine("Najmensi prvok je " + NajmensieCislo + " s poziciou " + Index);
        }/// <summary>
        /// Najvacsie cislo v poli
        /// </summary>
        private static void NajvacsieCislo()
        {
            int NajvacsieCislo = Program.Numbers[0];
            int Index = 0;
            for (int i = 0; i < Program.Numbers.Count; i++)
            {
                if (Program.Numbers[i] > NajvacsieCislo)
                {
                    NajvacsieCislo = Program.Numbers[i];
                    Index = i;
                }
            }
            Console.WriteLine("Najvacsi prvok je " + NajvacsieCislo + " s poziciou " + Index);
        }
        /// <summary>
        /// Zoradovaci algoritmus Bubble
        /// </summary>
        private static void PrvyAlgo()
        {   
            for(int i = 0; i < Program.Numbers.Count - 1; i++)
            {
                for(int j = 0; j < Program.Numbers.Count - i - 1; j++)
                {
                    if(Program.Numbers[j] > Program.Numbers[j + 1])
                    {
                        int temp = Program.Numbers[j];
                        Program.Numbers[j] = Program.Numbers[j + 1];
                        Program.Numbers[j + 1] = temp;
                    }
                }
            }
            for(int i = 0; i < Program.Numbers.Count; i++)
            {
                Console.Write(Program.Numbers[i] + " ");
            }
        }
        /// <summary>
        /// Zoradovaci algoritmus Selection
        /// </summary>
        private static void DruhyAlgo()
        {
            for(int i = 0; i < Program.Numbers.Count - 1; i++)
            {
                int min = i;
                for(int j = i + 1; j < Program.Numbers.Count; j++)
                {
                    if (Program.Numbers[j] < Program.Numbers[min])
                        min = j;
                }
                int temp = Program.Numbers[i];
                Program.Numbers[i] = Program.Numbers[min];
                Program.Numbers[min] = temp;
            }
            for (int i = 0; i < Program.Numbers.Count; i++)
            {
                Console.Write(Program.Numbers[i] + " ");
            }
        }
        /// <summary>
        /// Zoradovaci algoritmus Insertion
        /// </summary>
        private static void TretiAlgo()
        {
            for(int i = 1; i < Program.Numbers.Count; i++)
            {
                int j = i - 1;
                while (j >= 0 && Program.Numbers[j] > Program.Numbers[i])
                {
                    Program.Numbers[j + 1] = Program.Numbers[j]; 
                    j = j - 1; 
                }
                Program.Numbers[j + 1] = Program.Numbers[i];
            }
            for (int i = 0; i < Program.Numbers.Count; i++)
            {
                Console.Write(Program.Numbers[i] + " ");
            }
        }
    }
}
