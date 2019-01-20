using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Portfolio.Domain.Entities
{
    public class Produto
    {
        [Key]
        public int ProdutoId { get; set; }
        [Required(ErrorMessage ="Preencha o campo nome.")]
        public string Nome { get; set; }
        public virtual IEnumerable<Pedido> Pedidos { get; set; }
        public virtual IEnumerable<Cliente> Clientes { get; set; }
    }
}
