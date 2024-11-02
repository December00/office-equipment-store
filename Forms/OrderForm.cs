using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using АРМ_продавца_офисной_техники.Classes;

namespace АРМ_продавца_офисной_техники
{
    public partial class OrderForm : Form
    {
        BasketItems basket;
        BasketForm basketForm;
        Point lastpoint;
        public OrderForm(BasketItems basket, BasketForm basketForm)
        {
            InitializeComponent();
            this.basket = basket;
            this.basketForm = basketForm;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Order order = new Order(this.FIOTextBox.Text, this.AddressTextBox.Text, this.PhoneTextBox.Text);
            if (order.MakeOrder(basket))
            {
                this.Close();
                basketForm.Reload();
                basketForm.SwitchOrderButton();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {

        }

        private void TopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastpoint = new Point(e.X, e.Y);
        }

        private void TopPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                this.Left += e.X - lastpoint.X;
                this.Top += e.Y - lastpoint.Y;

            }
        }
    }
}
