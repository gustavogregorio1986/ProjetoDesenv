using ProjetoDesenv.Dominio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDesenv.Data.Repository.Interface
{
    public interface IUsuarioRepository
    {
        void Adicionar(Usuario usuario);
    }
}
