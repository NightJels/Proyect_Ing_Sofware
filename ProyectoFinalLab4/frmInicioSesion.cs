using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace ProyectoFinalLab4
{
    public partial class frmInicioSesion : Form
    {

        public frmInicioSesion()
        {
            InitializeComponent();
            NewMethod();
            bunifuFormDock1.SubscribeControlToDragEvents(tabPage1);
            bunifuFormDock1.SubscribeControlToDragEvents(tabPage2);

            //Instancia de la clase

        }

        private void NewMethod()
        {
            bunifuFormDock1.SubscribeControlToDragEvents(bunifuShadowPanel1);
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage(0);
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage(1);
        }

        private void bunifuFormDock1_FormDragging(object sender, Bunifu.UI.WinForms.BunifuFormDock.FormDraggingEventArgs e)
        {

        }

        private void bunifuFormDock1_FormDragging_1(object sender, Bunifu.UI.WinForms.BunifuFormDock.FormDraggingEventArgs e)
        {

        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage(0);
        }

        private void bunifuButton4_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage(1);
        }

        private void frmInicioSesion_Load(object sender, EventArgs e)
        {

        }

        private void bunifuShadowPanel1_ControlAdded(object sender, ControlEventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            curso_asignado formulario2 = new curso_asignado();
            formulario2.Show();
            this.Hide();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            curso_asignado formulario2 = new curso_asignado();
            formulario2.Show();
            this.Hide();
        }

        private void bunifuButton5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuButton6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmInicioSesion_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                // El usuario hizo clic en la "X" de cierre
                // Cierra la aplicación por completo
                Application.Exit();
            }
        }





    }
}
