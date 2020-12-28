using System.ComponentModel.DataAnnotations;

namespace NE.Identidade.API.Models
{
    public class UsuarioRegistro
    {
        [Required(ErrorMessage="O campo {0} é requerido.")]
        [EmailAddress(ErrorMessage="O campo {0} não é um email válido.")]
        public string Email { get; set; }
        
        [Required(ErrorMessage="O campo {0} é requerido.")]
        [StringLength(100, ErrorMessage="O campo {0} precisa ter entre {2} e {1} caracteres.", MinimumLength=6)]    
        public string Senha { get; set; }         

        [Compare("Senha", ErrorMessage="As senhas não conferem.")]
        public string ConfirmacaoSenha { get; set; }
    }

    public class UsuarioLogin
    {
        [Required(ErrorMessage="O campo {0} é requerido.")]
        [EmailAddress(ErrorMessage="O campo {0} não é um email válido.")]
        public string Email { get; set; }
        
        [Required(ErrorMessage="O campo {0} é requerido.")]
        [StringLength(100, ErrorMessage="O campo {0} precisa ter entre {2} e {1} caracteres.", MinimumLength=6)]    
        public string Senha { get; set; }
    }
}