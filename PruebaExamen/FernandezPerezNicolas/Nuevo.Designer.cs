namespace FernandezPerezNicolas
{
    partial class Nuevo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNombre = new NuevosComponentes.ValidateTextBox();
            this.txtEdad = new NuevosComponentes.ValidateTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbSexo = new System.Windows.Forms.GroupBox();
            this.rbSexoMujer = new System.Windows.Forms.RadioButton();
            this.rbSexoHombre = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.cbAficion = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.gbOrientacion = new System.Windows.Forms.GroupBox();
            this.rbOrientacionMujer = new System.Windows.Forms.RadioButton();
            this.rbOrientacionHombre = new System.Windows.Forms.RadioButton();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.txtRuta = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gbSexo.SuspendLayout();
            this.gbOrientacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(130, 12);
            this.txtNombre.Multilinea = false;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(150, 40);
            this.txtNombre.TabIndex = 0;
            this.txtNombre.Texto = "";
            this.txtNombre.Tipo = NuevosComponentes.ValidateTextBox.eTipo.Textual;
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(130, 58);
            this.txtEdad.Multilinea = false;
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(150, 40);
            this.txtEdad.TabIndex = 1;
            this.txtEdad.Texto = "";
            this.txtEdad.Tipo = NuevosComponentes.ValidateTextBox.eTipo.Numerico;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Edad:";
            // 
            // gbSexo
            // 
            this.gbSexo.AutoSize = true;
            this.gbSexo.Controls.Add(this.rbSexoMujer);
            this.gbSexo.Controls.Add(this.rbSexoHombre);
            this.gbSexo.Location = new System.Drawing.Point(130, 131);
            this.gbSexo.Name = "gbSexo";
            this.gbSexo.Size = new System.Drawing.Size(127, 55);
            this.gbSexo.TabIndex = 3;
            this.gbSexo.TabStop = false;
            // 
            // rbSexoMujer
            // 
            this.rbSexoMujer.AutoSize = true;
            this.rbSexoMujer.Location = new System.Drawing.Point(70, 19);
            this.rbSexoMujer.Name = "rbSexoMujer";
            this.rbSexoMujer.Size = new System.Drawing.Size(51, 17);
            this.rbSexoMujer.TabIndex = 1;
            this.rbSexoMujer.Tag = "Mujer";
            this.rbSexoMujer.Text = "Mujer";
            this.rbSexoMujer.UseVisualStyleBackColor = true;
            // 
            // rbSexoHombre
            // 
            this.rbSexoHombre.AutoSize = true;
            this.rbSexoHombre.Checked = true;
            this.rbSexoHombre.Location = new System.Drawing.Point(6, 19);
            this.rbSexoHombre.Name = "rbSexoHombre";
            this.rbSexoHombre.Size = new System.Drawing.Size(62, 17);
            this.rbSexoHombre.TabIndex = 0;
            this.rbSexoHombre.TabStop = true;
            this.rbSexoHombre.Tag = "Hombre";
            this.rbSexoHombre.Text = "Hombre";
            this.rbSexoHombre.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Aficion:";
            // 
            // cbAficion
            // 
            this.cbAficion.BackColor = System.Drawing.SystemColors.Window;
            this.cbAficion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAficion.FormattingEnabled = true;
            this.cbAficion.Location = new System.Drawing.Point(145, 104);
            this.cbAficion.Name = "cbAficion";
            this.cbAficion.Size = new System.Drawing.Size(121, 21);
            this.cbAficion.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Sexo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Orientación sexual:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(78, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Foto:";
            // 
            // gbOrientacion
            // 
            this.gbOrientacion.AutoSize = true;
            this.gbOrientacion.Controls.Add(this.rbOrientacionMujer);
            this.gbOrientacion.Controls.Add(this.rbOrientacionHombre);
            this.gbOrientacion.Location = new System.Drawing.Point(130, 192);
            this.gbOrientacion.Name = "gbOrientacion";
            this.gbOrientacion.Size = new System.Drawing.Size(127, 55);
            this.gbOrientacion.TabIndex = 4;
            this.gbOrientacion.TabStop = false;
            // 
            // rbOrientacionMujer
            // 
            this.rbOrientacionMujer.AutoSize = true;
            this.rbOrientacionMujer.Location = new System.Drawing.Point(70, 19);
            this.rbOrientacionMujer.Name = "rbOrientacionMujer";
            this.rbOrientacionMujer.Size = new System.Drawing.Size(51, 17);
            this.rbOrientacionMujer.TabIndex = 1;
            this.rbOrientacionMujer.Tag = "Mujer";
            this.rbOrientacionMujer.Text = "Mujer";
            this.rbOrientacionMujer.UseVisualStyleBackColor = true;
            // 
            // rbOrientacionHombre
            // 
            this.rbOrientacionHombre.AutoSize = true;
            this.rbOrientacionHombre.Checked = true;
            this.rbOrientacionHombre.Location = new System.Drawing.Point(6, 19);
            this.rbOrientacionHombre.Name = "rbOrientacionHombre";
            this.rbOrientacionHombre.Size = new System.Drawing.Size(62, 17);
            this.rbOrientacionHombre.TabIndex = 0;
            this.rbOrientacionHombre.TabStop = true;
            this.rbOrientacionHombre.Tag = "Hombre";
            this.rbOrientacionHombre.Text = "Hombre";
            this.rbOrientacionHombre.UseVisualStyleBackColor = true;
            // 
            // btnAbrir
            // 
            this.btnAbrir.AutoSize = true;
            this.btnAbrir.Location = new System.Drawing.Point(286, 252);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(75, 23);
            this.btnAbrir.TabIndex = 6;
            this.btnAbrir.Text = "Abrir";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // txtRuta
            // 
            this.txtRuta.Location = new System.Drawing.Point(130, 253);
            this.txtRuta.Name = "txtRuta";
            this.txtRuta.Size = new System.Drawing.Size(150, 20);
            this.txtRuta.TabIndex = 5;
            // 
            // btnAceptar
            // 
            this.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAceptar.Location = new System.Drawing.Point(12, 318);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 7;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(286, 318);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // Nuevo
            // 
            this.AcceptButton = this.btnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(373, 353);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtRuta);
            this.Controls.Add(this.btnAbrir);
            this.Controls.Add(this.gbOrientacion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbAficion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gbSexo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.txtNombre);
            this.Name = "Nuevo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nuevo";
            this.gbSexo.ResumeLayout(false);
            this.gbSexo.PerformLayout();
            this.gbOrientacion.ResumeLayout(false);
            this.gbOrientacion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        public NuevosComponentes.ValidateTextBox txtNombre;
        public NuevosComponentes.ValidateTextBox txtEdad;
        public System.Windows.Forms.ComboBox cbAficion;
        public System.Windows.Forms.TextBox txtRuta;
        private System.Windows.Forms.GroupBox gbOrientacion;
        private System.Windows.Forms.GroupBox gbSexo;
        public System.Windows.Forms.RadioButton rbSexoHombre;
        public System.Windows.Forms.RadioButton rbSexoMujer;
        public System.Windows.Forms.RadioButton rbOrientacionHombre;
        public System.Windows.Forms.RadioButton rbOrientacionMujer;
    }
}