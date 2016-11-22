using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DroneSite.Models
{
    public class Drone
    {
        [Required]
        public int ID { get; set; }
        [Required]
        public string name { get; set; }
        [Required]
        public string description { get; set; }
        [Required]
        public string image_link { get; set; }
        [Required]
        public string image_description { get; set; }
        public int stock { get; set; }
        [Required]
        public string dimensions { get; set; }
        [Required]
        public int weight { get; set; }
        [Required]
        public int battery_life{ get; set; }
        [Required]
        public int range { get; set; }
        [Required]
        public int price { get; set; }
    }
}