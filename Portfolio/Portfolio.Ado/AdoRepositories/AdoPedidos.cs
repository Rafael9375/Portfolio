
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Portfolio.Ado.AdoRepositories
{
    public class AdoPedidos
    {
        public SqlConnection con { get; set; }


        public AdoPedidos()
        {
            con = new SqlConnection("Server=den1.mssql8.gear.host;Database=portfoliorafael;User Id=portfoliorafael;Password=Lh7Z-v4_jOf5");
        }
        
        public List<string> GerarRelatorio()
        {
            List<string> lista = new List<string>();
            SqlCommand comando = new SqlCommand("select PedidoId, Cliente.Nome as Comprador, " + 
                "Produto.Nome as Produto from Pedido " + 
                "join Cliente on Pedido.ClienteId = Cliente.ClienteId " + 
                "join Produto on Pedido.ProdutoId = Produto.ProdutoId", con);
            DataSet dataset = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(comando.CommandText, con);
            con.Open();
            adapter.Fill(dataset);
            DataTable tabela;
            tabela = dataset.Tables[0];
            con.Close();
            foreach (DataRow item in tabela.Rows)
            {
                lista.Add(item["PedidoId"].ToString() + 
                    "_" + item["Comprador"].ToString() +
                    "_" + item["Produto"].ToString());
            }
            return lista;
            
        }

    }
}
