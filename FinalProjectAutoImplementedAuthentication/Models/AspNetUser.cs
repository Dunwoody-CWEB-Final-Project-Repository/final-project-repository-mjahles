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
    
    public partial class AspNetUser
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AspNetUser()
        {
            this.ApprovedUsers = new HashSet<ApprovedUser>();
            this.UserLists = new HashSet<UserList>();
        }
        [HiddenInput(DisplayValue = false)]
        public string Id { get; set; }
        public string Email { get; set; }

        [HiddenInput(DisplayValue = false)]
        public bool EmailConfirmed { get; set; }

        [HiddenInput(DisplayValue = false)]
        public string PasswordHash { get; set; }

        [HiddenInput(DisplayValue = false)]
        public string SecurityStamp { get; set; }

        [HiddenInput(DisplayValue = false)]
        public string PhoneNumber { get; set; }

        [HiddenInput(DisplayValue = false)]
        public bool PhoneNumberConfirmed { get; set; }

        [HiddenInput(DisplayValue = false)]
        public bool TwoFactorEnabled { get; set; }

        [HiddenInput(DisplayValue = false)]
        public Nullable<System.DateTime> LockoutEndDateUtc { get; set; }

        [HiddenInput(DisplayValue = false)]
        public bool LockoutEnabled { get; set; }

        [HiddenInput(DisplayValue = false)]
        public int AccessFailedCount { get; set; }
        public string UserName { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ApprovedUser> ApprovedUsers { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserList> UserLists { get; set; }
    }
}
