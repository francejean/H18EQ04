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

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("En construction...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
