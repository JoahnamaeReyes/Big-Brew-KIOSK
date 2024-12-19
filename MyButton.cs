using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace BIGBREWdaw
{
    class MyButton : Button
    {
        public int id { get; set; }

        public MyButton()
        {
            this.BackColor = Color.White;
            this.ForeColor = Color.Black;
        }
    }
}
