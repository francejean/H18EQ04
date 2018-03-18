namespace Bates_Reservation_Chambre
{
    partial class BR_LS_Chambres_NoCham
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
            this.dBR_LS_DGW_Chambre = new System.Windows.Forms.DataGridView();
            this.noChamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.etageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prixDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.etatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codLocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codTypChamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descLocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descComDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chambreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS_Bates_Reservation_Chambres = new Bates_Reservation_Chambre.DS_Bates_Reservation_Chambres();
            this.BR_LS_Chambres_Ok = new System.Windows.Forms.Button();
            this.BR_B_LS_Chambres_Cancel = new System.Windows.Forms.Button();
            this.chambreTableAdapter = new Bates_Reservation_Chambre.DS_Bates_Reservation_ChambresTableAdapters.chambreTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dBR_LS_DGW_Chambre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chambreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Bates_Reservation_Chambres)).BeginInit();
            this.SuspendLayout();
            // 
            // dBR_LS_DGW_Chambre
            // 
            this.dBR_LS_DGW_Chambre.AllowUserToAddRows = false;
            this.dBR_LS_DGW_Chambre.AllowUserToDeleteRows = false;
            this.dBR_LS_DGW_Chambre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dBR_LS_DGW_Chambre.AutoGenerateColumns = false;
            this.dBR_LS_DGW_Chambre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dBR_LS_DGW_Chambre.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.noChamDataGridViewTextBoxColumn,
            this.etageDataGridViewTextBoxColumn,
            this.prixDataGridViewTextBoxColumn,
            this.etatDataGridViewTextBoxColumn,
            this.memoDataGridViewTextBoxColumn,
            this.codLocDataGridViewTextBoxColumn,
            this.codTypChamDataGridViewTextBoxColumn,
            this.descLocDataGridViewTextBoxColumn,
            this.descComDataGridViewTextBoxColumn});
            this.dBR_LS_DGW_Chambre.DataSource = this.chambreBindingSource;
            this.dBR_LS_DGW_Chambre.Location = new System.Drawing.Point(12, 12);
            this.dBR_LS_DGW_Chambre.Name = "dBR_LS_DGW_Chambre";
            this.dBR_LS_DGW_Chambre.Size = new System.Drawing.Size(942, 388);
            this.dBR_LS_DGW_Chambre.TabIndex = 0;
            // 
            // noChamDataGridViewTextBoxColumn
            // 
            this.noChamDataGridViewTextBoxColumn.DataPropertyName = "NoCham";
            this.noChamDataGridViewTextBoxColumn.HeaderText = "NoCham";
            this.noChamDataGridViewTextBoxColumn.Name = "noChamDataGridViewTextBoxColumn";
            // 
            // etageDataGridViewTextBoxColumn
            // 
            this.etageDataGridViewTextBoxColumn.DataPropertyName = "Etage";
            this.etageDataGridViewTextBoxColumn.HeaderText = "Etage";
            this.etageDataGridViewTextBoxColumn.Name = "etageDataGridViewTextBoxColumn";
            // 
            // prixDataGridViewTextBoxColumn
            // 
            this.prixDataGridViewTextBoxColumn.DataPropertyName = "Prix";
            this.prixDataGridViewTextBoxColumn.HeaderText = "Prix";
            this.prixDataGridViewTextBoxColumn.Name = "prixDataGridViewTextBoxColumn";
            // 
            // etatDataGridViewTextBoxColumn
            // 
            this.etatDataGridViewTextBoxColumn.DataPropertyName = "Etat";
            this.etatDataGridViewTextBoxColumn.HeaderText = "Etat";
            this.etatDataGridViewTextBoxColumn.Name = "etatDataGridViewTextBoxColumn";
            // 
            // memoDataGridViewTextBoxColumn
            // 
            this.memoDataGridViewTextBoxColumn.DataPropertyName = "Memo";
            this.memoDataGridViewTextBoxColumn.HeaderText = "Memo";
            this.memoDataGridViewTextBoxColumn.Name = "memoDataGridViewTextBoxColumn";
            // 
            // codLocDataGridViewTextBoxColumn
            // 
            this.codLocDataGridViewTextBoxColumn.DataPropertyName = "CodLoc";
            this.codLocDataGridViewTextBoxColumn.HeaderText = "CodLoc";
            this.codLocDataGridViewTextBoxColumn.Name = "codLocDataGridViewTextBoxColumn";
            // 
            // codTypChamDataGridViewTextBoxColumn
            // 
            this.codTypChamDataGridViewTextBoxColumn.DataPropertyName = "CodTypCham";
            this.codTypChamDataGridViewTextBoxColumn.HeaderText = "CodTypCham";
            this.codTypChamDataGridViewTextBoxColumn.Name = "codTypChamDataGridViewTextBoxColumn";
            // 
            // descLocDataGridViewTextBoxColumn
            // 
            this.descLocDataGridViewTextBoxColumn.DataPropertyName = "DescLoc";
            this.descLocDataGridViewTextBoxColumn.HeaderText = "DescLoc";
            this.descLocDataGridViewTextBoxColumn.Name = "descLocDataGridViewTextBoxColumn";
            // 
            // descComDataGridViewTextBoxColumn
            // 
            this.descComDataGridViewTextBoxColumn.DataPropertyName = "DescCom";
            this.descComDataGridViewTextBoxColumn.HeaderText = "DescCom";
            this.descComDataGridViewTextBoxColumn.Name = "descComDataGridViewTextBoxColumn";
            // 
            // chambreBindingSource
            // 
            this.chambreBindingSource.DataMember = "chambre";
            this.chambreBindingSource.DataSource = this.dS_Bates_Reservation_Chambres;
            // 
            // dS_Bates_Reservation_Chambres
            // 
            this.dS_Bates_Reservation_Chambres.DataSetName = "DS_Bates_Reservation_Chambres";
            this.dS_Bates_Reservation_Chambres.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BR_LS_Chambres_Ok
            // 
            this.BR_LS_Chambres_Ok.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BR_LS_Chambres_Ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BR_LS_Chambres_Ok.Location = new System.Drawing.Point(178, 415);
            this.BR_LS_Chambres_Ok.Name = "BR_LS_Chambres_Ok";
            this.BR_LS_Chambres_Ok.Size = new System.Drawing.Size(241, 35);
            this.BR_LS_Chambres_Ok.TabIndex = 1;
            this.BR_LS_Chambres_Ok.Text = "OK";
            this.BR_LS_Chambres_Ok.UseVisualStyleBackColor = true;
            // 
            // BR_B_LS_Chambres_Cancel
            // 
            this.BR_B_LS_Chambres_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BR_B_LS_Chambres_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BR_B_LS_Chambres_Cancel.Location = new System.Drawing.Point(517, 415);
            this.BR_B_LS_Chambres_Cancel.Name = "BR_B_LS_Chambres_Cancel";
            this.BR_B_LS_Chambres_Cancel.Size = new System.Drawing.Size(241, 35);
            this.BR_B_LS_Chambres_Cancel.TabIndex = 2;
            this.BR_B_LS_Chambres_Cancel.Text = "Annuler";
            this.BR_B_LS_Chambres_Cancel.UseVisualStyleBackColor = true;
            // 
            // chambreTableAdapter
            // 
            this.chambreTableAdapter.ClearBeforeFill = true;
            // 
            // BR_LS_Chambres_NoCham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 462);
            this.Controls.Add(this.BR_B_LS_Chambres_Cancel);
            this.Controls.Add(this.BR_LS_Chambres_Ok);
            this.Controls.Add(this.dBR_LS_DGW_Chambre);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BR_LS_Chambres_NoCham";
            this.Text = "Chambres";
            this.Load += new System.EventHandler(this.BR_FO_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dBR_LS_DGW_Chambre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chambreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Bates_Reservation_Chambres)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dBR_LS_DGW_Chambre;
        private System.Windows.Forms.Button BR_LS_Chambres_Ok;
        private System.Windows.Forms.Button BR_B_LS_Chambres_Cancel;
        private DS_Bates_Reservation_Chambres dS_Bates_Reservation_Chambres;
        private System.Windows.Forms.BindingSource chambreBindingSource;
        private DS_Bates_Reservation_ChambresTableAdapters.chambreTableAdapter chambreTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn noChamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn etageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prixDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn etatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn memoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codLocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codTypChamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descLocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descComDataGridViewTextBoxColumn;
    }
}