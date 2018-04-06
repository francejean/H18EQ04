using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Bates_Reservation_Reservation
{
    public partial class BR_Reservation_Reservation : Bate_s_Reservation_Base_Biblioteque.BR_Biblio
    {
        public BR_Reservation_Reservation()
        {
            InitializeComponent();
            disabled();
        }

        private void Bates_Reservation_Reservation_Load(object sender, EventArgs e)
        {

            Fill();
            LienReservation();

        }



        private void LienReservation()
        {

            this.BR_BS_Reservation_Client.DataMember = "client";
            this.BR_BS_Reservation_Client.DataSource = this.BR_DS_Reservations;
            this.BR_BS_Reservation_Chambre.DataMember = "chambre";
            this.BR_BS_Reservation_Chambre.DataSource = this.BR_DS_Reservations;
            this.BR_BS_Reservation_Reserv.DataMember = "reservation";
            this.BR_BS_Reservation_Reserv.DataSource = this.BR_DS_Reservations;
            this.BR_BS_Reservation_De.DataSource = this.BR_BS_Reservation_Reserv;
            this.BR_BS_Reservation_De.DataMember = "FK__de__IdReser__6EE06CCD";

            try
            {
                BR_TB_reservation_IdClient.DataBindings.Add("Text", BR_BS_Reservation_Client, "IdCli");
                BR_TB_Reservation_Nom.DataBindings.Add("Text", BR_BS_Reservation_Client, "Nom");
                BR_TB_Reservation_Adresse.DataBindings.Add("Text", BR_BS_Reservation_Client, "Adresse");
                BR_TB_Reservation_Telephone.DataBindings.Add("Text", BR_BS_Reservation_Client, "Telephone");
                BR_TB_Reservation_Carte.DataBindings.Add("Text", BR_BS_Reservation_Client, "TypeCarte");
                BR_TB_Reservation_Expiration.DataBindings.Add("Text", BR_BS_Reservation_Client, "DateExp");
                BR_TB_Reservation_Solde.DataBindings.Add("Text", BR_BS_Reservation_Client, "SoldDu");
                BR_TB_Reservation_No.DataBindings.Add("Text", BR_BS_Reservation_Reserv, "IdReser");
                date.DataBindings.Add("Text", BR_BS_Reservation_Reserv, "DateReser");
                BR_DTP_Reservation_DateDebut.DataBindings.Add("Text", BR_BS_Reservation_Reserv, "DateDebut");
                BR_DTP_Reservation_DateFin.DataBindings.Add("Text", BR_BS_Reservation_Reserv, "DateFin");
            }
            catch
            {

                throw;
            }
        }

        private void Fill()
        {
            this.BR_TA_Reservation_Client.Fill(this.BR_DS_Reservations.client);
            this.BR_TA_Reservation_Chambre.Fill(this.BR_DS_Reservations.chambre);
            this.BR_TA_Reservation_de.Fill(this.BR_DS_Reservations.de);
            try { this.BR_TA_Reservation_Reserv.Fill(this.BR_DS_Reservations.reservation); }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }

        }

        private void Bates_Reservation_Button_Gotoend_G_Click(object sender, EventArgs e)
        {
            BR_BS_Reservation_Reserv.MoveLast();
        }

        private void Bates_Reservation_Button_Next_G_Click(object sender, EventArgs e)
        {
            BR_BS_Reservation_Reserv.MoveNext();
        }

        private void Bates_Reservation_Button_Previous_G_Click(object sender, EventArgs e)
        {
            BR_BS_Reservation_Reserv.MovePrevious();
        }

        private void Bates_Reservation_Button_Gotofirst_G_Click(object sender, EventArgs e)
        {
            BR_BS_Reservation_Reserv.MoveFirst();
        }

        private void Bates_Reservation_TabControl_S_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
            int temp = BR_BS_Reservation_Reserv.Position;
            BR_LS_Reservation BR_listeSelection = new BR_LS_Reservation();
            BR_listeSelection.DBR_LS_DGW_Resr.DataSource = BR_BS_Reservation_Reserv;
            if (BR_listeSelection.ShowDialog() == DialogResult.Cancel)
            {
                BR_BS_Reservation_Reserv.Position = temp;
            }
        }

        private void BR_TB_Reservation_No_TextChanged(object sender, EventArgs e)
        {
            BR_BS_Reservation_Client.Position = BR_BS_Reservation_Client.Find("IdCli", BR_DS_Reservations.client.Rows[BR_BS_Reservation_Reserv.Position]["IdCli"]);
        }

        private void enabled()
        {
            BR_TB_reservation_IdClient.Enabled = true;
            BR_TB_Reservation_Nom.Enabled = true;
            BR_TB_Reservation_Adresse.Enabled = true;
            BR_TB_Reservation_Telephone.Enabled = true;
            BR_TB_Reservation_Carte.Enabled = true;
            BR_TB_Reservation_Expiration.Enabled = true;
            BR_TB_Reservation_Solde.Enabled = true;
            BR_TB_Reservation_No.Enabled = true;
            date.Enabled = true;
            BR_DTP_Reservation_DateDebut.Enabled = true;
            BR_DTP_Reservation_DateFin.Enabled = true;
            BR_DTP_Reservation_ReserveLe.Enabled = true;
        }

        private void disabled()
        {
            BR_TB_reservation_IdClient.Enabled = false;
            BR_TB_Reservation_Nom.Enabled = false;
            BR_TB_Reservation_Adresse.Enabled = false;
            BR_TB_Reservation_Telephone.Enabled = false;
            BR_TB_Reservation_Carte.Enabled = false;
            BR_TB_Reservation_Expiration.Enabled = false;
            BR_TB_Reservation_Solde.Enabled = false;
            BR_TB_Reservation_No.Enabled = false;
            date.Enabled = false;
            BR_DTP_Reservation_DateDebut.Enabled = false;
            BR_DTP_Reservation_DateFin.Enabled = false;
            BR_DTP_Reservation_ReserveLe.Enabled = false;
        }

        private void BR_Button_Add_G_Click(object sender, EventArgs e)
        {
            enabled();
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
