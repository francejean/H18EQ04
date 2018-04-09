namespace Bates_Reservation_Reservation
{
    partial class BR_Reservation_Reservation
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.date = new System.Windows.Forms.TextBox();
            this.BR_TB_Reservation_No = new Bate_s_Reservation_Base_Biblioteque.BR_TB_S();
            this.bR_LA_S13 = new Bate_s_Reservation_Base_Biblioteque.BR_LA_S();
            this.bR_LA_S10 = new Bate_s_Reservation_Base_Biblioteque.BR_LA_S();
            this.bR_LA_S11 = new Bate_s_Reservation_Base_Biblioteque.BR_LA_S();
            this.bR_LA_S8 = new Bate_s_Reservation_Base_Biblioteque.BR_LA_S();
            this.bR_LA_S12 = new Bate_s_Reservation_Base_Biblioteque.BR_LA_S();
            this.BR_DTP_Reservation_DateFin = new Bate_s_Reservation_Base_Biblioteque.BR_DTP_S();
            this.BR_DTP_Reservation_ReserveLe = new Bate_s_Reservation_Base_Biblioteque.BR_DTP_S();
            this.BR_DTP_Reservation_DateDebut = new Bate_s_Reservation_Base_Biblioteque.BR_DTP_S();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bR_LA_S9 = new Bate_s_Reservation_Base_Biblioteque.BR_LA_S();
            this.bR_LA_S1 = new Bate_s_Reservation_Base_Biblioteque.BR_LA_S();
            this.BR_TB_reservation_IdClient = new Bate_s_Reservation_Base_Biblioteque.BR_TB_S();
            this.BR_TB_Reservation_Nom = new Bate_s_Reservation_Base_Biblioteque.BR_TB_S();
            this.BR_TB_Reservation_Expiration = new Bate_s_Reservation_Base_Biblioteque.BR_TB_S();
            this.bR_LA_S2 = new Bate_s_Reservation_Base_Biblioteque.BR_LA_S();
            this.bR_LA_S7 = new Bate_s_Reservation_Base_Biblioteque.BR_LA_S();
            this.BR_TB_Reservation_Adresse = new Bate_s_Reservation_Base_Biblioteque.BR_TB_S();
            this.BR_TB_Reservation_Solde = new Bate_s_Reservation_Base_Biblioteque.BR_TB_S();
            this.bR_LA_S3 = new Bate_s_Reservation_Base_Biblioteque.BR_LA_S();
            this.bR_LA_S6 = new Bate_s_Reservation_Base_Biblioteque.BR_LA_S();
            this.BR_TB_Reservation_Telephone = new Bate_s_Reservation_Base_Biblioteque.BR_TB_S();
            this.BR_TB_Reservation_Carte = new Bate_s_Reservation_Base_Biblioteque.BR_TB_S();
            this.bR_LA_S4 = new Bate_s_Reservation_Base_Biblioteque.BR_LA_S();
            this.bR_LA_S5 = new Bate_s_Reservation_Base_Biblioteque.BR_LA_S();
            this.BR_DS_Reservations = new Bates_Reservation_Reservation.BR_DS_Reservations();
            this.BR_BS_Reservation_De = new System.Windows.Forms.BindingSource(this.components);
            this.BR_BS_Reservation_Reserv = new System.Windows.Forms.BindingSource(this.components);
            this.BR_BS_Reservation_Chambre = new System.Windows.Forms.BindingSource(this.components);
            this.BR_BS_Reservation_Client = new System.Windows.Forms.BindingSource(this.components);
            this.BR_TA_Reservation_Chambre = new Bates_Reservation_Reservation.BR_DS_ReservationsTableAdapters.chambreTableAdapter();
            this.BR_TA_Reservation_Reserv = new Bates_Reservation_Reservation.BR_DS_ReservationsTableAdapters.reservationTableAdapter();
            this.BR_TA_Reservation_Client = new Bates_Reservation_Reservation.BR_DS_ReservationsTableAdapters.clientTableAdapter();
            this.BR_TA_Reservation_de = new Bates_Reservation_Reservation.BR_DS_ReservationsTableAdapters.deTableAdapter();
            this.BR_PA_G.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BR_PictureBox_G)).BeginInit();
            this.BR_TP_S.SuspendLayout();
            this.BR_TP_Reservation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BR_DS_Reservations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BR_BS_Reservation_De)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BR_BS_Reservation_Reserv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BR_BS_Reservation_Chambre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BR_BS_Reservation_Client)).BeginInit();
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
            this.BR_Button_Save_G.Click += new System.EventHandler(this.BR_Button_Save_G_Click);
            // 
            // BR_Button_Undo_G
            // 
            this.BR_Button_Undo_G.FlatAppearance.BorderSize = 0;
            this.BR_Button_Undo_G.Click += new System.EventHandler(this.BR_Button_Undo_G_Click);
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
            // BR_TP_Reservation
            // 
            this.BR_TP_Reservation.Controls.Add(this.dataGridView1);
            this.BR_TP_Reservation.Controls.Add(this.panel2);
            this.BR_TP_Reservation.Controls.Add(this.panel1);
            // 
            // BR_Button_Quit_G
            // 
            this.BR_Button_Quit_G.FlatAppearance.BorderSize = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(526, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(645, 451);
            this.dataGridView1.TabIndex = 66;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.date);
            this.panel2.Controls.Add(this.BR_TB_Reservation_No);
            this.panel2.Controls.Add(this.bR_LA_S13);
            this.panel2.Controls.Add(this.bR_LA_S10);
            this.panel2.Controls.Add(this.bR_LA_S11);
            this.panel2.Controls.Add(this.bR_LA_S8);
            this.panel2.Controls.Add(this.bR_LA_S12);
            this.panel2.Controls.Add(this.BR_DTP_Reservation_DateFin);
            this.panel2.Controls.Add(this.BR_DTP_Reservation_ReserveLe);
            this.panel2.Controls.Add(this.BR_DTP_Reservation_DateDebut);
            this.panel2.Location = new System.Drawing.Point(12, 256);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(508, 201);
            this.panel2.TabIndex = 65;
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(236, 34);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(100, 20);
            this.date.TabIndex = 69;
            // 
            // BR_TB_Reservation_No
            // 
            this.BR_TB_Reservation_No.Location = new System.Drawing.Point(187, 63);
            this.BR_TB_Reservation_No.Name = "BR_TB_Reservation_No";
            this.BR_TB_Reservation_No.Size = new System.Drawing.Size(200, 20);
            this.BR_TB_Reservation_No.TabIndex = 67;
            // 
            // bR_LA_S13
            // 
            this.bR_LA_S13.AutoSize = true;
            this.bR_LA_S13.Location = new System.Drawing.Point(47, 63);
            this.bR_LA_S13.Name = "bR_LA_S13";
            this.bR_LA_S13.Size = new System.Drawing.Size(84, 13);
            this.bR_LA_S13.TabIndex = 68;
            this.bR_LA_S13.Text = "No Réservation:";
            // 
            // bR_LA_S10
            // 
            this.bR_LA_S10.AutoSize = true;
            this.bR_LA_S10.Location = new System.Drawing.Point(47, 96);
            this.bR_LA_S10.Name = "bR_LA_S10";
            this.bR_LA_S10.Size = new System.Drawing.Size(61, 13);
            this.bR_LA_S10.TabIndex = 64;
            this.bR_LA_S10.Text = "Réservé le:";
            // 
            // bR_LA_S11
            // 
            this.bR_LA_S11.AutoSize = true;
            this.bR_LA_S11.Location = new System.Drawing.Point(47, 163);
            this.bR_LA_S11.Name = "bR_LA_S11";
            this.bR_LA_S11.Size = new System.Drawing.Size(62, 13);
            this.bR_LA_S11.TabIndex = 65;
            this.bR_LA_S11.Text = "Date de fin:";
            // 
            // bR_LA_S8
            // 
            this.bR_LA_S8.AutoSize = true;
            this.bR_LA_S8.Location = new System.Drawing.Point(25, 17);
            this.bR_LA_S8.Name = "bR_LA_S8";
            this.bR_LA_S8.Size = new System.Drawing.Size(84, 13);
            this.bR_LA_S8.TabIndex = 62;
            this.bR_LA_S8.Text = "RESERVATION";
            // 
            // bR_LA_S12
            // 
            this.bR_LA_S12.AutoSize = true;
            this.bR_LA_S12.Location = new System.Drawing.Point(47, 131);
            this.bR_LA_S12.Name = "bR_LA_S12";
            this.bR_LA_S12.Size = new System.Drawing.Size(78, 13);
            this.bR_LA_S12.TabIndex = 66;
            this.bR_LA_S12.Text = "Date de début:";
            // 
            // BR_DTP_Reservation_DateFin
            // 
            this.BR_DTP_Reservation_DateFin.CustomFormat = "dddd yyyy/mm/dd   hh:mm:ss";
            this.BR_DTP_Reservation_DateFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.BR_DTP_Reservation_DateFin.Location = new System.Drawing.Point(187, 158);
            this.BR_DTP_Reservation_DateFin.Name = "BR_DTP_Reservation_DateFin";
            this.BR_DTP_Reservation_DateFin.Size = new System.Drawing.Size(200, 20);
            this.BR_DTP_Reservation_DateFin.TabIndex = 61;
            // 
            // BR_DTP_Reservation_ReserveLe
            // 
            this.BR_DTP_Reservation_ReserveLe.CustomFormat = "mm/dd/yyyy";
            this.BR_DTP_Reservation_ReserveLe.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.BR_DTP_Reservation_ReserveLe.Location = new System.Drawing.Point(187, 96);
            this.BR_DTP_Reservation_ReserveLe.Name = "BR_DTP_Reservation_ReserveLe";
            this.BR_DTP_Reservation_ReserveLe.Size = new System.Drawing.Size(200, 20);
            this.BR_DTP_Reservation_ReserveLe.TabIndex = 48;
            // 
            // BR_DTP_Reservation_DateDebut
            // 
            this.BR_DTP_Reservation_DateDebut.CustomFormat = "dddd yyyy/mm/dd   hh:mm:ss";
            this.BR_DTP_Reservation_DateDebut.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.BR_DTP_Reservation_DateDebut.Location = new System.Drawing.Point(187, 125);
            this.BR_DTP_Reservation_DateDebut.Name = "BR_DTP_Reservation_DateDebut";
            this.BR_DTP_Reservation_DateDebut.Size = new System.Drawing.Size(200, 20);
            this.BR_DTP_Reservation_DateDebut.TabIndex = 60;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bR_LA_S9);
            this.panel1.Controls.Add(this.bR_LA_S1);
            this.panel1.Controls.Add(this.BR_TB_reservation_IdClient);
            this.panel1.Controls.Add(this.BR_TB_Reservation_Nom);
            this.panel1.Controls.Add(this.BR_TB_Reservation_Expiration);
            this.panel1.Controls.Add(this.bR_LA_S2);
            this.panel1.Controls.Add(this.bR_LA_S7);
            this.panel1.Controls.Add(this.BR_TB_Reservation_Adresse);
            this.panel1.Controls.Add(this.BR_TB_Reservation_Solde);
            this.panel1.Controls.Add(this.bR_LA_S3);
            this.panel1.Controls.Add(this.bR_LA_S6);
            this.panel1.Controls.Add(this.BR_TB_Reservation_Telephone);
            this.panel1.Controls.Add(this.BR_TB_Reservation_Carte);
            this.panel1.Controls.Add(this.bR_LA_S4);
            this.panel1.Controls.Add(this.bR_LA_S5);
            this.panel1.Location = new System.Drawing.Point(12, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(508, 236);
            this.panel1.TabIndex = 64;
            // 
            // bR_LA_S9
            // 
            this.bR_LA_S9.AutoSize = true;
            this.bR_LA_S9.Location = new System.Drawing.Point(20, 17);
            this.bR_LA_S9.Name = "bR_LA_S9";
            this.bR_LA_S9.Size = new System.Drawing.Size(73, 13);
            this.bR_LA_S9.TabIndex = 63;
            this.bR_LA_S9.Text = "INFO CLIENT";
            // 
            // bR_LA_S1
            // 
            this.bR_LA_S1.AutoSize = true;
            this.bR_LA_S1.Location = new System.Drawing.Point(31, 50);
            this.bR_LA_S1.Name = "bR_LA_S1";
            this.bR_LA_S1.Size = new System.Drawing.Size(53, 13);
            this.bR_LA_S1.TabIndex = 47;
            this.bR_LA_S1.Text = "Client No:";
            // 
            // BR_TB_reservation_IdClient
            // 
            this.BR_TB_reservation_IdClient.Location = new System.Drawing.Point(114, 47);
            this.BR_TB_reservation_IdClient.Name = "BR_TB_reservation_IdClient";
            this.BR_TB_reservation_IdClient.Size = new System.Drawing.Size(75, 20);
            this.BR_TB_reservation_IdClient.TabIndex = 46;
            // 
            // BR_TB_Reservation_Nom
            // 
            this.BR_TB_Reservation_Nom.Location = new System.Drawing.Point(248, 50);
            this.BR_TB_Reservation_Nom.Name = "BR_TB_Reservation_Nom";
            this.BR_TB_Reservation_Nom.Size = new System.Drawing.Size(100, 20);
            this.BR_TB_Reservation_Nom.TabIndex = 48;
            // 
            // BR_TB_Reservation_Expiration
            // 
            this.BR_TB_Reservation_Expiration.Location = new System.Drawing.Point(114, 191);
            this.BR_TB_Reservation_Expiration.Name = "BR_TB_Reservation_Expiration";
            this.BR_TB_Reservation_Expiration.Size = new System.Drawing.Size(113, 20);
            this.BR_TB_Reservation_Expiration.TabIndex = 59;
            // 
            // bR_LA_S2
            // 
            this.bR_LA_S2.AutoSize = true;
            this.bR_LA_S2.Location = new System.Drawing.Point(195, 53);
            this.bR_LA_S2.Name = "bR_LA_S2";
            this.bR_LA_S2.Size = new System.Drawing.Size(32, 13);
            this.bR_LA_S2.TabIndex = 49;
            this.bR_LA_S2.Text = "Nom:";
            // 
            // bR_LA_S7
            // 
            this.bR_LA_S7.AutoSize = true;
            this.bR_LA_S7.Location = new System.Drawing.Point(31, 194);
            this.bR_LA_S7.Name = "bR_LA_S7";
            this.bR_LA_S7.Size = new System.Drawing.Size(56, 13);
            this.bR_LA_S7.TabIndex = 58;
            this.bR_LA_S7.Text = "Expiration:";
            // 
            // BR_TB_Reservation_Adresse
            // 
            this.BR_TB_Reservation_Adresse.Location = new System.Drawing.Point(114, 85);
            this.BR_TB_Reservation_Adresse.Name = "BR_TB_Reservation_Adresse";
            this.BR_TB_Reservation_Adresse.Size = new System.Drawing.Size(234, 20);
            this.BR_TB_Reservation_Adresse.TabIndex = 50;
            // 
            // BR_TB_Reservation_Solde
            // 
            this.BR_TB_Reservation_Solde.Location = new System.Drawing.Point(283, 195);
            this.BR_TB_Reservation_Solde.Name = "BR_TB_Reservation_Solde";
            this.BR_TB_Reservation_Solde.Size = new System.Drawing.Size(65, 20);
            this.BR_TB_Reservation_Solde.TabIndex = 57;
            // 
            // bR_LA_S3
            // 
            this.bR_LA_S3.AutoSize = true;
            this.bR_LA_S3.Location = new System.Drawing.Point(31, 123);
            this.bR_LA_S3.Name = "bR_LA_S3";
            this.bR_LA_S3.Size = new System.Drawing.Size(61, 13);
            this.bR_LA_S3.TabIndex = 51;
            this.bR_LA_S3.Text = "Téléphone:";
            // 
            // bR_LA_S6
            // 
            this.bR_LA_S6.AutoSize = true;
            this.bR_LA_S6.Location = new System.Drawing.Point(245, 198);
            this.bR_LA_S6.Name = "bR_LA_S6";
            this.bR_LA_S6.Size = new System.Drawing.Size(37, 13);
            this.bR_LA_S6.TabIndex = 56;
            this.bR_LA_S6.Text = "Solde:";
            // 
            // BR_TB_Reservation_Telephone
            // 
            this.BR_TB_Reservation_Telephone.Location = new System.Drawing.Point(114, 120);
            this.BR_TB_Reservation_Telephone.Name = "BR_TB_Reservation_Telephone";
            this.BR_TB_Reservation_Telephone.Size = new System.Drawing.Size(113, 20);
            this.BR_TB_Reservation_Telephone.TabIndex = 52;
            // 
            // BR_TB_Reservation_Carte
            // 
            this.BR_TB_Reservation_Carte.Location = new System.Drawing.Point(114, 158);
            this.BR_TB_Reservation_Carte.Name = "BR_TB_Reservation_Carte";
            this.BR_TB_Reservation_Carte.Size = new System.Drawing.Size(113, 20);
            this.BR_TB_Reservation_Carte.TabIndex = 55;
            // 
            // bR_LA_S4
            // 
            this.bR_LA_S4.AutoSize = true;
            this.bR_LA_S4.Location = new System.Drawing.Point(31, 85);
            this.bR_LA_S4.Name = "bR_LA_S4";
            this.bR_LA_S4.Size = new System.Drawing.Size(48, 13);
            this.bR_LA_S4.TabIndex = 53;
            this.bR_LA_S4.Text = "Adresse:";
            // 
            // bR_LA_S5
            // 
            this.bR_LA_S5.AutoSize = true;
            this.bR_LA_S5.Location = new System.Drawing.Point(31, 161);
            this.bR_LA_S5.Name = "bR_LA_S5";
            this.bR_LA_S5.Size = new System.Drawing.Size(76, 13);
            this.bR_LA_S5.TabIndex = 54;
            this.bR_LA_S5.Text = "Type de carte:";
            // 
            // BR_DS_Reservations
            // 
            this.BR_DS_Reservations.DataSetName = "BR_DS_Reservations";
            this.BR_DS_Reservations.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BR_BS_Reservation_De
            // 
            this.BR_BS_Reservation_De.DataMember = "de";
            // 
            // BR_BS_Reservation_Chambre
            // 
            this.BR_BS_Reservation_Chambre.DataMember = "chambre";
            // 
            // BR_BS_Reservation_Client
            // 
            this.BR_BS_Reservation_Client.DataMember = "client";
            // 
            // BR_TA_Reservation_Chambre
            // 
            this.BR_TA_Reservation_Chambre.ClearBeforeFill = true;
            // 
            // BR_TA_Reservation_Reserv
            // 
            this.BR_TA_Reservation_Reserv.ClearBeforeFill = true;
            // 
            // BR_TA_Reservation_Client
            // 
            this.BR_TA_Reservation_Client.ClearBeforeFill = true;
            // 
            // BR_TA_Reservation_de
            // 
            this.BR_TA_Reservation_de.ClearBeforeFill = true;
            // 
            // BR_Reservation_Reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1285, 700);
            this.Name = "BR_Reservation_Reservation";
            this.Load += new System.EventHandler(this.Bates_Reservation_Reservation_Load);
            this.BR_PA_G.ResumeLayout(false);
            this.BR_PA_G.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BR_PictureBox_G)).EndInit();
            this.BR_TP_S.ResumeLayout(false);
            this.BR_TP_Reservation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BR_DS_Reservations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BR_BS_Reservation_De)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BR_BS_Reservation_Reserv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BR_BS_Reservation_Chambre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BR_BS_Reservation_Client)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox date;
        private Bate_s_Reservation_Base_Biblioteque.BR_TB_S BR_TB_Reservation_No;
        private Bate_s_Reservation_Base_Biblioteque.BR_LA_S bR_LA_S13;
        private Bate_s_Reservation_Base_Biblioteque.BR_LA_S bR_LA_S10;
        private Bate_s_Reservation_Base_Biblioteque.BR_LA_S bR_LA_S11;
        private Bate_s_Reservation_Base_Biblioteque.BR_LA_S bR_LA_S8;
        private Bate_s_Reservation_Base_Biblioteque.BR_LA_S bR_LA_S12;
        private Bate_s_Reservation_Base_Biblioteque.BR_DTP_S BR_DTP_Reservation_DateFin;
        private Bate_s_Reservation_Base_Biblioteque.BR_DTP_S BR_DTP_Reservation_ReserveLe;
        private Bate_s_Reservation_Base_Biblioteque.BR_DTP_S BR_DTP_Reservation_DateDebut;
        private System.Windows.Forms.Panel panel1;
        private Bate_s_Reservation_Base_Biblioteque.BR_LA_S bR_LA_S9;
        private Bate_s_Reservation_Base_Biblioteque.BR_LA_S bR_LA_S1;
        private Bate_s_Reservation_Base_Biblioteque.BR_TB_S BR_TB_reservation_IdClient;
        private Bate_s_Reservation_Base_Biblioteque.BR_TB_S BR_TB_Reservation_Nom;
        private Bate_s_Reservation_Base_Biblioteque.BR_TB_S BR_TB_Reservation_Expiration;
        private Bate_s_Reservation_Base_Biblioteque.BR_LA_S bR_LA_S2;
        private Bate_s_Reservation_Base_Biblioteque.BR_LA_S bR_LA_S7;
        private Bate_s_Reservation_Base_Biblioteque.BR_TB_S BR_TB_Reservation_Adresse;
        private Bate_s_Reservation_Base_Biblioteque.BR_TB_S BR_TB_Reservation_Solde;
        private Bate_s_Reservation_Base_Biblioteque.BR_LA_S bR_LA_S3;
        private Bate_s_Reservation_Base_Biblioteque.BR_LA_S bR_LA_S6;
        private Bate_s_Reservation_Base_Biblioteque.BR_TB_S BR_TB_Reservation_Telephone;
        private Bate_s_Reservation_Base_Biblioteque.BR_TB_S BR_TB_Reservation_Carte;
        private Bate_s_Reservation_Base_Biblioteque.BR_LA_S bR_LA_S4;
        private Bate_s_Reservation_Base_Biblioteque.BR_LA_S bR_LA_S5;
        private BR_DS_Reservations BR_DS_Reservations;
        private System.Windows.Forms.BindingSource BR_BS_Reservation_De;
        private System.Windows.Forms.BindingSource BR_BS_Reservation_Reserv;
        private System.Windows.Forms.BindingSource BR_BS_Reservation_Chambre;
        private System.Windows.Forms.BindingSource BR_BS_Reservation_Client;
        private BR_DS_ReservationsTableAdapters.chambreTableAdapter BR_TA_Reservation_Chambre;
        private BR_DS_ReservationsTableAdapters.reservationTableAdapter BR_TA_Reservation_Reserv;
        private BR_DS_ReservationsTableAdapters.clientTableAdapter BR_TA_Reservation_Client;
        private BR_DS_ReservationsTableAdapters.deTableAdapter BR_TA_Reservation_de;
    }
}
