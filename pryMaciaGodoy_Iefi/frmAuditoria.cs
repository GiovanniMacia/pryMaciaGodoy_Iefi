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
    public partial class frmAuditoria : MaterialForm
    {
        clsBD conexion = new clsBD();
        public frmAuditoria()
        {
            InitializeComponent();
        }

        private void frmAuditoria_Load(object sender, EventArgs e)
        {
            conexion.ListarSesiones(dgvAudi);
        }
    }
}
