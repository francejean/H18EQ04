namespace Bates_Reservation_Chambre
{
    partial class Bates_Reservation_Chambre
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
            this.dateTimePicker_S1 = new Bate_s_Reservation_Base_Biblioteque.DateTimePicker_S();
            this.panel1_G.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_G)).BeginInit();
            this.SuspendLayout();
            // 
            // button_gotoend_G
            // 
            this.button_gotoend_G.FlatAppearance.BorderSize = 0;
            // 
            // button_next_G
            // 
            this.button_next_G.FlatAppearance.BorderSize = 0;
            // 
            // button_gotofirst_G
            // 
            this.button_gotofirst_G.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.button_gotofirst_G.FlatAppearance.BorderSize = 0;
            // 
            // button_previous_G
            // 
            this.button_previous_G.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.button_previous_G.FlatAppearance.BorderSize = 0;
            // 
            // panel1_G
            // 
            this.panel1_G.Controls.Add(this.dateTimePicker_S1);
            this.panel1_G.Controls.SetChildIndex(this.label_version_G, 0);
            this.panel1_G.Controls.SetChildIndex(this.label_numversion_G, 0);
            this.panel1_G.Controls.SetChildIndex(this.dateTimePicker_S1, 0);
            // 
            // button_exit_G
            // 
            this.button_exit_G.FlatAppearance.BorderSize = 0;
            // 
            // button_list_G
            // 
            this.button_list_G.FlatAppearance.BorderSize = 0;
            // 
            // button_del_G
            // 
            this.button_del_G.FlatAppearance.BorderSize = 0;
            // 
            // button_consult_G
            // 
            this.button_consult_G.FlatAppearance.BorderSize = 0;
            // 
            // button_save_G
            // 
            this.button_save_G.FlatAppearance.BorderSize = 0;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            // 
            // button_mod_G
            // 
            this.button_mod_G.FlatAppearance.BorderSize = 0;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            // 
            // dateTimePicker_S1
            // 
            this.dateTimePicker_S1.CustomFormat = "dddd yyyy/mm/dd   hh:mm:ss";
            this.dateTimePicker_S1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_S1.Location = new System.Drawing.Point(1502, 54);
            this.dateTimePicker_S1.Name = "dateTimePicker_S1";
            this.dateTimePicker_S1.Size = new System.Drawing.Size(20, 20);
            this.dateTimePicker_S1.TabIndex = 48;
            // 
            // Bates_Reservation_Chambre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1574, 861);
            this.Name = "Bates_Reservation_Chambre";
            this.panel1_G.ResumeLayout(false);
            this.panel1_G.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_G)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bate_s_Reservation_Base_Biblioteque.DateTimePicker_S dateTimePicker_S1;
    }
}
