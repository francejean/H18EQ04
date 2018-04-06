using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bates_Reservation_Chambres
{
    public partial class BR_LS_Chambres_CodeType : Form
    {
        public BR_LS_Chambres_CodeType()
        {
            InitializeComponent();
        }

        private void BR_LS_Chambres_CodeType_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'bR_DS_Chambres.typecham'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            // this.BR_LS_TA_Chambres_TypeChambre.Fill(this.BR_DS_Chambres.typecham);

        }

        public DataGridView DBR_LS_DGW_Chambre
        {
            set
            {
                BR_LS_DGV_Chambre = value;
            }
            get
            {
                return BR_LS_DGV_Chambre;
            }
        }

    }
}
