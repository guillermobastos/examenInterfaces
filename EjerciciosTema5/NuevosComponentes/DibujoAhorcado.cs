using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace NuevosComponentes
{
    public partial class DibujoAhorcado : UserControl
    {
        public DibujoAhorcado()
        {
            InitializeComponent();
        }


        [Category("Action")]
        [Description("La propiedad de errores cambió")]
        public event EventHandler CambiaError;
        protected virtual void onCambiaError(EventArgs e)
        {
            CambiaError?.Invoke(this, e);

            for (int i = 0; i < Controls.Count; i++)
            {
                if (Controls[i].GetType() == typeof(Label))
                {
                    int num = int.Parse(Controls[i].Tag.ToString());
                    if (num <= Errores)
                    {
                        Controls[i].Visible = true;
                    }
                    else
                    {
                        Controls[i].Visible = false;
                    }
                }
            }
        }



        [Category("Action")]
        [Description("El dibujo del ahorcado ha sido completado")]
        public event EventHandler Ahorcado;
        protected virtual void onAhorcado(EventArgs e)
        {
            Ahorcado?.Invoke(this, e);
        }



        private int errores;
        [Category("Action")]
        [Description("Indica los errores cometidos en el ahorcado")]
        public int Errores
        {
            set
            {
                if (errores != value)
                {
                    errores = value;
                    onCambiaError(EventArgs.Empty);

                    if (errores >= 7)
                    {
                        onAhorcado(EventArgs.Empty);
                    }
                }
            }
            get { return errores; }
        }
    }
}
