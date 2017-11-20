using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Security.Cryptography;
using System.Diagnostics;
using Microsoft.Owin.Security.DataHandler.Encoder;

namespace api.tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GenerateEncryptedAudienceData()
        {
            var audienceId = Guid.NewGuid().ToString("N");

            var key = new byte[32];
            RNGCryptoServiceProvider.Create().GetBytes(key);
            var audienceSecret = TextEncodings.Base64Url.Encode(key);

            Debug.WriteLine($"AudienceId: {audienceId}\nAudienceSecret: {audienceSecret}");
        }
    }
}
