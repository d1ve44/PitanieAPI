using System;
using System.Collections.Generic;

namespace Питание.Models
{
    public partial class Allergen
    {
        public Allergen()
        {
            FoodAllergens = new HashSet<FoodAllergen>();
        }

        public int AllergenId { get; set; }
        public string? AllergenName { get; set; }
        public string? Description { get; set; }

        public virtual ICollection<FoodAllergen> FoodAllergens { get; set; }
    }
}
