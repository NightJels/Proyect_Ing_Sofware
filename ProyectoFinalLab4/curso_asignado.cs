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
    public partial class curso_asignado : Form
    {
         CN_VentasTaquillas objetoCN = new CN_VentasTaquillas();
        public curso_asignado()
        {
            InitializeComponent();
        }

        private void bunifuLabel9_Click(object sender, EventArgs e)
        {


        }

        private void bunifuShadowPanel2_ControlAdded(object sender, ControlEventArgs e)
        {

        }

        private void curso_asignado_Load(object sender, EventArgs e)
        {

        }

        private void bunifuButton5_Click(object sender, EventArgs e)
        {
            
            cursos formulario2 = new cursos();
            formulario2.Show();
          

        }

        private void bunifuButton9_Click(object sender, EventArgs e)
        {
            aula formulario2 = new aula();
            formulario2.Show();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            prr formulario2 = new prr();
            formulario2.Show();
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            prr formulario2 = new prr();
            formulario2.Show();
        }

        private void bunifuButton10_Click(object sender, EventArgs e)
        {
            aula formulario2 = new aula();
            formulario2.Show();
        }

        private void bunifuButton11_Click(object sender, EventArgs e)
        {
            cursos formulario2 = new cursos();
            formulario2.Show();
        }

        private void bunifuLabel12_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel18_Click(object sender, EventArgs e)
        {

        }
    }
}
