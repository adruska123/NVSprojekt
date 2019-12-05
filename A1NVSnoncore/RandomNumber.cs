using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;

namespace A1NVSnoncore
{
    /// <summary>
    /// Trieda slúžiaca pre generovanie pseudonáhodných čísel
    /// </summary>
    class RandomNumber
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
        /// Metóda, ktorá vygeneruje pseudonáhodné čísla v zadanom intervale
        /// </summary>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public int RandomInt(int min, int max)
        {
            byte[] randomBytes = new byte[8]; /**< Pole 8 bytov */
            rn.GetBytes(randomBytes); 
            int generatedValue = Math.Abs(BitConverter.ToInt32(randomBytes, startIndex: 0));
            int diff = max - min; /**< Veľkosť rozsahu generovania */
            int mod = generatedValue % diff; /**< Zvyšok po delení generovanej hodnoty a veľkosti rozsahu */   
            int normalizeNumber = min + mod; /**< Pričítanie k dolnej hranici rozsahu */
            return normalizeNumber; /**< Vráti pseudonáhodné číslo */
        }
    }
}
