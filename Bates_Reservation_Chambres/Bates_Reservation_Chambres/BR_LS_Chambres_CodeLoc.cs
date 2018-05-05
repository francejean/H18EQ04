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
    public partial class BR_LS_Chambres_CodeLoc : Form
    {
        public BR_LS_Chambres_CodeLoc()
        {
            InitializeComponent();
        }
        private void BR_LS_Chambres_CodeLoc_Load(object sender, EventArgs e)
        {

        }
        public DataGridView DBR_LS_DGW_Chambre_CodeLoc
        {
            set
            {
                BR_LS_DGW_Chambre_CodeLoc = value;
            }
            get
            {
                return BR_LS_DGW_Chambre_CodeLoc;
            }
        }


    }
}
