﻿using System;
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

        public DataGridView DBR_LS_DGV_arrive
        {
            set
            {
                BR_LS_DGV_arrive = value;
            }
            get
            {
                return BR_LS_DGV_arrive;
            }
        }

        private void BR_LS_Transaction_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'bR_DS_Transactions.arrive'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.arriveTableAdapter.Fill(this.bR_DS_Transactions.arrive);

        }
    }
}
