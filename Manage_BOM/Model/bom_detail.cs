//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Manage_BOM.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class bom_detail
    {
        public string client { get; set; }
        public string setcode { get; set; }
        public string version { get; set; }
        public string item_no { get; set; }
        public string uom { get; set; }
        public Nullable<decimal> qty { get; set; }
        public Nullable<decimal> unit_cost { get; set; }
        public Nullable<decimal> total_cost { get; set; }
        public string maker { get; set; }
        public string last_update { get; set; }
        public string created_by { get; set; }
        public Nullable<System.DateTime> created_date { get; set; }
        public long row_id { get; set; }
    }
}
