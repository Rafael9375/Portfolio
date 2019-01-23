using System;
using System.ComponentModel.DataAnnotations;

namespace Portfolio.Domain.Entities
{
    public class Pedido
    {
        [Key]
        public int PedidoId { get; set; }
        [Display(Name ="Cliente")]
        public int ClienteId { get; set; }
        [Display(Name = "Produto")]
        public int ProdutoId { get; set; }
        [ScaffoldColumn(false)]
        public DateTime DataPedido { get; set; }
        public virtual Cliente Cliente { get; set; }
        public virtual Produto Produto { get; set; }
    }
}
