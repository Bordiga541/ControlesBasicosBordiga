using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistrarTerea
{
    public partial class RegistrarTarea : Form
    {
        string datoConcatenar;
        string[] vectorActividad = new string[5];
        string[] vectorRegistroActividad = new string[4];
        int indiceRegistro = 0;
        frmMostrar frmMostrar = new frmMostrar();
        int indiceFilaRegistro;
        public RegistrarTarea()
        {
            InitializeComponent();
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cmdGrabar_Click(object sender, EventArgs e)
        {
            if (dtpFecha.Value >= DateTime.Today)
            {
                if (lstTipo.SelectedIndex != -1)
                {
                    if (txtDetalle.Text != "")
                    {
                        MessageBox.Show("Vamos a grabar...");


                        frmMostrar.matrizTareas[indiceFilaRegistro, 0] = dtpFecha.Value.ToString();
                        frmMostrar.matrizTareas[indiceFilaRegistro, 1] = lstTipo.Text;
                        frmMostrar.matrizTareas[indiceFilaRegistro, 2] = txtDetalle.Text;
                        frmMostrar.matrizTareas[indiceFilaRegistro, 3] = mrcReunion.Text;
                        frmMostrar.matrizTareas[indiceFilaRegistro, 4] = mrcTareas.Text;
                    }
                    else
                    {
                        MessageBox.Show("Te falta completar el detalle...");
                        txtDetalle.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione una actividad...");
                    lstTipo.Focus();
                }
                
            }
            else
            {
                MessageBox.Show("Selecciona una fecha actual o posterior a la de hoy",
                    "Carga de Tarea", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                dtpFecha.Value = DateTime.Today;
                dtpFecha.Focus();

            }
        }

        private void RegistrarTarea_Load(object sender, EventArgs e)
        {
            lstTipo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void lstTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
        
            
        }

        private void cmdmostrar_Click(object sender, EventArgs e)
        {
            frmMostrar frmMostrar = new frmMostrar();
            frmMostrar.Show();
            this.Hide();
        }
    }
}
