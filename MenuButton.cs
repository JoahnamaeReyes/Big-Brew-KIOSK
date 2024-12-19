using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace BIGBREWdaw
{
    class MenuButton : Button
    {
        public int MenuID { get; set; }    

        public MenuButton()
        {
            this.AutoSize = true;
            this.Font = new Font("Microsoft Sans Serif", 12);
            this.Padding = new Padding(15, 0, 0, 0);
            this.Size = new Size(165, 40);
            this.TextAlign = ContentAlignment.MiddleLeft;
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.Margin = new Padding(0, 0, 0, 0);
        }
    }
}
