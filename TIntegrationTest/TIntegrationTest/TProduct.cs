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
            List<Product> actual = loader.LoadProducts();

            List<Product> expected = new List<Product>
            {
                new Product{Name = "Виноград", Price = 130, Count = 10 },
                new Product{Name = "Сливы", Price = 100, Count = 5 },
                new Product{Name = "Апельсины", Price = 90, Count = 15 }
            };

            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
