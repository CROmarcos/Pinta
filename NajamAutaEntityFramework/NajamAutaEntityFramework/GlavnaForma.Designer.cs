namespace NajamAutaEntityFramework
{
    partial class GlavnaForma
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
            this.btnLokacije = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLokacije
            // 
            this.btnLokacije.Location = new System.Drawing.Point(209, 113);
            this.btnLokacije.Name = "btnLokacije";
            this.btnLokacije.Size = new System.Drawing.Size(81, 41);
            this.btnLokacije.TabIndex = 0;
            this.btnLokacije.Text = "Auto-saloni";
            this.btnLokacije.UseVisualStyleBackColor = true;
            this.btnLokacije.Click += new System.EventHandler(this.btnLokacije_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(603, 319);
            this.Controls.Add(this.btnLokacije);
            this.Name = "Form1";
            this.Text = "Rent-A-Car";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLokacije;
    }
}

