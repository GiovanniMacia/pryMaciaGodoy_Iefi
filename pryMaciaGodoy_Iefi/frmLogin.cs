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
    public partial class frmLogin : MaterialForm
    {
        // ---------------------------------------------------------------------------
        #region VARIABLES GLOBALES
        // ---------------------------------------------------------------------------
        public static string UsuarioActual;
        public static DateTime HoraInicioSesion;
        #endregion

        // ---------------------------------------------------------------------------
        #region CONSTRUCTOR Y CONFIGURACIÓN DEL FORMULARIO
        // ---------------------------------------------------------------------------
        public frmLogin()
        {
            InitializeComponent();

            // Configuración de estilo con MaterialSkin
            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.DARK;

            skinManager.ColorScheme = new ColorScheme(
                Primary.DeepPurple700,   // Color principal del contenido
                Primary.DeepPurple900,   // Fondo del formulario
                Primary.DeepPurple500,   // Cabecera
                Accent.Indigo200,        // Color de acento (botones, etc.)
                TextShade.WHITE);        // Color del texto

            // Configuración inicial de campos
            txtContraseña.Password = true;
            chkMostrar.Checked = false;

            // Fuente personalizada
            txtUsuario.Font = new Font("Georgia", 12, FontStyle.Regular);
            txtContraseña.Font = new Font("Georgia", 12, FontStyle.Regular);
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            
        }
        #endregion

        // ---------------------------------------------------------------------------
        #region EVENTOS DE CONTROLES
        // ---------------------------------------------------------------------------
        private void chkMostrar_CheckedChanged(object sender, EventArgs e)
        {
            // Alternar visibilidad de la contraseña
            txtContraseña.Password = !chkMostrar.Checked;
        }
        #endregion

        // ---------------------------------------------------------------------------
        #region MÉTODOS: SESIONES
        // ---------------------------------------------------------------------------
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string username = txtUsuario.Text.Trim();
            string password = txtContraseña.Text;

            // Validar campos vacíos
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Por favor, completá ambos campos.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Datos de conexión y consulta SQL
            string connectionString = "Server=localhost\\SQLEXPRESS;Database=LabIefi;Trusted_Connection=True;";
            string query = "SELECT RolId FROM Usuarios WHERE Nombre = @usuario AND Contraseña = @Contraseña";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@usuario", username);
                cmd.Parameters.AddWithValue("@Contraseña", password);

                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        // Login exitoso
                        int rolId = Convert.ToInt32(reader["RolId"]);

                        UsuarioActual = username;
                        HoraInicioSesion = DateTime.Now;

                        MessageBox.Show("Inicio de sesión exitoso. RolId: " + rolId);

                        // Abrir formulario principal
                        frmPrincipal ventana = new frmPrincipal(username, rolId);
                        ventana.Show();
                        this.Hide();
                    }
                    else
                    {
                        // Credenciales inválidas
                        MessageBox.Show("Usuario o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    // Error de conexión
                    MessageBox.Show("Error al conectar con la base de datos:\n" + ex.Message, "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        #endregion
    }
}


