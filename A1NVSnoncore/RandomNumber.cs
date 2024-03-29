﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;

namespace A1NVSnoncore
{
    /// <summary>
    /// Trieda slúžiaca pre generovanie pseudonáhodných čísel
    /// </summary>
    public class RandomNumber
    {
        private RandomNumberGenerator rn;
        /// <summary>
        /// Konštruktor triedy RandomNumber
        /// </summary>
        public RandomNumber()
        {
            rn = new RNGCryptoServiceProvider();
        }
        /// <summary>
        /// Metóda, ktorá vygeneruje pseudonáhodné číslo v zadanom intervale a vráti ho.
        /// </summary>
        /// <param name="min">dolná hranica intervalu</param>
        /// <param name="max">horná hranica intervalu</param>
        /// <returns> normalizeNumber </returns>
        public int RandomInt(int min, int max)
        {
            byte[] randomBytes = new byte[8]; /**byte[] radomBytes = pole 8 bytov */
            rn.GetBytes(randomBytes); 
            int generatedValue = Math.Abs(BitConverter.ToInt32(randomBytes, startIndex: 0));    
            int diff = max - min; /**int diff - veľkosť rozsahu generovania */
            int mod = generatedValue % diff; /**int mod - zvyšok po delení generovanej hodnoty a veľkosti rozsahu */
            int normalizeNumber = min + mod; /**int normalizeNumber - pričítanie k dolnej hranici rozsahu */
            return normalizeNumber; 
        }
    }
}
