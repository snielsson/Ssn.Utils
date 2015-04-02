// Copyright 2015 Stig Schmidt Nielsson. All rights reserved.
using System;
using Ssn.Utils.Extensions;
using Xunit;
namespace Ssn.Utils.Tests.Extensions {
    public class StringExtensionsTests : TestBase {
        [Fact]
        public void Base64EncodeDecodeWorks() {
            var sut = Create<string>();
            string b64 = sut.Base64Encode();
            string result = b64.Base64Decode();
            Assert.Equal(sut, result);
        }

        [Fact]
        public void ToHexStringAndToByteArrayWorks() {
            var sut = new Byte[] {0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20};
            string hexString = sut.ToHexString();
            byte[] byteArray = hexString.HexStringToByteArray();
            Assert.True(sut.IsJsonEqualTo(byteArray));
        }

        #region regex stuff
        #endregion
    }
}