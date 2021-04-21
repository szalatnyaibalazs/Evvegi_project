namespace Evvegi_project
{
    partial class frmItalok
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnUgyesseg = new System.Windows.Forms.Button();
            this.btnEro = new System.Windows.Forms.Button();
            this.btnLuck = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(175, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Válaszz egy italt (csak egyet vihetsz magaddal)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 86);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "ÜGYESSEG ITALA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 232);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Az ERŐ itala";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 376);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "A SZERENCSE itala";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 106);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(346, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "- kezdő értékre állítja az ÜGYESSÉG pontjaidat";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 252);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(336, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "- kezdeti értékre állítja az ÉLETERŐ pontjaidat";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 396);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(664, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "- kezdeti értékére állítja SZERENCSE pontjaidat és 1 ponttal növeli induló SZEREN" +
    "CSÉDET.";
            // 
            // btnUgyesseg
            // 
            this.btnUgyesseg.Location = new System.Drawing.Point(17, 129);
            this.btnUgyesseg.Name = "btnUgyesseg";
            this.btnUgyesseg.Size = new System.Drawing.Size(217, 34);
            this.btnUgyesseg.TabIndex = 7;
            this.btnUgyesseg.Text = "ÜGYESSÉG ITALA";
            this.btnUgyesseg.UseVisualStyleBackColor = true;
            this.btnUgyesseg.Click += new System.EventHandler(this.btnUgyesseg_Click);
            // 
            // btnEro
            // 
            this.btnEro.Location = new System.Drawing.Point(17, 275);
            this.btnEro.Name = "btnEro";
            this.btnEro.Size = new System.Drawing.Size(217, 34);
            this.btnEro.TabIndex = 8;
            this.btnEro.Text = "ERŐ ITALA";
            this.btnEro.UseVisualStyleBackColor = true;
            this.btnEro.Click += new System.EventHandler(this.btnEro_Click);
            // 
            // btnLuck
            // 
            this.btnLuck.Location = new System.Drawing.Point(17, 423);
            this.btnLuck.Name = "btnLuck";
            this.btnLuck.Size = new System.Drawing.Size(217, 34);
            this.btnLuck.TabIndex = 9;
            this.btnLuck.Text = "SZERENCSE ITALA";
            this.btnLuck.UseVisualStyleBackColor = true;
            this.btnLuck.Click += new System.EventHandler(this.btnLuck_Click);
            // 
            // frmItalok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 469);
            this.Controls.Add(this.btnLuck);
            this.Controls.Add(this.btnEro);
            this.Controls.Add(this.btnUgyesseg);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmItalok";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Italok";
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnUgyesseg;
        private System.Windows.Forms.Button btnEro;
        private System.Windows.Forms.Button btnLuck;
    }
}