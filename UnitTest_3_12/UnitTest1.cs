using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Project_3_12.Tests
{
    [TestClass]
    public class BookTests
    {
        [TestMethod]
        public void Check()
        {
            //arrange 
            Book c = new Book("История", "Сидякин", 2008, "Эксмо");
            bool expected = true;
            //act 
            bool actual = c.Check("Сидякин");

            //assert 
            Assert.AreEqual(expected, actual);
        }
    }
}
