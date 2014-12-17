namespace Otel
{
    partial class MusteriAra
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
            this.button1 = new System.Windows.Forms.Button();
            this.tcsorgu = new System.Windows.Forms.TextBox();
            this.Liste = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(393, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "Ara";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tcsorgu
            // 
            this.tcsorgu.Location = new System.Drawing.Point(12, 56);
            this.tcsorgu.Multiline = true;
            this.tcsorgu.Name = "tcsorgu";
            this.tcsorgu.Size = new System.Drawing.Size(311, 32);
            this.tcsorgu.TabIndex = 1;
            // 
            // Liste
            // 
            this.Liste.Location = new System.Drawing.Point(12, 94);
            this.Liste.Name = "Liste";
            this.Liste.Size = new System.Drawing.Size(560, 235);
            this.Liste.TabIndex = 2;
            this.Liste.UseCompatibleStateImageBehavior = false;
            // 
            // MusteriAra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(584, 422);
            this.Controls.Add(this.Liste);
            this.Controls.Add(this.tcsorgu);
            this.Controls.Add(this.button1);
            this.Name = "MusteriAra";
            this.Text = "MusteriAra";
            this.Load += new System.EventHandler(this.MusteriAra_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tcsorgu;
        private System.Windows.Forms.ListView Liste;
    }
}