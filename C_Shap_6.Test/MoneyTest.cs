using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace C_Shap_6.Test
{
    [TestClass]
    public class MoneyTest
    {
        [TestMethod]
        public void Cannot_Create_Money_With_Null_Currency()
        {
            //Arrange
            var paramName = "";
            //Act
            try
            {
                var money = new Money(null, 1.0m);
            }
            catch(ArgumentNullException ex)
            {
                paramName = ex.ParamName;
            }
            //Assert
            Assert.AreEqual("currency", paramName);
        }

    }
}
