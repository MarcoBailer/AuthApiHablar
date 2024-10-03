using System.ComponentModel.DataAnnotations;

namespace AuthApiHablar.Core.Dtos
{
    public class RegisterDto
    {
        [Required(ErrorMessage = "Primeiro nome é necessário")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Último nome é necessário")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Nome de usuário é necessário")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Email é necessário")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Senha é necessário")]
        public string Password { get; set; }
    }
}
