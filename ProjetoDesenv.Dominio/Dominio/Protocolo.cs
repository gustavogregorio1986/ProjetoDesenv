using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDesenv.Dominio.Dominio
{
    public class Protocolo
    {
        public int IdProtocolo { get; set; }

        public string NumeroProtocolo { get; set; }

        public string Nomeprotocolo { get; set; }

        public string Cpf_cnpj { get; set; }

        public int Id_Atendimento { get; set; }
    }
}
