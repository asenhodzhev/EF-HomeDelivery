using System;
using System.ComponentModel.DataAnnotations;
using System.Text;
using HD.Common.Attributes;

namespace HD.Gateway.DTOs
{
    public class OrderEntry
    {
        [Required]
        [StringLength(255)]
        public string Description { get; set; }

        [Required]
        [StringLength(255)]
        public string Address { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name = "Restaurant")]
        public string RestaurantId { get; set; }

        [Required]
        [StringLength(50)]
        [FutureDate]
        public string Date { get; set; }

        [Required]
        [StringLength(50)]
        [ValidTime]
        public string Time { get; set; }

        public DateTime GetDate()
        {
            return DateTime.Parse($"{this.Date} {this.Time}");
        }
    }
}