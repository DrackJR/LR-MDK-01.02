using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DishLibrary.Models
{
    public class StorageDish : IDataOfDish
    {
        private Dictionary<string, int> orders_ = new Dictionary<string, int>();
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
        public List<Dish> ChoiceCategoriesListBox()
        { 
            List<Dish> selectedDish = new List<Dish>();
            List<Dish> allDishes = Load();
            if()
            {
                foreach (Dish dish in allDishes)
                {
                    if (dish.Category == "Завтрак")
                    {
                        selectedDish.Add(dish);
                    }
                }
            }

            else if (number == 1)
            {
                foreach (Dish dish in allDishes)
                {
                    if (dish.Category == "Обед")
                    {
                        selectedDish.Add(dish);
                    }
                }
            }

            else
            {
                foreach (Dish dish in allDishes)
                {
                    if (dish.Category == "Ужин")
                    {
                        selectedDish.Add(dish);
                    }
                }
            }
            return selectedDish;
        }
    }
}