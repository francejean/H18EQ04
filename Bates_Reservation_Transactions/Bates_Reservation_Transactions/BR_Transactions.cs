using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Bates_Reservation_Transactions
{
    public partial class BR_Transactions : Bate_s_Reservation_Base_Biblioteque.BR_Biblio
    {
        public BR_Transactions()
        {
            InitializeComponent();
            disabled();
        }

        private void BR_Transactions_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'bR_DS_Transactions.trx'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.BR_TA_Transactions_Reservation.Fill(this.BR_DS_Transactions.trx);//gridview//

            Fill();
            LienTransactions();
        }

        private void LienTransactions()
        {
            this.BR_BS_Transactions_client.DataMember = "client";//bindingsource//
            this.BR_BS_Transactions_client.DataSource = this.BR_DS_Transactions;
            this.BR_BS_Transactions_arrive.DataMember = "arrive";//bindingsource//
            this.BR_BS_Transactions_arrive.DataSource = this.BR_DS_Transactions;
            this.BR_BS_Transactions_Reservation.DataMember = "reservation";//bindingsource//
            this.BR_BS_Transactions_Reservation.DataSource = this.BR_DS_Transactions;


            try
            {
                BR_TB_Transactions_NoCli.DataBindings.Add("Text", BR_BS_Transactions_arrive, "IdCli");//remplir textbox//
                BR_TB_Transactions_NomCli.DataBindings.Add("Text", BR_BS_Transactions_arrive, "Nom");
                BR_TB_Transaction_TelCli.DataBindings.Add("Text", BR_BS_Transactions_arrive, "Telephone");
                BR_TB_Transaction_NoArrive.DataBindings.Add("Text", BR_BS_Transactions_arrive, "IdArrive");
                BR_TB_Transaction_NoReservation.DataBindings.Add("Text", BR_BS_Transactions_arrive, "IdReser");
                BR_TB_Transaction_NoChambre.DataBindings.Add("Text", BR_BS_Transactions_arrive, "NoCham");
                BR_TB_Transaction_DateReserve.DataBindings.Add("Text", BR_BS_Transactions_arrive, "DateReser");
                BR_TB_Transaction_DateDebut.DataBindings.Add("Text", BR_BS_Transactions_arrive, "DateDebut");
                BR_TB_Transaction_DateFin.DataBindings.Add("Text", BR_BS_Transactions_arrive, "DateFin");
            }
            catch
            {

                throw;
            }
        }

        private void Fill()
        {
            this.BR_TA_Transactions_Transaction.Fill(this.BR_DS_Transactions.trx);
            this.BR_TA_Transactions_Client.Fill(this.BR_DS_Transactions.client);
            this.BR_TA_Transactions_Arrive.Fill(this.BR_DS_Transactions.arrive);
            //this.BR_TA_Transactions_Reservation.Fill(this.BR_DS_Transactions.reservation);
        }



        private void Bates_Reservation_TabControl_S_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int temp = BR_BS_Transactions_arrive.Position;
            BR_LS_Transaction BR_listeSelection = new BR_LS_Transaction();
            BR_listeSelection.DBR_LS_DGW_arrive.DataSource = BR_BS_Transactions_arrive;
            if (BR_listeSelection.ShowDialog() == DialogResult.Cancel)
            {
                BR_BS_Transactions_arrive.Position = temp;
            }


        }

        private void enabled()
        {
            BR_TB_Transactions_NoCli.Enabled = true;
            BR_TB_Transactions_NomCli.Enabled = true;
            BR_TB_Transaction_TelCli.Enabled = true;
            BR_TB_Transaction_NoArrive.Enabled = true;
            BR_TB_Transaction_NoReservation.Enabled = true;
            BR_TB_Transaction_NoChambre.Enabled = true;
            BR_TB_Transaction_DateReserve.Enabled = true;
            BR_TB_Transaction_DateDebut.Enabled = true;
            BR_TB_Transaction_DateFin.Enabled = true;
        }

        private void disabled()
        {
            BR_TB_Transactions_NoCli.Enabled = false;
            BR_TB_Transactions_NomCli.Enabled = false;
            BR_TB_Transaction_TelCli.Enabled = false;
            BR_TB_Transaction_NoArrive.Enabled = false;
            BR_TB_Transaction_NoReservation.Enabled = false;
            BR_TB_Transaction_NoChambre.Enabled = false;
            BR_TB_Transaction_DateReserve.Enabled = false;
            BR_TB_Transaction_DateDebut.Enabled = false;
            BR_TB_Transaction_DateFin.Enabled = false;
        }

        private void Bates_Reservation_Button_Next_G_Click(object sender, EventArgs e)
        {
            BR_BS_Transactions_arrive.MoveNext();
        }


        private void Bates_Reservation_Button_Gotoend_G_Click(object sender, EventArgs e)
        {
            BR_BS_Transactions_arrive.MoveLast();
        }

        private void Bates_Reservation_Button_Previous_G_Click(object sender, EventArgs e)
        {
            BR_BS_Transactions_arrive.MovePrevious();
        }

        private void Bates_Reservation_Button_Gotofirst_G_Click(object sender, EventArgs e)
        {
            BR_BS_Transactions_arrive.MoveFirst();
        }

        private void BR_Button_Add_G_Click(object sender, EventArgs e)
        {
            enabled();
        }
    }
}
