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
    public partial class frmMostrar : Form
    {
        public string[,] matrizTareas = new string[3, 5];
        int indiceFila, indiceColumna;
        public frmMostrar()
        {
            InitializeComponent();
        }

        private void Mostrar_Load(object sender, EventArgs e)
        {
            indiceColumna = 0;
            indiceFila = 0;

            while (indiceFila < matrizTareas.GetLength(0))
            {
                if (matrizTareas[indiceFila, indiceColumna] != null)
                {
                    dtgvRegistro.Rows.Add(indiceFila, indiceColumna);
                }
                indiceColumna++;
            }


        }
    }
}
