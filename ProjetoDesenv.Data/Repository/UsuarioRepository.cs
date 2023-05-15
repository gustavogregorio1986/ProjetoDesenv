using ProjetoDesenv.Data.Persistence;
using ProjetoDesenv.Data.Repository.Interface;
using ProjetoDesenv.Dominio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDesenv.Data.Repository
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly UsuarioDao usuarioDao;

        public UsuarioRepository()
        {
            usuarioDao = new UsuarioDao();
        }

        public void Adicionar(Usuario usuario)
        {
            usuarioDao.Salvar(usuario);
        }
    }
}
