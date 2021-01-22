using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace HealthyAndHappy.Models{
    public class AddLarderModel{

        [BindProperty]
        public int num { get; set; }
        public void OnPost() {
            
        }

        [Required]
        public int userId { get; set; }
        [Required]
        public int larderId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Measurement { get; set; }
        [Required]
        public int Amount { get; set; }
        [Required]
        public int Calories { get; set; } //Na jednostke
        [Required]
        public int Carbs { get; set; }
        [Required]
        public int Fats { get; set; }
        [Required]
        public int Proteins { get; set; }
        [Required]
        public int Category { get; set; }

    }
}
