using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace АРМ_продавца_офисной_техники
{
    public partial class RegAuthForm : Form
    {
        Point lastpoint;
        public RegAuthForm()
        {
            InitializeComponent();
            
        }
        /* private void InitializeTextBox()
        {
            TextBox LogTextBox = new TextBox();
            LogTextBox.Multiline = false;
            LogTextBox.AutoSize = false;
            LogTextBox.Location = new Point(65, 210);
            LogTextBox.Size = new Size(220, 60);
            this.Controls.Add(LogTextBox);

            TextBox PasTextBox = new TextBox();
            PasTextBox.AutoSize = false;
            PasTextBox.Location = new Point(65, 280);
            PasTextBox.Size = new Size(220, 60);
            PasTextBox.Multiline = false;
            this.Controls.Add(PasTextBox);
        }
        */
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

        private void ImageLabel_MouseDown(object sender, MouseEventArgs e)
        {
            lastpoint = new Point(e.X, e.Y);
        }

        private void ImageLabel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left && e.Y <= 32)
            {
                this.Left += e.X - lastpoint.X;
                this.Top += e.Y - lastpoint.Y;

            }
        }

        private void ToRegLabel_Click(object sender, EventArgs e)
        {
            this.ToAuthLabel.ForeColor = Color.Silver;
            this.ToRegLabel.ForeColor = Color.White;
            this.RegActLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(171)))), ((int)(((byte)(87))))); ;
            this.AuthActLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.WTDLabel.Text = "Зарегистрируйтесь, чтобы продолжить";
        }

        private void ToAuthLabel_Click(object sender, EventArgs e)
        {
            this.ToRegLabel.ForeColor = Color.Silver;
            this.ToAuthLabel.ForeColor = Color.White;
            this.RegActLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96))))); ;
            this.AuthActLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(171)))), ((int)(((byte)(87)))));
            this.WTDLabel.Text = "Войдите, чтобы продолжить";
        }
    }
}
