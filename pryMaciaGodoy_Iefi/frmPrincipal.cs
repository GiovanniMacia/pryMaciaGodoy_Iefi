using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryMaciaGodoy_Iefi
{
    public partial class frmPrincipal : MaterialForm
    {
        private  string usuarioNombre;
        private int usuarioRol;

        private DateTime fechaInicioSesion;
        private DateTime horaInicioSesion;
        private DateTime horaFinSesion;

        private int segundosContador = 0;

        private readonly clsBD conexion = new clsBD();
        public frmPrincipal(String nombre, int rol)
        {
            InitializeComponent();
            usuarioNombre = nombre;
            usuarioRol = rol;
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            // Iniciar tiempo
            Tiempo.Interval = 1000;
            Tiempo.Start();

            horaInicioSesion = DateTime.Now;
            fechaInicioSesion = horaInicioSesion.Date;

            lblUsuarioActivo.Text = $"Bienvenido: {usuarioNombre}";
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
                Tiempo.Stop();
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

            int idUsuario = conexion.ObtenerIdUsuarioPorNombre(usuarioNombre);
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

        private void registrarTareasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistrarTarea frm = new frmRegistrarTarea();
            frm.ShowDialog();

        }
    }
}
