using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryMaciaGodoy_Iefi
{
    internal class clsTarea
    {
        public int Id { get; set; }
        public int IdUsuario { get; set; }
        public int IdTipoTarea { get; set; }
        public DateTime Fecha { get; set; }
        public int? IdLugar { get; set; }  // Lugar puede ser opcional
        public string Comentario { get; set; }

        // Detalles como checkboxes
        public bool Uniforme { get; set; }
        public bool Insumo { get; set; }
        public bool Licencia { get; set; }
        public bool Estudio { get; set; }
        public bool Vacacion { get; set; }
        public bool ReclamoSalario { get; set; }
        public bool ReclamoRecibo { get; set; }

        // Constructor vacío (útil para DataGridView, serialización, etc.)
        public clsTarea() { }

        // Constructor opcional con todos los campos
        public clsTarea(int id, int idUsuario, int idTipoTarea, DateTime fecha, int? idLugar, string comentario,
                        bool uniforme, bool insumo, bool licencia, bool estudio, bool vacacion, bool reclamoSalario, bool reclamoRecibo)
        {
            Id = id;
            IdUsuario = idUsuario;
            IdTipoTarea = idTipoTarea;
            Fecha = fecha;
            IdLugar = idLugar;
            Comentario = comentario;
            Uniforme = uniforme;
            Insumo = insumo;
            Licencia = licencia;
            Estudio = estudio;
            Vacacion = vacacion;
            ReclamoSalario = reclamoSalario;
            ReclamoRecibo = reclamoRecibo;
        }
    }
}
