//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EFCore
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblEmployee
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public System.DateTime Birthday { get; set; }
        public Nullable<int> UserID { get; set; }
    
        public virtual tblUser tblUser { get; set; }
    }
}
