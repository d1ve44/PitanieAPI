using System;
using System.Collections.Generic;

namespace Питание.Models
{
    public partial class FoodCategory
    {
        public FoodCategory()
        {
            FoodItemCategories = new HashSet<FoodItemCategory>();
        }

        public int FoodCategoryId { get; set; }
        public string? CategoryName { get; set; }

        public virtual ICollection<FoodItemCategory> FoodItemCategories { get; set; }
    }
}
