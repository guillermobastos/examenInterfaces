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
    public partial class Nuevo : Form
    {
        public Nuevo()
        {
            InitializeComponent();
            cbAficion.Items.Add(sFriki.eAficion.Manga);
            cbAficion.Items.Add(sFriki.eAficion.SciFi);
            cbAficion.Items.Add(sFriki.eAficion.RPG);
            cbAficion.Items.Add(sFriki.eAficion.Fantasia);
            cbAficion.Items.Add(sFriki.eAficion.Terror);
            cbAficion.Items.Add(sFriki.eAficion.Tecnologia);
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Imagenes (.jpg) | *.jpg";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtRuta.Text = ofd.FileName;
            }
        }
    }
}
