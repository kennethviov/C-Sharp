using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroceryStroreDiscountGUI.Components
{

    public partial class ProductItem: UserControl
    {

        public ProductItem()
        {
            InitializeComponent();

            foreach (Control control in this.Controls)
            {
                control.Click += (s, e) => this.OnClick(e); // Redirect click to UserControl
            }
        }

        public Image ProductImage
        {
            get => pictureBox1.Image;
            set => pictureBox1.Image = value;
        }

        public string ProducTitle
        {
            get => label1.Text;
            set => label1.Text = value;
        }

        public double ProductPrice
        {
            get => double.Parse(label2.Text);
            set => label2.Text = value.ToString("F2");
        }

        public string Category
        { get; set; }
    }
}
