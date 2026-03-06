using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace LR_3_Variant_5
{
    public partial class MainForm : Form
    {
        private Dictionary<string, int> orders_ = new Dictionary<string, int>();
        private StorageDish dishes_ = new StorageDish();
        private List<Dish> allDishes_ = new List<Dish>();
        public MainForm()
        {
            InitializeComponent();

            allDishes_ = dishes_.Load();
            CategoriesListBox.Items.Add("Завтрак");
            CategoriesListBox.Items.Add("Обед");
            CategoriesListBox.Items.Add("Ужин");
            
            CategoriesListBox.SelectedIndex = 0;
        }

        private void CategoriesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            MenuComboBox.Items.Clear();
            foreach(Dish dish in allDishes_)
            {
                if (dish.Category == CategoriesListBox.SelectedItem.ToString())
                {
                    MenuComboBox.Items.Add(dish);
                }
            }
            MenuComboBox.DisplayMember = "Name";
            MenuComboBox.SelectedIndex = 0;
        }

        private void MenuComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Dish dish = MenuComboBox.SelectedItem as Dish;
            PriceLabel.Text = dish.Price.ToString() + "  руб.";
            PhotoPictureBox.Load(dish.Photo);
            DescriptionLabel.Text = dish.Description;
            QuantityTextBox.Text = "0";
        }

        private void BuyButton_Click(object sender, EventArgs e)
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
    }
}
