using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bates_Reservation_Reservation
{
    public partial class BR_LS_Reservation : Form
    {
        public BR_LS_Reservation()
        {
            InitializeComponent();
        }

        public DataGridView DBR_LS_DGW_Resr
        {
            set
            {
                BR_LS_DGW_Reser = value;
            }
            get
            {
                return BR_LS_DGW_Reser;
            }
        }
    }
}
