using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;

namespace Tarefas.Web.Models
{
    public class UsuarioViewModel
    {
        [AllowNull]
        [Required(ErrorMessage = "O Email deve ser informado.")]
        [EmailAddress(ErrorMessage = "Digite um email em formato válido.")]
        [DisplayName("Email")]    
        public string Email { get; set; }

        [AllowNull]
        [Required(ErrorMessage = "A senha deve ser informada.")]
        [DataType(DataType.Password)]
        [DisplayName("Senha")]    
        public string Senha { get; set; }
    }
}
