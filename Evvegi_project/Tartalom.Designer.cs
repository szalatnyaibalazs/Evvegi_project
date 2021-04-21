namespace Evvegi_project
{
    partial class Tartalom
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
            this.btnVissza = new System.Windows.Forms.Button();
            this.pb24 = new System.Windows.Forms.PictureBox();
            this.lblCim = new System.Windows.Forms.Label();
            this.tbTartalom = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb24)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVissza
            // 
            this.btnVissza.Location = new System.Drawing.Point(369, 495);
            this.btnVissza.Name = "btnVissza";
            this.btnVissza.Size = new System.Drawing.Size(75, 23);
            this.btnVissza.TabIndex = 0;
            this.btnVissza.Text = "Vissza";
            this.btnVissza.UseVisualStyleBackColor = true;
            this.btnVissza.Click += new System.EventHandler(this.btnVissza_Click);
            // 
            // pb24
            // 
            this.pb24.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pb24.Image = global::Evvegi_project.Properties.Resources._24;
            this.pb24.Location = new System.Drawing.Point(295, 184);
            this.pb24.Name = "pb24";
            this.pb24.Size = new System.Drawing.Size(223, 305);
            this.pb24.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb24.TabIndex = 1;
            this.pb24.TabStop = false;
            // 
            // lblCim
            // 
            this.lblCim.AutoSize = true;
            this.lblCim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCim.Location = new System.Drawing.Point(21, 9);
            this.lblCim.Name = "lblCim";
            this.lblCim.Size = new System.Drawing.Size(75, 20);
            this.lblCim.TabIndex = 3;
            this.lblCim.Text = "Tartalom:";
            // 
            // tbTartalom
            // 
            this.tbTartalom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbTartalom.Location = new System.Drawing.Point(12, 26);
            this.tbTartalom.Multiline = true;
            this.tbTartalom.Name = "tbTartalom";
            this.tbTartalom.ReadOnly = true;
            this.tbTartalom.Size = new System.Drawing.Size(776, 152);
            this.tbTartalom.TabIndex = 5;
            // 
            // Tartalom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 530);
            this.Controls.Add(this.lblCim);
            this.Controls.Add(this.btnVissza);
            this.Controls.Add(this.pb24);
            this.Controls.Add(this.tbTartalom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Tartalom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tartalom";
            this.Load += new System.EventHandler(this.Tartalom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb24)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pb24;
        private System.Windows.Forms.Button btnVissza;
        private System.Windows.Forms.Label lblCim;
        private System.Windows.Forms.TextBox tbTartalom;
    }
}