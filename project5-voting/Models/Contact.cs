//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace project5_voting.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Contact
    {
        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public Nullable<System.DateTime> date { get; set; }
        public Nullable<System.TimeSpan> time { get; set; }
        public string subject { get; set; }
        public string message { get; set; }
        public string status { get; set; }
        public string adminName { get; set; }
        public Nullable<System.DateTime> responseDate { get; set; }
        public Nullable<System.TimeSpan> responseTime { get; set; }
        public string answered { get; set; }
    }
}
