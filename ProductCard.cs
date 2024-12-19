using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace BIGBREWdaw
{
    class ProductCard : Button
    {
        public int productId { get; set; }

        public PictureBox ProductImg = new PictureBox();
        public Label ProductName = new Label();
        public Label Price = new Label();

        public ProductCard()
        {

            this.productId = productId;

            this.Size = new Size(167, 240);
            this.Padding = new Padding(0, 0, 0, 0);

            this.ProductImg.SizeMode = PictureBoxSizeMode.Zoom;
            this.ProductImg.Size = new Size(167, 200);

            this.ProductName.Size = new Size(167, 23);
            this.ProductName.Location = new Point(0, 200);
            this.ProductName.ForeColor = Color.Black;
            this.ProductName.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
            this.ProductName.TextAlign = ContentAlignment.MiddleCenter;

            this.Price.Size = new Size(167, 23);
            this.Price.Location = new Point(0, 220);
            this.Price.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
            this.Price.TextAlign = ContentAlignment.MiddleCenter;

            this.Controls.Add(this.ProductName);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.ProductImg);

            this.ProductImg.Click += ProductCard_ChildClick;
            this.Price.Click += ProductCard_ChildClick;
            this.ProductName.Click += ProductCard_ChildClick;
        }

        private void ProductCard_ChildClick(object sender, EventArgs e)
        {
            this.PerformClick();
        }
    }
}
