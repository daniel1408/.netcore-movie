using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace movie.Models
{
    public class User
    {
        [Key]
        public int UserID { get; set; }

        [Required(ErrorMessage ="Nome é obrigatório.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Sobrenome é obrigatório.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "E-mail é obrigatório.")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Nome de usuário é obrigatório.")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Senha é obrigatória.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage ="Senhas não conferem.")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
        
        
    }
}