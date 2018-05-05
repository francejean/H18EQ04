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
    public partial class BR_LS_Chambres_CodeCom : Form
    {
        public BR_LS_Chambres_CodeCom()
        {
            InitializeComponent();
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
