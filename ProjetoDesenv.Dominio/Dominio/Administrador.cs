using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDesenv.Dominio.Dominio
{
    public class Administrador
    {
        public  int IdAdm { get; set; }

        public string NomeAdm { get; set; }

        public string EmailAdm { get; set; }

        public int Id_Usuario { get; set; }
    }
}
