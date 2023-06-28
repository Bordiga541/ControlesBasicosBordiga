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
    public partial class Registrar : Form
    {
        Mostrar ventanaMostrar = new Mostrar();
        int indiceFilaRegistro;
        public Registrar()
        {
            InitializeComponent();
        }

        private void cmdGrabar_Click(object sender, EventArgs e)
        {
            string varTareas = "";
            string varReunion = "";
            if (dtpFecha.Value >= DateTime.Today)
            {
                if (lstTipo.SelectedIndex != -1)
                {
                    if (txtDetalle.Text != "")
                    {
                        MessageBox.Show("Se registro correctamente", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);


                        if (optSi.Checked == true)
                        {
                            varReunion = "Si";
                        }
                        else
                        {
                            varReunion = "No";
                        }
                        if (chkDebate.Checked)
                        {
                            varTareas = "Debate, ";
                        }
                        if (chkInvestigacion.Checked)
                        {
                            varTareas = varTareas + "Investigacion, ";
                        }
                        if (chkNotasReunion.Checked)
                        {
                            varTareas = varTareas + "Notas, ";
                        }
                        if (chkRepositorio.Checked)
                        {
                            varTareas = varTareas + "Repositorio, ";
                        }

                        ventanaMostrar.matrizTareas[indiceFilaRegistro, 0] = dtpFecha.Value.ToString();
                        ventanaMostrar.matrizTareas[indiceFilaRegistro, 1] = lstTipo.Text;
                        ventanaMostrar.matrizTareas[indiceFilaRegistro, 2] = txtDetalle.Text;
                        ventanaMostrar.matrizTareas[indiceFilaRegistro, 3] = varReunion;
                        ventanaMostrar.matrizTareas[indiceFilaRegistro, 4] = varTareas;



                        indiceFilaRegistro++;

                        if (indiceFilaRegistro == ventanaMostrar.matrizTareas.GetLength(0))
                        {
                            cmdGrabar.Enabled = false;

                        }
                    }
                    else
                    {
                        MessageBox.Show("Te falta completar el Detalle", "Detalle faltante", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtDetalle.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Selecciona una actividad..", "Falta seleccionar una Actividad", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    lstTipo.Focus();

                }
            }
            else
            {
                MessageBox.Show("Seleccione una fecha actual o posterior a la de hoy", "Carga de Tarea", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpFecha.Value = DateTime.Today;
                dtpFecha.Focus();
            }
        }

        private void cmdmostrar_Click(object sender, EventArgs e)
        {
            ventanaMostrar.ShowDialog();
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
