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
    public partial class CatalogForm : Form
    {
        Point lastpoint;
        User user;
        int multiplier = 1;
        TechniqueList techniqueList = new TechniqueList();
        RegAuthForm RegForm;
        private void Reload()
        {

            if(9 * multiplier < techniqueList.curLength)
            {
                int n = 9 * multiplier;
                int dif = 9;
                int curobj = 1;
                for (int i = n - dif; i < n; i++)
                {
                    switch (curobj)
                    {
                        case 1:
                            {
                                this.Item1ModelLabel.Text = techniqueList.list[i].manufacturer + " " + techniqueList.list[i].model;
                                this.Item1DescrlLabel.Text = techniqueList.list[i].description;
                                this.Item1CostLabel.Text = techniqueList.list[i].cost.ToString() + ",00 BYN";
                                this.Item1Panel.Visible = true;
                                curobj++;
                                break;
                            }
                        case 2:
                            {
                                this.Item2ModelLabel.Text = techniqueList.list[i].manufacturer + " " + techniqueList.list[i].model;
                                this.Item2DescrlLabel.Text = techniqueList.list[i].description;
                                this.Item2CostLabel.Text = techniqueList.list[i].cost.ToString() + ",00 BYN";
                                this.Item2Panel.Visible = true;
                                curobj++;
                                break;
                            }
                        case 3:
                            {
                                this.Item3ModelLabel.Text = techniqueList.list[i].manufacturer + " " + techniqueList.list[i].model;
                                this.Item3DescrlLabel.Text = techniqueList.list[i].description;
                                this.Item3CostLabel.Text = techniqueList.list[i].cost.ToString() + ",00 BYN";
                                this.Item3Panel.Visible = true;
                                curobj++;
                                break;
                            }
                        case 4:
                            {
                                this.Item4ModelLabel.Text = techniqueList.list[i].manufacturer + " " + techniqueList.list[i].model;
                                this.Item4DescrlLabel.Text = techniqueList.list[i].description;
                                this.Item4CostLabel.Text = techniqueList.list[i].cost.ToString() + ",00 BYN";
                                this.Item4Panel.Visible = true;
                                curobj++;
                                break;
                            }
                        case 5:
                            {
                                this.Item5ModelLabel.Text = techniqueList.list[i].manufacturer + " " + techniqueList.list[i].model;
                                this.Item5DescrlLabel.Text = techniqueList.list[i].description;
                                this.Item5CostLabel.Text = techniqueList.list[i].cost.ToString() + ",00 BYN";
                                this.Item5Panel.Visible = true;
                                curobj++;
                                break;
                            }
                        case 6:
                            {
                                this.Item6ModelLabel.Text = techniqueList.list[i].manufacturer + " " + techniqueList.list[i].model;
                                this.Item6DescrlLabel.Text = techniqueList.list[i].description;
                                this.Item6CostLabel.Text = techniqueList.list[i].cost.ToString() + ",00 BYN";
                                this.Item6Panel.Visible = true;
                                curobj++;
                                break;
                            }
                        case 7:
                            {
                                this.Item7ModelLabel.Text = techniqueList.list[i].manufacturer + " " + techniqueList.list[i].model;
                                this.Item7DescrlLabel.Text = techniqueList.list[i].description;
                                this.Item7CostLabel.Text = techniqueList.list[i].cost.ToString() + ",00 BYN";
                                this.Item7Panel.Visible = true;
                                curobj++;
                                break;
                            }
                        case 8:
                            {
                                this.Item8ModelLabel.Text = techniqueList.list[i].manufacturer + " " + techniqueList.list[i].model;
                                this.Item8DescrlLabel.Text = techniqueList.list[i].description;
                                this.Item8CostLabel.Text = techniqueList.list[i].cost.ToString() + ",00 BYN";
                                this.Item8Panel.Visible = true;
                                curobj++;
                                break;
                            }
                        case 9:
                            {
                                this.Item9ModelLabel.Text = techniqueList.list[i].manufacturer + " " + techniqueList.list[i].model;
                                this.Item9DescrlLabel.Text = techniqueList.list[i].description;
                                this.Item9CostLabel.Text = techniqueList.list[i].cost.ToString() + ",00 BYN";
                                this.Item9Panel.Visible = true;
                                curobj++;
                                break;
                            }
                    }
                }
            }
            else
            {
                int n = 9 * multiplier;
                int dif = 9 * multiplier - techniqueList.curLength;
                int curobj = 1;
                for (int i = n - 9; i < n - dif; i++)
                {
                    switch (curobj)
                    {
                        case 1:
                            {
                                this.Item1ModelLabel.Text = techniqueList.list[i].manufacturer + " " + techniqueList.list[i].model;
                                this.Item1DescrlLabel.Text = techniqueList.list[i].description;
                                this.Item1CostLabel.Text = techniqueList.list[i].cost.ToString() + ",00 BYN";
                                this.Item1Panel.Visible = true;
                                curobj++;
                                break;
                            }
                        case 2:
                            {
                                this.Item2ModelLabel.Text = techniqueList.list[i].manufacturer + " " + techniqueList.list[i].model;
                                this.Item2DescrlLabel.Text = techniqueList.list[i].description;
                                this.Item2CostLabel.Text = techniqueList.list[i].cost.ToString() + ",00 BYN";
                                this.Item2Panel.Visible = true;
                                curobj++;
                                break;
                            }
                        case 3:
                            {
                                this.Item3ModelLabel.Text = techniqueList.list[i].manufacturer + " " + techniqueList.list[i].model;
                                this.Item3DescrlLabel.Text = techniqueList.list[i].description;
                                this.Item3CostLabel.Text = techniqueList.list[i].cost.ToString() + ",00 BYN";
                                this.Item3Panel.Visible = true;
                                curobj++;
                                break;
                            }
                        case 4:
                            {
                                this.Item4ModelLabel.Text = techniqueList.list[i].manufacturer + " " + techniqueList.list[i].model;
                                this.Item4DescrlLabel.Text = techniqueList.list[i].description;
                                this.Item4CostLabel.Text = techniqueList.list[i].cost.ToString() + ",00 BYN";
                                this.Item4Panel.Visible = true;
                                curobj++;
                                break;
                            }
                        case 5:
                            {
                                this.Item5ModelLabel.Text = techniqueList.list[i].manufacturer + " " + techniqueList.list[i].model;
                                this.Item5DescrlLabel.Text = techniqueList.list[i].description;
                                this.Item5CostLabel.Text = techniqueList.list[i].cost.ToString() + ",00 BYN";
                                this.Item5Panel.Visible = true;
                                curobj++;
                                break;
                            }
                        case 6:
                            {
                                this.Item6ModelLabel.Text = techniqueList.list[i].manufacturer + " " + techniqueList.list[i].model;
                                this.Item6DescrlLabel.Text = techniqueList.list[i].description;
                                this.Item6CostLabel.Text = techniqueList.list[i].cost.ToString() + ",00 BYN";
                                this.Item6Panel.Visible = true;
                                curobj++;
                                break;
                            }
                        case 7:
                            {
                                this.Item7ModelLabel.Text = techniqueList.list[i].manufacturer + " " + techniqueList.list[i].model;
                                this.Item7DescrlLabel.Text = techniqueList.list[i].description;
                                this.Item7CostLabel.Text = techniqueList.list[i].cost.ToString() + ",00 BYN";
                                this.Item7Panel.Visible = true;
                                curobj++;
                                break;
                            }
                        case 8:
                            {
                                this.Item8ModelLabel.Text = techniqueList.list[i].manufacturer + " " + techniqueList.list[i].model;
                                this.Item8DescrlLabel.Text = techniqueList.list[i].description;
                                this.Item8CostLabel.Text = techniqueList.list[i].cost.ToString() + ",00 BYN";
                                this.Item8Panel.Visible = true;
                                curobj++;
                                break;
                            }
                    }
                }
                for(int i = curobj; i <= 9; i++)
                {
                    switch (curobj)
                    {
                        case 1:
                            {
                                this.Item1Panel.Visible = false;
                                curobj++;
                                break;
                            }
                        case 2:
                            {
                                this.Item2Panel.Visible = false;
                                curobj++;
                                break;
                            }
                        case 3:
                            {
                                this.Item3Panel.Visible = false;
                                curobj++;
                                break;
                            }
                        case 4:
                            {
                                this.Item4Panel.Visible = false;
                                curobj++;
                                break;
                            }
                        case 5:
                            {
                                this.Item5Panel.Visible = false;
                                curobj++;
                                break;
                            }
                        case 6:
                            {
                                this.Item6Panel.Visible = false;
                                curobj++;
                                break;
                            }
                        case 7:
                            {
                                this.Item7Panel.Visible = false;
                                curobj++;
                                break;
                            }
                        case 8:
                            {
                                this.Item8Panel.Visible = false;
                                curobj++;
                                break;
                            }
                        case 9:
                            {
                                this.Item9Panel.Visible = false;
                                curobj++;
                                break;
                            }
                    }
                }
            }
        }
        private void Reset()
        {
            
            NextButton.Enabled = true;
            PrevButton.Enabled = false;
            if (techniqueList.curLength < 10)
            {
                NextButton.Enabled = false;
            }
        }
        public CatalogForm(User user, RegAuthForm RegForm)
        {
            InitializeComponent();
           
            this.user = user;
            this.RegForm = RegForm;
        }

        private void CatalogForm_Load(object sender, EventArgs e)
        {
            techniqueList.Fill();
            this.LoginLabel.Text = user.login;
            Reload();
            Reset();
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

        private void ExitLabel_Click(object sender, EventArgs e)
        {
            this.Close();
            RegForm.Show();
        }

        private void LaptopCategory_Click(object sender, EventArgs e)
        {
            multiplier = 1;
            this.PageLabel.Text = multiplier.ToString();
            techniqueList.FillByType("laptop");
            this.ChosenCategoryLabel.Text = "Ноутбуки";
            Reset();
            SearchTextBox_TextChanged(sender, e);
        }

        private void PrinterCategory_Click(object sender, EventArgs e)
        {
            multiplier = 1;            this.PageLabel.Text = multiplier.ToString();
            techniqueList.FillByType("printer");
            this.ChosenCategoryLabel.Text = "Принтеры";
            Reset();
            SearchTextBox_TextChanged(sender, e);
        }

        private void MonitorCategory_Click(object sender, EventArgs e)
        {
            multiplier = 1;
            this.PageLabel.Text = multiplier.ToString();
            techniqueList.FillByType("monitor");
            this.ChosenCategoryLabel.Text = "Мониторы";
            Reset();
            SearchTextBox_TextChanged(sender, e);
        }

        private void HeadsetCategory_Click(object sender, EventArgs e)
        {
            multiplier = 1;
            this.PageLabel.Text = multiplier.ToString();
            techniqueList.FillByType("headset");
            this.ChosenCategoryLabel.Text = "Гарнитура";
            Reset();
            SearchTextBox_TextChanged(sender, e);
        }

        private void TVCategory_Click(object sender, EventArgs e)
        {
            multiplier = 1;
            this.PageLabel.Text = multiplier.ToString();
            techniqueList.FillByType("TV");
            this.ChosenCategoryLabel.Text = "Телевизоры";
            Reset();
            SearchTextBox_TextChanged(sender, e);
        }

        private void PCCategory_Click(object sender, EventArgs e)
        {
            multiplier = 1;
            this.PageLabel.Text = multiplier.ToString();
            techniqueList.FillByType("PC");
            this.ChosenCategoryLabel.Text = "Персональные компьютеры";
            Reset();
            SearchTextBox_TextChanged(sender, e);
        }

        private void OtherCategory_Click(object sender, EventArgs e)
        {
            multiplier = 1;
           
            this.PageLabel.Text = multiplier.ToString();
            techniqueList.FillByType("other");
            this.ChosenCategoryLabel.Text = "Другое";
            Reset();
            SearchTextBox_TextChanged(sender, e);
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            multiplier = 1;
            
            this.PageLabel.Text = multiplier.ToString();
            techniqueList.Fill();
            this.ChosenCategoryLabel.Text = "Каталог";
            this.sortComboBox.SelectedIndex = -1;
            this.SearchTextBox.Text = "";           
            Reset();
            Reload();
           
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            multiplier++;
            this.PageLabel.Text = multiplier.ToString();
            PrevButton.Enabled = true;
            Reload();
            if (multiplier*9 > techniqueList.curLength)
            {
                NextButton.Enabled = false;
            }
        }

        private void PrevButton_Click(object sender, EventArgs e)
        {
            multiplier--;
            this.PageLabel.Text = multiplier.ToString();
            NextButton.Enabled = true;
            Reload();
            if (multiplier == 1)
            {
                PrevButton.Enabled = false;
            }
            
        }

        private void Item1Button_Click(object sender, EventArgs e)
        {
            InformationForm form = new InformationForm(techniqueList.list[9*(multiplier - 1)], user.login);
            form.Show();
        }

        private void Item2Button_Click(object sender, EventArgs e)
        {
            InformationForm form = new InformationForm(techniqueList.list[9 * (multiplier - 1) + 1], user.login);
            form.Show();
        }

        private void Item3Button_Click(object sender, EventArgs e)
        {
            InformationForm form = new InformationForm(techniqueList.list[9 * (multiplier - 1) + 2], user.login);
            form.Show();
        }

        private void Item4Button_Click(object sender, EventArgs e)
        {
            InformationForm form = new InformationForm(techniqueList.list[9 * (multiplier - 1) + 3], user.login);
            form.Show();
        }

        private void Item5Button_Click(object sender, EventArgs e)
        {
            InformationForm form = new InformationForm(techniqueList.list[9 * (multiplier - 1) + 4], user.login);
            form.Show();
        }

        private void Item6Button_Click(object sender, EventArgs e)
        {
            InformationForm form = new InformationForm(techniqueList.list[9 * (multiplier - 1) + 5], user.login);
            form.Show();
        }

        private void Item7Button_Click(object sender, EventArgs e)
        {
            InformationForm form = new InformationForm(techniqueList.list[9 * (multiplier - 1) + 6], user.login);
            form.Show();
        }

        private void Item8Button_Click(object sender, EventArgs e)
        {
            InformationForm form = new InformationForm(techniqueList.list[9 * (multiplier - 1) + 7], user.login);
            form.Show();
        }

        private void Item9Button_Click(object sender, EventArgs e)
        {
            InformationForm form = new InformationForm(techniqueList.list[9 * (multiplier - 1) + 8], user.login);
            form.Show();
        }

       

        private void BasketButton_Click(object sender, EventArgs e)
        {
            BasketForm form = new BasketForm(user, RegForm);
            form.Show();
            this.Close();
        }

        private void sortComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sortComboBox.SelectedItem == null)
            {
                return;
            }
            if (sortComboBox.SelectedItem.ToString() == "По возрастанию цены") {
                techniqueList.ListSortByCost();
                Reload();
                return;
            }
            if (sortComboBox.SelectedItem.ToString() == "По убыванию цены") {
                techniqueList.ListReverseSortByCost();
                Reload();
                return;
            }

        }

       
        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            TechniqueList search = new TechniqueList();
            search = techniqueList.Search(this.SearchTextBox.Text);
            TechniqueList temp = techniqueList;
            techniqueList = search;
            Reload();
            techniqueList = temp;
        }
    }
}
