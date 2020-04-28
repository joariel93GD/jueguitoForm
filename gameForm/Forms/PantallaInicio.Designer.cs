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
            this.start.Location = new System.Drawing.Point(231, 228);
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
            this.formPregunta.Size = new System.Drawing.Size(774, 138);
            this.formPregunta.TabIndex = 1;
            this.formPregunta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // botonAbI
            // 
            this.botonAbI.Location = new System.Drawing.Point(16, 325);
            this.botonAbI.Name = "botonAbI";
            this.botonAbI.Size = new System.Drawing.Size(242, 92);
            this.botonAbI.TabIndex = 2;
            this.botonAbI.Text = "button1";
            this.botonAbI.UseVisualStyleBackColor = true;
            this.botonAbI.Visible = false;
            // 
            // botonArI
            // 
            this.botonArI.Location = new System.Drawing.Point(16, 193);
            this.botonArI.Name = "botonArI";
            this.botonArI.Size = new System.Drawing.Size(242, 92);
            this.botonArI.TabIndex = 3;
            this.botonArI.Text = "button2";
            this.botonArI.UseVisualStyleBackColor = true;
            this.botonArI.Visible = false;
            // 
            // botonAbD
            // 
            this.botonAbD.Location = new System.Drawing.Point(545, 325);
            this.botonAbD.Name = "botonAbD";
            this.botonAbD.Size = new System.Drawing.Size(242, 92);
            this.botonAbD.TabIndex = 4;
            this.botonAbD.Text = "button3";
            this.botonAbD.UseVisualStyleBackColor = true;
            this.botonAbD.Visible = false;
            // 
            // botonArD
            // 
            this.botonArD.AccessibleName = "botonArD";
            this.botonArD.Location = new System.Drawing.Point(545, 193);
            this.botonArD.Name = "botonArD";
            this.botonArD.Size = new System.Drawing.Size(242, 92);
            this.botonArD.TabIndex = 5;
            this.botonArD.Text = "button4";
            this.botonArD.UseVisualStyleBackColor = true;
            this.botonArD.Visible = false;
            // 
            // botonCentro
            // 
            this.botonCentro.Location = new System.Drawing.Point(285, 261);
            this.botonCentro.Name = "botonCentro";
            this.botonCentro.Size = new System.Drawing.Size(242, 92);
            this.botonCentro.TabIndex = 6;
            this.botonCentro.Text = "button5";
            this.botonCentro.UseVisualStyleBackColor = true;
            this.botonCentro.Visible = false;
            // 
            // PantallaInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}

