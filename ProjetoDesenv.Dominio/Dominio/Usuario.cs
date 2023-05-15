using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDesenv.Dominio.Dominio
{
    public class Usuario
    {
        public int IdUsuario { get; set; }

        public string Login { get; set; }

        public string Senha { get; set; }

        public string Email { get; set; }

        public string Perfil { get; set; }
    }
}
