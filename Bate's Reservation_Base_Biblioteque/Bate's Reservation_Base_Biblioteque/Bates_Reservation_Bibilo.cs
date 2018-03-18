using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bate_s_Reservation_Base_Biblioteque
{
    public partial class BR_Biblio : Form
    {
        public BR_Biblio()
        {
            InitializeComponent();
        }

        private void BR_Button_Add_G_Click(object sender, EventArgs e)
        {
            EnabledButton();
            MessageBox.Show("Bouton ADD en construction...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void BR_Button_Edit_G_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bouton MODIFIER en construction...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void BR_Button_Undo_G_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bouton ANNULER en construction...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            DisableButton();
        }

        private void BR_Button_Save_G_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bouton SAVE en construction...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void BR_Button_Del_G_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bouton SUPPRIMER en construction...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void BR_Button_View_G_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bouton CONSULTER en construction...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void BR_Button_List_G_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bouton LISTER en construction...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void BR_Button_Add_S_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bouton ADD_s en construction...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void BR_Button_Del_S_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bouton DEL_S en construction...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void BR_Button_View_S_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bouton CONSULTER_s en construction...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void BR_Button_Undo_S_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bouton ANNULER_S en construction...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void BR_Button_Edit_S_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bouton EDITER_S en construction...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void BR_Button_Save_S_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bouton SAVE_S en construction...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void button_exit_G_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EnabledButton()
        {
            BR_Button_Add_S.BackgroundImage = global::Bate_s_Reservation_Base_Biblioteque.Properties.Resources.BR_list_add;
            BR_Button_Del_S.BackgroundImage = global::Bate_s_Reservation_Base_Biblioteque.Properties.Resources.BR_list_remove;
            BR_Button_View_S.BackgroundImage = global::Bate_s_Reservation_Base_Biblioteque.Properties.Resources.BR_layer_visible;
            BR_Button_Undo_S.BackgroundImage = global::Bate_s_Reservation_Base_Biblioteque.Properties.Resources.BR_Busy_S;
            BR_Button_Edit_S.BackgroundImage = global::Bate_s_Reservation_Base_Biblioteque.Properties.Resources.BR_notes_128x128;
            BR_Button_Save_S.BackgroundImage = global::Bate_s_Reservation_Base_Biblioteque.Properties.Resources.BR_document_save;
            BR_Button_Add_S.Enabled = true;
            BR_Button_Del_S.Enabled = true;
            BR_Button_View_S.Enabled = true;
            BR_Button_Undo_S.Enabled = true;
            BR_Button_Edit_S.Enabled = true;
            BR_Button_Save_S.Enabled = true;
        }

        private void DisableButton()
        {
            BR_Button_Add_S.BackgroundImage = global::Bate_s_Reservation_Base_Biblioteque.Properties.Resources.BR_list_add_block;
            BR_Button_Del_S.BackgroundImage = global::Bate_s_Reservation_Base_Biblioteque.Properties.Resources.BR_list_remove_block;
            BR_Button_View_S.BackgroundImage = global::Bate_s_Reservation_Base_Biblioteque.Properties.Resources.BR_layer_visible_block;
            BR_Button_Undo_S.BackgroundImage = global::Bate_s_Reservation_Base_Biblioteque.Properties.Resources.BR_Busy_Block_S;
            BR_Button_Edit_S.BackgroundImage = global::Bate_s_Reservation_Base_Biblioteque.Properties.Resources.BR_notes_128x128_Block;
            BR_Button_Save_S.BackgroundImage = global::Bate_s_Reservation_Base_Biblioteque.Properties.Resources.BR_document_save_block;
            BR_Button_Add_S.Enabled = false;
            BR_Button_Del_S.Enabled = false;
            BR_Button_View_S.Enabled = false;
            BR_Button_Undo_S.Enabled = false;
            BR_Button_Edit_S.Enabled = false;
            BR_Button_Save_S.Enabled = false;
        }
    }
}
