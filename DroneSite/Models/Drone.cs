using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DroneSite.Models
{
    public class Drone
    {
        public int ID { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string image_link { get; set; }
        public string image_description { get; set; }
        [Required]
        public int stock { get; set; }
        public string dimensions { get; set; }
        public int weight { get; set; }
        public int battery_life{ get; set; }
        public int range { get; set; }
        public int price { get; set; }
    }
}