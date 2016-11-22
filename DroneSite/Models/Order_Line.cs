using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DroneSite.Models
{
    public class Order_Line
    {
        [Required]
        public int OrderID { get; set; }
        [Required]
        public int DroneID { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public float Price { get; set; }

    }
}