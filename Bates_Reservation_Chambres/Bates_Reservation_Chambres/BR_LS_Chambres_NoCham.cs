﻿using System;
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
    public partial class BR_LS_Chambres_NoCham : Form
    {
        public BR_LS_Chambres_NoCham()
        {
            InitializeComponent();
        }
        private void BR_LS_Chambres_NoCham_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'bR_DS_Chambres.chambre'. Vous pouvez la déplacer ou la supprimer selon les besoins.
           //  this.chambreTableAdapter.Fill(this.bR_DS_Chambres.chambre);
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
