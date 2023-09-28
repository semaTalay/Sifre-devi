namespace SifreÖdevi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtSifre = new TextBox();
            lblDerece = new Label();
            SuspendLayout();
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(41, 48);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(186, 23);
            txtSifre.TabIndex = 0;
            txtSifre.TextChanged += txtSifre_TextChanged;
            // 
            // lblDerece
            // 
            lblDerece.AutoSize = true;
            lblDerece.Location = new Point(45, 92);
            lblDerece.Name = "lblDerece";
            lblDerece.Size = new Size(0, 15);
            lblDerece.TabIndex = 1;
            lblDerece.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(392, 339);
            Controls.Add(lblDerece);
            Controls.Add(txtSifre);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSifre;
        private Label lblDerece;
    }
}