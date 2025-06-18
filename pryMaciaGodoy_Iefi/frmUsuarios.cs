using MaterialSkin.Controls;
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

namespace pryMaciaGodoy_Iefi
{
    public partial class frmUsuarios : MaterialForm
    {
        // ---------------------------------------------------------------------------
        #region 🧾 VARIABLES Y CAMPOS
        // ---------------------------------------------------------------------------
        clsBD conexion = new clsBD();
        int? usuarioSeleccionado = null;
        #endregion

        // ---------------------------------------------------------------------------
        #region 🚪 CONSTRUCTOR Y LOAD
        // ---------------------------------------------------------------------------
        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            CargarRoles();
            conexion.ObtenerUsuarios(dgvGestion);
        }
        #endregion

        // ---------------------------------------------------------------------------
        #region 🔄 EVENTOS DE CONTROLES
        // ---------------------------------------------------------------------------
        private void dgvGestion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var fila = dgvGestion.Rows[e.RowIndex];
            usuarioSeleccionado = Convert.ToInt32(fila.Cells["Id"].Value);

            txtUsuario.Text = fila.Cells["Nombre"].Value.ToString();
            txtCorreo.Text = fila.Cells["Correo"].Value.ToString();
            string nombreRol = fila.Cells["Rol"].Value.ToString();

            foreach (DataRowView item in cmbRol.Items)
            {
                if (item["Nombre"].ToString() == nombreRol)
                {
                    cmbRol.SelectedValue = item["Id"];
                    break;
                }
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e) { }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        // ---------------------------------------------------------------------------
        #region 📦 CRUD USUARIOS
        // ---------------------------------------------------------------------------
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                clsUsuario nuevo = new clsUsuario
                {
                    Nombre = txtUsuario.Text,
                    Contraseña = txtContraseña.Text,
                    Correo = txtCorreo.Text,
                    RolId = Convert.ToInt32(cmbRol.SelectedValue)
                };

                conexion.RegistrarUsuario(nuevo);
                conexion.ObtenerUsuarios(dgvGestion);
                LimpiarCampos();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (usuarioSeleccionado == null)
            {
                MessageBox.Show("Seleccioná un usuario de la grilla para modificar.");
                return;
            }

            if (ValidarCampos())
            {
                clsUsuario usuario = new clsUsuario
                {
                    Id = (int)usuarioSeleccionado,
                    Nombre = txtUsuario.Text,
                    Contraseña = txtContraseña.Text,
                    Correo = txtCorreo.Text,
                    RolId = Convert.ToInt32(cmbRol.SelectedValue)
                };

                conexion.ActualizarUsuario(usuario);
                conexion.ObtenerUsuarios(dgvGestion);
                LimpiarCampos();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (usuarioSeleccionado == null)
            {
                MessageBox.Show("Seleccioná un usuario para eliminar.");
                return;
            }

            if (MessageBox.Show("¿Deseás eliminar este usuario?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                conexion.EliminarUsuario((int)usuarioSeleccionado);
                conexion.ObtenerUsuarios(dgvGestion);
                LimpiarCampos();
                usuarioSeleccionado = null;
            }
        }
        #endregion

        // ---------------------------------------------------------------------------
        #region 🔍 BUSCAR Y RESTABLECER
        // ---------------------------------------------------------------------------
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string nombreBuscar = txtBuscar.Text.Trim();

            if (string.IsNullOrEmpty(nombreBuscar))
            {
                MessageBox.Show("Por favor ingresá un nombre para buscar.");
                return;
            }

            conexion.BuscarUsuarioPorNombre(dgvGestion, nombreBuscar);
        }

        private void btnRestablecer_Click(object sender, EventArgs e)
        {
            conexion.ObtenerUsuarios(dgvGestion);
            txtBuscar.Clear();
        }
        #endregion

        // ---------------------------------------------------------------------------
        #region 🧠 LÓGICA AUXILIAR
        // ---------------------------------------------------------------------------
        private void CargarRoles()
        {
            using (SqlConnection cn = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=LabIefi;Trusted_Connection=True;"))
            {
                string query = "SELECT Id, Nombre FROM Roles";
                SqlDataAdapter da = new SqlDataAdapter(query, cn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbRol.DataSource = dt;
                cmbRol.DisplayMember = "Nombre";
                cmbRol.ValueMember = "Id";
                cmbRol.SelectedIndex = -1;
            }
        }

        private bool ValidarCampos()
        {
            Error.Clear();

            if (string.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                Error.SetError(txtUsuario, "Debe ingresar un nombre de usuario");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtContraseña.Text))
            {
                Error.SetError(txtContraseña, "Debe ingresar una contraseña");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtCorreo.Text) || !txtCorreo.Text.Contains("@"))
            {
                Error.SetError(txtCorreo, "Ingrese un correo válido");
                return false;
            }

            if (cmbRol.SelectedIndex == -1)
            {
                Error.SetError(cmbRol, "Seleccione un rol");
                return false;
            }

            return true;
        }

        private void LimpiarCampos()
        {
            txtUsuario.Clear();
            txtCorreo.Clear();
            txtContraseña.Clear();
            cmbRol.SelectedIndex = -1;
            usuarioSeleccionado = null;
        }
        #endregion
       
    }
}
