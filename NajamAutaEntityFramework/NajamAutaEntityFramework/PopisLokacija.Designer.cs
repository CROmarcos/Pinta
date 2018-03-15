namespace NajamAutaEntityFramework
{
    partial class PopisLokacija
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
            this.dgvLokacije = new System.Windows.Forms.DataGridView();
            this.idLokacijeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zupanijaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vozilaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lokacijeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvVozila = new System.Windows.Forms.DataGridView();
            this.idVozilaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.markaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.godisteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gorivoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registracijaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kukaDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lokacijaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lokacijeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rezervacijeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vozilaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnNoviAuto = new System.Windows.Forms.Button();
            this.btnNovaLokacija = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLokacije)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lokacijeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVozila)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vozilaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLokacije
            // 
            this.dgvLokacije.AllowUserToAddRows = false;
            this.dgvLokacije.AllowUserToDeleteRows = false;
            this.dgvLokacije.AutoGenerateColumns = false;
            this.dgvLokacije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLokacije.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idLokacijeDataGridViewTextBoxColumn,
            this.zupanijaDataGridViewTextBoxColumn,
            this.gradDataGridViewTextBoxColumn,
            this.adresaDataGridViewTextBoxColumn,
            this.vozilaDataGridViewTextBoxColumn});
            this.dgvLokacije.DataSource = this.lokacijeBindingSource;
            this.dgvLokacije.Location = new System.Drawing.Point(13, 13);
            this.dgvLokacije.Name = "dgvLokacije";
            this.dgvLokacije.ReadOnly = true;
            this.dgvLokacije.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLokacije.Size = new System.Drawing.Size(475, 156);
            this.dgvLokacije.TabIndex = 0;
            this.dgvLokacije.SelectionChanged += new System.EventHandler(this.dgvLokacije_SelectionChanged);
            // 
            // idLokacijeDataGridViewTextBoxColumn
            // 
            this.idLokacijeDataGridViewTextBoxColumn.DataPropertyName = "IdLokacije";
            this.idLokacijeDataGridViewTextBoxColumn.HeaderText = "#";
            this.idLokacijeDataGridViewTextBoxColumn.Name = "idLokacijeDataGridViewTextBoxColumn";
            this.idLokacijeDataGridViewTextBoxColumn.ReadOnly = true;
            this.idLokacijeDataGridViewTextBoxColumn.Visible = false;
            this.idLokacijeDataGridViewTextBoxColumn.Width = 25;
            // 
            // zupanijaDataGridViewTextBoxColumn
            // 
            this.zupanijaDataGridViewTextBoxColumn.DataPropertyName = "Zupanija";
            this.zupanijaDataGridViewTextBoxColumn.HeaderText = "Županija";
            this.zupanijaDataGridViewTextBoxColumn.Name = "zupanijaDataGridViewTextBoxColumn";
            this.zupanijaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gradDataGridViewTextBoxColumn
            // 
            this.gradDataGridViewTextBoxColumn.DataPropertyName = "Grad";
            this.gradDataGridViewTextBoxColumn.HeaderText = "Grad";
            this.gradDataGridViewTextBoxColumn.Name = "gradDataGridViewTextBoxColumn";
            this.gradDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adresaDataGridViewTextBoxColumn
            // 
            this.adresaDataGridViewTextBoxColumn.DataPropertyName = "Adresa";
            this.adresaDataGridViewTextBoxColumn.HeaderText = "Adresa";
            this.adresaDataGridViewTextBoxColumn.Name = "adresaDataGridViewTextBoxColumn";
            this.adresaDataGridViewTextBoxColumn.ReadOnly = true;
            this.adresaDataGridViewTextBoxColumn.Width = 230;
            // 
            // vozilaDataGridViewTextBoxColumn
            // 
            this.vozilaDataGridViewTextBoxColumn.DataPropertyName = "Vozila";
            this.vozilaDataGridViewTextBoxColumn.HeaderText = "Vozila";
            this.vozilaDataGridViewTextBoxColumn.Name = "vozilaDataGridViewTextBoxColumn";
            this.vozilaDataGridViewTextBoxColumn.ReadOnly = true;
            this.vozilaDataGridViewTextBoxColumn.Visible = false;
            // 
            // lokacijeBindingSource
            // 
            this.lokacijeBindingSource.DataSource = typeof(NajamAutaEntityFramework.Lokacije);
            // 
            // dgvVozila
            // 
            this.dgvVozila.AllowUserToAddRows = false;
            this.dgvVozila.AllowUserToDeleteRows = false;
            this.dgvVozila.AutoGenerateColumns = false;
            this.dgvVozila.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVozila.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idVozilaDataGridViewTextBoxColumn,
            this.markaDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.godisteDataGridViewTextBoxColumn,
            this.gorivoDataGridViewTextBoxColumn,
            this.registracijaDataGridViewTextBoxColumn,
            this.kukaDataGridViewCheckBoxColumn,
            this.lokacijaDataGridViewTextBoxColumn,
            this.lokacijeDataGridViewTextBoxColumn,
            this.rezervacijeDataGridViewTextBoxColumn});
            this.dgvVozila.DataSource = this.vozilaBindingSource;
            this.dgvVozila.Location = new System.Drawing.Point(13, 188);
            this.dgvVozila.Name = "dgvVozila";
            this.dgvVozila.ReadOnly = true;
            this.dgvVozila.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVozila.Size = new System.Drawing.Size(644, 201);
            this.dgvVozila.TabIndex = 1;
            // 
            // idVozilaDataGridViewTextBoxColumn
            // 
            this.idVozilaDataGridViewTextBoxColumn.DataPropertyName = "IdVozila";
            this.idVozilaDataGridViewTextBoxColumn.HeaderText = "IdVozila";
            this.idVozilaDataGridViewTextBoxColumn.Name = "idVozilaDataGridViewTextBoxColumn";
            this.idVozilaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idVozilaDataGridViewTextBoxColumn.Visible = false;
            // 
            // markaDataGridViewTextBoxColumn
            // 
            this.markaDataGridViewTextBoxColumn.DataPropertyName = "Marka";
            this.markaDataGridViewTextBoxColumn.HeaderText = "Marka";
            this.markaDataGridViewTextBoxColumn.Name = "markaDataGridViewTextBoxColumn";
            this.markaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "Model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "Model";
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            this.modelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // godisteDataGridViewTextBoxColumn
            // 
            this.godisteDataGridViewTextBoxColumn.DataPropertyName = "Godiste";
            this.godisteDataGridViewTextBoxColumn.HeaderText = "Godište";
            this.godisteDataGridViewTextBoxColumn.Name = "godisteDataGridViewTextBoxColumn";
            this.godisteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gorivoDataGridViewTextBoxColumn
            // 
            this.gorivoDataGridViewTextBoxColumn.DataPropertyName = "Gorivo";
            this.gorivoDataGridViewTextBoxColumn.HeaderText = "Gorivo";
            this.gorivoDataGridViewTextBoxColumn.Name = "gorivoDataGridViewTextBoxColumn";
            this.gorivoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // registracijaDataGridViewTextBoxColumn
            // 
            this.registracijaDataGridViewTextBoxColumn.DataPropertyName = "Registracija";
            this.registracijaDataGridViewTextBoxColumn.HeaderText = "Registracija";
            this.registracijaDataGridViewTextBoxColumn.Name = "registracijaDataGridViewTextBoxColumn";
            this.registracijaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kukaDataGridViewCheckBoxColumn
            // 
            this.kukaDataGridViewCheckBoxColumn.DataPropertyName = "Kuka";
            this.kukaDataGridViewCheckBoxColumn.HeaderText = "Kuka";
            this.kukaDataGridViewCheckBoxColumn.Name = "kukaDataGridViewCheckBoxColumn";
            this.kukaDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // lokacijaDataGridViewTextBoxColumn
            // 
            this.lokacijaDataGridViewTextBoxColumn.DataPropertyName = "Lokacija";
            this.lokacijaDataGridViewTextBoxColumn.HeaderText = "Lokacija";
            this.lokacijaDataGridViewTextBoxColumn.Name = "lokacijaDataGridViewTextBoxColumn";
            this.lokacijaDataGridViewTextBoxColumn.ReadOnly = true;
            this.lokacijaDataGridViewTextBoxColumn.Visible = false;
            // 
            // lokacijeDataGridViewTextBoxColumn
            // 
            this.lokacijeDataGridViewTextBoxColumn.DataPropertyName = "Lokacije";
            this.lokacijeDataGridViewTextBoxColumn.HeaderText = "Lokacije";
            this.lokacijeDataGridViewTextBoxColumn.Name = "lokacijeDataGridViewTextBoxColumn";
            this.lokacijeDataGridViewTextBoxColumn.ReadOnly = true;
            this.lokacijeDataGridViewTextBoxColumn.Visible = false;
            // 
            // rezervacijeDataGridViewTextBoxColumn
            // 
            this.rezervacijeDataGridViewTextBoxColumn.DataPropertyName = "Rezervacije";
            this.rezervacijeDataGridViewTextBoxColumn.HeaderText = "Rezervacije";
            this.rezervacijeDataGridViewTextBoxColumn.Name = "rezervacijeDataGridViewTextBoxColumn";
            this.rezervacijeDataGridViewTextBoxColumn.ReadOnly = true;
            this.rezervacijeDataGridViewTextBoxColumn.Visible = false;
            // 
            // vozilaBindingSource
            // 
            this.vozilaBindingSource.DataSource = typeof(NajamAutaEntityFramework.Vozila);
            // 
            // btnNoviAuto
            // 
            this.btnNoviAuto.Location = new System.Drawing.Point(545, 33);
            this.btnNoviAuto.Name = "btnNoviAuto";
            this.btnNoviAuto.Size = new System.Drawing.Size(99, 38);
            this.btnNoviAuto.TabIndex = 2;
            this.btnNoviAuto.Text = "Dodaj novo vozilo";
            this.btnNoviAuto.UseVisualStyleBackColor = true;
            this.btnNoviAuto.Click += new System.EventHandler(this.btnNoviAuto_Click);
            // 
            // btnNovaLokacija
            // 
            this.btnNovaLokacija.Location = new System.Drawing.Point(545, 94);
            this.btnNovaLokacija.Name = "btnNovaLokacija";
            this.btnNovaLokacija.Size = new System.Drawing.Size(99, 40);
            this.btnNovaLokacija.TabIndex = 3;
            this.btnNovaLokacija.Text = "Dodaj novu lokaciju";
            this.btnNovaLokacija.UseVisualStyleBackColor = true;
            this.btnNovaLokacija.Click += new System.EventHandler(this.btnNovaLokacija_Click);
            // 
            // PopisLokacija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 401);
            this.Controls.Add(this.btnNovaLokacija);
            this.Controls.Add(this.btnNoviAuto);
            this.Controls.Add(this.dgvVozila);
            this.Controls.Add(this.dgvLokacije);
            this.Name = "PopisLokacija";
            this.Text = "PopisLokacija";
            this.Load += new System.EventHandler(this.PopisLokacija_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLokacije)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lokacijeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVozila)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vozilaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLokacije;
        private System.Windows.Forms.BindingSource lokacijeBindingSource;
        private System.Windows.Forms.DataGridView dgvVozila;
        private System.Windows.Forms.BindingSource vozilaBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idVozilaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn markaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn godisteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gorivoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn registracijaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn kukaDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lokacijaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lokacijeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rezervacijeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnNoviAuto;
        private System.Windows.Forms.DataGridViewTextBoxColumn idLokacijeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zupanijaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gradDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vozilaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnNovaLokacija;
    }
}