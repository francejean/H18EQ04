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
    public partial class Label_S : Label
    {
        public Label_S()
        {
            InitializeComponent();

            this.AutoSize = true;
            this.Location = new System.Drawing.Point(9, 329);
            this.Name = "label2";
            this.Size = new System.Drawing.Size(70, 13);
            this.Text = "Label_Info_S";
        }
    }
}
