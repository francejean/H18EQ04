using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bates_Reservation_Transactions
{
    public partial class BR_LS_Transaction : Form
    {
        public BR_LS_Transaction()
        {
            InitializeComponent();
        }

        private void BR_FO_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'dS_Bates_Reservation_Chambres.chambre'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            // this.chambreTableAdapter.Fill(this.dS_Bates_Reservation_Chambres.chambre);

        }

        public DataGridView DBR_LS_DGW_arrive
        {
            set
            {
                BR_LS_DGW_arrive = value;
            }
            get
            {
                return BR_LS_DGW_arrive;
            }
        }
    }
}
