using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bate_s_Reservation_Base_Biblioteque
{
    public partial class BR_CB_S : ComboBox
    {
        public BR_CB_S()
        {
            InitializeComponent();

            this.BackColor = System.Drawing.SystemColors.Control;
            this.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FormattingEnabled = true;
            this.Name = "BR_CB_S";
            this.Size = new System.Drawing.Size(121, 21);
            this.TabIndex = 49;
        }
    }
}
