//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Azure_Task_2.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class DeletedProduct
    {
        public int id { get; set; }
        public string Name { get; set; }
        public int ProductNumber { get; set; }
        public string Color { get; set; }
        public System.DateTime DeletedDate { get; set; }
        public decimal Price { get; set; }
        public int Weight { get; set; }
    }
}
