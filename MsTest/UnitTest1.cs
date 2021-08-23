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
            bool result2 = pattern.ValidateEmail("mayur.kalekar550@gmail.com");
            Assert.IsTrue(result2);
        }
        /// <summary>
        /// Tests the mobile nimber.
        /// </summary>
        [TestMethod]
        public void TestMobileNumber()
        {
            bool result3 = pattern.ValidateMobileNumber("91 7219451845");
            Assert.IsTrue(result3);
        }
        /// <summary>
        /// Test passwords the rule1.
        /// </summary>
        [TestMethod]
        public void TestpasswordRule1()
        {
            bool result4 = pattern.ValidatePasswordRule1("mayurkalekar");
            Assert.IsTrue(result4);
        }
        [TestMethod]
        public void TestpasswordRule2()
        {
            bool result5 = pattern.ValidatePasswordRule2("Mayurkalekar");
            Assert.IsTrue(result5);
        }
        /// <summary>
        /// Testpasswords the rule3.
        /// </summary>
        [TestMethod]
        public void TestpasswordRule3()
        {
            bool result6 = pattern.ValidatePasswordRule3("Mayur@123");
            Assert.IsTrue(result6);
        }
        /// <summary>
        /// Testpasswords the rule4.
        /// </summary>
        [TestMethod]
        public void TestpasswordRule4()
        {
            bool result7 = pattern.ValidatePasswordRule4("Mayur@#123");
            Assert.IsTrue(result7);
        }
    }
}
