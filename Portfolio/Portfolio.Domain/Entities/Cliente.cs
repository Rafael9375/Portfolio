using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Portfolio.Domain.Entities
{
    public class Cliente
    {
        [Key]
        public int ClienteId { get; set; }
        [Required(ErrorMessage ="Preencha o campo nome.")]
        [MaxLength(40, ErrorMessage ="O nome deve conter no máximo {0} caracteres")]
        public string Nome { get; set; }
        [DataType(DataType.EmailAddress)]
        [Display(Name ="E-mail")]
        public string Email { get; set; }
        [Required(ErrorMessage ="Preencha o campo login.")]
        public string Login { get; set; }
        [DataType(DataType.Password)]
        [MinLength(8, ErrorMessage ="A senha deve conter no minimo {0} caracteres")]
        public string Senha { get; set; }
        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }
        public virtual IEnumerable<Pedido> Pedidos { get; set; }
    }
}
