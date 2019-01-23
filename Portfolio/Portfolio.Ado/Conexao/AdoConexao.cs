using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Ado.Conexao
{
    public class AdoConexao
    {
        public SqlConnection con { get; set; }
        public AdoConexao()
        {
            con = new SqlConnection("Server=den1.mssql8.gear.host;Database=portfoliorafael;User Id=portfoliorafael;Password=Lh7Z-v4_jOf5");
        }

        public void Conectar()
        {
            con.Open();
        }

        public void Desconectar() {
            con.Close();
        }
    }
}
