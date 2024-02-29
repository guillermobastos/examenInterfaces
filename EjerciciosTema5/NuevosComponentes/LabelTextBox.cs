using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace NuevosComponentes
{
    [
    DefaultProperty("TextLbl"),
    DefaultEvent("Load")
    ]
    public partial class LabelTextBox : UserControl
    {
        private EPosicion posicion;
        private int separacion;
        private bool subrayar;

        public LabelTextBox()
        {
            InitializeComponent();
            TextLbl = Name;
            TextTxt = "";
            posicion = EPosicion.IZQUIERDA;
            separacion = 0;
            recolocar();
        }

        public enum EPosicion
        {
            IZQUIERDA, DERECHA
        }

        private void recolocar()
        {
            switch (posicion)
            {
                case EPosicion.IZQUIERDA:
                    lbl.Location = new Point(0, 3);
                    txt.Location = new Point(lbl.Width + Separacion, 0);
                    Height = Math.Max(txt.Height, lbl.Height);
                    break;
                case EPosicion.DERECHA:
                    txt.Location = new Point(0, 0);
                    lbl.Location = new Point(txt.Width + Separacion, 3);
                    Height = Math.Max(txt.Height, lbl.Height);
                    break;
            }
            Width = lbl.Width + txt.Width + Separacion;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (Subrayar)
            {
                e.Graphics.DrawLine(new Pen(Color.Black), lbl.Left, Height - 1, lbl.Left + lbl.Width, Height - 1);
            }
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            recolocar();
        }

        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnKeyPress(e);
        }

        private void txt_KeyUp(object sender, KeyEventArgs e)
        {
            OnKeyUp(e);
        }

        private void txt_TextChanged(object sender, EventArgs e)
        {
            OnTxtChanged(e);
        }

        [Category("La propiedad cambió")]
        [Description("Se lanza cuando la propiedad Posicion cambia")]
        public event EventHandler PosicionChanged;
        protected virtual void OnPosicionChanged(EventArgs e)
        {
            PosicionChanged?.Invoke(this, e);
        }


        [Category("La propiedad cambió")]
        [Description("Se lanza cuando la propiedad Separacion cambia")]
        public event EventHandler SeparacionChanged;
        protected virtual void OnSeparacionChanged(EventArgs e)
        {
            SeparacionChanged?.Invoke(this, e);
        }


        [Category("La propiedad cambió")]
        [Description("Se lanza cuando el TextBox cambia")]
        public event EventHandler TxtChanged;
        protected virtual void OnTxtChanged(EventArgs e)
        {
            TxtChanged?.Invoke(this, e);
        }


        [Category("Appearance")]
        [Description("Indica si la Label se sitúa a la IZQUIERDA o DERECHA del TextBox")]
        public EPosicion Posicion
        {
            set
            {
                if (Enum.IsDefined(typeof(EPosicion), value))
                {
                    posicion = value;
                    recolocar();
                    OnPosicionChanged(EventArgs.Empty);
                }
                else
                {
                    throw new InvalidEnumArgumentException();
                }
            }
            get
            {
                return posicion;
            }
        }

        [Category("Design")]
        [Description("Píxels de separación entre Label y TextBox")]
        public int Separacion
        {
            set
            {
                if (value >= 0)
                {
                    separacion = value;
                    recolocar();
                    OnSeparacionChanged(EventArgs.Empty);
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
            get
            {
                return separacion;
            }
        }

        [Category("Appearance")]
        [Description("Texto asociado a la Label del control")]
        public string TextLbl
        {
            set
            {
                lbl.Text = value;
                recolocar();
            }
            get
            {
                return lbl.Text;
            }
        }

        [Category("Appearance")]
        [Description("Texto asociado al TextBox del control")]
        public string TextTxt
        {
            set
            {
                txt.Text = value;
                OnTxtChanged(EventArgs.Empty);
            }
            get
            {
                return txt.Text;
            }
        }

        [Category("Appearance")]
        [Description("Subraya la label si está a true")]
        public bool Subrayar
        {
            set
            {
                subrayar = value;
                Refresh();
            }

            get
            {
                return subrayar;
            }
        }

        [Category("Appearance")]
        [Description("Cambia el dígito que se muestra cuando la etiqueta es una contraseña")]
        public char PswChr
        {
            set
            {
                txt.PasswordChar = value;

            }

            get
            {
                return txt.PasswordChar;
            }
        }
    }
}
