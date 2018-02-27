using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Bates_Reservation_Chambre
{
    public partial class Bates_Reservation_Chambre : Bate_s_Reservation_Base_Biblioteque.Bates_Reservation_Bibilo
    {
        public Bates_Reservation_Chambre()
        {
            InitializeComponent();
        }

        private void Bates_Reservation_Chambre_Load(object sender, EventArgs e)
        {
            {
                Fill();
                LienChambre();
            }
        }

        private void LienChambre()
        {
            this.BS_BR_Chambre.DataMember = "chambre";
            this.BS_BR_Chambre.DataSource = this.DS_Bates_Reservation_Chambres;

            try
            {
                BR_TextBox_Info_S_NoCham.DataBindings.Add("text", BS_BR_Chambre, "NoCham");
            }
            catch
            {

                throw;
            }
        }

        private void Fill()
        {
            //this.TA_BR_Chambre.Fill(this.DS_Bates_Reservation_Chambres.chambre);
        }
    }
}
