using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HD.Entities.Common;
using ITGigs.Common.Extensions;

namespace HD.Entities.Models
{
    public class Order
    {
        public Order()
        { }

        public Order(string clientId, string restaurantId,string address, string description, DateTime deliveryTime, DateTime orderTime, CustomId id = null)
            : this(id)
        {
            this.ClientId = clientId;
            this.RestaurantId = restaurantId;
            this.Description = description;
            this.Address = address;
            this.DeliveryTime = deliveryTime;
            this.OrderTime = orderTime;
        }

        public Order(CustomId id)
        {
            this.Id = string.IsNullOrEmpty(Convert.ToString(id)) ? new CustomId().ToString() : id.ToString();
        }

        [Key]
        public string Id { get; set; }

        [Required]
        public string ClientId { get; set; }

        public virtual User Client { get; set; }

        [Required]
        public string RestaurantId { get; set; }

        public virtual Restaurant Restaurant { get; set; }

        [Required]
        [StringLength(255)]
        public string Address  { get; set; }

        [Required]
        [StringLength(255)]
        public string Description { get; set; }

        [Required]
        public DateTime DeliveryTime { get; set; }

        [Required]
        public DateTime OrderTime { get; set; }
    }
}
