namespace ip
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
            this.labelip = new System.Windows.Forms.Label();
            this.labelmac = new System.Windows.Forms.Label();
            this.labeluser = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelip
            // 
            this.labelip.AutoSize = true;
            this.labelip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelip.Location = new System.Drawing.Point(131, 124);
            this.labelip.Name = "labelip";
            this.labelip.Size = new System.Drawing.Size(36, 25);
            this.labelip.TabIndex = 0;
            this.labelip.Text = "IP:";
            // 
            // labelmac
            // 
            this.labelmac.AutoSize = true;
            this.labelmac.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelmac.Location = new System.Drawing.Point(131, 181);
            this.labelmac.Name = "labelmac";
            this.labelmac.Size = new System.Drawing.Size(64, 25);
            this.labelmac.TabIndex = 1;
            this.labelmac.Text = "MAC:";
            // 
            // labeluser
            // 
            this.labeluser.AutoSize = true;
            this.labeluser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labeluser.Location = new System.Drawing.Point(131, 76);
            this.labeluser.Name = "labeluser";
            this.labeluser.Size = new System.Drawing.Size(136, 25);
            this.labeluser.TabIndex = 2;
            this.labeluser.Text = "Bilgisayar Adı:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labeluser);
            this.Controls.Add(this.labelmac);
            this.Controls.Add(this.labelip);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelip;
        private System.Windows.Forms.Label labelmac;
        private System.Windows.Forms.Label labeluser;
    }
}

