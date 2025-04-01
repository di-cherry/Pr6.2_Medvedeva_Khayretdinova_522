using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WpfApp3;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest4
    {
        [TestMethod]
        public void RegTes()
        {
            RegPage page = new RegPage(); 
            Assert.IsFalse(page.Reg("Иванов Иван Иванович", "gardener1", "12345", "gardener"));
        }
    }
}
