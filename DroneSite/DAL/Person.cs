//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DroneSite.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Person
    {
        public Person()
        {
            this.Articles = new HashSet<Article>();
            this.Orders = new HashSet<Order>();
        }
    
        public int id { get; set; }
        public string first_name { get; set; }
        public string middle_name { get; set; }
        public string last_name { get; set; }
        public string username { get; set; }
        public string user_password { get; set; }
        public string user_type { get; set; }
    
        public virtual ICollection<Article> Articles { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
