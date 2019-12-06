using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MayerP4.Models
{
    public class Message
    {
        public int Id { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 1)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 1)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Subject { get; set; }

        [Display(Name = "Comment/Quote Request")]
        [Required]
        public string Text { get; set; }

        [Display(Name = "Type of request")]
        public string TypeOfRequest { get; set; }

        [Display(Name = "Web app")]
        public bool IsWebApp { get; set; }

        [Display(Name = "Phone app")]
        public bool IsPhoneApp { get; set; }

        [Display(Name = "Windows app")]
        public bool IsWindowsApp { get; set; }

    }
}

