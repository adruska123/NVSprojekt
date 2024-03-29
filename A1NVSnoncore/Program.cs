﻿/*!
* \mainpage Minimax
* MINIMAX
*   
*   VSTUP
* - Program musí umět přijímat libovolně veliké pole celočíselných hodnot zadané
*   jako parametry, případně uložené v textovém souboru. V případě spuštění bez
*   parametru se využije generátor pseudonáhodných čísel, který vygeneruje 20
*   prvků.
*   
*   PŘÍKLAD SPUŠTĚNÍ
* - minimax.exe 8763 35 765 1 -90
* - minimax.exe soubor-s-cisly.txt
* - minimax.exe
* 
*   VÝSTUP
* - Informace o nejmenším prvku (hodnota a pozice v poli)
* - Informace o největším prvku (hodnota a pozice v poli)
* - Seřazené pole (program musí mít implementaci pro tři různé algoritmy řazení a
*   uživatel bude v průběhu programu dotázán na volbu algoritmu).
*  \authors Marcel Štrba, Adam Druska
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1NVSnoncore
{
    
    /// <summary>
    /// Trieda, v ktorej sa spracujú vstupné argumenty
    /// </summary>
    class Program
    {
        /// <summary>
        /// Dynamické pole čísel
        /// </summary>
        public static List<int> Numbers = new List<int>();
        /// <summary>
        /// Metóda, ktorá spracuje vstupné parametre
        /// </summary>
        /// <param name="args"></param>
        public static void SpracovanieVstupu(string[] args)
        {
            /**
             * V prípade, že niesú zadané žiadne vstupné parametre, 
             * program vygeneruje 20 pseudonáhodných čísel v intervale od 0 do 100
             */
            if (args.Length == 0)
            {
                RandomNumber rn = new RandomNumber();
                for (int i = 0; i < 20; i++)
                {
                    Numbers.Add(rn.RandomInt(0, 100));
                }
            }
            /**
             * V prípade, že vstupný parameter nieje číslo
             * program overí či sa jedná o cestu k súboru.
             * Ak áno tak prečíta všetky čísla v súbore
             * Ak nie tak program vypíše chybové hlásenie
             */
            else if (!(int.TryParse(args[0], out int t)))
            {
                string argument = args[0];
                if (argument[1] != ':')
                {
                    Console.WriteLine("Nesprávny vstup.");
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
            /**
             * V prípade, že sú zadané vstupné parametre a nejedná sa o cestu k súboru
             * program vloží vstupné parametre do poľa Numbers
             */
            else
            {
                for (int i = 0; i < args.Length; i++)
                {
                    string stringNumber = args[i];
                    Numbers.Add(Convert.ToInt32(stringNumber));
                }
            }
        }
        static void Main(string[] args)
        {
            /**
            * Volanie metódy SpracovanieVstupu
            */
            SpracovanieVstupu(args);
            /**
             * Volanie metódy VypisMenu
             */
            Menu.VypisMenu();
            Console.ReadKey();
        }
    }
}