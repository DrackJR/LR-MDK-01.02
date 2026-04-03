using System;
using System.Collections.Generic;
using System.IO;

namespace TestLibrary
{
    public class SaleImporter
    {
        private List<Product> allProduct_ = new List<Product>();
        public List<Product> LoadProducts()
        {
            string path = "..\\..\\..\\Products.txt";
            StreamReader sr = new StreamReader(path);

            string line;
            while((line = sr.ReadLine()) != null)
            {
                string[] lines = line.Split(';');
                allProduct_.Add(new Product
                {
                    Name = lines[0],
                    Price = Convert.ToDouble(lines[1]),
                    Count = Convert.ToInt32(lines[2])
                });
            }
            sr.Close();
            return allProduct_;
        }
    }
}
