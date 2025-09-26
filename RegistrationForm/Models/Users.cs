using System.ComponentModel.DataAnnotations;

namespace RegistrationForm.Models
{
    public class Users
    {
        [Required(ErrorMessage = "وارد کردن نام الزامی است")]
        public string Name {  get; set; }

        [Required(ErrorMessage = "وارد کردن ایمیل الزامی است")]
        [EmailAddress(ErrorMessage = "ایمیل نامعتبر است.")]
        public string Email {  get; set; }

        public DateTime CurrentTime { get; set; }   

    }
}
