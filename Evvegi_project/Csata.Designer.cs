﻿namespace Evvegi_project
{
    partial class Csata
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
            this.tbCsata = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnVissza = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbCsata
            // 
            this.tbCsata.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbCsata.Location = new System.Drawing.Point(12, 12);
            this.tbCsata.Multiline = true;
            this.tbCsata.Name = "tbCsata";
            this.tbCsata.ReadOnly = true;
            this.tbCsata.Size = new System.Drawing.Size(776, 307);
            this.tbCsata.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btnVissza
            // 
            this.btnVissza.Location = new System.Drawing.Point(363, 369);
            this.btnVissza.Name = "btnVissza";
            this.btnVissza.Size = new System.Drawing.Size(75, 23);
            this.btnVissza.TabIndex = 1;
            this.btnVissza.Text = "Vissza";
            this.btnVissza.UseVisualStyleBackColor = true;
            this.btnVissza.Click += new System.EventHandler(this.btnVissza_Click);
            // 
            // Csata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVissza);
            this.Controls.Add(this.tbCsata);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Csata";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Csata";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbCsata;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnVissza;
    }
}