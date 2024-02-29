using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;

namespace NuevosComponentes
{
    public partial class Reproductor : UserControl  //Aparece la label con asignación incorrecta en segundos **
    {
        [Category("Action")]
        [Description("Se lanza cuando se pulsa el botón de play o pause")]
        public event EventHandler PlayClick;
        [Category("Action")]
        [Description("Se lanza cuando los segundos supere el número 59")]
        public event EventHandler DesbordaTiempo;
        private int MM;
        private int SS;

        public Reproductor()
        {
            InitializeComponent();
            MM = SS = 0;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (btnPlay.Tag.ToString() == "play")
            {
                btnPlay.Image = Properties.Resources.reset;
                btnPlay.Tag = "pause";
            }
            else
            {
                btnPlay.Image = Properties.Resources.play;
                btnPlay.Tag = "play";
            }
            btnPlay.Image = btnPlay.Tag.ToString() == "play" ? Properties.Resources.reset : Properties.Resources.play;
            onPlayClick(e);
        }

        protected virtual void onPlayClick(EventArgs e)
        {
            PlayClick?.Invoke(this, e);
        }

        protected virtual void onDesbordaTiempo(EventArgs e)
        {
            DesbordaTiempo?.Invoke(this, e);
        }

        private void cambiaTiempo()
        {
            lblTiempo.Text = $"{MM:D2} : {SS:D2}";
        }

        public int Segundos
        {
            set
            {
                try
                {
                    if (value < 0)
                    {
                        throw new ArgumentException();
                    }
                    if (value > 59)
                    {
                        value = value % 60;
                        onDesbordaTiempo(EventArgs.Empty);
                    }
                    SS = value;
                    cambiaTiempo();
                }
                catch (ArgumentException)
                {
                    MessageBox.Show("No se aceptan valores negativos en los minutos");
                }
            }

            get
            {
                return SS;
            }
        }

        public int Minutos
        {
            set
            {
                try
                {
                    if (value < 0)
                    {
                        throw new ArgumentException();
                    }
                    if (value > 59)
                    {
                        value = 0;
                    }
                    MM = value;
                    cambiaTiempo();
                }
                catch (ArgumentException)
                {
                    MessageBox.Show("No se aceptan valores negativos en las horas");
                }
            }

            get
            {
                return MM;
            }
        }
    }
}
