using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Bates_Reservation_Transaction
{
    public partial class BR_Transactions : Bate_s_Reservation_Base_Biblioteque.Bates_Reservation_Bibilo
    {
        public BR_Transactions()
        {
            InitializeComponent();
        }

        private void BR_Transactions_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'bR_DS_Transactions.trx'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.BR_TA_Transactions.Fill(this.BR_DS_Transactions.trx);//gridview//
            
                Fill();
                LienTransactions();
        }

        private void LienTransactions()
        {
            this.BR_BS_Transactions_client.DataMember = "client";//bindingsource//
            this.BR_BS_Transactions_client.DataSource = this.BR_DS_Transactions;

            try
            {
                BR_TB_Transactions_NoCli.DataBindings.Add("Text", BR_BS_Transactions_client, "IdCli");//remplir textbox//
            }
            catch
            {

                throw;
            }
        }

        private void Fill()
        {
            this.BR_TA_Transactions_client.Fill(this.BR_DS_Transactions.client);
        }
    }
}
