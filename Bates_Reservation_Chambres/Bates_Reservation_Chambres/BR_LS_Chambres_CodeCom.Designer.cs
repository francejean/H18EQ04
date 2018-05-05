namespace Bates_Reservation_Chambres
{
    partial class BR_LS_Chambres_CodeCom
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
            this.BR_LS_DGV_Chambre = new System.Windows.Forms.DataGridView();
            this.bR_DS_Chambres = new Bates_Reservation_Chambres.BR_DS_Chambres();
            this.commoditeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.commoditeTableAdapter = new Bates_Reservation_Chambres.BR_DS_ChambresTableAdapters.commoditeTableAdapter();
            this.codcomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.BR_LS_DGV_Chambre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bR_DS_Chambres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commoditeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // BR_LS_Chambres_OK
            // 
            this.BR_LS_Chambres_OK.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BR_LS_Chambres_OK.Location = new System.Drawing.Point(413, 415);
            this.BR_LS_Chambres_OK.Name = "BR_LS_Chambres_OK";
            this.BR_LS_Chambres_OK.Size = new System.Drawing.Size(75, 23);
            this.BR_LS_Chambres_OK.TabIndex = 11;
            this.BR_LS_Chambres_OK.Text = "Annuler";
            this.BR_LS_Chambres_OK.UseVisualStyleBackColor = true;
            // 
            // BR_LS_Chambres_Cancel
            // 
            this.BR_LS_Chambres_Cancel.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BR_LS_Chambres_Cancel.Location = new System.Drawing.Point(313, 415);
            this.BR_LS_Chambres_Cancel.Name = "BR_LS_Chambres_Cancel";
            this.BR_LS_Chambres_Cancel.Size = new System.Drawing.Size(75, 23);
            this.BR_LS_Chambres_Cancel.TabIndex = 10;
            this.BR_LS_Chambres_Cancel.Text = "OK";
            this.BR_LS_Chambres_Cancel.UseVisualStyleBackColor = true;
            // 
            // BR_LS_DGV_Chambre
            // 
            this.BR_LS_DGV_Chambre.AllowUserToAddRows = false;
            this.BR_LS_DGV_Chambre.AllowUserToDeleteRows = false;
            this.BR_LS_DGV_Chambre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BR_LS_DGV_Chambre.AutoGenerateColumns = false;
            this.BR_LS_DGV_Chambre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BR_LS_DGV_Chambre.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codcomDataGridViewTextBoxColumn});
            this.BR_LS_DGV_Chambre.DataSource = this.commoditeBindingSource;
            this.BR_LS_DGV_Chambre.Location = new System.Drawing.Point(13, 13);
            this.BR_LS_DGV_Chambre.Name = "BR_LS_DGV_Chambre";
            this.BR_LS_DGV_Chambre.ReadOnly = true;
            this.BR_LS_DGV_Chambre.Size = new System.Drawing.Size(775, 390);
            this.BR_LS_DGV_Chambre.TabIndex = 9;
            // 
            // bR_DS_Chambres
            // 
            this.bR_DS_Chambres.DataSetName = "BR_DS_Chambres";
            this.bR_DS_Chambres.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // commoditeBindingSource
            // 
            this.commoditeBindingSource.DataMember = "commodite";
            this.commoditeBindingSource.DataSource = this.bR_DS_Chambres;
            // 
            // commoditeTableAdapter
            // 
            this.commoditeTableAdapter.ClearBeforeFill = true;
            // 
            // codcomDataGridViewTextBoxColumn
            // 
            this.codcomDataGridViewTextBoxColumn.DataPropertyName = "Codcom";
            this.codcomDataGridViewTextBoxColumn.HeaderText = "Codcom";
            this.codcomDataGridViewTextBoxColumn.Name = "codcomDataGridViewTextBoxColumn";
            this.codcomDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // BR_LS_Chambres_CodeCom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BR_LS_Chambres_OK);
            this.Controls.Add(this.BR_LS_Chambres_Cancel);
            this.Controls.Add(this.BR_LS_DGV_Chambre);
            this.Name = "BR_LS_Chambres_CodeCom";
            this.Text = "BR_LS_CodeCom";
            ((System.ComponentModel.ISupportInitialize)(this.BR_LS_DGV_Chambre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bR_DS_Chambres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commoditeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BR_LS_Chambres_OK;
        private System.Windows.Forms.Button BR_LS_Chambres_Cancel;
        private System.Windows.Forms.DataGridView BR_LS_DGV_Chambre;
        private BR_DS_Chambres bR_DS_Chambres;
        private System.Windows.Forms.BindingSource commoditeBindingSource;
        private BR_DS_ChambresTableAdapters.commoditeTableAdapter commoditeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codcomDataGridViewTextBoxColumn;
    }
}