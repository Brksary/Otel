namespace Otel
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.odalarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriAraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boşOdalarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doluOdalarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriAraToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.odalarToolStripMenuItem,
            this.müşteriAraToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(734, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // odalarToolStripMenuItem
            // 
            this.odalarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.boşOdalarToolStripMenuItem,
            this.doluOdalarToolStripMenuItem});
            this.odalarToolStripMenuItem.Name = "odalarToolStripMenuItem";
            this.odalarToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.odalarToolStripMenuItem.Text = "Odalar";
            // 
            // müşteriAraToolStripMenuItem
            // 
            this.müşteriAraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.müşteriAraToolStripMenuItem1});
            this.müşteriAraToolStripMenuItem.Name = "müşteriAraToolStripMenuItem";
            this.müşteriAraToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.müşteriAraToolStripMenuItem.Text = "Müşteri Ara";
            // 
            // boşOdalarToolStripMenuItem
            // 
            this.boşOdalarToolStripMenuItem.Name = "boşOdalarToolStripMenuItem";
            this.boşOdalarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.boşOdalarToolStripMenuItem.Text = "Boş Odalar";
            this.boşOdalarToolStripMenuItem.Click += new System.EventHandler(this.boşOdalarToolStripMenuItem_Click);
            // 
            // doluOdalarToolStripMenuItem
            // 
            this.doluOdalarToolStripMenuItem.Name = "doluOdalarToolStripMenuItem";
            this.doluOdalarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.doluOdalarToolStripMenuItem.Text = "Dolu Odalar";
            this.doluOdalarToolStripMenuItem.Click += new System.EventHandler(this.doluOdalarToolStripMenuItem_Click);
            // 
            // müşteriAraToolStripMenuItem1
            // 
            this.müşteriAraToolStripMenuItem1.Name = "müşteriAraToolStripMenuItem1";
            this.müşteriAraToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.müşteriAraToolStripMenuItem1.Text = "Müşteri Ara";
            this.müşteriAraToolStripMenuItem1.Click += new System.EventHandler(this.müşteriAraToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(734, 411);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem odalarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem boşOdalarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doluOdalarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşteriAraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşteriAraToolStripMenuItem1;
    }
}

