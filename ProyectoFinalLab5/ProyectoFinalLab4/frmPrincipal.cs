using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace ProyectoFinalLab4
{
    public partial class frmPrincipal : Form
    {
        private IconButton CurrentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;

        public frmPrincipal()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 50);
            panelSideMenu.Controls.Add(leftBorderBtn);
            OpenChildForm(new frmVentasTaquillas());

        }
        private struct RGBColors
        {
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
        }

        private void ActivateBoutton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();

                CurrentBtn = (IconButton)senderBtn;
                CurrentBtn.BackColor = Color.FromArgb(37, 36, 81);
                CurrentBtn.ForeColor = color;
                CurrentBtn.TextAlign = ContentAlignment.MiddleCenter;
                CurrentBtn.IconColor = color;
                CurrentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                CurrentBtn.ImageAlign = ContentAlignment.MiddleRight;

                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, CurrentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                iconFormActual.IconChar = CurrentBtn.IconChar;
                iconFormActual.IconColor = color;
                labelFormActual.Text = CurrentBtn.Text;
            }
        }
        private void DisableButton()
        {
            if (CurrentBtn != null)
            {
                CurrentBtn.BackColor = Color.FromArgb(11, 7, 17);
                CurrentBtn.ForeColor = Color.Gainsboro;
                CurrentBtn.TextAlign = ContentAlignment.MiddleLeft;
                CurrentBtn.IconColor = Color.FromArgb(243, 88, 6);
                CurrentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                CurrentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void OpenChildForm(Form childForm)
        {
       
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelBody.Controls.Add(childForm);
            panelBody.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            ActivateBoutton(sender, RGBColors.color3);
            OpenChildForm(new frmVentasTaquillas());
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            ActivateBoutton(sender, RGBColors.color2);
            OpenChildForm(new frmTaquillaVendidas());
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            ActivateBoutton(sender, RGBColors.color3);
            OpenChildForm(new frmPelicula());
          
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            ActivateBoutton(sender, RGBColors.color2);
            OpenChildForm(new frmSobreNosotros());
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Reset();
            OpenChildForm(new frmVentasTaquillas());
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconFormActual.IconChar = IconChar.Home;
            iconFormActual.IconColor = Color.FromArgb(243, 88, 6);
            labelFormActual.Text = "Inicio";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panelBody_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelSideMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel4_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel5_Click(object sender, EventArgs e)
        {

        }
    }
}
