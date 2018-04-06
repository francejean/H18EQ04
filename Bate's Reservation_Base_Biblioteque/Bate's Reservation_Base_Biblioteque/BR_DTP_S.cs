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
    public partial class BR_DTP_S : DateTimePicker
    {
        public BR_DTP_S()
        {
            InitializeComponent();
            this.CustomFormat = "yyyy/mm/dd";
            this.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Name = "Bates_Reservation_dateTimePicker_S";
            this.Size = new System.Drawing.Size(99, 20);
            this.TabIndex = 48;
        }
    }
}
