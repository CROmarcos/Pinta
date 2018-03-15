namespace NajamAutaEntityFramework
{
    partial class UnosLokacije
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
            System.Windows.Forms.Label gradLabel;
            System.Windows.Forms.Label adresaLabel;
            System.Windows.Forms.Label zupanijaLabel;
            this.lokacijeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gradTextBox = new System.Windows.Forms.TextBox();
            this.adresaTextBox = new System.Windows.Forms.TextBox();
            this.zupanijaTextBox = new System.Windows.Forms.TextBox();
            this.btnSpremi = new System.Windows.Forms.Button();
            gradLabel = new System.Windows.Forms.Label();
            adresaLabel = new System.Windows.Forms.Label();
            zupanijaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lokacijeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gradLabel
            // 
            gradLabel.AutoSize = true;
            gradLabel.Location = new System.Drawing.Point(24, 49);
            gradLabel.Name = "gradLabel";
            gradLabel.Size = new System.Drawing.Size(33, 13);
            gradLabel.TabIndex = 1;
            gradLabel.Text = "Grad:";
            // 
            // adresaLabel
            // 
            adresaLabel.AutoSize = true;
            adresaLabel.Location = new System.Drawing.Point(24, 77);
            adresaLabel.Name = "adresaLabel";
            adresaLabel.Size = new System.Drawing.Size(43, 13);
            adresaLabel.TabIndex = 3;
            adresaLabel.Text = "Adresa:";
            // 
            // zupanijaLabel
            // 
            zupanijaLabel.AutoSize = true;
            zupanijaLabel.Location = new System.Drawing.Point(24, 23);
            zupanijaLabel.Name = "zupanijaLabel";
            zupanijaLabel.Size = new System.Drawing.Size(51, 13);
            zupanijaLabel.TabIndex = 5;
            zupanijaLabel.Text = "Zupanija:";
            // 
            // lokacijeBindingSource
            // 
            this.lokacijeBindingSource.DataSource = typeof(NajamAutaEntityFramework.Lokacije);
            // 
            // gradTextBox
            // 
            this.gradTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lokacijeBindingSource, "Grad", true));
            this.gradTextBox.Location = new System.Drawing.Point(81, 46);
            this.gradTextBox.Name = "gradTextBox";
            this.gradTextBox.Size = new System.Drawing.Size(100, 20);
            this.gradTextBox.TabIndex = 2;
            // 
            // adresaTextBox
            // 
            this.adresaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lokacijeBindingSource, "Adresa", true));
            this.adresaTextBox.Location = new System.Drawing.Point(81, 74);
            this.adresaTextBox.Name = "adresaTextBox";
            this.adresaTextBox.Size = new System.Drawing.Size(100, 20);
            this.adresaTextBox.TabIndex = 3;
            // 
            // zupanijaTextBox
            // 
            this.zupanijaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lokacijeBindingSource, "Zupanija", true));
            this.zupanijaTextBox.Location = new System.Drawing.Point(81, 20);
            this.zupanijaTextBox.Name = "zupanijaTextBox";
            this.zupanijaTextBox.Size = new System.Drawing.Size(100, 20);
            this.zupanijaTextBox.TabIndex = 1;
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(57, 119);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(95, 35);
            this.btnSpremi.TabIndex = 4;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // UnosLokacije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(208, 169);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(zupanijaLabel);
            this.Controls.Add(this.zupanijaTextBox);
            this.Controls.Add(adresaLabel);
            this.Controls.Add(this.adresaTextBox);
            this.Controls.Add(gradLabel);
            this.Controls.Add(this.gradTextBox);
            this.Name = "UnosLokacije";
            this.Text = "Unos nove lokacije";
            ((System.ComponentModel.ISupportInitialize)(this.lokacijeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource lokacijeBindingSource;
        private System.Windows.Forms.TextBox gradTextBox;
        private System.Windows.Forms.TextBox adresaTextBox;
        private System.Windows.Forms.TextBox zupanijaTextBox;
        private System.Windows.Forms.Button btnSpremi;
    }
}