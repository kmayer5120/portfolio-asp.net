using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MayerP4.Models
{
    public class Message
    {
        private bool isQuota;
        private bool isGeneralMessage;

        public int Id { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 5)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 5)]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Subject { get; set; }

        [Display(Name = "Comment/Quota Request")]
        [Required]
        public string Text { get; set; }


        [Display(Name = "Quota")]
        public bool IsQuota
        {
            get { return isQuota; }
            set
            {
                isQuota = value;
                if (isQuota)
                {
                    isGeneralMessage = false;
                }
            }
        }

        [Display(Name = "General Message")]
        public bool IsGeneralMessage
        {
            get { return isGeneralMessage; }
            set
            {
                isGeneralMessage = value;
                if (isGeneralMessage)
                {
                    isQuota = false;
                }
            }
        }

        [Display(Name = "Web app")]
        public bool IsWebApp { get; set; }

        [Display(Name = "Phone app")]
        public bool IsPhoneApp { get; set; }

        [Display(Name = "Windows app")]
        public bool IsWindowsApp { get; set; }

    }
}

