using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace Digivance.Core {
    public class Crypto {
        private const int SaltSize = 16;
        private const int KeySize = 32;

        public Crypto() { }

        public static bool CheckPassword(string hash, string password) {
            var parts = hash.Split('.', 2);

            if(parts.Length != 2) {
                throw new FormatException("Unexpected hash format, expected {salt}.{key}");
            }

            var salt = Convert.FromBase64String(parts[0]);
            var key = Convert.FromBase64String(parts[1]);

            using(var algorithm = new Rfc2898DeriveBytes(password, salt, 1000, HashAlgorithmName.SHA256)) {
                var keyToCheck = algorithm.GetBytes(KeySize);
                return keyToCheck.SequenceEqual(key);
            }
        }

        public static string HashPassword(string password) {
            using (var algorithm = new Rfc2898DeriveBytes(password, SaltSize, 1000, HashAlgorithmName.SHA256)) {
                var key = Convert.ToBase64String(algorithm.GetBytes(KeySize));
                var salt = Convert.ToBase64String(algorithm.Salt);

                return $"{salt}.{key}";
            }
        }
    }
}
