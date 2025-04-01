using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WpfApp3;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void AuthTest()
        {
            var page = new MainWindow();
            Assert.IsTrue(page.Auth("test", "test"));
            Assert.IsFalse(page.Auth("gardener1", "12345"));
            Assert.IsFalse(page.Auth("", ""));
            Assert.IsFalse(page.Auth(" ", " "));
        }
    }
}
