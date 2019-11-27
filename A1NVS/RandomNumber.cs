using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;

namespace A1NVS
{
    /// <summary>
    /// 
    /// </summary>
    class RandomNumber
    {
        private RandomNumberGenerator rn;
        public RandomNumber()
        {
            rn = new RNGCryptoServiceProvider();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public int RandomInt(int min, int max)
        {
            byte[] randomBytes = new byte[8];
            rn.GetBytes(randomBytes);
            int generatedValue = Math.Abs(BitConverter.ToInt32(randomBytes, startIndex: 0));

            int diff = max - min;
            int mod = generatedValue % diff;
            int normalizeNumber = min + mod;

            return normalizeNumber;
        }
    }
}
