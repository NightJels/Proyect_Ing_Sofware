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
    public partial class frmPelicula : Form
    {
        private string IdPelicula = null;
        CN_Pelicula objetoCN = new CN_Pelicula();
        public frmPelicula()
        {
            InitializeComponent();
        }

        private void frmPelicula_Load(object sender, EventArgs e)
        {
            MostrarPelicula();
        }
        private void MostrarPelicula()
        {
          dtvPelicula.DataSource = objetoCN.MotrarPelicula();
        }
        private void LimpiarTextBox()
        {
            foreach (Control txt in this.Controls)
            {
                if (txt is TextBox)
                    txt.Text = String.Empty;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (this.btnGuardar.Text == "Guardar")
            {
                try
                {
                    objetoCN.InsertarPelicula(txtTitulo.Text, txtCategoria.Text, guna2DateTimePicker1.Text, txtPrecio.Text);
                    MostrarPelicula();
                    MessageBox.Show("Datos guardados\n\n", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarTextBox();
                }
                catch (Exception error)
                {
                    MessageBox.Show("hubo un error al guardar los datos\n\n" + error.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (this.btnGuardar.Text == "Actualizar")
            {
                objetoCN.editarPelicula(txtTitulo.Text, txtCategoria.Text, guna2DateTimePicker1.Text, txtPrecio.Text,IdPelicula);
                MostrarPelicula();
                MessageBox.Show("Datos Actualizado\n\n", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarTextBox();
                this.btnGuardar.Text = "Guardar";
                this.btnEliminar.Enabled = true;
                btnActualizar.Enabled = true;

            }
        }

        private void bunifuTextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void bttnActualizar_Click(object sender, EventArgs e)
        {
            if (dtvPelicula.SelectedRows.Count > 0)
            {
                txtTitulo.Text = dtvPelicula.CurrentRow.Cells["Titulo"].Value.ToString();
                txtCategoria.Text = dtvPelicula.CurrentRow.Cells["Categoria"].Value.ToString();
                guna2DateTimePicker1.Text = dtvPelicula.CurrentRow.Cells["Fecha_de_Salida"].Value.ToString();
                txtPrecio.Text = dtvPelicula.CurrentRow.Cells["Precio"].Value.ToString();
                this.btnEliminar.Enabled = false;
                this.btnActualizar.Enabled = false;
                btnGuardar.Text = "Actualizar";
                MostrarPelicula();
            }
            else
            {
                MessageBox.Show("Seleccione el registro a Actualizar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtvPelicula.SelectedRows.Count > 0)
                {
                    IdPelicula = dtvPelicula.CurrentRow.Cells["Id"].Value.ToString();
                    objetoCN.EliminarPelicula(IdPelicula);
                    MessageBox.Show("Registro Eliminado\n\n", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MostrarPelicula();
                }
                else
                {
                    MessageBox.Show("Seleccione el Registro a Eliminar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("hubo un error al aliminar el registro\n\n" + error.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}
