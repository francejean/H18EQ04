namespace Bates_Reservation_Transactions
{
    partial class BR_LS_Transaction
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
            this.BR_LS_DGV_arrive = new System.Windows.Forms.DataGridView();
            this.BR_BS_Transaction_Arrive = new System.Windows.Forms.BindingSource(this.components);
            this.BR_LS_Button_Annuler = new System.Windows.Forms.Button();
            this.BR_LS_Button_Ok_ = new System.Windows.Forms.Button();
            this.BR_BS_Transaction_Trx = new System.Windows.Forms.BindingSource(this.components);
            this.bR_DS_Transactions = new Bates_Reservation_Transactions.BR_DS_Transactions();
            this.arriveBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.arriveTableAdapter = new Bates_Reservation_Transactions.BR_DS_TransactionsTableAdapters.arriveTableAdapter();
            this.idArriveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateArriveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCliDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idReserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noChamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telephoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateReserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDebutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateFinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.BR_LS_DGV_arrive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BR_BS_Transaction_Arrive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BR_BS_Transaction_Trx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bR_DS_Transactions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arriveBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // BR_LS_DGV_arrive
            // 
            this.BR_LS_DGV_arrive.AllowUserToOrderColumns = true;
            this.BR_LS_DGV_arrive.AutoGenerateColumns = false;
            this.BR_LS_DGV_arrive.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BR_LS_DGV_arrive.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idArriveDataGridViewTextBoxColumn,
            this.dateArriveDataGridViewTextBoxColumn,
            this.idCliDataGridViewTextBoxColumn,
            this.idReserDataGridViewTextBoxColumn,
            this.noChamDataGridViewTextBoxColumn,
            this.nomDataGridViewTextBoxColumn,
            this.telephoneDataGridViewTextBoxColumn,
            this.dateReserDataGridViewTextBoxColumn,
            this.dateDebutDataGridViewTextBoxColumn,
            this.dateFinDataGridViewTextBoxColumn});
            this.BR_LS_DGV_arrive.DataSource = this.arriveBindingSource;
            this.BR_LS_DGV_arrive.Location = new System.Drawing.Point(12, 5);
            this.BR_LS_DGV_arrive.Name = "BR_LS_DGV_arrive";
            this.BR_LS_DGV_arrive.Size = new System.Drawing.Size(1079, 447);
            this.BR_LS_DGV_arrive.TabIndex = 3;
            // 
            // BR_LS_Button_Annuler
            // 
            this.BR_LS_Button_Annuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BR_LS_Button_Annuler.Location = new System.Drawing.Point(678, 458);
            this.BR_LS_Button_Annuler.Name = "BR_LS_Button_Annuler";
            this.BR_LS_Button_Annuler.Size = new System.Drawing.Size(75, 23);
            this.BR_LS_Button_Annuler.TabIndex = 5;
            this.BR_LS_Button_Annuler.Text = "ANNULER";
            this.BR_LS_Button_Annuler.UseVisualStyleBackColor = true;
            // 
            // BR_LS_Button_Ok_
            // 
            this.BR_LS_Button_Ok_.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BR_LS_Button_Ok_.Location = new System.Drawing.Point(71, 458);
            this.BR_LS_Button_Ok_.Name = "BR_LS_Button_Ok_";
            this.BR_LS_Button_Ok_.Size = new System.Drawing.Size(75, 23);
            this.BR_LS_Button_Ok_.TabIndex = 4;
            this.BR_LS_Button_Ok_.Text = "OK";
            this.BR_LS_Button_Ok_.UseVisualStyleBackColor = true;
            // 
            // bR_DS_Transactions
            // 
            this.bR_DS_Transactions.DataSetName = "BR_DS_Transactions";
            this.bR_DS_Transactions.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // arriveBindingSource
            // 
            this.arriveBindingSource.DataMember = "arrive";
            this.arriveBindingSource.DataSource = this.bR_DS_Transactions;
            // 
            // arriveTableAdapter
            // 
            this.arriveTableAdapter.ClearBeforeFill = true;
            // 
            // idArriveDataGridViewTextBoxColumn
            // 
            this.idArriveDataGridViewTextBoxColumn.DataPropertyName = "IdArrive";
            this.idArriveDataGridViewTextBoxColumn.HeaderText = "IdArrive";
            this.idArriveDataGridViewTextBoxColumn.Name = "idArriveDataGridViewTextBoxColumn";
            // 
            // dateArriveDataGridViewTextBoxColumn
            // 
            this.dateArriveDataGridViewTextBoxColumn.DataPropertyName = "DateArrive";
            this.dateArriveDataGridViewTextBoxColumn.HeaderText = "DateArrive";
            this.dateArriveDataGridViewTextBoxColumn.Name = "dateArriveDataGridViewTextBoxColumn";
            // 
            // idCliDataGridViewTextBoxColumn
            // 
            this.idCliDataGridViewTextBoxColumn.DataPropertyName = "IdCli";
            this.idCliDataGridViewTextBoxColumn.HeaderText = "IdCli";
            this.idCliDataGridViewTextBoxColumn.Name = "idCliDataGridViewTextBoxColumn";
            // 
            // idReserDataGridViewTextBoxColumn
            // 
            this.idReserDataGridViewTextBoxColumn.DataPropertyName = "IdReser";
            this.idReserDataGridViewTextBoxColumn.HeaderText = "IdReser";
            this.idReserDataGridViewTextBoxColumn.Name = "idReserDataGridViewTextBoxColumn";
            // 
            // noChamDataGridViewTextBoxColumn
            // 
            this.noChamDataGridViewTextBoxColumn.DataPropertyName = "NoCham";
            this.noChamDataGridViewTextBoxColumn.HeaderText = "NoCham";
            this.noChamDataGridViewTextBoxColumn.Name = "noChamDataGridViewTextBoxColumn";
            // 
            // nomDataGridViewTextBoxColumn
            // 
            this.nomDataGridViewTextBoxColumn.DataPropertyName = "Nom";
            this.nomDataGridViewTextBoxColumn.HeaderText = "Nom";
            this.nomDataGridViewTextBoxColumn.Name = "nomDataGridViewTextBoxColumn";
            // 
            // telephoneDataGridViewTextBoxColumn
            // 
            this.telephoneDataGridViewTextBoxColumn.DataPropertyName = "Telephone";
            this.telephoneDataGridViewTextBoxColumn.HeaderText = "Telephone";
            this.telephoneDataGridViewTextBoxColumn.Name = "telephoneDataGridViewTextBoxColumn";
            // 
            // dateReserDataGridViewTextBoxColumn
            // 
            this.dateReserDataGridViewTextBoxColumn.DataPropertyName = "DateReser";
            this.dateReserDataGridViewTextBoxColumn.HeaderText = "DateReser";
            this.dateReserDataGridViewTextBoxColumn.Name = "dateReserDataGridViewTextBoxColumn";
            // 
            // dateDebutDataGridViewTextBoxColumn
            // 
            this.dateDebutDataGridViewTextBoxColumn.DataPropertyName = "DateDebut";
            this.dateDebutDataGridViewTextBoxColumn.HeaderText = "DateDebut";
            this.dateDebutDataGridViewTextBoxColumn.Name = "dateDebutDataGridViewTextBoxColumn";
            // 
            // dateFinDataGridViewTextBoxColumn
            // 
            this.dateFinDataGridViewTextBoxColumn.DataPropertyName = "DateFin";
            this.dateFinDataGridViewTextBoxColumn.HeaderText = "DateFin";
            this.dateFinDataGridViewTextBoxColumn.Name = "dateFinDataGridViewTextBoxColumn";
            // 
            // BR_LS_Transaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 495);
            this.Controls.Add(this.BR_LS_DGV_arrive);
            this.Controls.Add(this.BR_LS_Button_Annuler);
            this.Controls.Add(this.BR_LS_Button_Ok_);
            this.Name = "BR_LS_Transaction";
            this.Text = "BR_LS_Transaction";
            this.Load += new System.EventHandler(this.BR_LS_Transaction_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BR_LS_DGV_arrive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BR_BS_Transaction_Arrive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BR_BS_Transaction_Trx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bR_DS_Transactions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arriveBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView BR_LS_DGV_arrive;
        private System.Windows.Forms.BindingSource BR_BS_Transaction_Arrive;
        private System.Windows.Forms.BindingSource BR_BS_Transaction_Trx;
        private System.Windows.Forms.Button BR_LS_Button_Annuler;
        private System.Windows.Forms.Button BR_LS_Button_Ok_;
        private BR_DS_Transactions bR_DS_Transactions;
        private System.Windows.Forms.BindingSource arriveBindingSource;
        private BR_DS_TransactionsTableAdapters.arriveTableAdapter arriveTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idArriveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateArriveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCliDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idReserDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noChamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telephoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateReserDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDebutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateFinDataGridViewTextBoxColumn;
    }
}