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
    public partial class AdminForm : Form
    {
        OrderList orderList;
        int curOrder = 0;
        Point lastpoint;
        public void Reload() 
        {
            Order order = orderList.list[curOrder];
            this.OrderNumberLabel.Text = "Заказ №" + order.Id;
            this.ContentLabel.Text = "Содержимое заказа: " + order.content;
            this.CostLabel.Text = order.finalCost + ",00 BYN";
            this.AddressLabel.Text = order.address;
            this.PhoneLabel.Text = order.phoneNumber;
            this.FIOLabel.Text = order.name;
        }
        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            orderList = new OrderList();
            orderList.Fill();
            Reload();

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            curOrder++;
            Reload();
            this.PrevButton.Enabled = true;
            if (orderList.maxLength <= curOrder + 1)
            {
                this.NextButton.Enabled = false;
            }
            
        }

        private void PrevButton_Click(object sender, EventArgs e)
        {
            curOrder--;
            Reload();
            this.NextButton.Enabled = true;
            if (0 <= curOrder)
            {
                this.PrevButton.Enabled = false;
            }
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
