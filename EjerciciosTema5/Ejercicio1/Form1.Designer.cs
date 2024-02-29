namespace Ejercicio1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCambiar = new System.Windows.Forms.Button();
            this.btnSepararMenos = new System.Windows.Forms.Button();
            this.btnSepararMas = new System.Windows.Forms.Button();
            this.txtTexto = new System.Windows.Forms.TextBox();
            this.etiquetaAviso1 = new NuevosComponentes.EtiquetaAviso();
            this.labelTextBox1 = new NuevosComponentes.LabelTextBox();
            this.SuspendLayout();
            // 
            // btnCambiar
            // 
            this.btnCambiar.AutoSize = true;
            this.btnCambiar.Location = new System.Drawing.Point(91, 76);
            this.btnCambiar.Name = "btnCambiar";
            this.btnCambiar.Size = new System.Drawing.Size(97, 23);
            this.btnCambiar.TabIndex = 2;
            this.btnCambiar.Text = "Cambiar posición";
            this.btnCambiar.UseVisualStyleBackColor = true;
            this.btnCambiar.Click += new System.EventHandler(this.btnCambiar_Click);
            // 
            // btnSepararMenos
            // 
            this.btnSepararMenos.AutoSize = true;
            this.btnSepararMenos.Location = new System.Drawing.Point(12, 38);
            this.btnSepararMenos.Name = "btnSepararMenos";
            this.btnSepararMenos.Size = new System.Drawing.Size(97, 23);
            this.btnSepararMenos.TabIndex = 4;
            this.btnSepararMenos.Text = "<-- Separacion";
            this.btnSepararMenos.UseVisualStyleBackColor = true;
            this.btnSepararMenos.Click += new System.EventHandler(this.btnSeparar_Click);
            // 
            // btnSepararMas
            // 
            this.btnSepararMas.AutoSize = true;
            this.btnSepararMas.Location = new System.Drawing.Point(175, 38);
            this.btnSepararMas.Name = "btnSepararMas";
            this.btnSepararMas.Size = new System.Drawing.Size(97, 23);
            this.btnSepararMas.TabIndex = 5;
            this.btnSepararMas.Text = "Separación -->";
            this.btnSepararMas.UseVisualStyleBackColor = true;
            this.btnSepararMas.Click += new System.EventHandler(this.btnSeparar_Click);
            // 
            // txtTexto
            // 
            this.txtTexto.Location = new System.Drawing.Point(12, 105);
            this.txtTexto.Multiline = true;
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.ReadOnly = true;
            this.txtTexto.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTexto.Size = new System.Drawing.Size(260, 44);
            this.txtTexto.TabIndex = 6;
            this.txtTexto.TabStop = false;
            // 
            // etiquetaAviso1
            // 
            this.etiquetaAviso1.Final = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.etiquetaAviso1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etiquetaAviso1.Gradiente = true;
            this.etiquetaAviso1.ImagenMarca = null;
            this.etiquetaAviso1.Inicial = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.etiquetaAviso1.Location = new System.Drawing.Point(12, 164);
            this.etiquetaAviso1.Marca = NuevosComponentes.EMarca.Cruz;
            this.etiquetaAviso1.Name = "etiquetaAviso1";
            this.etiquetaAviso1.Size = new System.Drawing.Size(291, 40);
            this.etiquetaAviso1.TabIndex = 7;
            this.etiquetaAviso1.Text = "Texto con gradiente";
            this.etiquetaAviso1.ClickEnMarca += new System.EventHandler(this.etiquetaAviso1_ClickEnMarca);
            // 
            // labelTextBox1
            // 
            this.labelTextBox1.Location = new System.Drawing.Point(67, 11);
            this.labelTextBox1.Name = "labelTextBox1";
            this.labelTextBox1.Posicion = NuevosComponentes.LabelTextBox.EPosicion.IZQUIERDA;
            this.labelTextBox1.PswChr = '●';
            this.labelTextBox1.Separacion = 0;
            this.labelTextBox1.Size = new System.Drawing.Size(172, 21);
            this.labelTextBox1.Subrayar = true;
            this.labelTextBox1.TabIndex = 1;
            this.labelTextBox1.TextLbl = "LabelTextBox";
            this.labelTextBox1.TextTxt = "";
            this.labelTextBox1.PosicionChanged += new System.EventHandler(this.labelTextBox1_PosicionChanged);
            this.labelTextBox1.SeparacionChanged += new System.EventHandler(this.labelTextBox1_SeparacionChanged);
            this.labelTextBox1.TxtChanged += new System.EventHandler(this.labelTextBox1_TxtChanged);
            this.labelTextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.labelTextBox1_KeyPress);
            this.labelTextBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.labelTextBox1_KeyUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 217);
            this.Controls.Add(this.etiquetaAviso1);
            this.Controls.Add(this.txtTexto);
            this.Controls.Add(this.btnSepararMas);
            this.Controls.Add(this.btnSepararMenos);
            this.Controls.Add(this.labelTextBox1);
            this.Controls.Add(this.btnCambiar);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCambiar;
        private System.Windows.Forms.Button btnSepararMenos;
        private System.Windows.Forms.Button btnSepararMas;
        private System.Windows.Forms.TextBox txtTexto;
        private NuevosComponentes.EtiquetaAviso etiquetaAviso1;
        private NuevosComponentes.LabelTextBox labelTextBox1;
    }
}

