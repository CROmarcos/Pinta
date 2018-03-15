namespace NajamAutaEntityFramework
{
    partial class UnosAuta
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbMarka = new System.Windows.Forms.TextBox();
            this.tbModel = new System.Windows.Forms.TextBox();
            this.tbRegistracija = new System.Windows.Forms.TextBox();
            this.cbGodiste = new System.Windows.Forms.ComboBox();
            this.cbGorivo = new System.Windows.Forms.ComboBox();
            this.rbDa = new System.Windows.Forms.RadioButton();
            this.rbNe = new System.Windows.Forms.RadioButton();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cbLokacija = new System.Windows.Forms.ComboBox();
            this.lokacijeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lokacijeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.lokacijeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lokacijeBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Marka:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Model:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Godina proizvodnje:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Gorivo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Registracija";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(28, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(218, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Posjeduje li automobil kuku za vuču?";
            // 
            // tbMarka
            // 
            this.tbMarka.Location = new System.Drawing.Point(154, 23);
            this.tbMarka.Name = "tbMarka";
            this.tbMarka.Size = new System.Drawing.Size(100, 20);
            this.tbMarka.TabIndex = 6;
            // 
            // tbModel
            // 
            this.tbModel.Location = new System.Drawing.Point(154, 49);
            this.tbModel.Name = "tbModel";
            this.tbModel.Size = new System.Drawing.Size(100, 20);
            this.tbModel.TabIndex = 7;
            // 
            // tbRegistracija
            // 
            this.tbRegistracija.Location = new System.Drawing.Point(154, 129);
            this.tbRegistracija.Name = "tbRegistracija";
            this.tbRegistracija.Size = new System.Drawing.Size(100, 20);
            this.tbRegistracija.TabIndex = 8;
            // 
            // cbGodiste
            // 
            this.cbGodiste.FormattingEnabled = true;
            this.cbGodiste.Location = new System.Drawing.Point(154, 75);
            this.cbGodiste.Name = "cbGodiste";
            this.cbGodiste.Size = new System.Drawing.Size(100, 21);
            this.cbGodiste.TabIndex = 9;
            // 
            // cbGorivo
            // 
            this.cbGorivo.FormattingEnabled = true;
            this.cbGorivo.Items.AddRange(new object[] {
            "benzin",
            "benzin+plin",
            "dizel",
            "hybrid"});
            this.cbGorivo.Location = new System.Drawing.Point(154, 102);
            this.cbGorivo.Name = "cbGorivo";
            this.cbGorivo.Size = new System.Drawing.Size(100, 21);
            this.cbGorivo.TabIndex = 10;
            // 
            // rbDa
            // 
            this.rbDa.AutoSize = true;
            this.rbDa.Location = new System.Drawing.Point(82, 202);
            this.rbDa.Name = "rbDa";
            this.rbDa.Size = new System.Drawing.Size(40, 17);
            this.rbDa.TabIndex = 11;
            this.rbDa.TabStop = true;
            this.rbDa.Text = "DA";
            this.rbDa.UseVisualStyleBackColor = true;
            // 
            // rbNe
            // 
            this.rbNe.AutoSize = true;
            this.rbNe.Location = new System.Drawing.Point(154, 202);
            this.rbNe.Name = "rbNe";
            this.rbNe.Size = new System.Drawing.Size(40, 17);
            this.rbNe.TabIndex = 12;
            this.rbNe.TabStop = true;
            this.rbNe.Text = "NE";
            this.rbNe.UseVisualStyleBackColor = true;
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(33, 233);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(88, 33);
            this.btnSpremi.TabIndex = 13;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(158, 233);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(88, 33);
            this.btnOdustani.TabIndex = 14;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(28, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Lokacija:";
            // 
            // cbLokacija
            // 
            this.cbLokacija.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.lokacijeBindingSource, "IdLokacije", true));
            this.cbLokacija.DataSource = this.lokacijeBindingSource1;
            this.cbLokacija.DisplayMember = "Grad";
            this.cbLokacija.FormattingEnabled = true;
            this.cbLokacija.Location = new System.Drawing.Point(154, 156);
            this.cbLokacija.Name = "cbLokacija";
            this.cbLokacija.Size = new System.Drawing.Size(100, 21);
            this.cbLokacija.TabIndex = 16;
            this.cbLokacija.ValueMember = "IdLokacije";
            // 
            // lokacijeBindingSource
            // 
            this.lokacijeBindingSource.DataSource = typeof(NajamAutaEntityFramework.Lokacije);
            // 
            // lokacijeBindingSource1
            // 
            this.lokacijeBindingSource1.DataSource = typeof(NajamAutaEntityFramework.Lokacije);
            // 
            // UnosAuta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 283);
            this.Controls.Add(this.cbLokacija);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.rbNe);
            this.Controls.Add(this.rbDa);
            this.Controls.Add(this.cbGorivo);
            this.Controls.Add(this.cbGodiste);
            this.Controls.Add(this.tbRegistracija);
            this.Controls.Add(this.tbModel);
            this.Controls.Add(this.tbMarka);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UnosAuta";
            this.Text = "UnosAuta";
            this.Load += new System.EventHandler(this.UnosAuta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lokacijeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lokacijeBindingSource1)).EndInit();
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
        private System.Windows.Forms.TextBox tbMarka;
        private System.Windows.Forms.TextBox tbModel;
        private System.Windows.Forms.TextBox tbRegistracija;
        private System.Windows.Forms.ComboBox cbGodiste;
        private System.Windows.Forms.ComboBox cbGorivo;
        private System.Windows.Forms.RadioButton rbDa;
        private System.Windows.Forms.RadioButton rbNe;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbLokacija;
        private System.Windows.Forms.BindingSource lokacijeBindingSource;
        private System.Windows.Forms.BindingSource lokacijeBindingSource1;
    }
}