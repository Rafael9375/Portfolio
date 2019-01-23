using Protfolio.Application;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Web;

namespace Portfolio.MVC.Models
{
    public class RelatorioPedidos
    {
        [Key]
        public int PedidoId { get; set; }
        public string Comprador { get; set; }
        public string Produto { get; set; }
        private readonly ApplicationPedido appPedido;

        

        public RelatorioPedidos()
        {
            appPedido = ApplicationConstrutor.AdoAplicacao();
        }

        public List<RelatorioPedidos> Conversao()
        {
            List<string> obj = appPedido.GerarRelatorio();
            List<RelatorioPedidos> relatorio = new List<RelatorioPedidos>(obj.Count);
            String[] aux;
            for (int i = 0; i < obj.Count; i++)
            {
                aux = new String[0];
                aux = obj[i].ToString().Split('_');
                relatorio.Add(new RelatorioPedidos() {
                    PedidoId = int.Parse(aux[0]),
                    Comprador = aux[1],
                    Produto = aux[2] });
            }
            return relatorio;
        }
        
    }
}