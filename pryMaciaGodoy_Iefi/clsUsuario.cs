using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryMaciaGodoy_Iefi
{
    public class clsUsuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Contraseña { get; set; }
        public string Correo { get; set; }
        public int RolId { get; set; }
        public clsUsuario() { }

        public clsUsuario(int id, string nombre, string Contraseña, string correo, int rolId)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Contraseña = Contraseña;
            this.Correo = correo;
            this.RolId = rolId;
        }
    }
}

