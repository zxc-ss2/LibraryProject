using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringCheckLib;

namespace StringCheckLibTests
{
    [TestClass]
    public class StringCheckTests
    {
        [TestMethod]
        public void CheckName_isRus_TrueReturned()
        {
            //Arrange
            string stringName = "Алексей";
            //Act 
            StringCheck isName = new StringCheck();
            bool correctName = isName.CheckName(stringName);
            //Assert
            Assert.IsTrue(correctName);
        }

        [TestMethod]
        public void CheckName_isEmpty_FalseReturned()
        {
            //Arrange
            string stringName = "";
            //Act 
            StringCheck isName = new StringCheck();
            bool correctName = isName.CheckName(stringName);
            //Assert
            Assert.IsFalse(correctName);
        }

        [TestMethod]
        public void CheckName_isSpace_FalseReturned()
        {
            //Arrange
            string stringName = "Ал ексей";
            //Act 
            StringCheck isName = new StringCheck();
            bool correctName = isName.CheckName(stringName);
            //Assert
            Assert.IsFalse(correctName);
        }
    }
}
