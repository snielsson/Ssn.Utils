// Copyright 2015 Stig Schmidt Nielsson. All rights reserved.
using System;
using Ssn.Utils.Extensions;
using Xunit;
namespace Ssn.Utils.Tests.Extensions {
    public class ExceptionExtensionsTests {
        [Fact]
        public void ToStringRecursiveWorks() {
            try {
                throw new Exception("exception 1", new Exception("exception 2", new Exception("exception 3")));
            }
            catch (Exception ex) {
                string str = ex.ToStringRecursive();
                Assert.True(str.Matches("exception 1.*exception 2.*exception 3"));
                string str2 = ex.ToString();
                Assert.NotEqual(str, str2);
            }
        }
    }
}