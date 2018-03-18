namespace Bates_Reservation_Chambre
{
    partial class BR_LS_Chambres_CodeType
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
            this.codTypChamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descTypDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nbDispoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typechamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS_Bates_Reservation_Chambres = new Bates_Reservation_Chambre.DS_Bates_Reservation_Chambres();
            this.chambreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chambreTableAdapter = new Bates_Reservation_Chambre.DS_Bates_Reservation_ChambresTableAdapters.chambreTableAdapter();
            this.BR_B_LS_Chambres_Cancel = new System.Windows.Forms.Button();
            this.BR_LS_Chambres_Ok = new System.Windows.Forms.Button();
            this.commoditeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.commoditeTableAdapter = new Bates_Reservation_Chambre.DS_Bates_Reservation_ChambresTableAdapters.commoditeTableAdapter();
            this.typechamTableAdapter = new Bates_Reservation_Chambre.DS_Bates_Reservation_ChambresTableAdapters.typechamTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dBR_LS_DGW_Chambre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typechamBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Bates_Reservation_Chambres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chambreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commoditeBindingSource)).BeginInit();
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
            this.codTypChamDataGridViewTextBoxColumn,
            this.descTypDataGridViewTextBoxColumn,
            this.nbDispoDataGridViewTextBoxColumn});
            this.dBR_LS_DGW_Chambre.DataSource = this.typechamBindingSource;
            this.dBR_LS_DGW_Chambre.Location = new System.Drawing.Point(12, 12);
            this.dBR_LS_DGW_Chambre.Name = "dBR_LS_DGW_Chambre";
            this.dBR_LS_DGW_Chambre.Size = new System.Drawing.Size(344, 400);
            this.dBR_LS_DGW_Chambre.TabIndex = 3;
            // 
            // codTypChamDataGridViewTextBoxColumn
            // 
            this.codTypChamDataGridViewTextBoxColumn.DataPropertyName = "CodTypCham";
            this.codTypChamDataGridViewTextBoxColumn.HeaderText = "CodTypCham";
            this.codTypChamDataGridViewTextBoxColumn.Name = "codTypChamDataGridViewTextBoxColumn";
            // 
            // descTypDataGridViewTextBoxColumn
            // 
            this.descTypDataGridViewTextBoxColumn.DataPropertyName = "DescTyp";
            this.descTypDataGridViewTextBoxColumn.HeaderText = "DescTyp";
            this.descTypDataGridViewTextBoxColumn.Name = "descTypDataGridViewTextBoxColumn";
            // 
            // nbDispoDataGridViewTextBoxColumn
            // 
            this.nbDispoDataGridViewTextBoxColumn.DataPropertyName = "NbDispo";
            this.nbDispoDataGridViewTextBoxColumn.HeaderText = "NbDispo";
            this.nbDispoDataGridViewTextBoxColumn.Name = "nbDispoDataGridViewTextBoxColumn";
            // 
            // typechamBindingSource
            // 
            this.typechamBindingSource.DataMember = "typecham";
            this.typechamBindingSource.DataSource = this.dS_Bates_Reservation_Chambres;
            // 
            // dS_Bates_Reservation_Chambres
            // 
            this.dS_Bates_Reservation_Chambres.DataSetName = "DS_Bates_Reservation_Chambres";
            this.dS_Bates_Reservation_Chambres.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chambreBindingSource
            // 
            this.chambreBindingSource.DataMember = "chambre";
            this.chambreBindingSource.DataSource = this.dS_Bates_Reservation_Chambres;
            // 
            // chambreTableAdapter
            // 
            this.chambreTableAdapter.ClearBeforeFill = true;
            // 
            // BR_B_LS_Chambres_Cancel
            // 
            this.BR_B_LS_Chambres_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BR_B_LS_Chambres_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BR_B_LS_Chambres_Cancel.Location = new System.Drawing.Point(532, 418);
            this.BR_B_LS_Chambres_Cancel.Name = "BR_B_LS_Chambres_Cancel";
            this.BR_B_LS_Chambres_Cancel.Size = new System.Drawing.Size(241, 35);
            this.BR_B_LS_Chambres_Cancel.TabIndex = 5;
            this.BR_B_LS_Chambres_Cancel.Text = "Annuler";
            this.BR_B_LS_Chambres_Cancel.UseVisualStyleBackColor = true;
            // 
            // BR_LS_Chambres_Ok
            // 
            this.BR_LS_Chambres_Ok.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BR_LS_Chambres_Ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BR_LS_Chambres_Ok.Location = new System.Drawing.Point(193, 418);
            this.BR_LS_Chambres_Ok.Name = "BR_LS_Chambres_Ok";
            this.BR_LS_Chambres_Ok.Size = new System.Drawing.Size(241, 35);
            this.BR_LS_Chambres_Ok.TabIndex = 4;
            this.BR_LS_Chambres_Ok.Text = "OK";
            this.BR_LS_Chambres_Ok.UseVisualStyleBackColor = true;
            // 
            // commoditeBindingSource
            // 
            this.commoditeBindingSource.DataMember = "commodite";
            this.commoditeBindingSource.DataSource = this.dS_Bates_Reservation_Chambres;
            // 
            // commoditeTableAdapter
            // 
            this.commoditeTableAdapter.ClearBeforeFill = true;
            // 
            // typechamTableAdapter
            // 
            this.typechamTableAdapter.ClearBeforeFill = true;
            // 
            // BR_LS_Chambres_CodeType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 462);
            this.Controls.Add(this.BR_B_LS_Chambres_Cancel);
            this.Controls.Add(this.BR_LS_Chambres_Ok);
            this.Controls.Add(this.dBR_LS_DGW_Chambre);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BR_LS_Chambres_CodeType";
            this.Text = "Codes Types";
            this.Load += new System.EventHandler(this.BR_LS_Chambres_CodeType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dBR_LS_DGW_Chambre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typechamBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Bates_Reservation_Chambres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chambreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commoditeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dBR_LS_DGW_Chambre;
        private System.Windows.Forms.BindingSource chambreBindingSource;
        private DS_Bates_Reservation_Chambres dS_Bates_Reservation_Chambres;
        private DS_Bates_Reservation_ChambresTableAdapters.chambreTableAdapter chambreTableAdapter;
        private System.Windows.Forms.Button BR_B_LS_Chambres_Cancel;
        private System.Windows.Forms.Button BR_LS_Chambres_Ok;
        private System.Windows.Forms.BindingSource commoditeBindingSource;
        private DS_Bates_Reservation_ChambresTableAdapters.commoditeTableAdapter commoditeTableAdapter;
        private System.Windows.Forms.BindingSource typechamBindingSource;
        private DS_Bates_Reservation_ChambresTableAdapters.typechamTableAdapter typechamTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codTypChamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descTypDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nbDispoDataGridViewTextBoxColumn;
    }
}