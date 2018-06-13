namespace ZCups
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
            this.YalovaSube = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BursaSubesi = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // YalovaSube
            // 
            this.YalovaSube.BackColor = System.Drawing.Color.White;
            this.YalovaSube.Font = new System.Drawing.Font("Modern No. 20", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YalovaSube.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.YalovaSube.Location = new System.Drawing.Point(187, 107);
            this.YalovaSube.Name = "YalovaSube";
            this.YalovaSube.Size = new System.Drawing.Size(231, 80);
            this.YalovaSube.TabIndex = 0;
            this.YalovaSube.Text = "Yalova";
            this.YalovaSube.UseVisualStyleBackColor = false;
            this.YalovaSube.Click += new System.EventHandler(this.YalovaSube_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(389, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(384, 123);
            this.label1.TabIndex = 2;
            this.label1.Text = "Z Cups";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // BursaSubesi
            // 
            this.BursaSubesi.BackColor = System.Drawing.Color.White;
            this.BursaSubesi.Font = new System.Drawing.Font("Modern No. 20", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BursaSubesi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BursaSubesi.Location = new System.Drawing.Point(187, 255);
            this.BursaSubesi.Name = "BursaSubesi";
            this.BursaSubesi.Size = new System.Drawing.Size(231, 80);
            this.BursaSubesi.TabIndex = 3;
            this.BursaSubesi.Text = "Bursa";
            this.BursaSubesi.UseVisualStyleBackColor = false;
            this.BursaSubesi.Click += new System.EventHandler(this.BursaSubesi_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.BursaSubesi);
            this.panel1.Controls.Add(this.YalovaSube);
            this.panel1.Location = new System.Drawing.Point(27, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(601, 438);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Maroon;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1184, 127);
            this.panel2.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Maroon;
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Location = new System.Drawing.Point(259, 224);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(650, 493);
            this.panel3.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1182, 808);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button YalovaSube;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BursaSubesi;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}

