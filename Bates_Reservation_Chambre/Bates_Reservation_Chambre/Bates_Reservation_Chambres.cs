using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Bates_Reservation_Chambre
{
    public partial class Bates_Reservation_Chambres : Bate_s_Reservation_Base_Biblioteque.BR_Biblio
    {
        public Bates_Reservation_Chambres()
        {
            InitializeComponent();
            
        }

        private void Bates_Reservation_Chambres_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'DS_Bates_Reservation_Chambres.ayant'. Vous pouvez la déplacer ou la supprimer selon les besoins.
//            this.ayantTableAdapter.Fill(this.DS_Bates_Reservation_Chambres.ayant);
            Fill();
            LienChambre();
        }

        private void Fill()
        {
 //           this.TA_BR_Chambre.Fill(this.DS_Bates_Reservation_Chambres.chambre);
        }

        private void LienChambre()
        {
            this.BR_BS_Chambre.DataMember = "chambre";
            this.BR_BS_Chambre.DataSource = this.DS_Bates_Reservation_Chambres;

            try
            {
                BR_TB_Chambre_NoCham.DataBindings.Add("Text", BR_BS_Chambre, "NoCham");
                BR_TB_Chambres_Etage.DataBindings.Add("Text", BR_BS_Chambre, "Etage");
                BR_TB_Chambres_Etat.DataBindings.Add("Text", BR_BS_Chambre, "Etat");
                BR_TB_Chambre_CodeType.DataBindings.Add("Text", BR_BS_Chambre, "CodTypCham");
                BR_TB_Chambre_CodeLoc.DataBindings.Add("Text", BR_BS_Chambre, "CodLoc");
                BR_TB_Chambres_Prix.DataBindings.Add("Text", BR_BS_Chambre, "Prix");
                BR_TB_Chambres_Desc1.DataBindings.Add("Text", BR_BS_Chambre, "DescCom");
                BR_TB_Chambres_Desc2.DataBindings.Add("Text", BR_BS_Chambre, "DescLoc");

            }
            catch
            {
                throw;
            }
        }

        private void BR_Button_Next_G_Click(object sender, EventArgs e)
        {
            BR_BS_Chambre.MoveNext();
        }

        private void BR_Button_Gotoend_G_Click(object sender, EventArgs e)
        {
            try
            {
                BR_BS_Chambre.MoveLast();
            }
            catch
            {
                throw;
            }
            
        }

        private void BR_Button_Previous_G_Click(object sender, EventArgs e)
        {
            try
            {
                BR_BS_Chambre.MovePrevious();
            }
            catch
            {
                throw;
            }
        }

        private void BR_Button_Gotofirst_G_Click(object sender, EventArgs e)
        {
            BR_BS_Chambre.MoveFirst();
        }

        private void BR_TB_Chambre_NoCham_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
            int temp = BR_BS_Chambre.Position;
            BR_LS_Chambres_NoCham BR_LS_NoCham = new BR_LS_Chambres_NoCham();
            BR_LS_NoCham.DBR_LS_DGW_Chambre.DataSource = BR_BS_Chambre;
            if (BR_LS_NoCham.ShowDialog() == DialogResult.Cancel)
            {
                BR_BS_Chambre.Position = temp;
            }
        }

        private void BR_TB_Chambre_CodeType_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int temp = BR_BS_Chambre.Position;
            BR_LS_Chambres_CodeType BR_LS_CodeType = new BR_LS_Chambres_CodeType();
            BR_LS_CodeType.DBR_LS_DGW_Chambre.DataSource = BR_BS_Chambre;
            if (BR_LS_CodeType.ShowDialog() == DialogResult.Cancel)
            {
                BR_BS_Chambre.Position = temp;
            }
        }

        private void BR_TB_Chambre_CodeLoc_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int temp = BR_BS_Chambre.Position;
            BR_LS_Chambres_CodeLoc BR_LS_CodeLoc = new BR_LS_Chambres_CodeLoc();
            BR_LS_CodeLoc.DBR_LS_DGW_Chambre.DataSource = BR_BS_Chambre;
            if (BR_LS_CodeLoc.ShowDialog() == DialogResult.Cancel)
            {
                BR_BS_Chambre.Position = temp;
            }
        }

        private void BR_Quit_G_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
