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
        public frmListarTareas()
        {
            InitializeComponent();
        }

        private void frmListarTareas_Load(object sender, EventArgs e)
        {
            clsBD conexion = new clsBD();
            conexion.ListarTareas(dgvTareas);

            dgvTareas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvTareas.ReadOnly = true;
            dgvTareas.AllowUserToAddRows = false;
            dgvTareas.AllowUserToDeleteRows = false;
            dgvTareas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
    }
}
