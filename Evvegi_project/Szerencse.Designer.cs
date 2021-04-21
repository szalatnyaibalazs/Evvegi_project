namespace Evvegi_project
{
    partial class Szerencse
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
            this.tbSzerencse = new System.Windows.Forms.TextBox();
            this.btnVissza = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tbProba = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbSzerencse
            // 
            this.tbSzerencse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbSzerencse.Location = new System.Drawing.Point(12, 12);
            this.tbSzerencse.Multiline = true;
            this.tbSzerencse.Name = "tbSzerencse";
            this.tbSzerencse.ReadOnly = true;
            this.tbSzerencse.Size = new System.Drawing.Size(776, 347);
            this.tbSzerencse.TabIndex = 1;
            // 
            // btnVissza
            // 
            this.btnVissza.Location = new System.Drawing.Point(363, 397);
            this.btnVissza.Name = "btnVissza";
            this.btnVissza.Size = new System.Drawing.Size(75, 23);
            this.btnVissza.TabIndex = 0;
            this.btnVissza.Text = "Vissza";
            this.btnVissza.UseVisualStyleBackColor = true;
            this.btnVissza.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.Location = new System.Drawing.Point(12, 166);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(775, 26);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Tedd Próbára a szerencséd";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbProba
            // 
            this.tbProba.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbProba.Location = new System.Drawing.Point(12, 189);
            this.tbProba.Multiline = true;
            this.tbProba.Name = "tbProba";
            this.tbProba.ReadOnly = true;
            this.tbProba.Size = new System.Drawing.Size(776, 170);
            this.tbProba.TabIndex = 3;
            // 
            // Szerencse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 450);
            this.Controls.Add(this.tbProba);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnVissza);
            this.Controls.Add(this.tbSzerencse);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Szerencse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Szerencse";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbSzerencse;
        private System.Windows.Forms.Button btnVissza;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox tbProba;
    }
}