//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FinalProjectAutoImplementedAuthentication.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ListInfo
    {
        public int InfoId { get; set; }
        public string ColumnName { get; set; }
        public string ColumnData { get; set; }
        public int RowNum { get; set; }
        public int ColumnNum { get; set; }
        public int ListId { get; set; }
        public bool IsChecked { get; set; }
    
        public virtual UserList UserList { get; set; }
    }
}
