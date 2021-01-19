using System.ComponentModel.DataAnnotations;

namespace HealthyAndHappy.Models{
    public class RegisterModel {

        [Required]
        public string Login { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
