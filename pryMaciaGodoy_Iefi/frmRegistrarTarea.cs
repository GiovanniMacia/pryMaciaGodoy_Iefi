using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace pryMaciaGodoy_Iefi
{
    public partial class frmRegistrarTarea : MaterialForm
    {
        private string cadenaConexion = "Server=localhost\\SQLEXPRESS;Database=LabIefi;Trusted_Connection=True;";
        private int idUsuario;
        public frmRegistrarTarea()
        {
            InitializeComponent();
        }

        private void frmRegistrarTarea_Load(object sender, EventArgs e)
        {
            CargarTiposTarea();
            CargarLugares();
        }
        private void CargarTiposTarea()
        {
            using (SqlConnection cn = new SqlConnection(cadenaConexion))
            {
                cn.Open();
                string query = "SELECT Id, Nombre FROM TiposTarea";
                SqlDataAdapter da = new SqlDataAdapter(query, cn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbTiposTarea.DataSource = dt;
                cmbTiposTarea.DisplayMember = "Nombre";
                cmbTiposTarea.ValueMember = "Id";
                cmbTiposTarea.SelectedIndex = -1;
            }
        }

        private void CargarLugares()
        {
            using (SqlConnection cn = new SqlConnection(cadenaConexion))
            {
                cn.Open();
                string query = "SELECT Id, Nombre FROM Lugares";
                SqlDataAdapter da = new SqlDataAdapter(query, cn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbLugares.DataSource = dt;
                cmbLugares.DisplayMember = "Nombre";
                cmbLugares.ValueMember = "Id";
                cmbLugares.SelectedIndex = -1;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            clsTarea nuevaTarea = CrearTareaDesdeFormulario();

            clsBD conexion = new clsBD();
            conexion.GuardarTarea(nuevaTarea);

            MessageBox.Show("Tarea registrada correctamente.");
            LimpiarFormulario();
        }
        private clsTarea CrearTareaDesdeFormulario()
        {
            return new clsTarea
            {
                IdUsuario = idUsuario, // obtenelo desde login o formulario
                IdTipoTarea = Convert.ToInt32(cmbTiposTarea.SelectedValue),
                Fecha = dateTimePicker1.Value.Date,
                IdLugar = cmbLugares.SelectedIndex != -1 ? (int?)cmbLugares.SelectedValue : null,
                Comentario = "", // podés agregar un txtComentario si querés
                Uniforme = chkUniforme.Checked,
                Insumo = chkInsumo.Checked,
                Licencia = chkLicencia.Checked,
                Estudio = chkEstudio.Checked,
                Vacacion = chkVacacion.Checked,
                ReclamoSalario = false, // si no estás usando el formulario de reclamo acá
                ReclamoRecibo = false
            };
        }
        private void LimpiarFormulario()
        {
            cmbTiposTarea.SelectedIndex = -1;
            cmbLugares.SelectedIndex = -1;
            dateTimePicker1.Value = DateTime.Today;

            chkUniforme.Checked = false;
            chkInsumo.Checked = false;
            chkLicencia.Checked = false;
            chkEstudio.Checked = false;
            chkVacacion.Checked = false;
        }

    }
}
