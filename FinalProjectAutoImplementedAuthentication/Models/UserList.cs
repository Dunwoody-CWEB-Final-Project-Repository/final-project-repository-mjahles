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
    using System.ComponentModel.DataAnnotations;
    using System.Web.Mvc;

    public partial class UserList
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public UserList()
        {
            this.ListInfoes = new HashSet<ListInfo>();
            this.ApprovedUsers = new HashSet<ApprovedUser>();
        }

        [HiddenInput(DisplayValue = false)]
        [Key]
        public int ListId { get; set; }

        [Required(ErrorMessage = "Please enter a list name")]
        public string ListName { get; set; }

        [Required(ErrorMessage = "Please enter the number of rows (This can be changed later)")]
        public int RowCount { get; set; }

        [Required(ErrorMessage = "Please enter the number of columns (This can be changed later)")]
        public int ColumnCount { get; set; }

        [HiddenInput(DisplayValue = false)]
        public string OwnerId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ListInfo> ListInfoes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ApprovedUser> ApprovedUsers { get; set; }
        public virtual AspNetUser AspNetUser { get; set; }
    }
}
