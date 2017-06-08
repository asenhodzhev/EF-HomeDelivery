using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HD.Common;


namespace HD.Entities.Common
{
    public class City
    {
        public City()
        { }

        public City(string cityName, CustomId id = null)
            : this(id)
        {
            this.CityName = cityName;
        }

        public City(CustomId id)
        {
            this.Id = string.IsNullOrEmpty(Convert.ToString(id)) ? new CustomId().ToString() : id.ToString();
        }

        [Key]
        public string Id { get; set; }

        [Required]
        public string CityName { get; set; }
    }
}
