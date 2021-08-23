using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistration_MsTest;
using System;

namespace MsTest
{
    [TestClass]
    public class UnitTest1
    {
        Pattern pattern = new Pattern();
        [TestMethod]
        public void TestFirstName()
        {
            bool result = pattern.ValidateFirstName("Mayur");
            Assert.IsTrue(result);
        }

    }
}
