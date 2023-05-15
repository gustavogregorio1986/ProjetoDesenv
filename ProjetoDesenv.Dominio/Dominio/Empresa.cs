using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDesenv.Dominio.Dominio
{
    public class Empresa
    {
        public int IdEmpresa { get; set; }

        public string NomeEmpresa { get; set; }

        public string Cnpj { get; set; }

        public string Ramo { get; set; }

        public int Id_Cliente { get; set; }
    }
}
