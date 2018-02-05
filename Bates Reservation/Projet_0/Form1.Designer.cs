namespace Projet_0
{
    partial class Fo_0
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
            this.panel1_G = new System.Windows.Forms.Panel();
            this.panel2_G = new System.Windows.Forms.Panel();
            this.dateTimePicker_G = new System.Windows.Forms.DateTimePicker();
            this.label_version_G = new System.Windows.Forms.Label();
            this.label_numversion_G = new System.Windows.Forms.Label();
            this.button_undo_G = new System.Windows.Forms.Button();
            this.button_save_G = new System.Windows.Forms.Button();
            this.button_list_G = new System.Windows.Forms.Button();
            this.button_gotoend_G = new System.Windows.Forms.Button();
            this.button_add_G = new System.Windows.Forms.Button();
            this.button_next_G = new System.Windows.Forms.Button();
            this.button_previous_G = new System.Windows.Forms.Button();
            this.button_gotofirst_G = new System.Windows.Forms.Button();
            this.button_consult_G = new System.Windows.Forms.Button();
            this.button_del_G = new System.Windows.Forms.Button();
            this.button_mod_G = new System.Windows.Forms.Button();
            this.button_exit_G = new System.Windows.Forms.Button();
            this.pictureBox_G = new System.Windows.Forms.PictureBox();
            this.panel1_G.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_G)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1_G
            // 
            this.panel1_G.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1_G.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1_G.Controls.Add(this.panel2_G);
            this.panel1_G.Controls.Add(this.label_numversion_G);
            this.panel1_G.Controls.Add(this.label_version_G);
            this.panel1_G.Location = new System.Drawing.Point(12, 143);
            this.panel1_G.Name = "panel1_G";
            this.panel1_G.Size = new System.Drawing.Size(1540, 591);
            this.panel1_G.TabIndex = 13;
            // 
            // panel2_G
            // 
            this.panel2_G.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2_G.BackColor = System.Drawing.SystemColors.Window;
            this.panel2_G.Location = new System.Drawing.Point(14, 13);
            this.panel2_G.Name = "panel2_G";
            this.panel2_G.Size = new System.Drawing.Size(1513, 566);
            this.panel2_G.TabIndex = 0;
            // 
            // dateTimePicker_G
            // 
            this.dateTimePicker_G.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker_G.CustomFormat = "yyyy/mm/dd";
            this.dateTimePicker_G.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_G.Location = new System.Drawing.Point(1409, 12);
            this.dateTimePicker_G.Name = "dateTimePicker_G";
            this.dateTimePicker_G.Size = new System.Drawing.Size(143, 20);
            this.dateTimePicker_G.TabIndex = 20;
            // 
            // label_version_G
            // 
            this.label_version_G.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label_version_G.AutoSize = true;
            this.label_version_G.ForeColor = System.Drawing.SystemColors.Window;
            this.label_version_G.Location = new System.Drawing.Point(1411, 0);
            this.label_version_G.Name = "label_version_G";
            this.label_version_G.Size = new System.Drawing.Size(42, 13);
            this.label_version_G.TabIndex = 21;
            this.label_version_G.Text = "Version";
            // 
            // label_numversion_G
            // 
            this.label_numversion_G.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label_numversion_G.AutoSize = true;
            this.label_numversion_G.Location = new System.Drawing.Point(1489, 0);
            this.label_numversion_G.Name = "label_numversion_G";
            this.label_numversion_G.Size = new System.Drawing.Size(35, 13);
            this.label_numversion_G.TabIndex = 22;
            this.label_numversion_G.Text = "label2";
            // 
            // button_undo_G
            // 
            this.button_undo_G.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_undo_G.Image = global::Projet_0.Properties.Resources.document_revert;
            this.button_undo_G.Location = new System.Drawing.Point(691, 44);
            this.button_undo_G.Name = "button_undo_G";
            this.button_undo_G.Size = new System.Drawing.Size(85, 93);
            this.button_undo_G.TabIndex = 24;
            this.button_undo_G.Text = "Annuler";
            this.button_undo_G.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_undo_G.UseVisualStyleBackColor = true;
            // 
            // button_save_G
            // 
            this.button_save_G.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_save_G.Image = global::Projet_0.Properties.Resources.document_save1;
            this.button_save_G.Location = new System.Drawing.Point(509, 44);
            this.button_save_G.Name = "button_save_G";
            this.button_save_G.Size = new System.Drawing.Size(85, 93);
            this.button_save_G.TabIndex = 23;
            this.button_save_G.Text = "Sauvegarder";
            this.button_save_G.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_save_G.UseVisualStyleBackColor = true;
            // 
            // button_list_G
            // 
            this.button_list_G.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_list_G.Image = global::Projet_0.Properties.Resources.system_search1;
            this.button_list_G.Location = new System.Drawing.Point(964, 44);
            this.button_list_G.Name = "button_list_G";
            this.button_list_G.Size = new System.Drawing.Size(85, 93);
            this.button_list_G.TabIndex = 19;
            this.button_list_G.Text = "LIster";
            this.button_list_G.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_list_G.UseVisualStyleBackColor = true;
            // 
            // button_gotoend_G
            // 
            this.button_gotoend_G.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_gotoend_G.Image = global::Projet_0.Properties.Resources.go_last;
            this.button_gotoend_G.Location = new System.Drawing.Point(830, 740);
            this.button_gotoend_G.Name = "button_gotoend_G";
            this.button_gotoend_G.Size = new System.Drawing.Size(75, 63);
            this.button_gotoend_G.TabIndex = 15;
            this.button_gotoend_G.UseVisualStyleBackColor = true;
            // 
            // button_add_G
            // 
            this.button_add_G.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_add_G.Image = global::Projet_0.Properties.Resources.address_book_new;
            this.button_add_G.Location = new System.Drawing.Point(418, 44);
            this.button_add_G.Name = "button_add_G";
            this.button_add_G.Size = new System.Drawing.Size(85, 93);
            this.button_add_G.TabIndex = 0;
            this.button_add_G.Text = "Ajouter";
            this.button_add_G.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_add_G.UseVisualStyleBackColor = true;
            // 
            // button_next_G
            // 
            this.button_next_G.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_next_G.Image = global::Projet_0.Properties.Resources.go_next;
            this.button_next_G.Location = new System.Drawing.Point(749, 740);
            this.button_next_G.Name = "button_next_G";
            this.button_next_G.Size = new System.Drawing.Size(75, 63);
            this.button_next_G.TabIndex = 16;
            this.button_next_G.UseVisualStyleBackColor = true;
            // 
            // button_previous_G
            // 
            this.button_previous_G.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_previous_G.Image = global::Projet_0.Properties.Resources.go_previous;
            this.button_previous_G.Location = new System.Drawing.Point(657, 740);
            this.button_previous_G.Name = "button_previous_G";
            this.button_previous_G.Size = new System.Drawing.Size(75, 63);
            this.button_previous_G.TabIndex = 17;
            this.button_previous_G.UseVisualStyleBackColor = true;
            // 
            // button_gotofirst_G
            // 
            this.button_gotofirst_G.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_gotofirst_G.Image = global::Projet_0.Properties.Resources.go_first;
            this.button_gotofirst_G.Location = new System.Drawing.Point(576, 740);
            this.button_gotofirst_G.Name = "button_gotofirst_G";
            this.button_gotofirst_G.Size = new System.Drawing.Size(75, 63);
            this.button_gotofirst_G.TabIndex = 14;
            this.button_gotofirst_G.UseVisualStyleBackColor = true;
            // 
            // button_consult_G
            // 
            this.button_consult_G.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_consult_G.Image = global::Projet_0.Properties.Resources.edit_find;
            this.button_consult_G.Location = new System.Drawing.Point(873, 44);
            this.button_consult_G.Name = "button_consult_G";
            this.button_consult_G.Size = new System.Drawing.Size(85, 93);
            this.button_consult_G.TabIndex = 10;
            this.button_consult_G.Text = "Consulter";
            this.button_consult_G.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_consult_G.UseVisualStyleBackColor = true;
            // 
            // button_del_G
            // 
            this.button_del_G.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_del_G.Image = global::Projet_0.Properties.Resources.application_exit;
            this.button_del_G.Location = new System.Drawing.Point(782, 44);
            this.button_del_G.Name = "button_del_G";
            this.button_del_G.Size = new System.Drawing.Size(85, 93);
            this.button_del_G.TabIndex = 12;
            this.button_del_G.Text = "Suprimer";
            this.button_del_G.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_del_G.UseVisualStyleBackColor = true;
            // 
            // button_mod_G
            // 
            this.button_mod_G.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_mod_G.Image = global::Projet_0.Properties.Resources.document_edit;
            this.button_mod_G.Location = new System.Drawing.Point(600, 44);
            this.button_mod_G.Name = "button_mod_G";
            this.button_mod_G.Size = new System.Drawing.Size(85, 93);
            this.button_mod_G.TabIndex = 11;
            this.button_mod_G.Text = "Modifier";
            this.button_mod_G.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_mod_G.UseVisualStyleBackColor = true;
            // 
            // button_exit_G
            // 
            this.button_exit_G.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_exit_G.Image = global::Projet_0.Properties.Resources.process_stop;
            this.button_exit_G.Location = new System.Drawing.Point(1477, 740);
            this.button_exit_G.Name = "button_exit_G";
            this.button_exit_G.Size = new System.Drawing.Size(75, 72);
            this.button_exit_G.TabIndex = 8;
            this.button_exit_G.Text = "Exit";
            this.button_exit_G.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_exit_G.UseVisualStyleBackColor = true;
            // 
            // pictureBox_G
            // 
            this.pictureBox_G.Image = global::Projet_0.Properties.Resources.Logo;
            this.pictureBox_G.Location = new System.Drawing.Point(12, 12);
            this.pictureBox_G.Name = "pictureBox_G";
            this.pictureBox_G.Size = new System.Drawing.Size(400, 192);
            this.pictureBox_G.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_G.TabIndex = 18;
            this.pictureBox_G.TabStop = false;
            // 
            // Fo_0
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1564, 819);
            this.Controls.Add(this.button_undo_G);
            this.Controls.Add(this.button_save_G);
            this.Controls.Add(this.dateTimePicker_G);
            this.Controls.Add(this.button_list_G);
            this.Controls.Add(this.button_gotoend_G);
            this.Controls.Add(this.button_add_G);
            this.Controls.Add(this.button_next_G);
            this.Controls.Add(this.button_previous_G);
            this.Controls.Add(this.button_gotofirst_G);
            this.Controls.Add(this.button_consult_G);
            this.Controls.Add(this.button_del_G);
            this.Controls.Add(this.panel1_G);
            this.Controls.Add(this.button_mod_G);
            this.Controls.Add(this.button_exit_G);
            this.Controls.Add(this.pictureBox_G);
            this.Name = "Fo_0";
            this.Text = "Form1";
            this.panel1_G.ResumeLayout(false);
            this.panel1_G.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_G)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_add_G;
        private System.Windows.Forms.Button button_exit_G;
        private System.Windows.Forms.Button button_mod_G;
        private System.Windows.Forms.Button button_del_G;
        private System.Windows.Forms.Panel panel1_G;
        private System.Windows.Forms.Button button_gotofirst_G;
        private System.Windows.Forms.Button button_gotoend_G;
        private System.Windows.Forms.Button button_next_G;
        private System.Windows.Forms.Button button_previous_G;
        private System.Windows.Forms.PictureBox pictureBox_G;
        private System.Windows.Forms.Button button_consult_G;
        private System.Windows.Forms.Button button_list_G;
        private System.Windows.Forms.Panel panel2_G;
        private System.Windows.Forms.DateTimePicker dateTimePicker_G;
        private System.Windows.Forms.Label label_version_G;
        private System.Windows.Forms.Label label_numversion_G;
        private System.Windows.Forms.Button button_save_G;
        private System.Windows.Forms.Button button_undo_G;
    }
}

