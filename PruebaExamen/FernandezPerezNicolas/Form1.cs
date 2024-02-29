using NuevosComponentes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FernandezPerezNicolas
{
    public partial class Form1 : Form
    {
        private List<sFriki> frikis = new List<sFriki>();
        private List<string> rutas = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            for (int i = listBox1.SelectedIndices.Count - 1; i >= 0; i--)
            {
                frikis.RemoveAt(listBox1.SelectedIndices[i]);
                rutas.RemoveAt(listBox1.SelectedIndices[i]);
                listBox1.Items.RemoveAt(listBox1.SelectedIndices[i]);
                pb.Image = null;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Nuevo nuevo = new Nuevo();
            if (nuevo.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    frikis.Add(new sFriki(nuevo.txtNombre.Texto.Trim(), int.Parse(nuevo.txtEdad.Texto.Trim())
                        , (sFriki.eAficion)nuevo.cbAficion.SelectedItem, nuevo.rbSexoHombre.Checked ?
                        sFriki.eSexo.Hombre : sFriki.eSexo.Mujer, nuevo.rbOrientacionHombre.Checked ? sFriki.eSexo.Hombre : sFriki.eSexo.Mujer, nuevo.txtRuta.Text));
                    listBox1.Items.Add(nuevo.txtNombre.Texto.Trim());
                    rutas.Add(nuevo.txtRuta.Text.Trim());
                }
                catch (NullReferenceException ex)
                {
                    MessageBox.Show("Error al guardar al Friki\r\nPor favor inténtelo de nuevo", "Fallo",
                       MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Error al guardar al Friki\r\nPor favor inténtelo de nuevo", "Fallo",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndices.Count >= 1)
            {
                pb.Image = new Bitmap(rutas[listBox1.SelectedIndices[0]]);
            }
        }

        private void pb_MouseHover(object sender, EventArgs e)
        {
            if (pb.Image != null)
            {
                int indice = listBox1.SelectedIndex;
                string texto = $"{frikis[indice].Nombre} {frikis[indice].Edad} {frikis[indice].AficionPrincipal}";

                toolTip1.SetToolTip(pb, texto);
                toolTip1.Show(texto,pb,10000);
            }
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{Text} Guillermo Bastos");
        }
    }
}
