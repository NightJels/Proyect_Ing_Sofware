using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace ProyectoFinalLab4
{
    public partial class frmVentasTaquillas : Form
    {
        CN_VentasTaquillas objetoCN = new CN_VentasTaquillas();

        public frmVentasTaquillas()
        {
            InitializeComponent();
        }

        private void panelBody_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmVentasTaquillas_Load(object sender, EventArgs e)
        {

        }
    }
}
