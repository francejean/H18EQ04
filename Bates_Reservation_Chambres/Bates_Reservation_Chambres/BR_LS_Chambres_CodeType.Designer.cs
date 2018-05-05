namespace Bates_Reservation_Chambres
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
            this.BR_LS_Chambres_OK = new System.Windows.Forms.Button();
            this.BR_LS_Chambres_Cancel = new System.Windows.Forms.Button();
            this.BR_LS_DGV_Chambre = new System.Windows.Forms.DataGridView();
            this.codTypChamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescTyp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NbDispo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BR_BS_LS_typecham = new System.Windows.Forms.BindingSource(this.components);
            this.bR_DS_Chambres = new Bates_Reservation_Chambres.BR_DS_Chambres();
            this.BR_TA_LS_typecham = new Bates_Reservation_Chambres.BR_DS_ChambresTableAdapters.typechamTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.BR_LS_DGV_Chambre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BR_BS_LS_typecham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bR_DS_Chambres)).BeginInit();
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
            // BR_LS_DGV_Chambre
            // 
            this.BR_LS_DGV_Chambre.AllowUserToAddRows = false;
            this.BR_LS_DGV_Chambre.AllowUserToDeleteRows = false;
            this.BR_LS_DGV_Chambre.AutoGenerateColumns = false;
            this.BR_LS_DGV_Chambre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BR_LS_DGV_Chambre.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codTypChamDataGridViewTextBoxColumn,
            this.DescTyp,
            this.NbDispo});
            this.BR_LS_DGV_Chambre.DataSource = this.BR_BS_LS_typecham;
            this.BR_LS_DGV_Chambre.Location = new System.Drawing.Point(13, 13);
            this.BR_LS_DGV_Chambre.Name = "BR_LS_DGV_Chambre";
            this.BR_LS_DGV_Chambre.ReadOnly = true;
            this.BR_LS_DGV_Chambre.Size = new System.Drawing.Size(775, 390);
            this.BR_LS_DGV_Chambre.TabIndex = 6;
            // 
            // codTypChamDataGridViewTextBoxColumn
            // 
            this.codTypChamDataGridViewTextBoxColumn.DataPropertyName = "CodTypCham";
            this.codTypChamDataGridViewTextBoxColumn.HeaderText = "CodTypCham";
            this.codTypChamDataGridViewTextBoxColumn.Name = "codTypChamDataGridViewTextBoxColumn";
            this.codTypChamDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // DescTyp
            // 
            this.DescTyp.DataPropertyName = "DescTyp";
            this.DescTyp.HeaderText = "DescTyp";
            this.DescTyp.Name = "DescTyp";
            this.DescTyp.ReadOnly = true;
            // 
            // NbDispo
            // 
            this.NbDispo.DataPropertyName = "NbDispo";
            this.NbDispo.HeaderText = "NbDispo";
            this.NbDispo.Name = "NbDispo";
            this.NbDispo.ReadOnly = true;
            // 
            // BR_BS_LS_typecham
            // 
            this.BR_BS_LS_typecham.DataMember = "typecham";
            this.BR_BS_LS_typecham.DataSource = this.bR_DS_Chambres;
            // 
            // bR_DS_Chambres
            // 
            this.bR_DS_Chambres.DataSetName = "BR_DS_Chambres";
            this.bR_DS_Chambres.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BR_TA_LS_typecham
            // 
            this.BR_TA_LS_typecham.ClearBeforeFill = true;
            // 
            // BR_LS_Chambres_CodeType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BR_LS_Chambres_OK);
            this.Controls.Add(this.BR_LS_Chambres_Cancel);
            this.Controls.Add(this.BR_LS_DGV_Chambre);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimizeBox = false;
            this.Name = "BR_LS_Chambres_CodeType";
            this.Text = "BR_LS_Chambres_CodeType";
            this.Load += new System.EventHandler(this.BR_LS_Chambres_CodeType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BR_LS_DGV_Chambre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BR_BS_LS_typecham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bR_DS_Chambres)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BR_LS_Chambres_OK;
        private System.Windows.Forms.Button BR_LS_Chambres_Cancel;
        private System.Windows.Forms.DataGridView BR_LS_DGV_Chambre;
        private BR_DS_Chambres bR_DS_Chambres;
        private System.Windows.Forms.BindingSource BR_BS_LS_typecham;
        private BR_DS_ChambresTableAdapters.typechamTableAdapter BR_TA_LS_typecham;
        private System.Windows.Forms.DataGridViewTextBoxColumn codTypChamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescTyp;
        private System.Windows.Forms.DataGridViewTextBoxColumn NbDispo;
    }
}