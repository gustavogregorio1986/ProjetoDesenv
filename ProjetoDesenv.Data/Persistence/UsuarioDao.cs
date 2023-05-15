using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ProjetoDesenv.Dominio.Dominio;

namespace ProjetoDesenv.Data.Persistence
{
    public class UsuarioDao : Conexao
    {
        public void Salvar(Usuario usuario)
        {
            AbrirConexao();
            Cmd = new SqlCommand("insert into Usuario(Login, Senha, Email, Perfil) values(@v1, @v2, @v3, @v4)", Con);
            Cmd.Parameters.AddWithValue("@v1", usuario.Login);
            Cmd.Parameters.AddWithValue("@v2", usuario.Senha);
            Cmd.Parameters.AddWithValue("@v3", usuario.Email);
            Cmd.Parameters.AddWithValue("@v4", usuario.Perfil);
            Cmd.ExecuteNonQuery();
            FecharConexao();
        }
    }
}
