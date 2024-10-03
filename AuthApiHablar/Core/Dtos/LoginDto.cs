using System.ComponentModel.DataAnnotations;

namespace AuthApiHablar.Core.Dtos
{
    public class LoginDto
    {          
        [Required(ErrorMessage = "Email é necessário")]
        public string Email {  get; set; }

        [Required(ErrorMessage = "Senha é necessário")]
        public string Password { get; set; }
        
    }
}
