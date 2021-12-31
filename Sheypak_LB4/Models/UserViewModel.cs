using System.ComponentModel.DataAnnotations;

namespace Sheypak_LB4.Models
{
    public class UserViewModel
    {
        [Required(ErrorMessage = "Нужно ввести имя  пользователя")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Нужно ввести фамилию пользователя")]
        public string Password { get; set; }
    }
}
