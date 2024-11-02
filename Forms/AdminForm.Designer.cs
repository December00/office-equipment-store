namespace АРМ_продавца_офисной_техники
{
    partial class AdminForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.TopPanel = new System.Windows.Forms.Panel();
            this.ExitButton = new System.Windows.Forms.Label();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ExitLabel = new System.Windows.Forms.Label();
            this.OrderPanel = new System.Windows.Forms.Panel();
            this.PhoneLabel = new System.Windows.Forms.Label();
            this.FIOLabel = new System.Windows.Forms.Label();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.Item1pic = new System.Windows.Forms.Label();
            this.OrderNumberLabel = new System.Windows.Forms.Label();
            this.CostLabel = new System.Windows.Forms.Label();
            this.ContentLabel = new System.Windows.Forms.Label();
            this.PrevButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.ChosenCategoryLabel = new System.Windows.Forms.Label();
            this.TopPanel.SuspendLayout();
            this.OrderPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.TopPanel.Controls.Add(this.ExitButton);
            this.TopPanel.Controls.Add(this.LoginLabel);
            this.TopPanel.Controls.Add(this.label2);
            this.TopPanel.Controls.Add(this.label1);
            this.TopPanel.Controls.Add(this.ExitLabel);
            this.TopPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(1300, 50);
            this.TopPanel.TabIndex = 2;
            this.TopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseDown);
            this.TopPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseMove);
            // 
            // ExitButton
            // 
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButton.Image = ((System.Drawing.Image)(resources.GetObject("ExitButton.Image")));
            this.ExitButton.Location = new System.Drawing.Point(1248, 5);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(50, 38);
            this.ExitButton.TabIndex = 3;
            this.ExitButton.Text = " ";
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Font = new System.Drawing.Font("Arial Black", 12.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginLabel.ForeColor = System.Drawing.Color.White;
            this.LoginLabel.Location = new System.Drawing.Point(64, 12);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(210, 31);
            this.LoginLabel.TabIndex = 17;
            this.LoginLabel.Text = "Администратор";
            // 
            // label2
            // 
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 47);
            this.label2.TabIndex = 3;
            this.label2.Text = " ";
            // 
            // label1
            // 
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(1362, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 47);
            this.label1.TabIndex = 2;
            this.label1.Text = " ";
            // 
            // ExitLabel
            // 
            this.ExitLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitLabel.Image = ((System.Drawing.Image)(resources.GetObject("ExitLabel.Image")));
            this.ExitLabel.Location = new System.Drawing.Point(1418, 5);
            this.ExitLabel.Name = "ExitLabel";
            this.ExitLabel.Size = new System.Drawing.Size(50, 38);
            this.ExitLabel.TabIndex = 1;
            this.ExitLabel.Text = " ";
            // 
            // OrderPanel
            // 
            this.OrderPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.OrderPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OrderPanel.Controls.Add(this.PhoneLabel);
            this.OrderPanel.Controls.Add(this.FIOLabel);
            this.OrderPanel.Controls.Add(this.AddressLabel);
            this.OrderPanel.Controls.Add(this.Item1pic);
            this.OrderPanel.Controls.Add(this.OrderNumberLabel);
            this.OrderPanel.Controls.Add(this.CostLabel);
            this.OrderPanel.Controls.Add(this.ContentLabel);
            this.OrderPanel.Location = new System.Drawing.Point(150, 150);
            this.OrderPanel.Name = "OrderPanel";
            this.OrderPanel.Size = new System.Drawing.Size(1000, 220);
            this.OrderPanel.TabIndex = 4;
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.AutoSize = true;
            this.PhoneLabel.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PhoneLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.PhoneLabel.Location = new System.Drawing.Point(842, 181);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(127, 19);
            this.PhoneLabel.TabIndex = 8;
            this.PhoneLabel.Text = "+375444528064";
            // 
            // FIOLabel
            // 
            this.FIOLabel.AutoSize = true;
            this.FIOLabel.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FIOLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.FIOLabel.Location = new System.Drawing.Point(195, 181);
            this.FIOLabel.Name = "FIOLabel";
            this.FIOLabel.Size = new System.Drawing.Size(212, 19);
            this.FIOLabel.TabIndex = 7;
            this.FIOLabel.Text = "Сташук Богдан Сергеевич";
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddressLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.AddressLabel.Location = new System.Drawing.Point(195, 137);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(220, 19);
            this.AddressLabel.TabIndex = 6;
            this.AddressLabel.Text = "Минск, ул.Якуба Коласа 28";
            // 
            // Item1pic
            // 
            this.Item1pic.Image = ((System.Drawing.Image)(resources.GetObject("Item1pic.Image")));
            this.Item1pic.Location = new System.Drawing.Point(24, 37);
            this.Item1pic.Name = "Item1pic";
            this.Item1pic.Size = new System.Drawing.Size(143, 149);
            this.Item1pic.TabIndex = 5;
            this.Item1pic.Text = " ";
            // 
            // OrderNumberLabel
            // 
            this.OrderNumberLabel.AutoSize = true;
            this.OrderNumberLabel.Font = new System.Drawing.Font("Arial Black", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrderNumberLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.OrderNumberLabel.Location = new System.Drawing.Point(194, 30);
            this.OrderNumberLabel.Name = "OrderNumberLabel";
            this.OrderNumberLabel.Size = new System.Drawing.Size(138, 26);
            this.OrderNumberLabel.TabIndex = 3;
            this.OrderNumberLabel.Text = "Заказ №253";
            // 
            // CostLabel
            // 
            this.CostLabel.AutoSize = true;
            this.CostLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CostLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.CostLabel.Location = new System.Drawing.Point(862, 30);
            this.CostLabel.Name = "CostLabel";
            this.CostLabel.Size = new System.Drawing.Size(107, 19);
            this.CostLabel.TabIndex = 0;
            this.CostLabel.Text = "2049,00 BYN";
            // 
            // ContentLabel
            // 
            this.ContentLabel.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ContentLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.ContentLabel.Location = new System.Drawing.Point(195, 67);
            this.ContentLabel.Name = "ContentLabel";
            this.ContentLabel.Size = new System.Drawing.Size(634, 65);
            this.ContentLabel.TabIndex = 4;
            this.ContentLabel.Text = "Содержимое заказа: ASUS Vivobook 15 X1504ZA-BQ1120, Logitech Pro X Superlight, JB" +
    "L Tune 520BT";
            // 
            // PrevButton
            // 
            this.PrevButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PrevButton.Enabled = false;
            this.PrevButton.FlatAppearance.BorderSize = 0;
            this.PrevButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrevButton.Image = ((System.Drawing.Image)(resources.GetObject("PrevButton.Image")));
            this.PrevButton.Location = new System.Drawing.Point(50, 259);
            this.PrevButton.Name = "PrevButton";
            this.PrevButton.Size = new System.Drawing.Size(43, 48);
            this.PrevButton.TabIndex = 17;
            this.PrevButton.Text = " ";
            this.PrevButton.UseVisualStyleBackColor = true;
            this.PrevButton.Click += new System.EventHandler(this.PrevButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.NextButton.FlatAppearance.BorderSize = 0;
            this.NextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NextButton.Image = ((System.Drawing.Image)(resources.GetObject("NextButton.Image")));
            this.NextButton.Location = new System.Drawing.Point(1198, 250);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(48, 48);
            this.NextButton.TabIndex = 16;
            this.NextButton.Text = " ";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // ChosenCategoryLabel
            // 
            this.ChosenCategoryLabel.AutoSize = true;
            this.ChosenCategoryLabel.Font = new System.Drawing.Font("Arial Black", 14.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChosenCategoryLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.ChosenCategoryLabel.Location = new System.Drawing.Point(172, 92);
            this.ChosenCategoryLabel.Name = "ChosenCategoryLabel";
            this.ChosenCategoryLabel.Size = new System.Drawing.Size(273, 36);
            this.ChosenCategoryLabel.TabIndex = 18;
            this.ChosenCategoryLabel.Text = "Открытые заказы";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1300, 850);
            this.Controls.Add(this.ChosenCategoryLabel);
            this.Controls.Add(this.PrevButton);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.OrderPanel);
            this.Controls.Add(this.TopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.OrderPanel.ResumeLayout(false);
            this.OrderPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Label ExitButton;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ExitLabel;
        private System.Windows.Forms.Panel OrderPanel;
        private System.Windows.Forms.Label OrderNumberLabel;
        private System.Windows.Forms.Label CostLabel;
        private System.Windows.Forms.Label ContentLabel;
        private System.Windows.Forms.Label Item1pic;
        private System.Windows.Forms.Label PhoneLabel;
        private System.Windows.Forms.Label FIOLabel;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.Button PrevButton;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Label ChosenCategoryLabel;
    }
}