using System;
using System.Collections.Generic;
using System.Text;

using NUnit.Framework;

namespace Digivance.Core.Tests {
    public class CryptoTests {
        [SetUp]
        public void SetUp() { }

        [Test()]
        public void TestHashing() {
            string password = "some test password";
            string hash = Crypto.HashPassword(password);

            if (!Crypto.CheckPassword(hash, password)) {
                Assert.Fail("Failed to hash and validate password");
            }
        }
    }
}
