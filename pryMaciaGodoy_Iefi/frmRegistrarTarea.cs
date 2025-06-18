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
        // ---------------------------------------------------------------------------
        #region 🧾 VARIABLES Y CAMPOS
        // ---------------------------------------------------------------------------
        private BindingList<clsTarea> listaTareas = new BindingList<clsTarea>();
        private string cadenaConexion = "Server=localhost\\SQLEXPRESS;Database=LabIefi;Trusted_Connection=True;";
        private int usuarioId;
        clsBD conexion = new clsBD();
        #endregion

        // ---------------------------------------------------------------------------
        #region 🚪 CONSTRUCTOR Y LOAD
        // ---------------------------------------------------------------------------
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
            ConfigurarAccesoPorRol();
        }
        #endregion

        // ---------------------------------------------------------------------------
        #region 🔒 CONTROL DE ACCESO
        // ---------------------------------------------------------------------------
        private void ConfigurarAccesoPorRol()
        {
            if (usuarioId != 1)
            {
                btnAgregar.Enabled = false;
                btnModificar.Enabled = false;
                btnEliminar.Enabled = false;
                btnAgregarLugares.Enabled = false;
                btnModificarLugares.Enabled = false;
                btnEliminarLugares.Enabled = false;
            }
        }
        #endregion

        // ---------------------------------------------------------------------------
        #region 📋 CREAR Y LIMPIAR FORMULARIO
        // ---------------------------------------------------------------------------
        private clsTarea CrearTareaDesdeFormulario()
        {
            return new clsTarea
            {
                IdUsuario = usuarioId,
                IdTipoTarea = Convert.ToInt32(cmbTipoTarea.SelectedValue),
                Fecha = dateTime.Value.Date,
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
            dateTime.Value = DateTime.Today;

            chkInsumos.Checked = false;
            chkEstudio.Checked = false;
            chkVacacion.Checked = false;
            chkSalario.Checked = false;
            chkRecibo.Checked = false;
            txtMensajeria.Clear();
            txtLugares.Clear();
            txtTareas.Clear();
        }
        #endregion

        // ---------------------------------------------------------------------------
        #region 💾 GUARDAR Y AGREGAR TAREAS
        // ---------------------------------------------------------------------------
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (cmbLugaress.SelectedIndex == -1 || cmbTipoTarea.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un lugar y un tipo de tarea.");
                return;
            }

            clsTarea nueva = new clsTarea
            {
                IdUsuario = usuarioId,
                IdTipoTarea = Convert.ToInt32(cmbTipoTarea.SelectedValue),
                NombreTipoTarea = cmbTipoTarea.Text,
                IdLugar = cmbLugaress.SelectedIndex != -1 ? (int?)cmbLugaress.SelectedValue : null,
                NombreLugar = cmbLugaress.Text,
                Fecha = dateTime.Value,
                Comentario = txtMensajeria.Text.Trim(),
                Insumo = chkInsumos.Checked,
                Vacacion = chkVacacion.Checked,
                Estudio = chkEstudio.Checked,
                ReclamoSalario = chkSalario.Checked,
                ReclamoRecibo = chkRecibo.Checked
            };

            conexion.GuardarTarea(nueva);
            listaTareas.Add(nueva);
            MessageBox.Show("Tarea agregada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LimpiarFormulario();
        }
        #endregion

        // ---------------------------------------------------------------------------
        #region 🗂️ GRILLA
        // ---------------------------------------------------------------------------
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
        #endregion

        // ---------------------------------------------------------------------------
        #region 🏷️ CRUD TAREAS Y LUGARES
        // ---------------------------------------------------------------------------
        private void btnAgregarLugares_Click(object sender, EventArgs e)
        {
            string nuevoLugar = txtLugares.Text.Trim();

            if (!string.IsNullOrEmpty(nuevoLugar))
            {
                conexion.Agregar_Lugar(nuevoLugar);
                MessageBox.Show("Lugar agregado correctamente.", "Éxito");
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
                clsTarea tarea = new clsTarea();
                tarea.Comentario = nuevaTarea;

                conexion.Agregar_TipoTarea(tarea);
                MessageBox.Show("Tarea agregada correctamente.", "Éxito");
                txtTareas.Clear();
                conexion.CargarTiposTarea(cmbTipoTarea);
            }
            else
            {
                MessageBox.Show("Debe ingresar un nombre para la tarea.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            txtTareas.Focus();
        }

        public void btnModificar_Click(object sender, EventArgs e)
        {
            if (cmbTipoTarea.SelectedIndex != -1 && !string.IsNullOrWhiteSpace(txtTareas.Text))
            {
                int id = Convert.ToInt32(cmbTipoTarea.SelectedValue);
                string nuevoNombre = txtTareas.Text.Trim();
                conexion.Modificar_TipoTarea(id, nuevoNombre);

                MessageBox.Show("Tarea modificada con éxito.");
                conexion.CargarTiposTarea(cmbTipoTarea);
                txtTareas.Clear();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (cmbTipoTarea.SelectedIndex != -1)
            {
                int id = Convert.ToInt32(cmbTipoTarea.SelectedValue);

                if (conexion.TipoTareaEnUso(id))
                {
                    MessageBox.Show("No se puede eliminar esta tarea porque ya fue utilizada.", "Advertencia");
                    return;
                }

                conexion.Eliminar_TipoTarea(id);
                MessageBox.Show("Tarea eliminada correctamente.");
                conexion.CargarTiposTarea(cmbTipoTarea);
                txtTareas.Clear();
            }
        }

        private void btnModificarLugares_Click(object sender, EventArgs e)
        {
            if (cmbLugaress.SelectedIndex != -1 && !string.IsNullOrWhiteSpace(txtLugares.Text))
            {
                int id = Convert.ToInt32(cmbLugaress.SelectedValue);
                string nuevoNombre = txtLugares.Text.Trim();
                conexion.Modificar_Lugar(id, nuevoNombre);

                MessageBox.Show("Lugar modificado con éxito.");
                conexion.CargarLugares(cmbLugaress);
                txtLugares.Clear();
            }
        }

        private void btnEliminarLugares_Click(object sender, EventArgs e)
        {
            if (cmbLugaress.SelectedIndex != -1)
            {
                int id = Convert.ToInt32(cmbLugaress.SelectedValue);

                if (conexion.LugarEnUso(id))
                {
                    MessageBox.Show("No se puede eliminar este lugar porque ya está vinculado a tareas.", "Advertencia");
                    return;
                }

                conexion.Eliminar_Lugar(id);
                MessageBox.Show("Lugar eliminado correctamente.");
                conexion.CargarLugares(cmbLugaress);
                txtLugares.Clear();
            }
        }
        #endregion

        // ---------------------------------------------------------------------------
        #region 🔄 EVENTOS DE CONTROLES
        // ---------------------------------------------------------------------------
        private void cmbTipoTarea_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipoTarea.SelectedIndex != -1)
                txtTareas.Text = cmbTipoTarea.Text;
        }

        private void cmbLugaress_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLugaress.SelectedIndex != -1)
                txtLugares.Text = cmbLugaress.Text;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }
        #endregion
        
    }
}
