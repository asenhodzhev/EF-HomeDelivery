using System;
using System.ComponentModel.DataAnnotations;
using System.Text;

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
        public string Date { get; set; }

        [Required]
        [StringLength(50)]
        public string Time { get; set; }


        //[StringLength(255)]
        //[DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        //[Required]
        //public DateTime DeliveryTime { get; set; }

        //[Required]
        //[StringLength(255)]
        //[DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        //public DateTime OrderTime { get; set; }


        //public DateTime GetDate()
        //{
        //    return DateTime.Parse($"{this.Date}");
        //}
    }
}