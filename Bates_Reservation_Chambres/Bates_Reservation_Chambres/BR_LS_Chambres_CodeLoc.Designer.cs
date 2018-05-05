namespace Bates_Reservation_Chambres
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
            this.BR_LS_Chambres_OK = new System.Windows.Forms.Button();
            this.BR_LS_Chambres_Cancel = new System.Windows.Forms.Button();
            this.BR_LS_DGW_Chambre_CodeLoc = new System.Windows.Forms.DataGridView();
            this.codLocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescLoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BR_LS_BS_localisation = new System.Windows.Forms.BindingSource(this.components);
            this.BR_DS_Chambres = new Bates_Reservation_Chambres.BR_DS_Chambres();
            this.BR_LS_TA_localisation = new Bates_Reservation_Chambres.BR_DS_ChambresTableAdapters.localisationTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.BR_LS_DGW_Chambre_CodeLoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BR_LS_BS_localisation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BR_DS_Chambres)).BeginInit();
            this.SuspendLayout();
            // 
            // BR_LS_Chambres_OK
            // 
            this.BR_LS_Chambres_OK.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BR_LS_Chambres_OK.Location = new System.Drawing.Point(413, 415);
            this.BR_LS_Chambres_OK.Name = "BR_LS_Chambres_OK";
            this.BR_LS_Chambres_OK.Size = new System.Drawing.Size(75, 23);
            this.BR_LS_Chambres_OK.TabIndex = 8;
            this.BR_LS_Chambres_OK.Text = "Annuler";
            this.BR_LS_Chambres_OK.UseVisualStyleBackColor = true;
            // 
            // BR_LS_Chambres_Cancel
            // 
            this.BR_LS_Chambres_Cancel.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BR_LS_Chambres_Cancel.Location = new System.Drawing.Point(313, 415);
            this.BR_LS_Chambres_Cancel.Name = "BR_LS_Chambres_Cancel";
            this.BR_LS_Chambres_Cancel.Size = new System.Drawing.Size(75, 23);
            this.BR_LS_Chambres_Cancel.TabIndex = 7;
            this.BR_LS_Chambres_Cancel.Text = "OK";
            this.BR_LS_Chambres_Cancel.UseVisualStyleBackColor = true;
            // 
            // BR_LS_DGW_Chambre_CodeLoc
            // 
            this.BR_LS_DGW_Chambre_CodeLoc.AllowUserToAddRows = false;
            this.BR_LS_DGW_Chambre_CodeLoc.AllowUserToDeleteRows = false;
            this.BR_LS_DGW_Chambre_CodeLoc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BR_LS_DGW_Chambre_CodeLoc.AutoGenerateColumns = false;
            this.BR_LS_DGW_Chambre_CodeLoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BR_LS_DGW_Chambre_CodeLoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codLocDataGridViewTextBoxColumn,
            this.DescLoc});
            this.BR_LS_DGW_Chambre_CodeLoc.DataSource = this.BR_LS_BS_localisation;
            this.BR_LS_DGW_Chambre_CodeLoc.Location = new System.Drawing.Point(13, 13);
            this.BR_LS_DGW_Chambre_CodeLoc.Name = "BR_LS_DGW_Chambre_CodeLoc";
            this.BR_LS_DGW_Chambre_CodeLoc.ReadOnly = true;
            this.BR_LS_DGW_Chambre_CodeLoc.Size = new System.Drawing.Size(775, 390);
            this.BR_LS_DGW_Chambre_CodeLoc.TabIndex = 0;
            // 
            // codLocDataGridViewTextBoxColumn
            // 
            this.codLocDataGridViewTextBoxColumn.DataPropertyName = "CodLoc";
            this.codLocDataGridViewTextBoxColumn.HeaderText = "CodLoc";
            this.codLocDataGridViewTextBoxColumn.Name = "codLocDataGridViewTextBoxColumn";
            this.codLocDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // DescLoc
            // 
            this.DescLoc.DataPropertyName = "DescLoc";
            this.DescLoc.HeaderText = "DescLoc";
            this.DescLoc.Name = "DescLoc";
            this.DescLoc.ReadOnly = true;
            // 
            // BR_LS_BS_localisation
            // 
            this.BR_LS_BS_localisation.DataMember = "localisation";
            this.BR_LS_BS_localisation.DataSource = this.BR_DS_Chambres;
            // 
            // BR_DS_Chambres
            // 
            this.BR_DS_Chambres.DataSetName = "BR_DS_Chambres";
            this.BR_DS_Chambres.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BR_LS_TA_localisation
            // 
            this.BR_LS_TA_localisation.ClearBeforeFill = true;
            // 
            // BR_LS_Chambres_CodeLoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BR_LS_Chambres_OK);
            this.Controls.Add(this.BR_LS_Chambres_Cancel);
            this.Controls.Add(this.BR_LS_DGW_Chambre_CodeLoc);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "BR_LS_Chambres_CodeLoc";
            this.Text = "BR_LS_Chambres_CodeLoc";
            this.Load += new System.EventHandler(this.BR_LS_Chambres_CodeLoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BR_LS_DGW_Chambre_CodeLoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BR_LS_BS_localisation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BR_DS_Chambres)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BR_LS_Chambres_OK;
        private System.Windows.Forms.Button BR_LS_Chambres_Cancel;
        private System.Windows.Forms.DataGridView BR_LS_DGW_Chambre_CodeLoc;
        private BR_DS_Chambres BR_DS_Chambres;
        private System.Windows.Forms.BindingSource BR_LS_BS_localisation;
        private BR_DS_ChambresTableAdapters.localisationTableAdapter BR_LS_TA_localisation;
        private System.Windows.Forms.DataGridViewTextBoxColumn codLocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescLoc;
    }
}