using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DroneSite.Models
{
    public class Article
    {
        public int ID { get; set; }
        public string title { get; set; }
        public string body { get; set; }
        public string image_link { get; set; }
        public string image_description { get; set; }
        public DateTime date_created { get; set; }
        public int author_id { get; set; }
    }
}