using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace ProjetoDesenv.Data.Persistence
{
    public class Conexao
    {
        protected SqlConnection Con;
        protected SqlCommand Cmd;
        protected SqlDataReader Dr;

        protected void AbrirConexao()
        {
            Con = new SqlConnection(ConfigurationManager.ConnectionStrings["projetodesenv"].ConnectionString);
            Con.Open();
        }

        protected void FecharConexao()
        {
            Con.Close();
        }
    }
}
