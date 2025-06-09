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
        private BindingList<clsTarea> listaTareas = new BindingList<clsTarea>();

        private string cadenaConexion = "Server=localhost\\SQLEXPRESS;Database=LabIefi;Trusted_Connection=True;";
        private int usuarioId;
        clsBD conexion = new clsBD();
        public frmRegistrarTarea(int usuarioId)
        {
            InitializeComponent();
            this.usuarioId = usuarioId;
        }

        public void frmRegistrarTarea_Load(object sender, EventArgs e)
        {

            InicializarGrilla();
            conexion.CargarTiposTarea(cmbTipoTarea);
            conexion.CargarLugares(cmbLugaress);
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

                cmbTipoTarea.DataSource = dt;
                cmbTipoTarea.DisplayMember = "Nombre";
                cmbTipoTarea.ValueMember = "Id";
                cmbTipoTarea.SelectedIndex = -1;
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

                cmbLugaress.DataSource = dt;
                cmbLugaress.DisplayMember = "Nombre";
                cmbLugaress.ValueMember = "Id";
                cmbLugaress.SelectedIndex = -1;
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
                IdUsuario = usuarioId, 
                IdTipoTarea = Convert.ToInt32(cmbTipoTarea.SelectedValue),
                Fecha = dateTimePicker1.Value.Date,
                IdLugar = cmbLugaress.SelectedIndex != -1 ? (int?)cmbLugaress.SelectedValue : null,
                Comentario = "", 
              
                Insumo = chkInsumos.Checked,
              
                Estudio = chkEstudio.Checked,
                Vacacion = chkVacacion.Checked,
                
                ReclamoSalario = false, 
                ReclamoRecibo = false
            };
        }
        private void LimpiarFormulario()
        {
            cmbTipoTarea.SelectedIndex = -1;
            cmbLugaress.SelectedIndex = -1;
            dateTimePicker1.Value = DateTime.Today;

           
            chkInsumos.Checked = false;
           
            chkEstudio.Checked = false;
            chkVacacion.Checked = false;
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (cmbLugaress.SelectedIndex == -1 || cmbTipoTarea.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un lugar y un tipo de tarea.");
                return;
            }
            clsTarea nueva = new clsTarea
            {
                IdTipoTarea = Convert.ToInt32(cmbTipoTarea.SelectedValue),
                NombreTipoTarea = cmbTipoTarea.Text, // << NUEVO

                IdLugar = cmbLugaress.SelectedIndex != -1 ? (int?)cmbLugaress.SelectedValue : null,
                NombreLugar = cmbLugaress.Text, // << NUEVO

                Fecha = dateTimePicker1.Value,
                Comentario = txtMensajeria.Text.Trim(),
                Insumo = chkInsumos.Checked,
                Vacacion = chkVacacion.Checked,
                Estudio = chkEstudio.Checked,
                ReclamoSalario = chkSalario.Checked,
                ReclamoRecibo = chkRecibo.Checked
            };

            listaTareas.Add(nueva); // <<--- ¡Este es el cambio!

            // Mostrar mensaje
            MessageBox.Show("Tarea agregada a la lista correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Limpiar controles
            cmbLugaress.SelectedIndex = -1;
            cmbTipoTarea.SelectedIndex = -1;
            txtMensajeria.Clear();
            chkInsumos.Checked = false;
            chkVacacion.Checked = false;
            chkEstudio.Checked = false;
            chkSalario.Checked = false;
            chkRecibo.Checked = false;
        }
        private void InicializarGrilla()
        {
            dgvTareas.AutoGenerateColumns = false;
            dgvTareas.Columns.Clear();

            dgvTareas.Columns.Add("Comentario", "Comentario");
            dgvTareas.Columns["Comentario"].DataPropertyName = "Comentario";

            dgvTareas.Columns.Add("Fecha", "Fecha");
            dgvTareas.Columns["Fecha"].DataPropertyName = "Fecha";

            dgvTareas.Columns.Add("NombreTipoTarea", "Tipo de Tarea"); 
            dgvTareas.Columns["NombreTipoTarea"].DataPropertyName = "NombreTipoTarea";

            dgvTareas.Columns.Add("NombreLugar", "Lugar");
            dgvTareas.Columns["NombreLugar"].DataPropertyName = "NombreLugar";

            // Columnas checkbox
            dgvTareas.Columns.Add(new DataGridViewCheckBoxColumn()
            {
                HeaderText = "Insumo",
                DataPropertyName = "Insumo",
                Name = "Insumo"
            });

            dgvTareas.Columns.Add(new DataGridViewCheckBoxColumn()
            {
                HeaderText = "Estudio",
                DataPropertyName = "Estudio",
                Name = "Estudio"
            });

            dgvTareas.Columns.Add(new DataGridViewCheckBoxColumn()
            {
                HeaderText = "Vacación",
                DataPropertyName = "Vacacion",
                Name = "Vacacion"
            });

            dgvTareas.Columns.Add(new DataGridViewCheckBoxColumn()
            {
                HeaderText = "Reclamo Salario",
                DataPropertyName = "ReclamoSalario",
                Name = "ReclamoSalario"
            });

            dgvTareas.Columns.Add(new DataGridViewCheckBoxColumn()
            {
                HeaderText = "Reclamo Recibo",
                DataPropertyName = "ReclamoRecibo",
                Name = "ReclamoRecibo"
            });

           
            dgvTareas.DataSource = listaTareas;
        }

        private void btnAgregarLugares_Click(object sender, EventArgs e)
        {
            string nuevoLugar = txtLugares.Text.Trim();

            if (!string.IsNullOrEmpty(nuevoLugar))
            {
                conexion.Agregar_Lugar(nuevoLugar);

                MessageBox.Show("Lugar agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtLugares.Clear();

            
                conexion.CargarLugares(cmbLugaress);
            }
            else
            {
                MessageBox.Show("Debe ingresar un nombre para el lugar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            txtLugares.Focus();
        }

        private void btnAgregarTareas_Click(object sender, EventArgs e)
        {
            string nuevaTarea = txtTareas.Text.Trim();

            if (!string.IsNullOrEmpty(nuevaTarea))
            {
                // Crear una instancia de clsTarea solo para pasar el nombre
                clsTarea tarea = new clsTarea();
                tarea.Comentario = nuevaTarea;

                conexion.Agregar_TipoTarea(tarea);

                MessageBox.Show("Tarea agregada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTareas.Clear();

                conexion.CargarTiposTarea(cmbTipoTarea);
            }
            else
            {
                MessageBox.Show("Debe ingresar un nombre para la tarea.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            txtTareas.Focus();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // Limpiar campos de texto
            txtLugares.Clear();
            txtTareas.Clear();
            txtMensajeria.Clear();

            // Resetear comboBox
            cmbLugaress.SelectedIndex = -1;
            cmbTipoTarea.SelectedIndex = -1;

            // Resetear fecha al día actual
            dateTimePicker1.Value = DateTime.Now;

            // Desmarcar todos los CheckBoxes
            chkInsumos.Checked = false;
            chkEstudio.Checked = false;
            chkVacacion.Checked = false;
            chkSalario.Checked = false;
            chkRecibo.Checked = false;

       
        }

        private void btnGuardar_Click_2(object sender, EventArgs e)
        {
       
        }
    
    }
}
