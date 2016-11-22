using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace DroneSite.Models
{
    public class Article
    {
        [Required]
        public int ID { get; set; }
        [Required]
        public string title { get; set; }
        [Required]
        public string body { get; set; }
        public string image_link { get; set; }
        public string image_description { get; set; }
        [Required]
        public DateTime date_created { get; set; }
        [Required]
        public int author_id { get; set; }
    }

}