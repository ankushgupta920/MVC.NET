//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UploadingAndRetrievingImages.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Web;

    public partial class student
    {
        public int id { get; set; }
        [DisplayName("Student Name")]
        [Required(ErrorMessage = "Name is Requied")]
        public string name { get; set; }
        [DisplayName("Student Class")]
        [Required(ErrorMessage = "Class is Requied")]
        public int standard { get; set; }
        [DisplayName("Choose Image")]
        public string image_path { get; set; }
        public HttpPostedFileBase ImageFile { get; set; }
    }
}
