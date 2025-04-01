using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WpfApp3;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest3
    {
        [TestMethod]
        public void AuthTestSucces()
        {

            var page = new MainWindow();

            Assert.IsTrue(page.Auth("gardener1", "12345")); //User
            Assert.IsTrue(page.Auth("admin1", "122333")); // Admin
        }
    }
}
