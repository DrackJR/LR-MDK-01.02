namespace LR_3_Variant_5
{
    public class Dish
    {
        private string name_;
        private double price_;
        private string photo_;
        private string description_;
        private string category_;

        public Dish(string name, double price, string photo, string description, string category)
        {
            name_ = name;
            price_ = price;
            photo_ = photo;
            description_ = description;
            category_ = category;
        }

        public string Name
        {
            get { return name_; }
        }

        public double Price
        {
            get { return price_; }
        }

        public string Photo
        {
            get { return photo_; }
        }

        public string Description
        {
            get { return description_; }
        }

        public string Category
        {
            get { return category_; }
        }
    }
}
