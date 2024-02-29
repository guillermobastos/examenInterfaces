using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NuevosComponentes
{
    public partial class ValidateTextBox : UserControl
    {

        private eTipo tipo;

        public ValidateTextBox()
        {
            InitializeComponent();
            Height = txt.Height + 20;
            txt.Width = Width - 20;
        }

        public enum eTipo
        {
            Numerico, Textual
        }

        [Category("Apariencia")]
        [Description("Texto del TextBox del componente")]
        public string Texto
        {
            set
            {
                txt.Text = value;
                Refresh();
            }

            get
            {
                return txt.Text;
            }
        }

        [Category("Comportamiento")]
        [Description("Cambia la propiedad Multilinea del TextBox")]
        public bool Multilinea
        {
            set
            {
                txt.Multiline = value;
            }

            get
            {
                return txt.Multiline;
            }
        }

        [Category("Apariencia")]
        [Description("Si es Númerico, el Texto del TextBox solo acepta dígitos.\nSi es Textual, solo admitirá letras o espacios")]
        public eTipo Tipo
        {
            set
            {
                tipo = value;
                Refresh();
            }

            get
            {
                return tipo;
            }
        }


        [Category("La propiedad cambió")]
        [Description("Se lanza cuando cambie el texto del TextBox")]
        public event EventHandler CambiaTexto;

        protected virtual void OnCambiaTexto(EventArgs e)
        {
            CambiaTexto?.Invoke(this, e);
            Refresh();
        }
        private void txt_TextChanged(object sender, EventArgs e)
        {
            OnCambiaTexto(e);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            Pen pen;

            if (comprobar())
            {
                pen = new Pen(Color.Green);
            }
            else
            {
                pen = new Pen(Color.Red);
            }

            g.DrawRectangle(pen, 5, 5, Width - 10, Height - 10);
        }

        private bool comprobar()
        {
            bool numerico = Tipo == eTipo.Numerico ? true : false;
            foreach (char c in txt.Text.Trim())
            {
                if (numerico ? (char.IsLetter(c) || c == ' ') : (!char.IsLetter(c) && c != ' '))
                {
                    return false;
                }
            }
            return true;
        }

       
    }
}
