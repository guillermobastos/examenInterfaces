using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace NuevosComponentes
{
    public enum EMarca
    {
        Nada,
        Cruz,
        Circulo,
        Imagen,
    }

    public partial class EtiquetaAviso : Control
    {
        [Category("Action")]
        [Description("Se lanza cuando se pulsa en la marca (si existe)")]
        public event EventHandler ClickEnMarca;

        private EMarca marca = EMarca.Nada;
        private Image imagenMarca;
        private Color inicial;
        private Color final;
        private bool gradiente;
        private int offsetX;

        public EtiquetaAviso()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            int grosor = 0;
            int offsetX = 0;
            int offsetY = 0;
            int h = Font.Height;

            Brush b;
            if (Gradiente)
            {
                b = new LinearGradientBrush(new Rectangle(0, 0, Width, Height), Inicial, Final, 90);
                g.DrawRectangle(new Pen(b, Width), new Rectangle(new Point(0, 0), new Size(Width, Height)));
            }
            g.SmoothingMode = SmoothingMode.AntiAlias;

            switch (Marca)
            {
                case EMarca.Circulo:
                    grosor = 20;
                    g.DrawEllipse(new Pen(Color.Green, grosor), grosor, grosor, h, h);
                    offsetX = h + grosor;
                    offsetY = grosor;
                    break;

                case EMarca.Cruz:
                    grosor = 3;
                    Pen lapiz = new Pen(Color.Red, grosor);
                    g.DrawLine(lapiz, grosor, grosor, h, h);
                    g.DrawLine(lapiz, h, grosor, grosor, h);
                    offsetX = h + grosor;
                    offsetY = grosor / 2;
                    lapiz.Dispose();
                    break;

                case EMarca.Imagen:
                    grosor = 5;
                    if (imagenMarca != null)
                    {
                        g.DrawImage(imagenMarca, 0, Height / 4, Font.Height, Font.Height);
                        offsetX = h + grosor;
                        offsetY = Font.Height / 2;
                    }
                    break;
            }

            b = new SolidBrush(ForeColor);
            g.DrawString(Text, Font, b, offsetX + grosor, offsetY);
            b.Dispose();
            Size tam = g.MeasureString(Text, Font).ToSize();
            Size = new Size(tam.Width + offsetX + grosor, tam.Height + offsetY * 2 + 5);
            this.offsetX = offsetX;
        }

        private void EtiquetaAviso_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Location.X < offsetX)
            {
                onClickEnMarca(e);
            }
        }

        protected virtual void onClickEnMarca(EventArgs e)
        {
            ClickEnMarca?.Invoke(this, e);
        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            Refresh();
        }

        [Category("Appearance")]
        [Description("Indica el tipo de marca que aparece junto al texto")]
        public EMarca Marca
        {
            set
            {
                marca = value;
                Refresh();
            }
            get
            {
                return marca;
            }
        }

        [Category("Design")]
        [Description("Coge la imagen que se va a aplicar al lado del texto")]
        public Image ImagenMarca
        {
            set
            {
                imagenMarca = value;
                Refresh();
            }

            get
            {
                return imagenMarca;
            }
        }

        [Category("Appearance")]
        [Description("Crea un fondo con gradiente si está a true")]
        public bool Gradiente
        {
            set
            {
                gradiente = value;
                Refresh();
            }

            get
            {
                return gradiente;
            }
        }

        [Category("Appearance")]
        [Description("Color inicial del gradiente")]
        public Color Inicial
        {
            set
            {
                inicial = value;
                Refresh();
            }

            get
            {
                return inicial;
            }
        }

        [Category("Appearance")]
        [Description("Color final del gradiente")]
        public Color Final
        {
            set
            {
                final = value;
                Refresh();
            }

            get
            {
                return final;
            }
        }
    }
}
// corregido; ojo subrayado labeltextbox