using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using NuevosComponentes;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            labelTextBox1.Posicion = LabelTextBox.EPosicion.IZQUIERDA;
        }

        private void labelTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Text = "Letra PRESS: " + e.KeyChar;
        }

        private void labelTextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            Text = "Letra UP: " + e.KeyCode;
        }

        private void btnCambiar_Click(object sender, EventArgs e)
        {
            labelTextBox1.Posicion = labelTextBox1.Posicion == LabelTextBox.EPosicion.IZQUIERDA ? LabelTextBox.EPosicion.DERECHA : LabelTextBox.EPosicion.IZQUIERDA;
        }

        private void btnSeparar_Click(object sender, EventArgs e)
        {
            labelTextBox1.Separacion += ((Button)sender).Name.Contains("Menos") ? -1 : 1;
        }

        private void labelTextBox1_PosicionChanged(object sender, EventArgs e)
        {
            Text = labelTextBox1.Posicion.ToString();
        }

        private void labelTextBox1_SeparacionChanged(object sender, EventArgs e)
        {
            Text = labelTextBox1.Separacion.ToString();
        }

        private void labelTextBox1_TxtChanged(object sender, EventArgs e)
        {
            txtTexto.Text = labelTextBox1.TextTxt;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawString("Prueba PAINT", Font, Brushes.Violet, 10, 80);
        }

        private void etiquetaAviso1_ClickEnMarca(object sender, EventArgs e)
        {
            Debug.WriteLine("hola");
        }
    }
}
// 