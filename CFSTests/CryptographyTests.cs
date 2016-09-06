using Xunit;
using CFS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CFS.Tests
{
    public class CryptographyTests
    {
        [Fact()]
        public void CFSTest()
        {
            var actual = Cryptography.CFS("1234");
            Assert.Equal("4D48FCD27827B82C5E831B9896C57C", actual);
        }

        [Fact()]
        public void CFSMD5Test()
        {
            var CFSKey = Cryptography.CFS("1234");
            var validcode = "7890";
            var EnCryptData = CFSKey + validcode;
            var actual = Cryptography.Md5Hash(EnCryptData);
            Assert.Equal("979305b3fc54533c67039a428990748d", actual);
        }
    }
}