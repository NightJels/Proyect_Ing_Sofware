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
    public partial class frmTaquillaVendidas : Form
    {
        CN_VentasTaquillas objetoCN = new CN_VentasTaquillas();

        public frmTaquillaVendidas()
        {
            InitializeComponent();
        }

        private void frmTaquillaVendidas_Load(object sender, EventArgs e)
        {
            MostrarEmpleado();
        }
        private void MostrarEmpleado()
        {
            this.dgvVentasTaquillas.DataSource = null;
            this.dgvVentasTaquillas.Rows.Clear();
            dgvVentasTaquillas.DataSource = objetoCN.MostVentasTaquillas();
        }

        private void bunifuShadowPanel3_ControlAdded(object sender, ControlEventArgs e)
        {

        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {

        }
    }
}
