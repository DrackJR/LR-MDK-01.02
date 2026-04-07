using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLibrary
{
    public class SellAnalyzer
    {
        public int CalcAvgSale(List<Product> allProducts)
        {
            double revenue = 0;
            int countOfSale = 0;
            int counter = 0;
            for (int i = 0; i < allProducts.Count; i++) // посчитать среднюю выручку
            {
                revenue += allProducts[i].Price * allProducts[i].Count;
                countOfSale ++;
            }

            for (int i = 0; i < allProducts.Count; i++) // посчитать кол-во продаж превышающую среднюю выручку 
            {
                if(allProducts[i].Price * allProducts[i].Count > revenue / countOfSale)
                {
                    counter++;
                }
            }

            return counter;
        }
    }
}
