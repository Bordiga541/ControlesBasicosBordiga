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
    public partial class Mostrar : Form
    {
        public string[,] matrizTareas = new string[5, 5];
        int indiceFila, indiceColumna;
        public Mostrar()
        {
            InitializeComponent();
        }

        private void Mostrar_Load(object sender, EventArgs e)
        {
            indiceColumna = 0;
            indiceFila = 0;

            while (indiceFila < matrizTareas.GetLength(0))
            {
                dtgvRegistro.Rows.Add(matrizTareas[indiceFila, 0],
                    matrizTareas[indiceFila, 1],
                    matrizTareas[indiceFila, 2],
                    matrizTareas[indiceFila, 3],
                    matrizTareas[indiceFila, 4]);



                indiceFila++;

            }


            
        }
    }
}
