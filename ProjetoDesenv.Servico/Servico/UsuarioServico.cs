using ProjetoDesenv.Data.Repository;
using ProjetoDesenv.Dominio.Dominio;
using ProjetoDesenv.Servico.Servico.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDesenv.Servico.Servico
{
    public class UsuarioServico : IUsuarioServico
    {
        private readonly UsuarioRepository _repositorio;

        public UsuarioServico()
        {
            _repositorio = new UsuarioRepository();
        }

        public void Adicionar(Usuario usuario)
        {
            _repositorio.Adicionar(usuario);
        }
    }
}
