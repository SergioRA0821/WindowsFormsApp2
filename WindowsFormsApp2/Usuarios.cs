using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    internal class Usuarios
    {

        private static List<Usuarios> usuarios = new List<Usuarios>
        {
            new Usuarios{NombreUsuario = "Admin", Contraseña = "1234"},
            new Usuarios{NombreUsuario = "Sergio", Contraseña = "2214"},
            new Usuarios{NombreUsuario = "Sofia", Contraseña = "9876"}
        };

        public Usuarios() { }

        public List<Usuarios> ObtenerUsuarios()
        {
            return usuarios;
        }

        public string NombreUsuario { get; set; }
        public string Contraseña { get; set; }
    }
}
