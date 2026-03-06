using System.Collections.Generic;
namespace DishLibrary.Models
{
    public interface IDataOfDish
    {
        List<Dish> Load();
    }
}
