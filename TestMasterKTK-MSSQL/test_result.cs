//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestMasterKTK_MSSQL
{
    using System;
    using System.Collections.Generic;
    
    public partial class test_result
    {
        public int id { get; set; }
        public Nullable<int> assigned_test_id { get; set; }
        public Nullable<System.DateTime> start_time { get; set; }
        public Nullable<System.DateTime> end_time { get; set; }
        public Nullable<double> score { get; set; }
    
        public virtual assigned_test assigned_test { get; set; }
    }
}
