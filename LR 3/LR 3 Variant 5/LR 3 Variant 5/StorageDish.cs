using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR_3_Variant_5
{
    public class StorageDish : IDataOfDish
    {
        public List<Dish> Load()
        {
            List<Dish> allDish = new List<Dish>();
            string path = ".\\data.csv";
            StreamReader sr = new StreamReader(path);

            string line;
            while ((line = sr.ReadLine()) != null)
            {
                string[] lines = line.Split(';');
                allDish.Add(new Dish(lines[1], Convert.ToDouble(lines[2]), lines[3], lines[4], lines[0]));
            }

            sr.Close();

            return allDish;
        }
    }
}