using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DroneSite.Models
{
    public class Order
    {
        [Required]
        public int id { get; set; }
        [Required]
        public int person_id { get; set; }
        [Required]
        public DateTime order_date { get; set; }
        [Required]
        public int duration { get; set; }
        [Required]
        public DateTime date_returned { get; set; }
    }
}