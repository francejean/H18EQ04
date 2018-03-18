namespace Bates_Reservation_Chambre
{
    partial class BR_LS_Chambres_CodeLoc
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
            this.BR_B_LS_Chambres_Cancel = new System.Windows.Forms.Button();
            this.BR_LS_Chambres_Ok = new System.Windows.Forms.Button();
            this.dBR_LS_DGW_Chambre = new System.Windows.Forms.DataGridView();
            this.codLocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descLocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localisationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS_Bates_Reservation_Chambres = new Bates_Reservation_Chambre.DS_Bates_Reservation_Chambres();
            this.localisationTableAdapter = new Bates_Reservation_Chambre.DS_Bates_Reservation_ChambresTableAdapters.localisationTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dBR_LS_DGW_Chambre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.localisationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Bates_Reservation_Chambres)).BeginInit();
            this.SuspendLayout();
            // 
            // BR_B_LS_Chambres_Cancel
            // 
            this.BR_B_LS_Chambres_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BR_B_LS_Chambres_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BR_B_LS_Chambres_Cancel.Location = new System.Drawing.Point(623, 417);
            this.BR_B_LS_Chambres_Cancel.Name = "BR_B_LS_Chambres_Cancel";
            this.BR_B_LS_Chambres_Cancel.Size = new System.Drawing.Size(241, 35);
            this.BR_B_LS_Chambres_Cancel.TabIndex = 8;
            this.BR_B_LS_Chambres_Cancel.Text = "Annuler";
            this.BR_B_LS_Chambres_Cancel.UseVisualStyleBackColor = true;
            // 
            // BR_LS_Chambres_Ok
            // 
            this.BR_LS_Chambres_Ok.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BR_LS_Chambres_Ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BR_LS_Chambres_Ok.Location = new System.Drawing.Point(284, 417);
            this.BR_LS_Chambres_Ok.Name = "BR_LS_Chambres_Ok";
            this.BR_LS_Chambres_Ok.Size = new System.Drawing.Size(241, 35);
            this.BR_LS_Chambres_Ok.TabIndex = 7;
            this.BR_LS_Chambres_Ok.Text = "OK";
            this.BR_LS_Chambres_Ok.UseVisualStyleBackColor = true;
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
            this.codLocDataGridViewTextBoxColumn,
            this.descLocDataGridViewTextBoxColumn});
            this.dBR_LS_DGW_Chambre.DataSource = this.localisationBindingSource;
            this.dBR_LS_DGW_Chambre.Location = new System.Drawing.Point(12, 11);
            this.dBR_LS_DGW_Chambre.Name = "dBR_LS_DGW_Chambre";
            this.dBR_LS_DGW_Chambre.Size = new System.Drawing.Size(245, 400);
            this.dBR_LS_DGW_Chambre.TabIndex = 6;
            // 
            // codLocDataGridViewTextBoxColumn
            // 
            this.codLocDataGridViewTextBoxColumn.DataPropertyName = "CodLoc";
            this.codLocDataGridViewTextBoxColumn.HeaderText = "CodLoc";
            this.codLocDataGridViewTextBoxColumn.Name = "codLocDataGridViewTextBoxColumn";
            // 
            // descLocDataGridViewTextBoxColumn
            // 
            this.descLocDataGridViewTextBoxColumn.DataPropertyName = "DescLoc";
            this.descLocDataGridViewTextBoxColumn.HeaderText = "DescLoc";
            this.descLocDataGridViewTextBoxColumn.Name = "descLocDataGridViewTextBoxColumn";
            // 
            // localisationBindingSource
            // 
            this.localisationBindingSource.DataMember = "localisation";
            this.localisationBindingSource.DataSource = this.dS_Bates_Reservation_Chambres;
            // 
            // dS_Bates_Reservation_Chambres
            // 
            this.dS_Bates_Reservation_Chambres.DataSetName = "DS_Bates_Reservation_Chambres";
            this.dS_Bates_Reservation_Chambres.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // localisationTableAdapter
            // 
            this.localisationTableAdapter.ClearBeforeFill = true;
            // 
            // BR_LS_Chambres_CodeLoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 462);
            this.Controls.Add(this.BR_B_LS_Chambres_Cancel);
            this.Controls.Add(this.BR_LS_Chambres_Ok);
            this.Controls.Add(this.dBR_LS_DGW_Chambre);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BR_LS_Chambres_CodeLoc";
            this.Text = "Codes Localisation";
            this.Load += new System.EventHandler(this.BR_LS_Chambres_CodeLoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dBR_LS_DGW_Chambre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.localisationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Bates_Reservation_Chambres)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BR_B_LS_Chambres_Cancel;
        private System.Windows.Forms.Button BR_LS_Chambres_Ok;
        private System.Windows.Forms.DataGridView dBR_LS_DGW_Chambre;
        private DS_Bates_Reservation_Chambres dS_Bates_Reservation_Chambres;
        private System.Windows.Forms.BindingSource localisationBindingSource;
        private DS_Bates_Reservation_ChambresTableAdapters.localisationTableAdapter localisationTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codLocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descLocDataGridViewTextBoxColumn;
    }
}