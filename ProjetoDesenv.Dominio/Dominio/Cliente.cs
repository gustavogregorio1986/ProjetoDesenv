using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDesenv.Dominio.Dominio
{
    public class Cliente
    {
        public int IdCliente { get; set; }

        public string Nome { get; set; }

        public string Email { get; set; }

        public string Perfil { get; set; }

        public virtual Endereco Endereco { get; set; }

        public virtual Empresa Empresa { get; set; }

        public virtual Atendimento Atendimento { get; set; }

        public int Id_Usuario { get; set; }
    }
}
