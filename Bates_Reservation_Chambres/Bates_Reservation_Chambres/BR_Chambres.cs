using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Bates_Reservation_Chambres
{
    public partial class BR_Chambres : Bate_s_Reservation_Base_Biblioteque.BR_Biblio
    {
        public BR_Chambres()
        {
            InitializeComponent();
        }

        private void BR_Chambres_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'BR_DS_Chambres.ayant'. Vous pouvez la déplacer ou la supprimer selon les besoins.
             this.BR_TA_Chambres_Ayant.Fill(this.BR_DS_Chambres.ayant);
            Fill();
            LienChambre();
        }

        private void Fill()
        {
            this.BR_TA_Chambres.Fill(this.BR_DS_Chambres.chambre);
        }

        private void LienChambre()
        {
            this.BR_BS_Chambres.DataMember = "chambre";
            this.BR_BS_Chambres.DataSource = this.BR_DS_Chambres;

            try
            {
                BR_TB_Chambres_NoCham.DataBindings.Add("Text", BR_BS_Chambres, "NoCham");
                BR_TB_Chambres_Etage.DataBindings.Add("Text", BR_BS_Chambres, "Etage");
                BR_TB_Chambres_Etat.DataBindings.Add("Text", BR_BS_Chambres, "Etat");
                BR_TB_Chambre_CodeType.DataBindings.Add("Text", BR_BS_Chambres, "CodTypCham");
                BR_TB_Chambre_CodeLoc.DataBindings.Add("Text", BR_BS_Chambres, "CodLoc");
                BR_TB_Chambres_Prix.DataBindings.Add("Text", BR_BS_Chambres, "Prix");
                BR_TB_Chambres_Desc1.DataBindings.Add("Text", BR_BS_Chambres, "DescLoc");
                BR_TB_Chambres_Desc2.DataBindings.Add("Text", BR_BS_Chambres, "DescTyp");

            }
            catch
            {
                throw;
            }
        }
        private void enabled()
        {
            BR_TB_Chambres_NoCham.Enabled = true;
            BR_TB_Chambres_Etage.Enabled = true;
            BR_TB_Chambres_Etat.Enabled = true;
            BR_TB_Chambre_CodeType.Enabled = true;
            BR_TB_Chambre_CodeLoc.Enabled = true;
            BR_TB_Chambres_Prix.Enabled = true;
            BR_TB_Chambres_Desc1.Enabled = true;
            BR_TB_Chambres_Desc2.Enabled = true;
        }

        private void disabled()
        {
            BR_TB_Chambres_NoCham.Enabled = false;
            BR_TB_Chambres_Etage.Enabled = false;
            BR_TB_Chambres_Etat.Enabled = false;
            BR_TB_Chambre_CodeType.Enabled = false;
            BR_TB_Chambre_CodeLoc.Enabled = false;
            BR_TB_Chambres_Prix.Enabled = false;
            BR_TB_Chambres_Desc1.Enabled = false;
            BR_TB_Chambres_Desc2.Enabled = false;
        }

        private void BR_Button_Add_G_Click(object sender, EventArgs e)
        {
            enabled();
        }
        
        private void BR_Button_Gotofirst_G_Click(object sender, EventArgs e)
        {
            BR_BS_Chambres.MoveFirst();
        }

        private void BR_Button_Previous_G_Click(object sender, EventArgs e)
        {
            BR_BS_Chambres.MovePrevious();
        }

        private void BR_Button_Next_G_Click(object sender, EventArgs e)
        {
            BR_BS_Chambres.MoveNext();
        }

        private void BR_Button_Gotoend_G_Click(object sender, EventArgs e)
        {
            BR_BS_Chambres.MoveLast();
        }

        private void BR_TB_Chambre_NoCham_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int temp = BR_BS_Chambres.Position;
            BR_LS_Chambres_NoCham BR_LS_NoCham = new BR_LS_Chambres_NoCham();
            BR_LS_NoCham.DBR_LS_DGW_Chambre.DataSource = BR_BS_Chambres;
            if (BR_LS_NoCham.ShowDialog() == DialogResult.Cancel)
            {
                BR_BS_Chambres.Position = temp;
            }
        }

         private void BR_TB_Chambre_CodeType_MouseDoubleClick(object sender, MouseEventArgs e)
         {
             int temp = BR_BS_Chambres.Position;
             BR_LS_Chambres_CodeType BR_LS_CodeType = new BR_LS_Chambres_CodeType();
             BR_LS_CodeType.DBR_LS_DGW_Chambre.DataSource = BR_BS_Chambres;
             if (BR_LS_CodeType.ShowDialog() == DialogResult.Cancel)
             {
                 BR_BS_Chambres.Position = temp;
             }
         }

         private void BR_TB_Chambre_CodeLoc_MouseDoubleClick(object sender, MouseEventArgs e)
         {
             int temp = BR_BS_Chambres.Position;
             BR_LS_Chambres_CodeLoc BR_LS_CodeLoc = new BR_LS_Chambres_CodeLoc();
             BR_LS_CodeLoc.DBR_LS_DGW_Chambre.DataSource = BR_BS_Chambres;
             if (BR_LS_CodeLoc.ShowDialog() == DialogResult.Cancel)
             {
                 BR_BS_Chambres.Position = temp;
             }
         }

        private void BR_Button_Undo_G_Click(object sender, EventArgs e)
        {
            disabled();
        }

        private void BR_Button_Save_G_Click(object sender, EventArgs e)
        {
            disabled();
        }
    }
}
