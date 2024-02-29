using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace NuevosComponentes
{
    public partial class ValidateTextBox : UserControl
    {
        [Category("La propiedad cambió")]
        [Description("El texto del TextBox cambió")]
        public event EventHandler TextChange;
        private string texto;
        private bool multilinea;
        public enum eTipo
        {
            Numerico,
            Textual,
        };
        public eTipo tipo;

        public ValidateTextBox()
        {
            InitializeComponent();
            Height = textBox1.Height + 20;
            textBox1.Width = Width - 20;
            tipo = eTipo.Textual;
            Texto = textBox1.Text;
            Multilinea = textBox1.Multiline;
            Refresh();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            Brush b;
            Color color;
            bool error = false;
            if (tipo == eTipo.Numerico)
            {
                if (int.TryParse(Texto.Trim(), out _))
                {
                    color = Color.Green;
                }
                else
                {
                    color = Color.Red;
                }
            }
            else
            {
                for (int i = 0; i < Texto.Length; i++)
                {
                    if (int.TryParse(Texto[i].ToString(), out _))
                    {
                        error = true;
                        i = Texto.Length;
                    }
                }
                if (error)
                {
                    color = Color.Red;
                }
                else
                {
                    color = Color.Green;
                }
            }
            b = new SolidBrush(color);
            g.DrawRectangle(new Pen(b, 10), 5, 5, Width - 10, Height - 10);
        }

        protected virtual void onTextChange(EventArgs e)
        {
            TextChange?.Invoke(this, e);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Texto = textBox1.Text;
        }

        private void textBox1_MultilineChanged(object sender, EventArgs e)
        {
            Multilinea = textBox1.Multiline;
        }

        public string Texto
        {
            set
            {
                texto = value;
                Refresh();
            }
            get { return texto; }
        }

        public bool Multilinea
        {
            set
            {
                multilinea = value;
            }
            get { return multilinea; }
        }

        private void ValidateTextBox_Resize(object sender, EventArgs e)
        {
            Height = textBox1.Height + 20;
            textBox1.Width = Width - 20;
        }
    }
}
