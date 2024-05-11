using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AppVector
{
    public partial class frmPrincipal : Form
    {
        //Crear una instancia de mi clase Vector, al crear una instancia va heredar todas las funciones
        clsVector v = new clsVector();
        public frmPrincipal()
        {
            InitializeComponent();
        }

        //Funcion para mostrar los datos del vector
        string mostrarVector()
        {
            {
                String x = "[ ";
                for (int i = 0; i < v.longitud(); i++)
                {
                    x = x + v.obtenerElemento(i);
                    if (i != v.longitud())
                        x = x + " , ";
                }
                x = x + " ]";
                return x;
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            mostrarVector();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt16(txtValor.Text); //convertir valor int en texto
            v.adicionar(x);
            txtValor.Clear(); // limpiar para siguente numero
            lblResultado.Text =  mostrarVector();
        }

        private void tsmAsignar_Click(object sender, EventArgs e)
        {
            int ele=Convert.ToInt16(txtValor.Text);
            v.adicionar(ele);
            lblResultado.Text = mostrarVector();
        }

        private void tsmMostrar_Click(object sender, EventArgs e)
        {
            mostrarVector();
        }

        private void tsmLongitud_Click(object sender, EventArgs e)
        {
            MessageBox.Show ( "La longitud es: " + v.longitud().ToString());
        }

        private void tsmEliminar_Click(object sender, EventArgs e)
        {
            v.eliminarUlt();
            MessageBox.Show("Último elemento eliminado correctamente.");
        }

        private void tsmEliminarPosicion_Click(object sender, EventArgs e)
        {
            int p = Convert.ToInt16(txtValor.Text);
            v.eliminarElementoPos(p);
            mostrarVector();
        }

       

        private void invertirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v.invertir();
            mostrarVector();
        }


        

        private void cantDeParesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int c = v.cantPares();
            MessageBox.Show("Cant. de Elementos pares: " + c.ToString());
        }

        private void btnMostrarValor_Click(object sender, EventArgs e)
        {
            lblResultado.Text = mostrarVector();
        }

        private void ordenarDeMenorAMayorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v.OrdenarMenorMayor();
            mostrarVector();
        }

        private void invertirCadaElementoDelVectorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v.InvertCadaElementVector();
            mostrarVector();
        }

        private void cantidadDeElementosCapicuaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int c = v.CantElemCapicua();
            MessageBox.Show("Cant. de Elementos Capicua: " + c.ToString());
        }

        private void cantidadDeElementosPrimosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int c = v.CantNumeroPrimo();
            MessageBox.Show("Cant. de Elementos Primos: " + c.ToString());
        }

        private void tsmSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
