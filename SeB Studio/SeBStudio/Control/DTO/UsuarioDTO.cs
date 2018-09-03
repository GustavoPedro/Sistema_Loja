using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeBStudio.Control.DTO
{
    public class UsuarioDTO
    {
        public int idUsuario { get; set; }
        public string Usuario { get; set; }
        public string Senha { get; set; }
        public int Codigo { get; set; }
        public int idPermissao { get; set; }
        public string Permissao { get; set; }
    }
}
