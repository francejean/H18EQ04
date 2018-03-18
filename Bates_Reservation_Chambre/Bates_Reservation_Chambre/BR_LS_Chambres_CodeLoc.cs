using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bates_Reservation_Chambre
{
    public partial class BR_LS_Chambres_CodeLoc : Form
    {
        public BR_LS_Chambres_CodeLoc()
        {
            InitializeComponent();
        }

        private void BR_LS_Chambres_CodeLoc_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'dS_Bates_Reservation_Chambres.localisation'. Vous pouvez la déplacer ou la supprimer selon les besoins.
             // this.localisationTableAdapter.Fill(this.dS_Bates_Reservation_Chambres.localisation);
        }
        public DataGridView DBR_LS_DGW_Chambre
        {
            set
            {
                dBR_LS_DGW_Chambre = value;
            }
            get
            {
                return dBR_LS_DGW_Chambre;
            }
        }
    }
}
