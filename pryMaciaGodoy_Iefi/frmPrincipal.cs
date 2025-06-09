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
        private string nombreUsuario;
        private int usuarioRol;

        private DateTime fechaInicioSesion;
        private DateTime horaInicioSesion;
        private DateTime horaFinSesion;

        private int segundosContador = 0;

        private readonly clsBD conexion = new clsBD();
        public frmPrincipal(String nombre, int rol)
        {
            InitializeComponent();
            nombreUsuario = nombre;
            usuarioRol = rol;
        }

        public void frmPrincipal_Load(object sender, EventArgs e)
        {
            // Iniciar tiempo
            Tiempo.Interval = 1000;
            Tiempo.Start();

            horaInicioSesion = DateTime.Now;
            fechaInicioSesion = horaInicioSesion.Date;

            lblUsuarioActivo.Text = $"Bienvenido: {nombreUsuario}";
            lblFechaa.Text = $"Fecha: {fechaInicioSesion:dd/MM/yyyy}";

            ConfigurarAccesoPorRol();
        }
        private void ConfigurarAccesoPorRol()
        {
            menuInicio.Visible = true;

            if (usuarioRol == 1) // Administrador
            {
                menuTareas.Visible = false;
                menuAdministracion.Visible = true;
            }
            else // Usuario común
            {
                menuTareas.Visible = true;
                menuAdministracion.Visible = false;
            }
        }



        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var confirmar = MessageBox.Show("¿Deseás cerrar sesión?", "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmar == DialogResult.Yes)
            {
                // Detener cualquier temporizador si aplica
                Tiempo.Stop();

                // Obtener hora fin
                DateTime horaFinSesion = DateTime.Now;

                // Armar el objeto sesión
                int idUsuario = conexion.ObtenerIdUsuarioPorNombre(nombreUsuario); // Método que ya tenés
                clsSesion sesion = new clsSesion
                {
                    IdUsuario = idUsuario,
                    FechaInicio = horaInicioSesion.Date,
                    HoraInicio = horaInicioSesion,
                    HoraFin = horaFinSesion
                };

                // Guardar la sesión
                conexion.GuardarSesion(sesion);

                // Volver al login
                this.Hide();
                new frmLogin().Show();
            }
        }

        private void timerTiempo_Tick(object sender, EventArgs e)
        {
            segundosContador++;
            TimeSpan tiempoTranscurrido = TimeSpan.FromSeconds(segundosContador);
            LblTiempo.Text = tiempoTranscurrido.ToString(@"hh\:mm\:ss");
        }

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

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuarios Gestion = new frmUsuarios();
            Gestion.ShowDialog();
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

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            clsBD conexion = new clsBD();

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

        private void listarTareasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListarTareas listar = new frmListarTareas();
            listar.ShowDialog();
        }
    }
}
