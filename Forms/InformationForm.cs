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
    public partial class InformationForm : Form
    {
        Point lastpoint;
        Technique technique;
        string login;
        public InformationForm(Technique technique, string login)
        {
            InitializeComponent();
            this.login = login;
            this.technique = technique;
            this.ModelLabel.Text = technique.manufacturer + " " + technique.model;
            this.DescrlLabel.Text = technique.description;
            this.CostLabel.Text = technique.cost.ToString() + ",00 BYN";
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastpoint = new Point(e.X, e.Y);    
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                this.Left += e.X - lastpoint.X;
                this.Top += e.Y - lastpoint.Y;

            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            BasketItems basket = new BasketItems(login);
            basket.Add(technique);
            this.Close();
        }

        private void ExitLabel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
