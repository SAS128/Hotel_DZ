
using System.ComponentModel.DataAnnotations;

namespace Hotel
{
    public class GuestResponse
    {
       
        public string Name { get; set; }
        [Required]
        [StringLength(24, MinimumLength = 4, ErrorMessage = "Не допустимое имя!")]
        [RegularExpression(@"^\<[:alpha:]$", ErrorMessage = "Начало логина должно начинаться с буквы")]
        public string Login { get; set; }
        [Required]
        public string Password { get; set; }

        public bool? Logical_parts { get; set; }
        [Required]
        [StringLength(13, MinimumLength = 13, ErrorMessage = "Не коректный ввод телефона(больше или меньше нужного количества символов)")]
        [RegularExpression(@"^\+[0-9]\d{11}$", ErrorMessage = "Не корректный номер!")]
        public string Phone { get; set; }
        //--------------------------------------------------------------------------------------------
        [Required]

        public string Email { get; set; }
        //--------------------------------------------------------------------------------------------
    }
}