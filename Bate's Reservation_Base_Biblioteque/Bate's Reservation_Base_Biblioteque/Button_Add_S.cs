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
    public partial class Button_Add_S : Button
    {
        public Button_Add_S()
        {
            InitializeComponent();

            this.BackgroundImage = global::Bate_s_Reservation_Base_Biblioteque.Properties.Resources.folder_add;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FlatAppearance.BorderSize = 0;
            this.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Name = "Button_Add_S";
            this.Size = new System.Drawing.Size(53, 51);
            this.Text = "button1";
            this.UseVisualStyleBackColor = true;
        }
    }
}
