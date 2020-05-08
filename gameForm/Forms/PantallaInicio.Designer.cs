namespace Forms
{
    partial class PantallaInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaInicio));
            this.start = new System.Windows.Forms.Button();
            this.formPregunta = new System.Windows.Forms.Label();
            this.botonAbI = new System.Windows.Forms.Button();
            this.botonArI = new System.Windows.Forms.Button();
            this.botonAbD = new System.Windows.Forms.Button();
            this.botonArD = new System.Windows.Forms.Button();
            this.botonCentro = new System.Windows.Forms.Button();
            this.labelVidas = new System.Windows.Forms.Label();
            this.imgCorazon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgCorazon)).BeginInit();
            this.SuspendLayout();
            // 
            // start
            // 
            this.start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.start.Cursor = System.Windows.Forms.Cursors.Hand;
            this.start.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.start.FlatAppearance.BorderSize = 0;
            this.start.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Window;
            this.start.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Window;
            this.start.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.start.Font = new System.Drawing.Font("Berlin Sans FB Demi", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start.Location = new System.Drawing.Point(181, 228);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(366, 144);
            this.start.TabIndex = 0;
            this.start.Text = "Comencemos";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // formPregunta
            // 
            this.formPregunta.Font = new System.Drawing.Font("Berlin Sans FB Demi", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formPregunta.Location = new System.Drawing.Point(13, 9);
            this.formPregunta.Name = "formPregunta";
            this.formPregunta.Size = new System.Drawing.Size(680, 216);
            this.formPregunta.TabIndex = 1;
            this.formPregunta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // botonAbI
            // 
            this.botonAbI.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botonAbI.BackgroundImage")));
            this.botonAbI.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botonAbI.FlatAppearance.BorderSize = 0;
            this.botonAbI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonAbI.Font = new System.Drawing.Font("Berlin Sans FB Demi", 18F);
            this.botonAbI.Location = new System.Drawing.Point(18, 510);
            this.botonAbI.Name = "botonAbI";
            this.botonAbI.Size = new System.Drawing.Size(209, 92);
            this.botonAbI.TabIndex = 2;
            this.botonAbI.UseVisualStyleBackColor = true;
            this.botonAbI.Visible = false;
            this.botonAbI.Click += new System.EventHandler(this.botonAbI_Click);
            // 
            // botonArI
            // 
            this.botonArI.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botonArI.BackgroundImage")));
            this.botonArI.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botonArI.FlatAppearance.BorderSize = 0;
            this.botonArI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonArI.Font = new System.Drawing.Font("Berlin Sans FB Demi", 18F);
            this.botonArI.Location = new System.Drawing.Point(18, 378);
            this.botonArI.Name = "botonArI";
            this.botonArI.Size = new System.Drawing.Size(209, 92);
            this.botonArI.TabIndex = 3;
            this.botonArI.UseVisualStyleBackColor = true;
            this.botonArI.Visible = false;
            this.botonArI.Click += new System.EventHandler(this.botonArI_Click);
            // 
            // botonAbD
            // 
            this.botonAbD.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botonAbD.BackgroundImage")));
            this.botonAbD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botonAbD.FlatAppearance.BorderSize = 0;
            this.botonAbD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonAbD.Font = new System.Drawing.Font("Berlin Sans FB Demi", 18F);
            this.botonAbD.Location = new System.Drawing.Point(484, 510);
            this.botonAbD.Name = "botonAbD";
            this.botonAbD.Size = new System.Drawing.Size(209, 92);
            this.botonAbD.TabIndex = 4;
            this.botonAbD.UseVisualStyleBackColor = true;
            this.botonAbD.Visible = false;
            this.botonAbD.Click += new System.EventHandler(this.botonAbD_Click);
            // 
            // botonArD
            // 
            this.botonArD.AccessibleName = "botonArD";
            this.botonArD.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botonArD.BackgroundImage")));
            this.botonArD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botonArD.FlatAppearance.BorderSize = 0;
            this.botonArD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonArD.Font = new System.Drawing.Font("Berlin Sans FB Demi", 18F);
            this.botonArD.Location = new System.Drawing.Point(484, 378);
            this.botonArD.Name = "botonArD";
            this.botonArD.Size = new System.Drawing.Size(209, 92);
            this.botonArD.TabIndex = 5;
            this.botonArD.UseVisualStyleBackColor = true;
            this.botonArD.Visible = false;
            this.botonArD.Click += new System.EventHandler(this.botonArD_Click);
            // 
            // botonCentro
            // 
            this.botonCentro.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botonCentro.BackgroundImage")));
            this.botonCentro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botonCentro.FlatAppearance.BorderSize = 0;
            this.botonCentro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonCentro.Font = new System.Drawing.Font("Berlin Sans FB Demi", 18F);
            this.botonCentro.Location = new System.Drawing.Point(250, 445);
            this.botonCentro.Name = "botonCentro";
            this.botonCentro.Size = new System.Drawing.Size(209, 92);
            this.botonCentro.TabIndex = 6;
            this.botonCentro.UseVisualStyleBackColor = true;
            this.botonCentro.Visible = false;
            this.botonCentro.Click += new System.EventHandler(this.botonCentro_Click);
            // 
            // labelVidas
            // 
            this.labelVidas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(1)))), ((int)(((byte)(0)))));
            this.labelVidas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelVidas.Font = new System.Drawing.Font("Berlin Sans FB Demi", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVidas.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelVidas.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelVidas.Location = new System.Drawing.Point(74, 271);
            this.labelVidas.Name = "labelVidas";
            this.labelVidas.Size = new System.Drawing.Size(37, 51);
            this.labelVidas.TabIndex = 7;
            this.labelVidas.Tag = "";
            this.labelVidas.Text = "5";
            this.labelVidas.Visible = false;
            // 
            // imgCorazon
            // 
            this.imgCorazon.Image = ((System.Drawing.Image)(resources.GetObject("imgCorazon.Image")));
            this.imgCorazon.Location = new System.Drawing.Point(48, 252);
            this.imgCorazon.Name = "imgCorazon";
            this.imgCorazon.Size = new System.Drawing.Size(90, 84);
            this.imgCorazon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgCorazon.TabIndex = 8;
            this.imgCorazon.TabStop = false;
            this.imgCorazon.Visible = false;
            // 
            // PantallaInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(705, 612);
            this.Controls.Add(this.imgCorazon);
            this.Controls.Add(this.labelVidas);
            this.Controls.Add(this.botonCentro);
            this.Controls.Add(this.botonArD);
            this.Controls.Add(this.botonAbD);
            this.Controls.Add(this.botonArI);
            this.Controls.Add(this.botonAbI);
            this.Controls.Add(this.formPregunta);
            this.Controls.Add(this.start);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PantallaInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bienvenido";
            ((System.ComponentModel.ISupportInitialize)(this.imgCorazon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Label formPregunta;
        private System.Windows.Forms.Button botonAbI;
        private System.Windows.Forms.Button botonArI;
        private System.Windows.Forms.Button botonAbD;
        private System.Windows.Forms.Button botonArD;
        private System.Windows.Forms.Button botonCentro;
        private System.Windows.Forms.Label labelVidas;
        private System.Windows.Forms.PictureBox imgCorazon;
    }
}

