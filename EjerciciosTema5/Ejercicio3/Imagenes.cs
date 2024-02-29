using System.Collections;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using NuevosComponentes;

namespace Ejercicio3
{
    public partial class Imagenes : Form //Inc minutos **, revisar cambios en combio **
    {
        ArrayList imagenes = new ArrayList();
        int cont;
        int aux;
        bool entrar;
        bool primero;
        bool bucle = false;

        public Imagenes()
        {
            InitializeComponent();

            for (int i = 1; i <= 20; i++)
            {
                cbTiempo.Items.Add(i.ToString());
            }
            cbTiempo.SelectedIndex = 0;
            timer.Interval = 1000;
            cont = 1;
            aux = 0;
            primero = true;
            entrar = false;
        }

        private void btnDirectorio_Click(object sender, System.EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.ShowNewFolderButton = false;
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                DirectoryInfo di = new DirectoryInfo(fbd.SelectedPath);
                imagenes.Clear();
                foreach (FileInfo fi in di.GetFiles())
                {
                    if (fi.Extension == ".png" || fi.Extension == ".ico" || fi.Extension == ".jpg" || fi.Extension == ".jpeg")
                    {
                        imagenes.Add(fi.FullName);
                    }
                }
                Text = di.FullName;
            }
            primero = true;
        }

        private void cbTiempo_SelectedValueChanged(object sender, System.EventArgs e)
        {
            cont = int.Parse(cbTiempo.SelectedItem.ToString());
            aux = 0;
        }

        private void timer_Tick(object sender, System.EventArgs e)
        {
            reproductor.Segundos++;

            if (cont == ++aux)
            {
                aux = 0;
                string ruta;
                for (int i = bucle ? 1 : 0; i < imagenes.Count; i++)
                {
                    ruta = imagenes[i].ToString();
                    if (entrar || primero)
                    {
                        primero = false;
                        entrar = false;
                        pictureBox.Image = new Bitmap(ruta);
                        pictureBox.Tag = ruta;
                        i = imagenes.Count;
                    }
                    else if (ruta == pictureBox.Tag.ToString())
                    {
                        entrar = true;
                        bucle = true;
                    }
                    if (entrar)
                    {
                        pictureBox.Image = new Bitmap(imagenes[0].ToString());
                    }
                }
            }
        }

        private void reproductor_Click(object sender, System.EventArgs e)
        {
            if (reproductor.btnPlay.Tag.ToString() == "play" && imagenes.Count > 0)
            {
                timer.Start();
            }
            else
            {
                timer.Stop();
            }
        }

        private void reproductor_DesbordaTiempo(object sender, System.EventArgs e)
        {
            reproductor.Minutos++;
        }
    }
}