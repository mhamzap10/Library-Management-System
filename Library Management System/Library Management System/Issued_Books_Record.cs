//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Library_Management_System
{
    using System;
    using System.Collections.Generic;
    
    public partial class Issued_Books_Record
    {
        public int Book_id { get; set; }
        public Nullable<int> Member_id { get; set; }
        public Nullable<System.DateTime> Issued_Date { get; set; }
        public Nullable<System.TimeSpan> Issued_Time { get; set; }
    
        public virtual library_books library_books { get; set; }
        public virtual library_members library_members { get; set; }
    }
}