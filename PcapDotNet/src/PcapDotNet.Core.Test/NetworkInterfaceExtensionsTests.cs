using System;
using System.Diagnostics.CodeAnalysis;
using System.Net.NetworkInformation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PcapDotNet.Core.Extensions;
using PcapDotNet.TestUtils;

namespace PcapDotNet.Core.Test
{
    /// <summary>
    /// Summary description for NetworkInterfaceExtensionsTests.
    /// </summary>
    [TestClass]
    [ExcludeFromCodeCoverage]
    public class NetworkInterfaceExtensionsTests
    {
        /// <summary>
        /// Gets or sets the test context which provides
        /// information about and functionality for the current test run.
        /// </summary>
        public TestContext TestContext { get; set; }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException), AllowDerivedTypes = false)]
        public void GetLivePacketDeviceNull()
        {
            NetworkInterface networkInterface = null;
            Assert.IsNull(networkInterface.GetLivePacketDevice());
            Assert.Fail();
        }
    }
}