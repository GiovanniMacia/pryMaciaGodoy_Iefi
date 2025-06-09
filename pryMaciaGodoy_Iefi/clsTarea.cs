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
        public int? IdLugar { get; set; }
        public string Comentario { get; set; }

        public bool Insumo { get; set; }
        public bool Estudio { get; set; }
        public bool Vacacion { get; set; }
        public bool ReclamoSalario { get; set; }
        public bool ReclamoRecibo { get; set; }
        public string NombreTipoTarea { get; set; }
        public string NombreLugar { get; set; }

        public clsTarea() { }

        public clsTarea(int id, int idUsuario, int idTipoTarea, DateTime fecha, int? idLugar, string comentario,
                        bool insumo, bool estudio, bool vacacion, bool reclamoSalario, bool reclamoRecibo)
        {
            Id = id;
            IdUsuario = idUsuario;
            IdTipoTarea = idTipoTarea;
            Fecha = fecha;
            IdLugar = idLugar;
            Comentario = comentario;

            Insumo = insumo;
            Estudio = estudio;
            Vacacion = vacacion;
            ReclamoSalario = reclamoSalario;
            ReclamoRecibo = reclamoRecibo;
        }
    }
}
