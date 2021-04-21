namespace Evvegi_project
{
    partial class frmOpciok
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
            this.btnTartalom = new System.Windows.Forms.Button();
            this.btnIsmerteto = new System.Windows.Forms.Button();
            this.btnHarc = new System.Windows.Forms.Button();
            this.btnMenekules = new System.Windows.Forms.Button();
            this.btnCsata = new System.Windows.Forms.Button();
            this.btnSzerencse = new System.Windows.Forms.Button();
            this.btnKilepes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTartalom
            // 
            this.btnTartalom.Location = new System.Drawing.Point(12, 12);
            this.btnTartalom.Name = "btnTartalom";
            this.btnTartalom.Size = new System.Drawing.Size(88, 25);
            this.btnTartalom.TabIndex = 0;
            this.btnTartalom.Text = "Tartalom";
            this.btnTartalom.UseVisualStyleBackColor = true;
            this.btnTartalom.Click += new System.EventHandler(this.btnTartalom_Click);
            // 
            // btnIsmerteto
            // 
            this.btnIsmerteto.Location = new System.Drawing.Point(12, 43);
            this.btnIsmerteto.Name = "btnIsmerteto";
            this.btnIsmerteto.Size = new System.Drawing.Size(88, 25);
            this.btnIsmerteto.TabIndex = 1;
            this.btnIsmerteto.Text = "Ismertető";
            this.btnIsmerteto.UseVisualStyleBackColor = true;
            this.btnIsmerteto.Click += new System.EventHandler(this.btnIsmerteto_Click);
            // 
            // btnHarc
            // 
            this.btnHarc.Location = new System.Drawing.Point(12, 74);
            this.btnHarc.Name = "btnHarc";
            this.btnHarc.Size = new System.Drawing.Size(88, 25);
            this.btnHarc.TabIndex = 2;
            this.btnHarc.Text = "Harc";
            this.btnHarc.UseVisualStyleBackColor = true;
            this.btnHarc.Click += new System.EventHandler(this.btnHarc_Click);
            // 
            // btnMenekules
            // 
            this.btnMenekules.Location = new System.Drawing.Point(12, 105);
            this.btnMenekules.Name = "btnMenekules";
            this.btnMenekules.Size = new System.Drawing.Size(88, 25);
            this.btnMenekules.TabIndex = 3;
            this.btnMenekules.Text = "Menekülés";
            this.btnMenekules.UseVisualStyleBackColor = true;
            this.btnMenekules.Click += new System.EventHandler(this.btnMenekules_Click);
            // 
            // btnCsata
            // 
            this.btnCsata.Location = new System.Drawing.Point(12, 136);
            this.btnCsata.Name = "btnCsata";
            this.btnCsata.Size = new System.Drawing.Size(88, 25);
            this.btnCsata.TabIndex = 4;
            this.btnCsata.Text = "Csata";
            this.btnCsata.UseVisualStyleBackColor = true;
            this.btnCsata.Click += new System.EventHandler(this.btnCsata_Click);
            // 
            // btnSzerencse
            // 
            this.btnSzerencse.Location = new System.Drawing.Point(12, 167);
            this.btnSzerencse.Name = "btnSzerencse";
            this.btnSzerencse.Size = new System.Drawing.Size(88, 25);
            this.btnSzerencse.TabIndex = 5;
            this.btnSzerencse.Text = "Szerencse";
            this.btnSzerencse.UseVisualStyleBackColor = true;
            this.btnSzerencse.Click += new System.EventHandler(this.btnSzerencse_Click);
            // 
            // btnKilepes
            // 
            this.btnKilepes.Location = new System.Drawing.Point(12, 198);
            this.btnKilepes.Name = "btnKilepes";
            this.btnKilepes.Size = new System.Drawing.Size(88, 25);
            this.btnKilepes.TabIndex = 6;
            this.btnKilepes.Text = "Kilépés";
            this.btnKilepes.UseVisualStyleBackColor = true;
            this.btnKilepes.Click += new System.EventHandler(this.btnKilepes_Click);
            // 
            // frmOpciok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(120, 239);
            this.Controls.Add(this.btnKilepes);
            this.Controls.Add(this.btnSzerencse);
            this.Controls.Add(this.btnCsata);
            this.Controls.Add(this.btnMenekules);
            this.Controls.Add(this.btnHarc);
            this.Controls.Add(this.btnIsmerteto);
            this.Controls.Add(this.btnTartalom);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmOpciok";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Opciók";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTartalom;
        private System.Windows.Forms.Button btnIsmerteto;
        private System.Windows.Forms.Button btnHarc;
        private System.Windows.Forms.Button btnMenekules;
        private System.Windows.Forms.Button btnCsata;
        private System.Windows.Forms.Button btnSzerencse;
        private System.Windows.Forms.Button btnKilepes;
    }
}