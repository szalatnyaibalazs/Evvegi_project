namespace Evvegi_project
{
    partial class Menekules
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
            this.tbMenekules = new System.Windows.Forms.TextBox();
            this.btnVissza = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbMenekules
            // 
            this.tbMenekules.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbMenekules.Location = new System.Drawing.Point(12, 12);
            this.tbMenekules.Multiline = true;
            this.tbMenekules.Name = "tbMenekules";
            this.tbMenekules.Size = new System.Drawing.Size(776, 339);
            this.tbMenekules.TabIndex = 2;
            // 
            // btnVissza
            // 
            this.btnVissza.Location = new System.Drawing.Point(345, 391);
            this.btnVissza.Name = "btnVissza";
            this.btnVissza.Size = new System.Drawing.Size(75, 23);
            this.btnVissza.TabIndex = 1;
            this.btnVissza.Text = "Vissza";
            this.btnVissza.UseVisualStyleBackColor = true;
            this.btnVissza.Click += new System.EventHandler(this.btnVissza_Click);
            // 
            // Menekules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVissza);
            this.Controls.Add(this.tbMenekules);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Menekules";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menekules";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbMenekules;
        private System.Windows.Forms.Button btnVissza;
    }
}