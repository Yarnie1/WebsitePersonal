using System.ComponentModel.DataAnnotations;

namespace WebsitePersonal.Models
{
    public class VerifyOTPViewModel
    {
        [Required]
        public string OTP { get; set; }
    }
}