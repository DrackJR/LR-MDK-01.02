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
        public void BuyButtonClick()
        {
            if (orders_.ContainsKey(CategoriesListBox.SelectedItem.ToString()))
            {
                orders_[CategoriesListBox.SelectedItem.ToString()] += Convert.ToInt32(QuantityTextBox.Text);
                BasketRichTextBox.Clear();
                foreach (string key in orders_.Keys)
                {
                    BasketRichTextBox.AppendText(key + " " + orders_[key] + " шт.\n");
                }
            }
            else
            {
                orders_.Add(CategoriesListBox.SelectedItem.ToString(), Convert.ToInt32(QuantityTextBox.Text));
                BasketRichTextBox.Clear();
                foreach (string key in orders_.Keys)
                {
                    BasketRichTextBox.AppendText(key + " " + orders_[key] + " шт.\n");
                }
            }
        }
        public void ChoiceMenuComboBox()
        {
            Dish dish = MenuComboBox.SelectedItem as Dish;
            PriceLabel.Text = dish.Price.ToString() + "  руб.";
            PhotoPictureBox.Load(dish.Photo);
            DescriptionLabel.Text = dish.Description;
            QuantityTextBox.Text = "0";
        }
    }
}
