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
    
    public partial class Order_Line
    {
        public int order_id { get; set; }
        public int drone_id { get; set; }
        public int quantity { get; set; }
        public double price { get; set; }
    
        public virtual Drone Drone { get; set; }
        public virtual Order Order { get; set; }
    }
}
