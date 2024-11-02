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
    public partial class BasketForm : Form
    {
        Point lastpoint;
        User user;
        BasketItems basket;
        RegAuthForm regAuthForm;
        public BasketForm(User user, RegAuthForm regAuthForm)
        {
            this.user = user;
            InitializeComponent();
            basket = new BasketItems(user.login);
            this.regAuthForm = regAuthForm;

        }
        public void Reload()
        {
            switch (basket.items.curLength)
            {
                case 0:
                    {
                        this.Item1Panel.Visible = false;

                        this.Item2Panel.Visible = false;

                        this.Item3Panel.Visible = false;
                        break;
                    }
                case 1:
                    {
                        this.Item1CostLabel.Text = basket.items.list[0].cost.ToString() + ",00 BYN";
                        this.Item1AmountLabel.Text = basket.items.list[0].amount.ToString();
                        this.Item1DescrlLabel.Text = basket.items.list[0].description;
                        this.Item1ModelLabel.Text = basket.items.list[0].model + " " + basket.items.list[0].model;
                        this.Item2Panel.Visible = false;

                        this.Item3Panel.Visible = false;
                        break;
                    }
                case 2:
                    {
                        this.Item1CostLabel.Text = basket.items.list[0].cost.ToString() + ",00 BYN";
                        this.Item1AmountLabel.Text = basket.items.list[0].amount.ToString();
                        this.Item1DescrlLabel.Text = basket.items.list[0].description;
                        this.Item1ModelLabel.Text = basket.items.list[0].model + " " + basket.items.list[0].model;

                        this.Item2CostLabel.Text = basket.items.list[1].cost.ToString() + ",00 BYN";
                        this.Item2AmountLabel.Text = basket.items.list[1].amount.ToString();
                        this.Item2DescrlLabel.Text = basket.items.list[1].description;
                        this.Item2ModelLabel.Text = basket.items.list[1].model + " " + basket.items.list[1].model;
                        this.Item3Panel.Visible = false;
                        break;
                    }
                case 3:
                    {
                        this.Item1CostLabel.Text = basket.items.list[0].cost.ToString() + ",00 BYN";
                        this.Item1AmountLabel.Text = basket.items.list[0].amount.ToString();
                        this.Item1DescrlLabel.Text = basket.items.list[0].description;
                        this.Item1ModelLabel.Text = basket.items.list[0].model + " " + basket.items.list[0].model;

                        this.Item2CostLabel.Text = basket.items.list[1].cost.ToString() + ",00 BYN";
                        this.Item2AmountLabel.Text = basket.items.list[1].amount.ToString();
                        this.Item2DescrlLabel.Text = basket.items.list[1].description;
                        this.Item2ModelLabel.Text = basket.items.list[1].model + " " + basket.items.list[1].model;

                        this.Item3CostLabel.Text = basket.items.list[2].cost.ToString() + ",00 BYN";
                        this.Item3AmountLabel.Text = basket.items.list[2].amount.ToString();
                        this.Item3DescrlLabel.Text = basket.items.list[2].description;
                        this.Item3ModelLabel.Text = basket.items.list[2].model + " " + basket.items.list[2].model;
                        break;
                    }
            }
        }
        public void SwitchOrderButton()
        {
            if (basket.items.curLength == 0)
            {
                this.OrderButton.Enabled = false;
            }
        }
        private void PrevButton_Click(object sender, EventArgs e)
        {

        }


        private void ExitButton_Click(object sender, EventArgs e)
        {
            RegAuthForm form = new RegAuthForm();
            this.Close();
            form.Show();
        }

        private void CatalogButton_Click(object sender, EventArgs e)
        {
            CatalogForm form = new CatalogForm(user, regAuthForm);
            this.Close();
            form.Show();
        }

        private void BasketForm_Load(object sender, EventArgs e)
        {
            Reload();
            SwitchOrderButton();
            this.LoginLabel.Text = user.login;
        }

        private void ClearLabel_Click(object sender, EventArgs e)
        {
            basket.ClearBasketByLogin();
            Reload();
        }

        private void OrderButton_Click(object sender, EventArgs e)
        {
        
            OrderForm form = new OrderForm(basket, this);
            form.Show();
            
            
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

        private void Item1PlusButton_Click(object sender, EventArgs e)
        {
            int num = int.Parse(Item1AmountLabel.Text);
            this.Item1AmountLabel.Text = (num + 1).ToString();
            this.Item1MinusButton.Enabled = true;
            if (num == 8)
            {
                this.Item1PlusButton.Enabled = false;
            }
        }

        private void Item1MinusButton_Click(object sender, EventArgs e)
        {
            int num = int.Parse(Item1AmountLabel.Text);
            this.Item1AmountLabel.Text = (num - 1).ToString();
            this.Item1PlusButton.Enabled = true;
            if (num == 2)
            {
                this.Item1MinusButton.Enabled = false;
            }
        }

        private void Item2MinusButton_Click(object sender, EventArgs e)
        {
            int num = int.Parse(Item2AmountLabel.Text);
            this.Item2AmountLabel.Text = (num - 1).ToString();
            this.Item2PlusButton.Enabled = true;
            if (num == 2)
            {
                this.Item2MinusButton.Enabled = false;
            }
        }

        private void Item2PlusButton_Click(object sender, EventArgs e)
        {
            int num = int.Parse(Item2AmountLabel.Text);
            this.Item2AmountLabel.Text = (num + 1).ToString();
            this.Item2MinusButton.Enabled = true;
            if (num == 8)
            {
                this.Item2PlusButton.Enabled = false;
            }
        }

        private void Item3MinusButton_Click(object sender, EventArgs e)
        {
            int num = int.Parse(Item3AmountLabel.Text);
            this.Item3AmountLabel.Text = (num - 1).ToString();
            this.Item3PlusButton.Enabled = true;
            if (num == 2)
            {
                this.Item3MinusButton.Enabled = false;
            }
        }

        private void Item3PlusButton_Click(object sender, EventArgs e)
        {
            int num = int.Parse(Item3AmountLabel.Text);
            this.Item3AmountLabel.Text = (num + 1).ToString();
            this.Item3MinusButton.Enabled = true;
            if (num == 8)
            {
                this.Item3PlusButton.Enabled = false;
            }
        }
    }
}
