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
            for (int i = 0; i < expectedList.Count; i++)
            {
                Assert.AreEqual(expectedList[i].Name, actualList[i].Name);
                Assert.AreEqual(expectedList[i].Price, actualList[i].Price);
                Assert.AreEqual(expectedList[i].Count, actualList[i].Count);
            }
        }

        [TestMethod]
        public void TSellAnalyzer()
        {
            SaleImporter loader = new SaleImporter();
            List<Product> allProducts = loader.LoadProducts();

            SellAnalyzer analyzer = new SellAnalyzer();

            Assert.AreEqual(2, analyzer.CalcAvgSale(allProducts));
        }
    }
}
