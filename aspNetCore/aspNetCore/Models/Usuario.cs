using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace aspNetCore.Models
{
    public class Usuario
    {
        public int Id { get; set; }

        //[Range(18, 70, ErrorMessage = "Você não está na faixa de idade permitida")]
        //public int Idade { get; set; }

        [Required(ErrorMessage = "O nome é obrigatório!")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "Insira um nome válido")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O login é obrigatório!")]
        [RegularExpression(@"[a-zA-Z]{5,15}", ErrorMessage = "O login deve conter somente letras!")]
        public string Login { get; set; }

        [Required(ErrorMessage = "O email é obrigatório!")]
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", ErrorMessage = "O email não é válido!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "A senha é obrigatória!")]
        [RegularExpression(@"[a-zA-Z]{5,15}",ErrorMessage = "A senha não é válida")]
        public string Senha { get; set; }

        [Compare("Senha", ErrorMessage = "As senhas digitadas não são iguais!")]
        public string ConfirmacaoSenha { get; set; }

        public string Observacoes { get; set; }
    }
}
