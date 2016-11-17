using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DroneSite.Models
{
    public class Order
    {
        public int id { get; set; }
        public int person_id { get; set; }
        public DateTime order_date { get; set; }
        public int duration { get; set; }
        public DateTime date_returned { get; set; }
    }
}