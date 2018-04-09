namespace Bates_Reservation_Transactions
{
    partial class BR_Transactions
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.BR_TB_Transaction_DateFin = new Bate_s_Reservation_Base_Biblioteque.BR_TB_S();
            this.BR_TB_Transaction_DateDebut = new Bate_s_Reservation_Base_Biblioteque.BR_TB_S();
            this.BR_TB_Transaction_DateReserve = new Bate_s_Reservation_Base_Biblioteque.BR_TB_S();
            this.bR_LA_S8 = new Bate_s_Reservation_Base_Biblioteque.BR_LA_S();
            this.bR_LA_S7 = new Bate_s_Reservation_Base_Biblioteque.BR_LA_S();
            this.bR_LA_S6 = new Bate_s_Reservation_Base_Biblioteque.BR_LA_S();
            this.bR_LA_S5 = new Bate_s_Reservation_Base_Biblioteque.BR_LA_S();
            this.bR_LA_S4 = new Bate_s_Reservation_Base_Biblioteque.BR_LA_S();
            this.bR_LA_S1 = new Bate_s_Reservation_Base_Biblioteque.BR_LA_S();
            this.BR_TB_Transaction_NoChambre = new Bate_s_Reservation_Base_Biblioteque.BR_TB_S();
            this.BR_TB_Transaction_NoReservation = new Bate_s_Reservation_Base_Biblioteque.BR_TB_S();
            this.BR_TB_Transaction_NoArrive = new Bate_s_Reservation_Base_Biblioteque.BR_TB_S();
            this.BR_TB_Transaction_TelCli = new Bate_s_Reservation_Base_Biblioteque.BR_TB_S();
            this.BR_TB_Transactions_NomCli = new Bate_s_Reservation_Base_Biblioteque.BR_TB_S();
            this.bR_LA_S3 = new Bate_s_Reservation_Base_Biblioteque.BR_LA_S();
            this.bR_LA_S2 = new Bate_s_Reservation_Base_Biblioteque.BR_LA_S();
            this.BR_LA_Transactions_Nocli = new Bate_s_Reservation_Base_Biblioteque.BR_LA_S();
            this.BR_TB_Transactions_NoCli = new Bate_s_Reservation_Base_Biblioteque.BR_TB_S();
            this.BR_DGV_Transaction = new System.Windows.Forms.DataGridView();
            this.idTrxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTrxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nature = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescTrx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monantTrxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reporteeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdArrive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeTypeTrxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idReserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noChamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCliDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trxBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BR_DS_Transactions = new Bates_Reservation_Transactions.BR_DS_Transactions();
            this.BR_BS_Transactions_Transactions = new System.Windows.Forms.BindingSource(this.components);
            this.BR_TA_Transactions_Reservation = new Bates_Reservation_Transactions.BR_DS_TransactionsTableAdapters.trxTableAdapter();
            this.BR_TA_Transactions_Arrive = new Bates_Reservation_Transactions.BR_DS_TransactionsTableAdapters.arriveTableAdapter();
            this.BR_TA_Transactions_Client = new Bates_Reservation_Transactions.BR_DS_TransactionsTableAdapters.clientTableAdapter();
            this.BR_BS_Transactions_client = new System.Windows.Forms.BindingSource(this.components);
            this.BR_BS_Transactions_arrive = new System.Windows.Forms.BindingSource(this.components);
            this.BR_BS_Transactions_Reservation = new System.Windows.Forms.BindingSource(this.components);
            this.BR_TA_Transactions_Transaction = new Bates_Reservation_Transactions.BR_DS_TransactionsTableAdapters.trxTableAdapter();
            this.BR_DTP_Transaction_DateReserve = new Bate_s_Reservation_Base_Biblioteque.BR_DTP_S();
            this.BR_DTP_Transaction_DateDebut = new Bate_s_Reservation_Base_Biblioteque.BR_DTP_S();
            this.BR_DTP_Transaction_DateFin = new Bate_s_Reservation_Base_Biblioteque.BR_DTP_S();
            this.bR_TB_S1 = new Bate_s_Reservation_Base_Biblioteque.BR_TB_S();
            this.bR_LA_S9 = new Bate_s_Reservation_Base_Biblioteque.BR_LA_S();
            this.BR_PA_G.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BR_PictureBox_G)).BeginInit();
            this.BR_TP_S.SuspendLayout();
            this.BR_TP_Transaction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BR_DGV_Transaction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trxBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BR_DS_Transactions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BR_BS_Transactions_Transactions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BR_BS_Transactions_client)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BR_BS_Transactions_arrive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BR_BS_Transactions_Reservation)).BeginInit();
            this.SuspendLayout();
            // 
            // BR_Button_Gotoend_G
            // 
            this.BR_Button_Gotoend_G.FlatAppearance.BorderSize = 0;
            this.BR_Button_Gotoend_G.Click += new System.EventHandler(this.Bates_Reservation_Button_Gotoend_G_Click);
            // 
            // BR_Button_Next_G
            // 
            this.BR_Button_Next_G.FlatAppearance.BorderSize = 0;
            this.BR_Button_Next_G.Click += new System.EventHandler(this.Bates_Reservation_Button_Next_G_Click);
            // 
            // BR_Button_Gotofirst_G
            // 
            this.BR_Button_Gotofirst_G.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.BR_Button_Gotofirst_G.FlatAppearance.BorderSize = 0;
            this.BR_Button_Gotofirst_G.Click += new System.EventHandler(this.Bates_Reservation_Button_Gotofirst_G_Click);
            // 
            // BR_Button_Previous_G
            // 
            this.BR_Button_Previous_G.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.BR_Button_Previous_G.FlatAppearance.BorderSize = 0;
            this.BR_Button_Previous_G.Click += new System.EventHandler(this.Bates_Reservation_Button_Previous_G_Click);
            // 
            // BR_Button_List_G
            // 
            this.BR_Button_List_G.FlatAppearance.BorderSize = 0;
            // 
            // BR_Button_Del_G
            // 
            this.BR_Button_Del_G.FlatAppearance.BorderSize = 0;
            // 
            // BR_Button_View_G
            // 
            this.BR_Button_View_G.FlatAppearance.BorderSize = 0;
            // 
            // BR_Button_Save_G
            // 
            this.BR_Button_Save_G.FlatAppearance.BorderSize = 0;
            // 
            // BR_Button_Undo_G
            // 
            this.BR_Button_Undo_G.FlatAppearance.BorderSize = 0;
            // 
            // BR_Button_Edit_G
            // 
            this.BR_Button_Edit_G.FlatAppearance.BorderSize = 0;
            // 
            // BR_Button_Add_G
            // 
            this.BR_Button_Add_G.FlatAppearance.BorderSize = 0;
            this.BR_Button_Add_G.Click += new System.EventHandler(this.BR_Button_Add_G_Click);
            // 
            // BR_Button_Edit_S
            // 
            this.BR_Button_Edit_S.FlatAppearance.BorderSize = 0;
            // 
            // BR_Button_Undo_S
            // 
            this.BR_Button_Undo_S.FlatAppearance.BorderSize = 0;
            // 
            // BR_Button_Save_S
            // 
            this.BR_Button_Save_S.FlatAppearance.BorderSize = 0;
            // 
            // BR_Button_View_S
            // 
            this.BR_Button_View_S.FlatAppearance.BorderSize = 0;
            // 
            // BR_Button_Add_S
            // 
            this.BR_Button_Add_S.FlatAppearance.BorderSize = 0;
            // 
            // BR_Button_Del_S
            // 
            this.BR_Button_Del_S.FlatAppearance.BorderSize = 0;
            // 
            // BR_TP_Transaction
            // 
            this.BR_TP_Transaction.Controls.Add(this.bR_LA_S9);
            this.BR_TP_Transaction.Controls.Add(this.bR_TB_S1);
            this.BR_TP_Transaction.Controls.Add(this.BR_DTP_Transaction_DateFin);
            this.BR_TP_Transaction.Controls.Add(this.BR_DTP_Transaction_DateDebut);
            this.BR_TP_Transaction.Controls.Add(this.BR_DTP_Transaction_DateReserve);
            this.BR_TP_Transaction.Controls.Add(this.BR_TB_Transaction_DateFin);
            this.BR_TP_Transaction.Controls.Add(this.BR_TB_Transaction_DateDebut);
            this.BR_TP_Transaction.Controls.Add(this.BR_TB_Transaction_DateReserve);
            this.BR_TP_Transaction.Controls.Add(this.bR_LA_S8);
            this.BR_TP_Transaction.Controls.Add(this.bR_LA_S7);
            this.BR_TP_Transaction.Controls.Add(this.bR_LA_S6);
            this.BR_TP_Transaction.Controls.Add(this.bR_LA_S5);
            this.BR_TP_Transaction.Controls.Add(this.bR_LA_S4);
            this.BR_TP_Transaction.Controls.Add(this.bR_LA_S1);
            this.BR_TP_Transaction.Controls.Add(this.BR_TB_Transaction_NoChambre);
            this.BR_TP_Transaction.Controls.Add(this.BR_TB_Transaction_NoReservation);
            this.BR_TP_Transaction.Controls.Add(this.BR_TB_Transaction_NoArrive);
            this.BR_TP_Transaction.Controls.Add(this.BR_TB_Transaction_TelCli);
            this.BR_TP_Transaction.Controls.Add(this.BR_TB_Transactions_NomCli);
            this.BR_TP_Transaction.Controls.Add(this.bR_LA_S3);
            this.BR_TP_Transaction.Controls.Add(this.bR_LA_S2);
            this.BR_TP_Transaction.Controls.Add(this.BR_LA_Transactions_Nocli);
            this.BR_TP_Transaction.Controls.Add(this.BR_TB_Transactions_NoCli);
            this.BR_TP_Transaction.Controls.Add(this.BR_DGV_Transaction);
            // 
            // BR_Button_Quit_G
            // 
            this.BR_Button_Quit_G.FlatAppearance.BorderSize = 0;
            // 
            // BR_TB_Transaction_DateFin
            // 
            this.BR_TB_Transaction_DateFin.Location = new System.Drawing.Point(95, 406);
            this.BR_TB_Transaction_DateFin.Name = "BR_TB_Transaction_DateFin";
            this.BR_TB_Transaction_DateFin.Size = new System.Drawing.Size(171, 20);
            this.BR_TB_Transaction_DateFin.TabIndex = 63;
            // 
            // BR_TB_Transaction_DateDebut
            // 
            this.BR_TB_Transaction_DateDebut.Location = new System.Drawing.Point(95, 347);
            this.BR_TB_Transaction_DateDebut.Name = "BR_TB_Transaction_DateDebut";
            this.BR_TB_Transaction_DateDebut.Size = new System.Drawing.Size(171, 20);
            this.BR_TB_Transaction_DateDebut.TabIndex = 65;
            // 
            // BR_TB_Transaction_DateReserve
            // 
            this.BR_TB_Transaction_DateReserve.Location = new System.Drawing.Point(95, 281);
            this.BR_TB_Transaction_DateReserve.Name = "BR_TB_Transaction_DateReserve";
            this.BR_TB_Transaction_DateReserve.Size = new System.Drawing.Size(171, 20);
            this.BR_TB_Transaction_DateReserve.TabIndex = 64;
            // 
            // bR_LA_S8
            // 
            this.bR_LA_S8.AutoSize = true;
            this.bR_LA_S8.Location = new System.Drawing.Point(10, 406);
            this.bR_LA_S8.Name = "bR_LA_S8";
            this.bR_LA_S8.Size = new System.Drawing.Size(65, 13);
            this.bR_LA_S8.TabIndex = 77;
            this.bR_LA_S8.Text = "Date de fin :";
            // 
            // bR_LA_S7
            // 
            this.bR_LA_S7.AutoSize = true;
            this.bR_LA_S7.Location = new System.Drawing.Point(10, 347);
            this.bR_LA_S7.Name = "bR_LA_S7";
            this.bR_LA_S7.Size = new System.Drawing.Size(81, 13);
            this.bR_LA_S7.TabIndex = 76;
            this.bR_LA_S7.Text = "Date de début :";
            // 
            // bR_LA_S6
            // 
            this.bR_LA_S6.AutoSize = true;
            this.bR_LA_S6.Location = new System.Drawing.Point(10, 282);
            this.bR_LA_S6.Name = "bR_LA_S6";
            this.bR_LA_S6.Size = new System.Drawing.Size(79, 13);
            this.bR_LA_S6.TabIndex = 75;
            this.bR_LA_S6.Text = "Date Réservé :";
            // 
            // bR_LA_S5
            // 
            this.bR_LA_S5.AutoSize = true;
            this.bR_LA_S5.Location = new System.Drawing.Point(10, 174);
            this.bR_LA_S5.Name = "bR_LA_S5";
            this.bR_LA_S5.Size = new System.Drawing.Size(72, 13);
            this.bR_LA_S5.TabIndex = 74;
            this.bR_LA_S5.Text = "Chambre No :";
            // 
            // bR_LA_S4
            // 
            this.bR_LA_S4.AutoSize = true;
            this.bR_LA_S4.Location = new System.Drawing.Point(283, 123);
            this.bR_LA_S4.Name = "bR_LA_S4";
            this.bR_LA_S4.Size = new System.Drawing.Size(90, 13);
            this.bR_LA_S4.TabIndex = 73;
            this.bR_LA_S4.Text = "No. Réservation :";
            // 
            // bR_LA_S1
            // 
            this.bR_LA_S1.AutoSize = true;
            this.bR_LA_S1.Location = new System.Drawing.Point(13, 126);
            this.bR_LA_S1.Name = "bR_LA_S1";
            this.bR_LA_S1.Size = new System.Drawing.Size(60, 13);
            this.bR_LA_S1.TabIndex = 72;
            this.bR_LA_S1.Text = "No. Arrivé :";
            // 
            // BR_TB_Transaction_NoChambre
            // 
            this.BR_TB_Transaction_NoChambre.Location = new System.Drawing.Point(95, 171);
            this.BR_TB_Transaction_NoChambre.Name = "BR_TB_Transaction_NoChambre";
            this.BR_TB_Transaction_NoChambre.Size = new System.Drawing.Size(171, 20);
            this.BR_TB_Transaction_NoChambre.TabIndex = 61;
            // 
            // BR_TB_Transaction_NoReservation
            // 
            this.BR_TB_Transaction_NoReservation.Location = new System.Drawing.Point(379, 119);
            this.BR_TB_Transaction_NoReservation.Name = "BR_TB_Transaction_NoReservation";
            this.BR_TB_Transaction_NoReservation.Size = new System.Drawing.Size(117, 20);
            this.BR_TB_Transaction_NoReservation.TabIndex = 60;
            // 
            // BR_TB_Transaction_NoArrive
            // 
            this.BR_TB_Transaction_NoArrive.Location = new System.Drawing.Point(95, 120);
            this.BR_TB_Transaction_NoArrive.Name = "BR_TB_Transaction_NoArrive";
            this.BR_TB_Transaction_NoArrive.Size = new System.Drawing.Size(171, 20);
            this.BR_TB_Transaction_NoArrive.TabIndex = 59;
            this.BR_TB_Transaction_NoArrive.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.BR_TB_Transaction_NoArrive_MouseDoubleClick);
            // 
            // BR_TB_Transaction_TelCli
            // 
            this.BR_TB_Transaction_TelCli.Location = new System.Drawing.Point(95, 58);
            this.BR_TB_Transaction_TelCli.Name = "BR_TB_Transaction_TelCli";
            this.BR_TB_Transaction_TelCli.Size = new System.Drawing.Size(401, 20);
            this.BR_TB_Transaction_TelCli.TabIndex = 58;
            // 
            // BR_TB_Transactions_NomCli
            // 
            this.BR_TB_Transactions_NomCli.Location = new System.Drawing.Point(95, 29);
            this.BR_TB_Transactions_NomCli.Name = "BR_TB_Transactions_NomCli";
            this.BR_TB_Transactions_NomCli.Size = new System.Drawing.Size(401, 20);
            this.BR_TB_Transactions_NomCli.TabIndex = 57;
            // 
            // bR_LA_S3
            // 
            this.bR_LA_S3.AutoSize = true;
            this.bR_LA_S3.Location = new System.Drawing.Point(10, 58);
            this.bR_LA_S3.Name = "bR_LA_S3";
            this.bR_LA_S3.Size = new System.Drawing.Size(64, 13);
            this.bR_LA_S3.TabIndex = 71;
            this.bR_LA_S3.Text = "Téléphone :";
            // 
            // bR_LA_S2
            // 
            this.bR_LA_S2.AutoSize = true;
            this.bR_LA_S2.Location = new System.Drawing.Point(10, 32);
            this.bR_LA_S2.Name = "bR_LA_S2";
            this.bR_LA_S2.Size = new System.Drawing.Size(64, 13);
            this.bR_LA_S2.TabIndex = 70;
            this.bR_LA_S2.Text = "Nom Client :";
            // 
            // BR_LA_Transactions_Nocli
            // 
            this.BR_LA_Transactions_Nocli.AutoSize = true;
            this.BR_LA_Transactions_Nocli.Location = new System.Drawing.Point(10, 8);
            this.BR_LA_Transactions_Nocli.Name = "BR_LA_Transactions_Nocli";
            this.BR_LA_Transactions_Nocli.Size = new System.Drawing.Size(79, 13);
            this.BR_LA_Transactions_Nocli.TabIndex = 66;
            this.BR_LA_Transactions_Nocli.Text = "Numéro Client :";
            // 
            // BR_TB_Transactions_NoCli
            // 
            this.BR_TB_Transactions_NoCli.Location = new System.Drawing.Point(95, 5);
            this.BR_TB_Transactions_NoCli.Name = "BR_TB_Transactions_NoCli";
            this.BR_TB_Transactions_NoCli.Size = new System.Drawing.Size(171, 20);
            this.BR_TB_Transactions_NoCli.TabIndex = 62;
            // 
            // BR_DGV_Transaction
            // 
            this.BR_DGV_Transaction.AutoGenerateColumns = false;
            this.BR_DGV_Transaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BR_DGV_Transaction.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idTrxDataGridViewTextBoxColumn,
            this.dateTrxDataGridViewTextBoxColumn,
            this.nature,
            this.DescTrx,
            this.monantTrxDataGridViewTextBoxColumn,
            this.reporteeDataGridViewTextBoxColumn,
            this.IdArrive,
            this.codeTypeTrxDataGridViewTextBoxColumn,
            this.idReserDataGridViewTextBoxColumn,
            this.noChamDataGridViewTextBoxColumn,
            this.idCliDataGridViewTextBoxColumn});
            this.BR_DGV_Transaction.DataSource = this.trxBindingSource;
            this.BR_DGV_Transaction.Location = new System.Drawing.Point(509, 3);
            this.BR_DGV_Transaction.Name = "BR_DGV_Transaction";
            this.BR_DGV_Transaction.Size = new System.Drawing.Size(644, 403);
            this.BR_DGV_Transaction.TabIndex = 56;
            // 
            // idTrxDataGridViewTextBoxColumn
            // 
            this.idTrxDataGridViewTextBoxColumn.DataPropertyName = "IdTrx";
            this.idTrxDataGridViewTextBoxColumn.HeaderText = "IdTrx";
            this.idTrxDataGridViewTextBoxColumn.Name = "idTrxDataGridViewTextBoxColumn";
            // 
            // dateTrxDataGridViewTextBoxColumn
            // 
            this.dateTrxDataGridViewTextBoxColumn.DataPropertyName = "DateTrx";
            this.dateTrxDataGridViewTextBoxColumn.HeaderText = "DateTrx";
            this.dateTrxDataGridViewTextBoxColumn.Name = "dateTrxDataGridViewTextBoxColumn";
            // 
            // nature
            // 
            this.nature.DataPropertyName = "nature";
            this.nature.HeaderText = "nature";
            this.nature.Name = "nature";
            // 
            // DescTrx
            // 
            this.DescTrx.DataPropertyName = "DescTrx";
            this.DescTrx.HeaderText = "DescTrx";
            this.DescTrx.Name = "DescTrx";
            // 
            // monantTrxDataGridViewTextBoxColumn
            // 
            this.monantTrxDataGridViewTextBoxColumn.DataPropertyName = "MonantTrx";
            this.monantTrxDataGridViewTextBoxColumn.HeaderText = "MonantTrx";
            this.monantTrxDataGridViewTextBoxColumn.Name = "monantTrxDataGridViewTextBoxColumn";
            // 
            // reporteeDataGridViewTextBoxColumn
            // 
            this.reporteeDataGridViewTextBoxColumn.DataPropertyName = "Reportee";
            this.reporteeDataGridViewTextBoxColumn.HeaderText = "Reportee";
            this.reporteeDataGridViewTextBoxColumn.Name = "reporteeDataGridViewTextBoxColumn";
            // 
            // IdArrive
            // 
            this.IdArrive.DataPropertyName = "IdArrive";
            this.IdArrive.HeaderText = "IdArrive";
            this.IdArrive.Name = "IdArrive";
            // 
            // codeTypeTrxDataGridViewTextBoxColumn
            // 
            this.codeTypeTrxDataGridViewTextBoxColumn.DataPropertyName = "CodeTypeTrx";
            this.codeTypeTrxDataGridViewTextBoxColumn.HeaderText = "CodeTypeTrx";
            this.codeTypeTrxDataGridViewTextBoxColumn.Name = "codeTypeTrxDataGridViewTextBoxColumn";
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
            // idCliDataGridViewTextBoxColumn
            // 
            this.idCliDataGridViewTextBoxColumn.DataPropertyName = "IdCli";
            this.idCliDataGridViewTextBoxColumn.HeaderText = "IdCli";
            this.idCliDataGridViewTextBoxColumn.Name = "idCliDataGridViewTextBoxColumn";
            // 
            // trxBindingSource
            // 
            this.trxBindingSource.DataMember = "trx";
            this.trxBindingSource.DataSource = this.BR_DS_Transactions;
            // 
            // BR_DS_Transactions
            // 
            this.BR_DS_Transactions.DataSetName = "BR_DS_Transactions";
            this.BR_DS_Transactions.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BR_BS_Transactions_Transactions
            // 
            this.BR_BS_Transactions_Transactions.DataMember = "trx";
            this.BR_BS_Transactions_Transactions.DataSource = this.BR_DS_Transactions;
            // 
            // BR_TA_Transactions_Reservation
            // 
            this.BR_TA_Transactions_Reservation.ClearBeforeFill = true;
            // 
            // BR_TA_Transactions_Arrive
            // 
            this.BR_TA_Transactions_Arrive.ClearBeforeFill = true;
            // 
            // BR_TA_Transactions_Client
            // 
            this.BR_TA_Transactions_Client.ClearBeforeFill = true;
            // 
            // BR_TA_Transactions_Transaction
            // 
            this.BR_TA_Transactions_Transaction.ClearBeforeFill = true;
            // 
            // BR_DTP_Transaction_DateReserve
            // 
            this.BR_DTP_Transaction_DateReserve.CustomFormat = "yyyy/mm/dd";
            this.BR_DTP_Transaction_DateReserve.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.BR_DTP_Transaction_DateReserve.Location = new System.Drawing.Point(272, 281);
            this.BR_DTP_Transaction_DateReserve.Name = "BR_DTP_Transaction_DateReserve";
            this.BR_DTP_Transaction_DateReserve.Size = new System.Drawing.Size(224, 20);
            this.BR_DTP_Transaction_DateReserve.TabIndex = 48;
            // 
            // BR_DTP_Transaction_DateDebut
            // 
            this.BR_DTP_Transaction_DateDebut.CustomFormat = "yyyy/mm/dd";
            this.BR_DTP_Transaction_DateDebut.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.BR_DTP_Transaction_DateDebut.Location = new System.Drawing.Point(272, 347);
            this.BR_DTP_Transaction_DateDebut.Name = "BR_DTP_Transaction_DateDebut";
            this.BR_DTP_Transaction_DateDebut.Size = new System.Drawing.Size(224, 20);
            this.BR_DTP_Transaction_DateDebut.TabIndex = 48;
            // 
            // BR_DTP_Transaction_DateFin
            // 
            this.BR_DTP_Transaction_DateFin.CustomFormat = "yyyy/mm/dd";
            this.BR_DTP_Transaction_DateFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.BR_DTP_Transaction_DateFin.Location = new System.Drawing.Point(274, 406);
            this.BR_DTP_Transaction_DateFin.Name = "BR_DTP_Transaction_DateFin";
            this.BR_DTP_Transaction_DateFin.Size = new System.Drawing.Size(222, 20);
            this.BR_DTP_Transaction_DateFin.TabIndex = 48;
            // 
            // bR_TB_S1
            // 
            this.bR_TB_S1.Location = new System.Drawing.Point(956, 423);
            this.bR_TB_S1.Name = "bR_TB_S1";
            this.bR_TB_S1.Size = new System.Drawing.Size(197, 20);
            this.bR_TB_S1.TabIndex = 46;
            // 
            // bR_LA_S9
            // 
            this.bR_LA_S9.AutoSize = true;
            this.bR_LA_S9.Location = new System.Drawing.Point(824, 429);
            this.bR_LA_S9.Name = "bR_LA_S9";
            this.bR_LA_S9.Size = new System.Drawing.Size(112, 13);
            this.bR_LA_S9.TabIndex = 78;
            this.bR_LA_S9.Text = "MONTANT TOTALS :";
            // 
            // BR_Transactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1285, 700);
            this.Name = "BR_Transactions";
            this.Load += new System.EventHandler(this.BR_Transactions_Load);
            this.BR_PA_G.ResumeLayout(false);
            this.BR_PA_G.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BR_PictureBox_G)).EndInit();
            this.BR_TP_S.ResumeLayout(false);
            this.BR_TP_Transaction.ResumeLayout(false);
            this.BR_TP_Transaction.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BR_DGV_Transaction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trxBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BR_DS_Transactions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BR_BS_Transactions_Transactions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BR_BS_Transactions_client)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BR_BS_Transactions_arrive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BR_BS_Transactions_Reservation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bate_s_Reservation_Base_Biblioteque.BR_TB_S BR_TB_Transaction_DateFin;
        private Bate_s_Reservation_Base_Biblioteque.BR_TB_S BR_TB_Transaction_DateDebut;
        private Bate_s_Reservation_Base_Biblioteque.BR_TB_S BR_TB_Transaction_DateReserve;
        private Bate_s_Reservation_Base_Biblioteque.BR_LA_S bR_LA_S8;
        private Bate_s_Reservation_Base_Biblioteque.BR_LA_S bR_LA_S7;
        private Bate_s_Reservation_Base_Biblioteque.BR_LA_S bR_LA_S6;
        private Bate_s_Reservation_Base_Biblioteque.BR_LA_S bR_LA_S5;
        private Bate_s_Reservation_Base_Biblioteque.BR_LA_S bR_LA_S4;
        private Bate_s_Reservation_Base_Biblioteque.BR_LA_S bR_LA_S1;
        private Bate_s_Reservation_Base_Biblioteque.BR_TB_S BR_TB_Transaction_NoChambre;
        private Bate_s_Reservation_Base_Biblioteque.BR_TB_S BR_TB_Transaction_NoReservation;
        private Bate_s_Reservation_Base_Biblioteque.BR_TB_S BR_TB_Transaction_NoArrive;
        private Bate_s_Reservation_Base_Biblioteque.BR_TB_S BR_TB_Transaction_TelCli;
        private Bate_s_Reservation_Base_Biblioteque.BR_TB_S BR_TB_Transactions_NomCli;
        private Bate_s_Reservation_Base_Biblioteque.BR_LA_S bR_LA_S3;
        private Bate_s_Reservation_Base_Biblioteque.BR_LA_S bR_LA_S2;
        private Bate_s_Reservation_Base_Biblioteque.BR_LA_S BR_LA_Transactions_Nocli;
        private Bate_s_Reservation_Base_Biblioteque.BR_TB_S BR_TB_Transactions_NoCli;
        private System.Windows.Forms.DataGridView BR_DGV_Transaction;
        private BR_DS_Transactions BR_DS_Transactions;
        private System.Windows.Forms.BindingSource BR_BS_Transactions_Transactions;
        private System.Windows.Forms.BindingSource BR_BS_Transactions_client;
        private System.Windows.Forms.BindingSource BR_BS_Transactions_arrive;
        private System.Windows.Forms.BindingSource BR_BS_Transactions_Reservation;
        private BR_DS_TransactionsTableAdapters.trxTableAdapter BR_TA_Transactions_Reservation;
        private BR_DS_TransactionsTableAdapters.arriveTableAdapter BR_TA_Transactions_Arrive;
        private BR_DS_TransactionsTableAdapters.clientTableAdapter BR_TA_Transactions_Client;
        private BR_DS_TransactionsTableAdapters.trxTableAdapter BR_TA_Transactions_Transaction;
        private System.Windows.Forms.BindingSource trxBindingSource;
        private Bate_s_Reservation_Base_Biblioteque.BR_DTP_S BR_DTP_Transaction_DateFin;
        private Bate_s_Reservation_Base_Biblioteque.BR_DTP_S BR_DTP_Transaction_DateDebut;
        private Bate_s_Reservation_Base_Biblioteque.BR_DTP_S BR_DTP_Transaction_DateReserve;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTrxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateTrxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nature;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescTrx;
        private System.Windows.Forms.DataGridViewTextBoxColumn monantTrxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reporteeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdArrive;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeTypeTrxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idReserDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noChamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCliDataGridViewTextBoxColumn;
        private Bate_s_Reservation_Base_Biblioteque.BR_LA_S bR_LA_S9;
        private Bate_s_Reservation_Base_Biblioteque.BR_TB_S bR_TB_S1;
    }
}
