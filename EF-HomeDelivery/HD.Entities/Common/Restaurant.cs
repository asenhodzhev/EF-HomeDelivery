using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITGigs.Common.Extensions;

namespace HD.Entities.Common
{
    public class Restaurant
    {
        public Restaurant()
        { }

        public Restaurant(string restaurantName, CustomId id = null)
            : this(id)
        {
            this.RestaurantName = restaurantName;
        }

        public Restaurant(CustomId id)
        {
            this.Id = string.IsNullOrEmpty(Convert.ToString(id)) ? new CustomId().ToString() : id.ToString();
        }

        [Key]
        public string Id { get; set; }

        [Required]
        public string RestaurantName { get; set; }
    }
}
