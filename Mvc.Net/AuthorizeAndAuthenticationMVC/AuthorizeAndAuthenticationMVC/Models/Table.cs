//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AuthorizeAndAuthenticationMVC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public partial class Table
    {
        public int Id { get; set; }
        [DisplayName("UserName")]
        [Required]
        public string username { get; set; }
        [DisplayName("Password")]
        [Required]
        [DataType(DataType.Password)]
        public string password { get; set; }
    }
}
