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

namespace pryMaciaGodoy_Iefi
{
    public partial class frmPrincipal : MaterialForm
    {
        // ---------------------------------------------------------------------------
        #region VARIABLES GLOBALES
        // ---------------------------------------------------------------------------
        private string nombreUsuario;
        private int usuarioRol;

        private DateTime fechaInicioSesion;
        private DateTime horaInicioSesion;
        private DateTime horaFinSesion;

        private int segundosContador = 0;

        private readonly clsBD conexion = new clsBD();
        #endregion

        // ---------------------------------------------------------------------------
        #region CONSTRUCTOR
        // ---------------------------------------------------------------------------
        public frmPrincipal(string nombre, int rol)
        {
            InitializeComponent();
            nombreUsuario = nombre;
            usuarioRol = rol;
        }
        #endregion

        // ---------------------------------------------------------------------------
        #region EVENTO LOAD DEL FORMULARIO
        // ---------------------------------------------------------------------------
        public void frmPrincipal_Load(object sender, EventArgs e)
        {
            // Iniciar temporizador
            Tiempo.Interval = 1000;
            Tiempo.Start();

            horaInicioSesion = DateTime.Now;
            fechaInicioSesion = horaInicioSesion.Date;

            lblUsuarioActivo.Text = $"Bienvenido: {nombreUsuario}";
            lblFechaa.Text = $"Fecha: {fechaInicioSesion:dd/MM/yyyy}";

            ConfigurarAccesoPorRol();
        }
        #endregion

        // ---------------------------------------------------------------------------
        #region CONFIGURAR ACCESO POR ROL
        // ---------------------------------------------------------------------------
        public void ConfigurarAccesoPorRol()
        {
            menuInicio.Visible = true;

            if (usuarioRol == 1) // Administrador
            {
                menuTareas.Visible = true;
                menuAdministracion.Visible = true;
            }
            else // Usuario común
            {
                menuTareas.Visible = true;
                menuAdministracion.Visible = false;
            }
        }
        #endregion

        // ---------------------------------------------------------------------------
        #region CIERRE DE SESIÓN
        // ---------------------------------------------------------------------------
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var confirmar = MessageBox.Show("¿Deseás cerrar sesión?", "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmar == DialogResult.Yes)
            {
                Tiempo.Stop();
                horaFinSesion = DateTime.Now;

                int idUsuario = conexion.ObtenerIdUsuarioPorNombre(nombreUsuario);

                clsSesion sesion = new clsSesion
                {
                    IdUsuario = idUsuario,
                    FechaInicio = horaInicioSesion.Date,
                    HoraInicio = horaInicioSesion,
                    HoraFin = horaFinSesion
                };

                conexion.GuardarSesion(sesion);

                this.Hide();
                new frmLogin().Show();
            }
        }
        #endregion

        // ---------------------------------------------------------------------------
        #region TEMPORIZADOR
        // ---------------------------------------------------------------------------
        private void timerTiempo_Tick(object sender, EventArgs e)
        {
            segundosContador++;
            TimeSpan tiempoTranscurrido = TimeSpan.FromSeconds(segundosContador);
            LblTiempo.Text = tiempoTranscurrido.ToString(@"hh\:mm\:ss");
        }
        #endregion

        // ---------------------------------------------------------------------------
        #region CIERRE COMPLETO DEL FORMULARIO
        // ---------------------------------------------------------------------------
        private void frmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Tiempo.Stop();
            horaFinSesion = DateTime.Now;

            TimeSpan duracion = horaFinSesion - horaInicioSesion;
            int idUsuario = conexion.ObtenerIdUsuarioPorNombre(nombreUsuario);

            clsSesion nuevaSesion = new clsSesion(0, idUsuario, fechaInicioSesion, horaInicioSesion, horaFinSesion, duracion);
            conexion.GuardarSesion(nuevaSesion);

            Application.Exit();
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            int idUsuario = conexion.ObtenerIdUsuarioPorNombre(frmLogin.UsuarioActual);

            clsSesion sesion = new clsSesion
            {
                IdUsuario = idUsuario,
                FechaInicio = frmLogin.HoraInicioSesion.Date,
                HoraInicio = frmLogin.HoraInicioSesion,
                HoraFin = DateTime.Now
            };

            conexion.GuardarSesion(sesion);
        }
        #endregion

        // ---------------------------------------------------------------------------
        #region EVENTOS DE MENÚ
        // ---------------------------------------------------------------------------
        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuarios gestion = new frmUsuarios();
            gestion.ShowDialog();
        }

        private void auditoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAuditoria auditoria = new frmAuditoria();
            auditoria.ShowDialog();
        }

        public void registrarTareasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistrarTarea frm = new frmRegistrarTarea(usuarioRol);
            frm.Show();
        }

        private void listarTareasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListarTareas listar = new frmListarTareas();
            listar.ShowDialog();
        }
        #endregion

 
        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }
       
       
    }
}
