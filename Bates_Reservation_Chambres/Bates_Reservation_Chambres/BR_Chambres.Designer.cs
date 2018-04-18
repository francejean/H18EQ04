namespace Bates_Reservation_Chambres
{
    partial class BR_Chambres
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
            this.BR_TB_Chambres_NoCham = new Bate_s_Reservation_Base_Biblioteque.BR_TB_S();
            this.BR_TB_Chambre_CodeLoc = new Bate_s_Reservation_Base_Biblioteque.BR_TB_S();
            this.BR_TB_Chambre_CodeType = new Bate_s_Reservation_Base_Biblioteque.BR_TB_S();
            this.BR_LA_Chambre_Mémo = new Bate_s_Reservation_Base_Biblioteque.BR_LA_S();
            this.BR_RTB_Chambres = new System.Windows.Forms.RichTextBox();
            this.BR_TB_Chambres_Desc2 = new Bate_s_Reservation_Base_Biblioteque.BR_TB_S();
            this.BR_TB_Chambres_Desc1 = new Bate_s_Reservation_Base_Biblioteque.BR_TB_S();
            this.BR_TB_Chambres_Prix = new Bate_s_Reservation_Base_Biblioteque.BR_TB_S();
            this.BR_TB_Chambres_Etat = new Bate_s_Reservation_Base_Biblioteque.BR_TB_S();
            this.BR_TB_Chambres_Etage = new Bate_s_Reservation_Base_Biblioteque.BR_TB_S();
            this.BR_LA_Chambre_Desc2 = new Bate_s_Reservation_Base_Biblioteque.BR_LA_S();
            this.BR_LA_Chambre_Desc1 = new Bate_s_Reservation_Base_Biblioteque.BR_LA_S();
            this.BR_LA_Chambre_CodeLoc = new Bate_s_Reservation_Base_Biblioteque.BR_LA_S();
            this.BR_LA_Chambre_CodeType = new Bate_s_Reservation_Base_Biblioteque.BR_LA_S();
            this.BR_LA_Chambre_Etat = new Bate_s_Reservation_Base_Biblioteque.BR_LA_S();
            this.BR_LA_Chambre_Etage = new Bate_s_Reservation_Base_Biblioteque.BR_LA_S();
            this.BR_LA_Chambre_NoCham = new Bate_s_Reservation_Base_Biblioteque.BR_LA_S();
            this.BR_DGV_Chambres = new System.Windows.Forms.DataGridView();
            this.BR_DescCom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nochamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codcomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BR_BS_Chambres_Ayant = new System.Windows.Forms.BindingSource(this.components);
            this.BR_DS_Chambres = new Bates_Reservation_Chambres.BR_DS_Chambres();
            this.BR_LA_Chambre_Prix = new Bate_s_Reservation_Base_Biblioteque.BR_LA_S();
            this.BR_TA_Chambres = new Bates_Reservation_Chambres.BR_DS_ChambresTableAdapters.chambreTableAdapter();
            this.BR_BS_Chambres = new System.Windows.Forms.BindingSource(this.components);
            this.BR_TA_Chambres_Ayant = new Bates_Reservation_Chambres.BR_DS_ChambresTableAdapters.ayantTableAdapter();
            this.BR_PA_G.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BR_PictureBox_G)).BeginInit();
            this.BR_TP_S.SuspendLayout();
            this.BR_TP_Chambre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BR_DGV_Chambres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BR_BS_Chambres_Ayant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BR_DS_Chambres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BR_BS_Chambres)).BeginInit();
            this.SuspendLayout();
            // 
            // BR_Button_Gotoend_G
            // 
            this.BR_Button_Gotoend_G.FlatAppearance.BorderSize = 0;
            this.BR_Button_Gotoend_G.Click += new System.EventHandler(this.BR_Button_Gotoend_G_Click);
            // 
            // BR_Button_Next_G
            // 
            this.BR_Button_Next_G.FlatAppearance.BorderSize = 0;
            this.BR_Button_Next_G.Click += new System.EventHandler(this.BR_Button_Next_G_Click);
            // 
            // BR_Button_Gotofirst_G
            // 
            this.BR_Button_Gotofirst_G.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.BR_Button_Gotofirst_G.FlatAppearance.BorderSize = 0;
            this.BR_Button_Gotofirst_G.Click += new System.EventHandler(this.BR_Button_Gotofirst_G_Click);
            // 
            // BR_Button_Previous_G
            // 
            this.BR_Button_Previous_G.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.BR_Button_Previous_G.FlatAppearance.BorderSize = 0;
            this.BR_Button_Previous_G.Click += new System.EventHandler(this.BR_Button_Previous_G_Click);
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
            this.BR_Button_Undo_S.Click += new System.EventHandler(this.BR_Button_Undo_S_Click);
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
            this.BR_Button_Add_S.Click += new System.EventHandler(this.BR_Button_Add_S_Click);
            // 
            // BR_Button_Del_S
            // 
            this.BR_Button_Del_S.FlatAppearance.BorderSize = 0;
            // 
            // BR_TP_Chambre
            // 
            this.BR_TP_Chambre.Controls.Add(this.BR_LA_Chambre_Prix);
            this.BR_TP_Chambre.Controls.Add(this.BR_TB_Chambres_NoCham);
            this.BR_TP_Chambre.Controls.Add(this.BR_TB_Chambre_CodeLoc);
            this.BR_TP_Chambre.Controls.Add(this.BR_TB_Chambre_CodeType);
            this.BR_TP_Chambre.Controls.Add(this.BR_LA_Chambre_Mémo);
            this.BR_TP_Chambre.Controls.Add(this.BR_RTB_Chambres);
            this.BR_TP_Chambre.Controls.Add(this.BR_TB_Chambres_Desc2);
            this.BR_TP_Chambre.Controls.Add(this.BR_TB_Chambres_Desc1);
            this.BR_TP_Chambre.Controls.Add(this.BR_TB_Chambres_Prix);
            this.BR_TP_Chambre.Controls.Add(this.BR_TB_Chambres_Etat);
            this.BR_TP_Chambre.Controls.Add(this.BR_TB_Chambres_Etage);
            this.BR_TP_Chambre.Controls.Add(this.BR_LA_Chambre_Desc2);
            this.BR_TP_Chambre.Controls.Add(this.BR_LA_Chambre_Desc1);
            this.BR_TP_Chambre.Controls.Add(this.BR_LA_Chambre_CodeLoc);
            this.BR_TP_Chambre.Controls.Add(this.BR_LA_Chambre_CodeType);
            this.BR_TP_Chambre.Controls.Add(this.BR_LA_Chambre_Etat);
            this.BR_TP_Chambre.Controls.Add(this.BR_LA_Chambre_Etage);
            this.BR_TP_Chambre.Controls.Add(this.BR_LA_Chambre_NoCham);
            this.BR_TP_Chambre.Controls.Add(this.BR_DGV_Chambres);
            // 
            // BR_Button_Quit_G
            // 
            this.BR_Button_Quit_G.FlatAppearance.BorderSize = 0;
            // 
            // BR_TB_Chambres_NoCham
            // 
            this.BR_TB_Chambres_NoCham.Enabled = false;
            this.BR_TB_Chambres_NoCham.Location = new System.Drawing.Point(147, 17);
            this.BR_TB_Chambres_NoCham.Name = "BR_TB_Chambres_NoCham";
            this.BR_TB_Chambres_NoCham.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BR_TB_Chambres_NoCham.Size = new System.Drawing.Size(100, 20);
            this.BR_TB_Chambres_NoCham.TabIndex = 83;
            this.BR_TB_Chambres_NoCham.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.BR_TB_Chambre_NoCham_MouseDoubleClick);
            // 
            // BR_TB_Chambre_CodeLoc
            // 
            this.BR_TB_Chambre_CodeLoc.Enabled = false;
            this.BR_TB_Chambre_CodeLoc.Location = new System.Drawing.Point(440, 74);
            this.BR_TB_Chambre_CodeLoc.Name = "BR_TB_Chambre_CodeLoc";
            this.BR_TB_Chambre_CodeLoc.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BR_TB_Chambre_CodeLoc.Size = new System.Drawing.Size(100, 20);
            this.BR_TB_Chambre_CodeLoc.TabIndex = 84;
            this.BR_TB_Chambre_CodeLoc.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.BR_TB_Chambre_CodeLoc_MouseDoubleClick);
            // 
            // BR_TB_Chambre_CodeType
            // 
            this.BR_TB_Chambre_CodeType.Enabled = false;
            this.BR_TB_Chambre_CodeType.Location = new System.Drawing.Point(440, 17);
            this.BR_TB_Chambre_CodeType.Name = "BR_TB_Chambre_CodeType";
            this.BR_TB_Chambre_CodeType.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BR_TB_Chambre_CodeType.Size = new System.Drawing.Size(100, 20);
            this.BR_TB_Chambre_CodeType.TabIndex = 85;
            this.BR_TB_Chambre_CodeType.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.BR_TB_Chambre_CodeType_MouseDoubleClick);
            // 
            // BR_LA_Chambre_Mémo
            // 
            this.BR_LA_Chambre_Mémo.AutoSize = true;
            this.BR_LA_Chambre_Mémo.Location = new System.Drawing.Point(14, 186);
            this.BR_LA_Chambre_Mémo.Name = "BR_LA_Chambre_Mémo";
            this.BR_LA_Chambre_Mémo.Size = new System.Drawing.Size(36, 13);
            this.BR_LA_Chambre_Mémo.TabIndex = 100;
            this.BR_LA_Chambre_Mémo.Text = "Mémo";
            // 
            // BR_RTB_Chambres
            // 
            this.BR_RTB_Chambres.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BR_RTB_Chambres.BackColor = System.Drawing.SystemColors.Control;
            this.BR_RTB_Chambres.Enabled = false;
            this.BR_RTB_Chambres.Location = new System.Drawing.Point(14, 213);
            this.BR_RTB_Chambres.Name = "BR_RTB_Chambres";
            this.BR_RTB_Chambres.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BR_RTB_Chambres.Size = new System.Drawing.Size(406, 244);
            this.BR_RTB_Chambres.TabIndex = 99;
            this.BR_RTB_Chambres.Text = "";
            // 
            // BR_TB_Chambres_Desc2
            // 
            this.BR_TB_Chambres_Desc2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.BR_TB_Chambres_Desc2.Enabled = false;
            this.BR_TB_Chambres_Desc2.Location = new System.Drawing.Point(734, 72);
            this.BR_TB_Chambres_Desc2.Name = "BR_TB_Chambres_Desc2";
            this.BR_TB_Chambres_Desc2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BR_TB_Chambres_Desc2.Size = new System.Drawing.Size(100, 20);
            this.BR_TB_Chambres_Desc2.TabIndex = 98;
            // 
            // BR_TB_Chambres_Desc1
            // 
            this.BR_TB_Chambres_Desc1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.BR_TB_Chambres_Desc1.Enabled = false;
            this.BR_TB_Chambres_Desc1.Location = new System.Drawing.Point(734, 17);
            this.BR_TB_Chambres_Desc1.Name = "BR_TB_Chambres_Desc1";
            this.BR_TB_Chambres_Desc1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BR_TB_Chambres_Desc1.Size = new System.Drawing.Size(100, 20);
            this.BR_TB_Chambres_Desc1.TabIndex = 97;
            // 
            // BR_TB_Chambres_Prix
            // 
            this.BR_TB_Chambres_Prix.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.BR_TB_Chambres_Prix.Enabled = false;
            this.BR_TB_Chambres_Prix.Location = new System.Drawing.Point(440, 126);
            this.BR_TB_Chambres_Prix.Name = "BR_TB_Chambres_Prix";
            this.BR_TB_Chambres_Prix.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BR_TB_Chambres_Prix.Size = new System.Drawing.Size(100, 20);
            this.BR_TB_Chambres_Prix.TabIndex = 96;
            // 
            // BR_TB_Chambres_Etat
            // 
            this.BR_TB_Chambres_Etat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.BR_TB_Chambres_Etat.Enabled = false;
            this.BR_TB_Chambres_Etat.Location = new System.Drawing.Point(147, 126);
            this.BR_TB_Chambres_Etat.Name = "BR_TB_Chambres_Etat";
            this.BR_TB_Chambres_Etat.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BR_TB_Chambres_Etat.Size = new System.Drawing.Size(100, 20);
            this.BR_TB_Chambres_Etat.TabIndex = 95;
            // 
            // BR_TB_Chambres_Etage
            // 
            this.BR_TB_Chambres_Etage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.BR_TB_Chambres_Etage.Enabled = false;
            this.BR_TB_Chambres_Etage.Location = new System.Drawing.Point(147, 74);
            this.BR_TB_Chambres_Etage.Name = "BR_TB_Chambres_Etage";
            this.BR_TB_Chambres_Etage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BR_TB_Chambres_Etage.Size = new System.Drawing.Size(100, 20);
            this.BR_TB_Chambres_Etage.TabIndex = 94;
            // 
            // BR_LA_Chambre_Desc2
            // 
            this.BR_LA_Chambre_Desc2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.BR_LA_Chambre_Desc2.AutoSize = true;
            this.BR_LA_Chambre_Desc2.Location = new System.Drawing.Point(607, 77);
            this.BR_LA_Chambre_Desc2.Name = "BR_LA_Chambre_Desc2";
            this.BR_LA_Chambre_Desc2.Size = new System.Drawing.Size(60, 13);
            this.BR_LA_Chambre_Desc2.TabIndex = 93;
            this.BR_LA_Chambre_Desc2.Text = "Description";
            // 
            // BR_LA_Chambre_Desc1
            // 
            this.BR_LA_Chambre_Desc1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.BR_LA_Chambre_Desc1.AutoSize = true;
            this.BR_LA_Chambre_Desc1.Location = new System.Drawing.Point(607, 17);
            this.BR_LA_Chambre_Desc1.Name = "BR_LA_Chambre_Desc1";
            this.BR_LA_Chambre_Desc1.Size = new System.Drawing.Size(60, 13);
            this.BR_LA_Chambre_Desc1.TabIndex = 92;
            this.BR_LA_Chambre_Desc1.Text = "Description";
            // 
            // BR_LA_Chambre_CodeLoc
            // 
            this.BR_LA_Chambre_CodeLoc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.BR_LA_Chambre_CodeLoc.AutoSize = true;
            this.BR_LA_Chambre_CodeLoc.Location = new System.Drawing.Point(314, 77);
            this.BR_LA_Chambre_CodeLoc.Name = "BR_LA_Chambre_CodeLoc";
            this.BR_LA_Chambre_CodeLoc.Size = new System.Drawing.Size(97, 13);
            this.BR_LA_Chambre_CodeLoc.TabIndex = 91;
            this.BR_LA_Chambre_CodeLoc.Text = "Code Loacalisation";
            // 
            // BR_LA_Chambre_CodeType
            // 
            this.BR_LA_Chambre_CodeType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.BR_LA_Chambre_CodeType.AutoSize = true;
            this.BR_LA_Chambre_CodeType.Location = new System.Drawing.Point(314, 17);
            this.BR_LA_Chambre_CodeType.Name = "BR_LA_Chambre_CodeType";
            this.BR_LA_Chambre_CodeType.Size = new System.Drawing.Size(59, 13);
            this.BR_LA_Chambre_CodeType.TabIndex = 90;
            this.BR_LA_Chambre_CodeType.Text = "Code Type";
            // 
            // BR_LA_Chambre_Etat
            // 
            this.BR_LA_Chambre_Etat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.BR_LA_Chambre_Etat.AutoSize = true;
            this.BR_LA_Chambre_Etat.Location = new System.Drawing.Point(14, 129);
            this.BR_LA_Chambre_Etat.Name = "BR_LA_Chambre_Etat";
            this.BR_LA_Chambre_Etat.Size = new System.Drawing.Size(26, 13);
            this.BR_LA_Chambre_Etat.TabIndex = 89;
            this.BR_LA_Chambre_Etat.Text = "Etat";
            // 
            // BR_LA_Chambre_Etage
            // 
            this.BR_LA_Chambre_Etage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.BR_LA_Chambre_Etage.AutoSize = true;
            this.BR_LA_Chambre_Etage.Location = new System.Drawing.Point(14, 75);
            this.BR_LA_Chambre_Etage.Name = "BR_LA_Chambre_Etage";
            this.BR_LA_Chambre_Etage.Size = new System.Drawing.Size(35, 13);
            this.BR_LA_Chambre_Etage.TabIndex = 88;
            this.BR_LA_Chambre_Etage.Text = "Etage";
            // 
            // BR_LA_Chambre_NoCham
            // 
            this.BR_LA_Chambre_NoCham.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.BR_LA_Chambre_NoCham.AutoSize = true;
            this.BR_LA_Chambre_NoCham.Location = new System.Drawing.Point(14, 17);
            this.BR_LA_Chambre_NoCham.Name = "BR_LA_Chambre_NoCham";
            this.BR_LA_Chambre_NoCham.Size = new System.Drawing.Size(66, 13);
            this.BR_LA_Chambre_NoCham.TabIndex = 87;
            this.BR_LA_Chambre_NoCham.Text = "No.Chambre";
            // 
            // BR_DGV_Chambres
            // 
            this.BR_DGV_Chambres.AllowUserToAddRows = false;
            this.BR_DGV_Chambres.AllowUserToDeleteRows = false;
            this.BR_DGV_Chambres.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BR_DGV_Chambres.AutoGenerateColumns = false;
            this.BR_DGV_Chambres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BR_DGV_Chambres.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BR_DescCom,
            this.nochamDataGridViewTextBoxColumn,
            this.codcomDataGridViewTextBoxColumn});
            this.BR_DGV_Chambres.DataSource = this.BR_BS_Chambres_Ayant;
            this.BR_DGV_Chambres.Location = new System.Drawing.Point(840, 3);
            this.BR_DGV_Chambres.Name = "BR_DGV_Chambres";
            this.BR_DGV_Chambres.ReadOnly = true;
            this.BR_DGV_Chambres.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BR_DGV_Chambres.Size = new System.Drawing.Size(339, 555);
            this.BR_DGV_Chambres.TabIndex = 86;
            // 
            // BR_DescCom
            // 
            this.BR_DescCom.DataPropertyName = "DescCom";
            this.BR_DescCom.HeaderText = "DescCom";
            this.BR_DescCom.Name = "BR_DescCom";
            this.BR_DescCom.ReadOnly = true;
            // 
            // nochamDataGridViewTextBoxColumn
            // 
            this.nochamDataGridViewTextBoxColumn.DataPropertyName = "Nocham";
            this.nochamDataGridViewTextBoxColumn.HeaderText = "Nocham";
            this.nochamDataGridViewTextBoxColumn.Name = "nochamDataGridViewTextBoxColumn";
            this.nochamDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codcomDataGridViewTextBoxColumn
            // 
            this.codcomDataGridViewTextBoxColumn.DataPropertyName = "Codcom";
            this.codcomDataGridViewTextBoxColumn.HeaderText = "Codcom";
            this.codcomDataGridViewTextBoxColumn.Name = "codcomDataGridViewTextBoxColumn";
            this.codcomDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // BR_BS_Chambres_Ayant
            // 
            this.BR_BS_Chambres_Ayant.DataMember = "ayant";
            this.BR_BS_Chambres_Ayant.DataSource = this.BR_DS_Chambres;
            // 
            // BR_DS_Chambres
            // 
            this.BR_DS_Chambres.DataSetName = "BR_DS_Chambres";
            this.BR_DS_Chambres.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BR_LA_Chambre_Prix
            // 
            this.BR_LA_Chambre_Prix.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.BR_LA_Chambre_Prix.AutoSize = true;
            this.BR_LA_Chambre_Prix.Location = new System.Drawing.Point(314, 129);
            this.BR_LA_Chambre_Prix.Name = "BR_LA_Chambre_Prix";
            this.BR_LA_Chambre_Prix.Size = new System.Drawing.Size(24, 13);
            this.BR_LA_Chambre_Prix.TabIndex = 101;
            this.BR_LA_Chambre_Prix.Text = "Prix";
            // 
            // BR_TA_Chambres
            // 
            this.BR_TA_Chambres.ClearBeforeFill = true;
            // 
            // BR_TA_Chambres_Ayant
            // 
            this.BR_TA_Chambres_Ayant.ClearBeforeFill = true;
            // 
            // BR_Chambres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1285, 700);
            this.Name = "BR_Chambres";
            this.Load += new System.EventHandler(this.BR_Chambres_Load);
            this.BR_PA_G.ResumeLayout(false);
            this.BR_PA_G.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BR_PictureBox_G)).EndInit();
            this.BR_TP_S.ResumeLayout(false);
            this.BR_TP_Chambre.ResumeLayout(false);
            this.BR_TP_Chambre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BR_DGV_Chambres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BR_BS_Chambres_Ayant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BR_DS_Chambres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BR_BS_Chambres)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bate_s_Reservation_Base_Biblioteque.BR_TB_S BR_TB_Chambres_NoCham;
        private Bate_s_Reservation_Base_Biblioteque.BR_TB_S BR_TB_Chambre_CodeLoc;
        private Bate_s_Reservation_Base_Biblioteque.BR_TB_S BR_TB_Chambre_CodeType;
        private Bate_s_Reservation_Base_Biblioteque.BR_LA_S BR_LA_Chambre_Mémo;
        private System.Windows.Forms.RichTextBox BR_RTB_Chambres;
        private Bate_s_Reservation_Base_Biblioteque.BR_TB_S BR_TB_Chambres_Desc2;
        private Bate_s_Reservation_Base_Biblioteque.BR_TB_S BR_TB_Chambres_Desc1;
        private Bate_s_Reservation_Base_Biblioteque.BR_TB_S BR_TB_Chambres_Prix;
        private Bate_s_Reservation_Base_Biblioteque.BR_TB_S BR_TB_Chambres_Etat;
        private Bate_s_Reservation_Base_Biblioteque.BR_TB_S BR_TB_Chambres_Etage;
        private Bate_s_Reservation_Base_Biblioteque.BR_LA_S BR_LA_Chambre_Desc2;
        private Bate_s_Reservation_Base_Biblioteque.BR_LA_S BR_LA_Chambre_Desc1;
        private Bate_s_Reservation_Base_Biblioteque.BR_LA_S BR_LA_Chambre_CodeLoc;
        private Bate_s_Reservation_Base_Biblioteque.BR_LA_S BR_LA_Chambre_CodeType;
        private Bate_s_Reservation_Base_Biblioteque.BR_LA_S BR_LA_Chambre_Etat;
        private Bate_s_Reservation_Base_Biblioteque.BR_LA_S BR_LA_Chambre_Etage;
        private Bate_s_Reservation_Base_Biblioteque.BR_LA_S BR_LA_Chambre_NoCham;
        private System.Windows.Forms.DataGridView BR_DGV_Chambres;
        private System.Windows.Forms.DataGridViewTextBoxColumn BR_DescCom;
        private Bate_s_Reservation_Base_Biblioteque.BR_LA_S BR_LA_Chambre_Prix;
        private BR_DS_Chambres BR_DS_Chambres;
        private BR_DS_ChambresTableAdapters.chambreTableAdapter BR_TA_Chambres;
        private System.Windows.Forms.BindingSource BR_BS_Chambres;
        private System.Windows.Forms.BindingSource BR_BS_Chambres_Ayant;
        private BR_DS_ChambresTableAdapters.ayantTableAdapter BR_TA_Chambres_Ayant;
        private System.Windows.Forms.DataGridViewTextBoxColumn nochamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codcomDataGridViewTextBoxColumn;
    }
}
