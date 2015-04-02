// Copyright 2015 Stig Schmidt Nielsson. All rights reserved.
using System;
using System.Reflection;
using Ssn.Utils.Extensions;
using Xunit;
namespace Ssn.Utils.Tests.Extensions {
    public class AssemblyExtensionsTests {
        [Fact]
        public void VersionStringWorks() {
            Assembly sut = Assembly.GetExecutingAssembly();
            string versionString = sut.VersionString();
            Assert.Equal("1.0.0.0", versionString); // "1.0.0.0" is the version from the AssembleInfo of the current test assembly.
        }

        [Fact]
        public void BuildTimeWorks() {
            Assembly sut = Assembly.GetExecutingAssembly();
            DateTime buildTime = sut.BuildTime();
            Assert.Equal(DateTime.Today, buildTime.Date); // Assumes the current test assembly is built today.
        }

        [Fact]
        public void GetAssemblyInfoWorks() {
            Assembly sut = Assembly.GetExecutingAssembly();
            string info = sut.GetAssemblyInfo();
            Assert.True(info.Matches(@"Assembly: .*, version= \d+\.\d+\.\d+\.\d+, buildtime= \d\d\d\d-\d\d-\d\d \d\d:\d\d:\d\d UTC"));
        }
    }
}