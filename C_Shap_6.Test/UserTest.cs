using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace C_Shap_6.Test
{
    [TestClass]
    public class UserTest
    {
        [TestMethod]
        public void User_Create_An_Id()
        {
            var user = new User();
            Assert.AreNotEqual(Guid.Empty, user.Id);
        }
    }
}
