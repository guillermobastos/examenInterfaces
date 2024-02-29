namespace Ejercicio3
{
    partial class Imagenes
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Imagenes));
            this.btnDirectorio = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.cbTiempo = new System.Windows.Forms.ComboBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.reproductor = new NuevosComponentes.Reproductor();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDirectorio
            // 
            this.btnDirectorio.AutoSize = true;
            this.btnDirectorio.Location = new System.Drawing.Point(226, 12);
            this.btnDirectorio.Name = "btnDirectorio";
            this.btnDirectorio.Size = new System.Drawing.Size(102, 23);
            this.btnDirectorio.TabIndex = 0;
            this.btnDirectorio.Text = "Escoger directorio";
            this.btnDirectorio.UseVisualStyleBackColor = true;
            this.btnDirectorio.Click += new System.EventHandler(this.btnDirectorio_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(12, 56);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(545, 282);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            this.pictureBox.Tag = "tag";
            // 
            // cbTiempo
            // 
            this.cbTiempo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTiempo.FormattingEnabled = true;
            this.cbTiempo.Location = new System.Drawing.Point(390, 394);
            this.cbTiempo.Name = "cbTiempo";
            this.cbTiempo.Size = new System.Drawing.Size(121, 21);
            this.cbTiempo.TabIndex = 3;
            this.cbTiempo.SelectedValueChanged += new System.EventHandler(this.cbTiempo_SelectedValueChanged);
            // 
            // timer
            // 
            this.timer.Interval = 5000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // reproductor
            // 
            this.reproductor.Location = new System.Drawing.Point(85, 364);
            this.reproductor.Minutos = 0;
            this.reproductor.Name = "reproductor";
            this.reproductor.Segundos = 10;
            this.reproductor.Size = new System.Drawing.Size(228, 79);
            this.reproductor.TabIndex = 2;
            this.reproductor.PlayClick += new System.EventHandler(this.reproductor_Click);
            this.reproductor.DesbordaTiempo += new System.EventHandler(this.reproductor_DesbordaTiempo);
            // 
            // Imagenes
            // 
            this.ClientSize = new System.Drawing.Size(574, 481);
            this.Controls.Add(this.cbTiempo);
            this.Controls.Add(this.reproductor);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.btnDirectorio);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Imagenes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDirectorio;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.ComboBox cbTiempo;
        private System.Windows.Forms.Timer timer;
        private NuevosComponentes.Reproductor reproductor;
    }
}