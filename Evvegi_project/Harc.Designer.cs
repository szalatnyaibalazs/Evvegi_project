namespace Evvegi_project
{
    partial class Harc
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
            this.tbHarcmenete = new System.Windows.Forms.TextBox();
            this.lbFelsorolas = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnVissza
            // 
            this.btnVissza.Location = new System.Drawing.Point(426, 481);
            this.btnVissza.Name = "btnVissza";
            this.btnVissza.Size = new System.Drawing.Size(75, 23);
            this.btnVissza.TabIndex = 1;
            this.btnVissza.Text = "Vissza";
            this.btnVissza.UseVisualStyleBackColor = true;
            this.btnVissza.Click += new System.EventHandler(this.btnVissza_Click);
            // 
            // tbHarcmenete
            // 
            this.tbHarcmenete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbHarcmenete.Location = new System.Drawing.Point(12, 12);
            this.tbHarcmenete.Multiline = true;
            this.tbHarcmenete.Name = "tbHarcmenete";
            this.tbHarcmenete.ReadOnly = true;
            this.tbHarcmenete.Size = new System.Drawing.Size(906, 421);
            this.tbHarcmenete.TabIndex = 2;
            // 
            // lbFelsorolas
            // 
            this.lbFelsorolas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbFelsorolas.FormattingEnabled = true;
            this.lbFelsorolas.ItemHeight = 16;
            this.lbFelsorolas.Location = new System.Drawing.Point(12, 189);
            this.lbFelsorolas.Name = "lbFelsorolas";
            this.lbFelsorolas.Size = new System.Drawing.Size(906, 244);
            this.lbFelsorolas.TabIndex = 3;
            // 
            // Harc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 540);
            this.Controls.Add(this.lbFelsorolas);
            this.Controls.Add(this.tbHarcmenete);
            this.Controls.Add(this.btnVissza);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Harc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Harc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnVissza;
        private System.Windows.Forms.TextBox tbHarcmenete;
        private System.Windows.Forms.ListBox lbFelsorolas;
    }
}