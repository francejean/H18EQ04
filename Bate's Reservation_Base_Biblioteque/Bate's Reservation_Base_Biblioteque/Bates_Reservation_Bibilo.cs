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
            BR_LA_Heure_G.Text = DateTime.Now.ToLongDateString();//its for current time
            BR_LA_Mode_G.Text = "Consutation";
            VisibleLabel_G(false, false, false, false, false, false, false, false);
            VisibleLabel_S(false, false, false, false, false, false);
        }

        #region VisibleLabel
        private void VisibleLabel_G(bool LA_Add_G, bool LA_Edit_G, bool LA_Undo_G, bool LA_Save_G, bool LA_Del_G, bool LA_View_G, bool LA_List_G, bool LA_Quit_G)
        {
            BR_LA_Add_G.Visible = LA_Add_G;
            BR_LA_Edit_G.Visible = LA_Edit_G;
            BR_LA_Undo_G.Visible = LA_Undo_G;
            BR_LA_Save_G.Visible = LA_Save_G;
            BR_LA_Del_G.Visible = LA_Del_G;
            BR_LA_View_G.Visible = LA_View_G;
            BR_LA_List_G.Visible = LA_List_G;
            BR_LA_Quit_G.Visible = LA_Quit_G;
        }
        private void VisibleLabel_S(bool LA_Add_S, bool LA_Edit_S, bool LA_Undo_S, bool LA_Save_S, bool LA_Del_S, bool LA_View_S)
        {
            BR_LA_Add_S.Visible = LA_Add_S;
            BR_LA_Edit_S.Visible = LA_Edit_S;
            BR_LA_Undo_S.Visible = LA_Undo_S;
            BR_LA_Save_S.Visible = LA_Save_S;
            BR_LA_Del_S.Visible = LA_Del_S;
            BR_LA_View_S.Visible = LA_View_S;
        }
        #endregion
        #region Button_G
        private void BR_Button_Add_G_Click(object sender, EventArgs e)
        {
            EnabledButton();
            BR_LA_Mode_G.Text = "Ajout";
        }
        private void BR_Button_Edit_G_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bouton MODIFIER en construction...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void BR_Button_Undo_G_Click(object sender, EventArgs e)
        {
            BR_LA_Heure_G.Text = DateTime.Now.ToLongDateString();//its for current time
            BR_LA_Mode_G.Text = "Consutation";
            DisableButton();
        }
        private void BR_Button_Save_G_Click(object sender, EventArgs e)
        {
            BR_LA_Heure_G.Text = DateTime.Now.ToLongDateString();//its for current time
            BR_LA_Mode_G.Text = "Consutation";
            DisableButton();
        }
        private void BR_Button_Del_G_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bouton SUPPRIMER en construction...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            BR_LA_Mode_G.Text = "Consutation";
        }
        private void BR_Button_View_G_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bouton CONSULTER en construction...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void BR_Button_List_G_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bouton LISTER en construction...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void BR_Button_Quit_G_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BR_Button_Add_G_MouseHover(object sender, EventArgs e)
        {
            VisibleLabel_G(true, false, false, false, false, false, false, false);
        }
        private void BR_Button_Add_G_MouseLeave(object sender, EventArgs e)
        {
            VisibleLabel_G(false, false, false, false, false, false, false, false);
        }
        private void BR_Button_Edit_G_MouseHover(object sender, EventArgs e)
        {
            VisibleLabel_G(false, true, false, false, false, false, false, false);
        }
        private void BR_Button_Edit_G_MouseLeave(object sender, EventArgs e)
        {
            VisibleLabel_G(false, false, false, false, false, false, false, false);
        }
        private void BR_Button_Undo_G_MouseHover(object sender, EventArgs e)
        {
            VisibleLabel_G(false, false, true, false, false, false, false, false);
        }
        private void BR_Button_Undo_G_MouseLeave(object sender, EventArgs e)
        {
            VisibleLabel_G(false, false, false, false, false, false, false, false);
        }
        private void BR_Button_Save_G_MouseHover(object sender, EventArgs e)
        {
            VisibleLabel_G(false, false, false, true, false, false, false, false);
        }
        private void BR_Button_Save_G_MouseLeave(object sender, EventArgs e)
        {
            VisibleLabel_G(false, false, false, false, false, false, false, false);
        }
        private void BR_Button_Del_G_MouseHover(object sender, EventArgs e)
        {
            VisibleLabel_G(false, false, false, false, true, false, false, false);

        }
        private void BR_Button_Del_G_MouseLeave(object sender, EventArgs e)
        {
            VisibleLabel_G(false, false, false, false, false, false, false, false);
        }
        private void BR_Button_View_G_MouseHover(object sender, EventArgs e)
        {
            VisibleLabel_G(false, false, false, false, false, true, false, false);
        }
        private void BR_Button_View_G_MouseLeave(object sender, EventArgs e)
        {
            VisibleLabel_G(false, false, false, false, false, false, false, false);
        }
        private void BR_Button_List_G_MouseHover(object sender, EventArgs e)
        {
            VisibleLabel_G(false, false, false, false, false, false, true, false);
        }
        private void BR_Button_List_G_MouseLeave(object sender, EventArgs e)
        {
            VisibleLabel_G(false, false, false, false, false, false, false, false);
        }
        private void BR_Button_Quit_G_MouseHover(object sender, EventArgs e)
        {
            VisibleLabel_G(false, false, false, false, false, false, false, true);
        }
        private void BR_Button_Quit_G_MouseLeave(object sender, EventArgs e)
        {
            VisibleLabel_G(false, false, false, false, false, false, false, false);
        }
        #endregion
        #region Button_S
        private void BR_Button_Add_S_Click(object sender, EventArgs e)
        {

        }
        private void BR_Button_Del_S_Click(object sender, EventArgs e)
        {

        }
        private void BR_Button_View_S_Click(object sender, EventArgs e)
        {

        }
        private void BR_Button_Undo_S_Click(object sender, EventArgs e)
        {
            BR_Button_Undo_G_Click(this, e);
        }
        private void BR_Button_Edit_S_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bouton EDITER_S en construction...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void BR_Button_Save_S_Click(object sender, EventArgs e)
        {
            BR_Button_Save_G_Click(this, e);
        }

        private void BR_Button_Add_S_MouseHover(object sender, EventArgs e)
        {
            VisibleLabel_S(true, false, false, false, false, false);
        }
        private void BR_Button_Add_S_MouseLeave(object sender, EventArgs e)
        {
            VisibleLabel_S(false, false, false, false, false, false);
        }
        private void BR_Button_Del_S_MouseHover(object sender, EventArgs e)
        {
            VisibleLabel_S(false, false, false, false, true, false);
        }
        private void BR_Button_Del_S_MouseLeave(object sender, EventArgs e)
        {
            VisibleLabel_S(false, false, false, false, false, false);
        }
        private void BR_Button_View_S_MouseHover(object sender, EventArgs e)
        {
            VisibleLabel_S(false, false, false, false, false, true);
        }
        private void BR_Button_View_S_MouseLeave(object sender, EventArgs e)
        {
            VisibleLabel_S(false, false, false, false, false, false);
        }
        private void BR_Button_Undo_S_MouseHover(object sender, EventArgs e)
        {
            VisibleLabel_S(false, false, true, false, false, false);
        }
        private void BR_Button_Undo_S_MouseLeave(object sender, EventArgs e)
        {
            VisibleLabel_S(false, false, false, false, false, false);
        }
        private void BR_Button_Edit_S_MouseHover(object sender, EventArgs e)
        {
            VisibleLabel_S(false, true, false, false, false, false);
        }
        private void BR_Button_Edit_S_MouseLeave(object sender, EventArgs e)
        {
            VisibleLabel_S(false, false, false, false, false, false);
        }
        private void BR_Button_Save_S_MouseHover(object sender, EventArgs e)
        {
            VisibleLabel_S(false, false, false, true, false, false);
        }
        private void BR_Button_Save_S_MouseLeave(object sender, EventArgs e)
        {
            VisibleLabel_S(false, false, false, false, false, false);
        }
        #endregion
        #region PixsChange
        private void EnabledButton()
        {
            BR_Button_Add_S.BackgroundImage = global::Bate_s_Reservation_Base_Biblioteque.Properties.Resources.BR_add_S;
            BR_Button_Del_S.BackgroundImage = global::Bate_s_Reservation_Base_Biblioteque.Properties.Resources.BR_list_remove_S;
            BR_Button_View_S.BackgroundImage = global::Bate_s_Reservation_Base_Biblioteque.Properties.Resources.BR_layer_visible_on_S;
            BR_Button_Undo_S.BackgroundImage = global::Bate_s_Reservation_Base_Biblioteque.Properties.Resources.BR_Cancel_S;
            BR_Button_Edit_S.BackgroundImage = global::Bate_s_Reservation_Base_Biblioteque.Properties.Resources.BR_Notes_S;
            BR_Button_Save_S.BackgroundImage = global::Bate_s_Reservation_Base_Biblioteque.Properties.Resources.BR_document_save_S;
            BR_Button_Gotoend_G.BackgroundImage = global::Bate_s_Reservation_Base_Biblioteque.Properties.Resources.BR_go_last_block_G;
            BR_Button_Gotofirst_G.BackgroundImage = global::Bate_s_Reservation_Base_Biblioteque.Properties.Resources.BR_go_first_block_G;
            BR_Button_Next_G.BackgroundImage = global::Bate_s_Reservation_Base_Biblioteque.Properties.Resources.BR_go_next_block_G;
            BR_Button_Previous_G.BackgroundImage = global::Bate_s_Reservation_Base_Biblioteque.Properties.Resources.BR_go_previous_block_G;
        }
        private void DisableButton()
        {
            BR_Button_Add_S.BackgroundImage = global::Bate_s_Reservation_Base_Biblioteque.Properties.Resources.BR_add_block_S;
            BR_Button_Del_S.BackgroundImage = global::Bate_s_Reservation_Base_Biblioteque.Properties.Resources.BR_list_remove_block_S;
            BR_Button_View_S.BackgroundImage = global::Bate_s_Reservation_Base_Biblioteque.Properties.Resources.BR_layer_visible_off_S;
            BR_Button_Undo_S.BackgroundImage = global::Bate_s_Reservation_Base_Biblioteque.Properties.Resources.BR_Cancel_Block_S;
            BR_Button_Edit_S.BackgroundImage = global::Bate_s_Reservation_Base_Biblioteque.Properties.Resources.BR_notes_128x128_Block;
            BR_Button_Save_S.BackgroundImage = global::Bate_s_Reservation_Base_Biblioteque.Properties.Resources.BR_document_save_Block_S;
            BR_Button_Gotoend_G.BackgroundImage = global::Bate_s_Reservation_Base_Biblioteque.Properties.Resources.BR_go_last_G;
            BR_Button_Gotofirst_G.BackgroundImage = global::Bate_s_Reservation_Base_Biblioteque.Properties.Resources.BR_go_first_G;
            BR_Button_Next_G.BackgroundImage = global::Bate_s_Reservation_Base_Biblioteque.Properties.Resources.BR_go_next_G;
            BR_Button_Previous_G.BackgroundImage = global::Bate_s_Reservation_Base_Biblioteque.Properties.Resources.BR_go_previous_G;
        }
        #endregion
    }
}
