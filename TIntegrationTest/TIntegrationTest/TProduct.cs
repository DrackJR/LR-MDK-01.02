using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestLibrary;

namespace TIntegrationTest
{
    [TestClass]
    public class TProduct
    {
        [TestMethod]
        public void TestLoadFromFile()
        {
            SaleImporter loader = new SaleImporter();
            List<Product> actualList = loader.LoadProducts();

            List<Product> expectedList = new List<Product>
            {
                new Product { Name = "Виноград", Price = 130, Count = 10 },
                new Product { Name = "Сливы", Price = 100, Count = 5 },
                new Product { Name = "Апельсины", Price = 90, Count = 15 }
            };

            Assert.AreEqual(expectedList.Count, actualList.Count);
            Assert.AreEqual(expectedList[0].Name, actualList[0].Name);
            Assert.AreEqual(expectedList[0].Price, actualList[0].Price);
            Assert.AreEqual(expectedList[0].Count, actualList[0].Count);
        }
    }
}
