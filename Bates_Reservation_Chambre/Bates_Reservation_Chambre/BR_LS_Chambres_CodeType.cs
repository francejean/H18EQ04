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
    public partial class BR_LS_Chambres_CodeType : Form
    {
        public BR_LS_Chambres_CodeType()
        {
            InitializeComponent();
        }

        private void BR_LS_Chambres_CodeType_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'dS_Bates_Reservation_Chambres.typecham'. Vous pouvez la déplacer ou la supprimer selon les besoins.
           // this.typechamTableAdapter.Fill(this.dS_Bates_Reservation_Chambres.typecham);

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
