using System;
using System.Security.Cryptography;
using System.Text;

namespace Digivance.Core {
    /// <summary>
    /// Randomizer is a little helper class that can generate random data (such as strings)
    /// </summary>
    public class Randomizer {
        /// <summary>
        /// alphaNumericCharacters are the possible characters that can be used when generating
        /// a random string
        /// </summary>
        internal static readonly char[] alphaNumericCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890".ToCharArray();

        /// <summary>
        /// GetString generates and returns a random string of the provided length
        /// </summary>
        /// <param name="length">The length of the string to randomly generate</param>
        /// <returns>string</returns>
        public static string GetString(int length) {
            using (RandomNumberGenerator rng = RandomNumberGenerator.Create()) {
                byte[] data = new byte[4 * length];
                rng.GetBytes(data);

                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < length; i++) {
                    uint rnd = BitConverter.ToUInt32(data, i * 4);
                    long c = rnd % alphaNumericCharacters.Length;
                    sb.Append(alphaNumericCharacters[c]);
                }

                return sb.ToString();
            }
        }
    }
}
