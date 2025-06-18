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
using MaterialSkin;


namespace pryMaciaGodoy_Iefi
{
    public partial class frmListarTareas : MaterialForm
    {
        clsBD conexion = new clsBD();
        public frmListarTareas()
        {
            InitializeComponent();
        }

        private void frmListarTareas_Load(object sender, EventArgs e)
        {
            
            conexion.Listar_Tareas(dgvTareas);

            dgvTareas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvTareas.ReadOnly = true;
            dgvTareas.AllowUserToAddRows = false;
            dgvTareas.AllowUserToDeleteRows = false;
            dgvTareas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void txtBuscarTarea_TextChanged(object sender, EventArgs e)
        {
            conexion.BuscarporTarea(dgvTareas, txtBuscarTarea.Text);
        }

        private void btnVerTodos_Click(object sender, EventArgs e)
        {
            conexion.Listar_Tareas(dgvTareas);

            txtBuscarTarea.Clear();
        }
    }
}
