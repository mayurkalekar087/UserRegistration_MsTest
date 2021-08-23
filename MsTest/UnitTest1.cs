using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistration_MsTest;
using System;

namespace MsTest
{
    [TestClass]
    public class UnitTest1
    {
        Pattern pattern = new Pattern();
        /// <summary>
        /// Tests the first name.
        /// </summary>
        [TestMethod]
        public void TestFirstName()
        {
            bool result = pattern.ValidateFirstName("Mayur");
            Assert.IsTrue(result);
        }
        /// <summary>
        /// Tests the first name.
        /// </summary>
        [TestMethod]
        public void TestLastName()
        {
            bool result1 = pattern.ValidateLastName("Kalekar");
            Assert.IsTrue(result1);
        }
        /// <summary>
        /// Tests the Email.
        /// </summary>
        [TestMethod]
        public void TestEmail()
        {
            bool result2 = pattern.ValidateEmail("mayurkalekar550@gmail.com");
            Assert.IsTrue(result2);
        }

    }
}
