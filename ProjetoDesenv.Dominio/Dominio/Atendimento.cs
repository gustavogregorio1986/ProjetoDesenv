using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDesenv.Dominio.Dominio
{
    public class Atendimento
    {
        public int IdAtendimento { get; set; }

        public string Consulta { get; set; }

        public DateTime DataConsulta { get; set; }

        public int Id_Cliente { get; set; }
    }
}
