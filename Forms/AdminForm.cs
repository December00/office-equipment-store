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
        TechniqueList techniqueList;
        int curOrder = 0;
        Point lastpoint;
        public void Reload() 
        {
            if (orderList.list[curOrder] != null)
            {
                Order order = orderList.list[curOrder];
                this.OrderNumberLabel.Text = "Заказ №" + order.Id;
                this.ContentLabel.Text = "Содержимое заказа: " + order.content;
                this.CostLabel.Text = order.finalCost + ",00 BYN";
                this.AddressLabel.Text = order.address;
                this.PhoneLabel.Text = order.phoneNumber;
                this.FIOLabel.Text = order.name;
            }
            else
            {
                this.OrderNumberLabel.Text = "Открытых заказов нет";
                this.ContentLabel.Text = "";
                this.CostLabel.Text = "0,00 BYN";
                this.AddressLabel.Text = "";
                this.PhoneLabel.Text = "";
                this.FIOLabel.Text = "";
            }
        }
        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            orderList = new OrderList();
            orderList.Fill();
            techniqueList = new TechniqueList();
            techniqueList.Fill();
            for (int i = 0; i < techniqueList.maxLength; i++)
            {

                this.TechniqueComboBox.Items.Add(techniqueList.list[i].manufacturer + " " + techniqueList.list[i].model);
            }
            this.TechniqueComboBox.Items.Add("Добавить...");
            UpdateButtonStates();
            Reload();

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            if (curOrder < orderList.maxLength - 1) 
            {
                curOrder++;
                Reload();
                UpdateButtonStates();
            }

        }

        private void PrevButton_Click(object sender, EventArgs e)
        {
            if (curOrder > 0)  
            {
                curOrder--;
                Reload();
                UpdateButtonStates();
            }
        }
        private void UpdateButtonStates()
        {
            this.PrevButton.Enabled = curOrder > 0; 
            this.NextButton.Enabled = curOrder < orderList.maxLength - 1; 
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

        private void OrderCancelButton_Click(object sender, EventArgs e)
        {
            if(orderList.list[curOrder] == null)
            {
                MessageBox.Show("Заказов нет");
                orderList.Fill();
                Reload();
                
                return;
            }
             
            orderList.list[curOrder].DeleteOrder(); 
            orderList = new OrderList();
            orderList.Fill();
            Reload();
            UpdateButtonStates();
            curOrder = 0;
        }

        private void OrderAcceptButton_Click(object sender, EventArgs e)
        {
            if (orderList.list[curOrder] == null)
            {
                MessageBox.Show("Заказов нет");
                Reload();
                return;
            }
            orderList.list[curOrder].AcceptOrder();
            orderList = new OrderList();
            orderList.Fill();
            Reload();
            UpdateButtonStates();
            curOrder = 0;
        }

        private void TechniqueComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < techniqueList.maxLength; i++)
            {
                if (techniqueList.list[i].manufacturer + " " + techniqueList.list[i].model == this.TechniqueComboBox.Text)
                {
                    this.ManufacturerTextBox.Text = techniqueList.list[i].manufacturer;
                    this.ModelTextBox.Text = techniqueList.list[i].model;
                    this.DescriptionTextBox.Text = techniqueList.list[i].description;
                    this.TypeTextBox.Text = techniqueList.list[i].type;
                    this.CostTextBox.Text = techniqueList.list[i].cost.ToString();
                    this.AmountTextBox.Text = techniqueList.list[i].amount.ToString();
                }
                
            }
        }

        private void ItemButton_Click(object sender, EventArgs e)
        {
            Technique tech;
            if(this.TechniqueComboBox.SelectedItem == null)
            {
                MessageBox.Show("Сделайте выбор в выпадающем списке");
                return;
            }
            try
            {
                tech = new Technique(this.TypeTextBox.Text, this.ManufacturerTextBox.Text, this.ModelTextBox.Text, this.DescriptionTextBox.Text, int.Parse(this.CostTextBox.Text), int.Parse(this.AmountTextBox.Text));
                if (this.TechniqueComboBox.SelectedItem.ToString() == "Добавить...")
                {
                    tech.Add();
                    this.ManufacturerTextBox.Text = "";
                    this.ModelTextBox.Text = "";
                    this.DescriptionTextBox.Text = "";
                    this.TypeTextBox.Text = "";
                    this.CostTextBox.Text = "";
                    this.AmountTextBox.Text = "";
                }
                else
                {
                    tech.Update();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex);
            }
            
        }
    }
}
