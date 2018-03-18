using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Bates_Reservation_Reservation
{
    public partial class BR_Reservation : Bate_s_Reservation_Base_Biblioteque.Bates_Reservation_Bibilo
    {
        public BR_Reservation()
        {
            InitializeComponent();
        }

        private void Bates_Reservation_Reservation_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'dS_Bates_Reservation_Reservation.de'. Vous pouvez la déplacer ou la supprimer selon les besoins.
           // this.deTableAdapter.Fill(this.dS_Bates_Reservation_Reservation.de);

        }

        private void BR_Reservation_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'dS_Bates_Reservation_Reservation.chambre'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.chambreTableAdapter.Fill(this.dS_Bates_Reservation_Reservation.chambre);
            // TODO: cette ligne de code charge les données dans la table 'dS_Bates_Reservation_Reservation.client'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.BR_TA_client.Fill(this.dS_Bates_Reservation_Reservation.client);
            // TODO: cette ligne de code charge les données dans la table 'dS_Bates_Reservation_Reservation1.de'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.BR_TA_de.Fill(this.dS_Bates_Reservation_Reservation1.de);
            // TODO: cette ligne de code charge les données dans la table 'dS_Bates_Reservation_Reservation.de'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.BR_TA_de.Fill(this.dS_Bates_Reservation_Reservation.de);
            Fill();
            LienReservation();
        }

        private void LienReservation()
        {

            this.BR_BS_client.DataMember = "client";
            this.BR_BS_client.DataSource = this.dS_Bates_Reservation_Reservation;

            try
            {
                BR_TB_reservation_IdClient.DataBindings.Add("Text", BR_BS_client, "IdClient");
               /* BR_TB_Chambres_Etage.DataBindings.Add("Text", BS_BR_Chambre, "Etage");
                BR_TB_Chambres_Etat.DataBindings.Add("Text", BS_BR_Chambre, "Etat");
                BR_CB_Chambre_CodeType.DataBindings.Add("Text", BS_BR_Chambre, "CodTypCham");
                BR_CB_Chambre_CodeLoc.DataBindings.Add("Text", BS_BR_Chambre, "CodLoc");
                BR_TB_Chambres_Prix.DataBindings.Add("Text", BS_BR_Chambre, "Prix");*/

            }
            catch
            {

                throw;
            }
        }

        private void Fill()
        {
            this.BR_TA_client.Fill(this.dS_Bates_Reservation_Reservation.client);
        }
    }
}
