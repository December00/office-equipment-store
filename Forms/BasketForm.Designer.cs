namespace АРМ_продавца_офисной_техники
{
    partial class BasketForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BasketForm));
            this.LoginLabel = new System.Windows.Forms.Label();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.CatalogButton = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ExitLabel = new System.Windows.Forms.Label();
            this.Item1Panel = new System.Windows.Forms.Panel();
            this.Item1AmountLabel = new System.Windows.Forms.Label();
            this.Item1MinusButton = new System.Windows.Forms.Button();
            this.Item1PlusButton = new System.Windows.Forms.Button();
            this.Item1ModelLabel = new System.Windows.Forms.Label();
            this.Item1pic = new System.Windows.Forms.Label();
            this.Item1CostLabel = new System.Windows.Forms.Label();
            this.Item1DescrlLabel = new System.Windows.Forms.Label();
            this.ChosenCategoryLabel = new System.Windows.Forms.Label();
            this.Item2Panel = new System.Windows.Forms.Panel();
            this.Item2AmountLabel = new System.Windows.Forms.Label();
            this.Item2MinusButton = new System.Windows.Forms.Button();
            this.Item2PlusButton = new System.Windows.Forms.Button();
            this.Item2ModelLabel = new System.Windows.Forms.Label();
            this.Item2pic = new System.Windows.Forms.Label();
            this.Item2CostLabel = new System.Windows.Forms.Label();
            this.Item2DescrlLabel = new System.Windows.Forms.Label();
            this.Item3Panel = new System.Windows.Forms.Panel();
            this.Item3AmountLabel = new System.Windows.Forms.Label();
            this.Item3MinusButton = new System.Windows.Forms.Button();
            this.Item3PlusButton = new System.Windows.Forms.Button();
            this.Item3ModelLabel = new System.Windows.Forms.Label();
            this.Item3pic = new System.Windows.Forms.Label();
            this.Item3CostLabel = new System.Windows.Forms.Label();
            this.Item3DescrlLabel = new System.Windows.Forms.Label();
            this.OrderButton = new System.Windows.Forms.Button();
            this.ClearLabel = new System.Windows.Forms.Label();
            this.TopPanel.SuspendLayout();
            this.Item1Panel.SuspendLayout();
            this.Item2Panel.SuspendLayout();
            this.Item3Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Font = new System.Drawing.Font("Arial Black", 12.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginLabel.ForeColor = System.Drawing.Color.White;
            this.LoginLabel.Location = new System.Drawing.Point(64, 12);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(192, 31);
            this.LoginLabel.TabIndex = 17;
            this.LoginLabel.Text = "Пользователь";
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.TopPanel.Controls.Add(this.CatalogButton);
            this.TopPanel.Controls.Add(this.ExitButton);
            this.TopPanel.Controls.Add(this.LoginLabel);
            this.TopPanel.Controls.Add(this.label2);
            this.TopPanel.Controls.Add(this.label1);
            this.TopPanel.Controls.Add(this.ExitLabel);
            this.TopPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(1200, 50);
            this.TopPanel.TabIndex = 1;
            this.TopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseDown);
            this.TopPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseMove);
            // 
            // CatalogButton
            // 
            this.CatalogButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CatalogButton.Image = ((System.Drawing.Image)(resources.GetObject("CatalogButton.Image")));
            this.CatalogButton.Location = new System.Drawing.Point(1092, 0);
            this.CatalogButton.Name = "CatalogButton";
            this.CatalogButton.Size = new System.Drawing.Size(50, 47);
            this.CatalogButton.TabIndex = 4;
            this.CatalogButton.Text = " ";
            this.CatalogButton.Click += new System.EventHandler(this.CatalogButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButton.Image = ((System.Drawing.Image)(resources.GetObject("ExitButton.Image")));
            this.ExitButton.Location = new System.Drawing.Point(1148, 5);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(50, 38);
            this.ExitButton.TabIndex = 3;
            this.ExitButton.Text = " ";
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
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
            // Item1Panel
            // 
            this.Item1Panel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Item1Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Item1Panel.Controls.Add(this.Item1AmountLabel);
            this.Item1Panel.Controls.Add(this.Item1MinusButton);
            this.Item1Panel.Controls.Add(this.Item1PlusButton);
            this.Item1Panel.Controls.Add(this.Item1ModelLabel);
            this.Item1Panel.Controls.Add(this.Item1pic);
            this.Item1Panel.Controls.Add(this.Item1CostLabel);
            this.Item1Panel.Controls.Add(this.Item1DescrlLabel);
            this.Item1Panel.Location = new System.Drawing.Point(70, 111);
            this.Item1Panel.Name = "Item1Panel";
            this.Item1Panel.Size = new System.Drawing.Size(1096, 164);
            this.Item1Panel.TabIndex = 3;
            // 
            // Item1AmountLabel
            // 
            this.Item1AmountLabel.AutoSize = true;
            this.Item1AmountLabel.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Item1AmountLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.Item1AmountLabel.Location = new System.Drawing.Point(940, 118);
            this.Item1AmountLabel.Name = "Item1AmountLabel";
            this.Item1AmountLabel.Size = new System.Drawing.Size(30, 32);
            this.Item1AmountLabel.TabIndex = 19;
            this.Item1AmountLabel.Text = "1";
            // 
            // Item1MinusButton
            // 
            this.Item1MinusButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Item1MinusButton.Enabled = false;
            this.Item1MinusButton.FlatAppearance.BorderSize = 0;
            this.Item1MinusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Item1MinusButton.Image = ((System.Drawing.Image)(resources.GetObject("Item1MinusButton.Image")));
            this.Item1MinusButton.Location = new System.Drawing.Point(862, 109);
            this.Item1MinusButton.Name = "Item1MinusButton";
            this.Item1MinusButton.Size = new System.Drawing.Size(43, 48);
            this.Item1MinusButton.TabIndex = 18;
            this.Item1MinusButton.Text = " ";
            this.Item1MinusButton.UseVisualStyleBackColor = true;
            this.Item1MinusButton.Click += new System.EventHandler(this.Item1MinusButton_Click);
            // 
            // Item1PlusButton
            // 
            this.Item1PlusButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Item1PlusButton.FlatAppearance.BorderSize = 0;
            this.Item1PlusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Item1PlusButton.Image = ((System.Drawing.Image)(resources.GetObject("Item1PlusButton.Image")));
            this.Item1PlusButton.Location = new System.Drawing.Point(1001, 109);
            this.Item1PlusButton.Name = "Item1PlusButton";
            this.Item1PlusButton.Size = new System.Drawing.Size(48, 48);
            this.Item1PlusButton.TabIndex = 17;
            this.Item1PlusButton.Text = " ";
            this.Item1PlusButton.UseVisualStyleBackColor = true;
            this.Item1PlusButton.Click += new System.EventHandler(this.Item1PlusButton_Click);
            // 
            // Item1ModelLabel
            // 
            this.Item1ModelLabel.Font = new System.Drawing.Font("Arial Black", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Item1ModelLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.Item1ModelLabel.Location = new System.Drawing.Point(221, 17);
            this.Item1ModelLabel.Name = "Item1ModelLabel";
            this.Item1ModelLabel.Size = new System.Drawing.Size(444, 22);
            this.Item1ModelLabel.TabIndex = 3;
            this.Item1ModelLabel.Text = "Asus Vivobook 15 X1504ZA-BQ1120";
            // 
            // Item1pic
            // 
            this.Item1pic.Image = ((System.Drawing.Image)(resources.GetObject("Item1pic.Image")));
            this.Item1pic.Location = new System.Drawing.Point(13, 0);
            this.Item1pic.Name = "Item1pic";
            this.Item1pic.Size = new System.Drawing.Size(180, 150);
            this.Item1pic.TabIndex = 2;
            this.Item1pic.Text = " ";
            // 
            // Item1CostLabel
            // 
            this.Item1CostLabel.AutoSize = true;
            this.Item1CostLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Item1CostLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.Item1CostLabel.Location = new System.Drawing.Point(964, 20);
            this.Item1CostLabel.Name = "Item1CostLabel";
            this.Item1CostLabel.Size = new System.Drawing.Size(107, 19);
            this.Item1CostLabel.TabIndex = 0;
            this.Item1CostLabel.Text = "2049,00 BYN";
            // 
            // Item1DescrlLabel
            // 
            this.Item1DescrlLabel.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Item1DescrlLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.Item1DescrlLabel.Location = new System.Drawing.Point(222, 51);
            this.Item1DescrlLabel.Name = "Item1DescrlLabel";
            this.Item1DescrlLabel.Size = new System.Drawing.Size(534, 89);
            this.Item1DescrlLabel.TabIndex = 4;
            this.Item1DescrlLabel.Text = "15.6\" 1920 x 1080, IPS, 60 Гц, Intel Core i5 1235U, 16 ГБ DDR4, SSD 512 ГБ, видео" +
    "карта встроенная";
            // 
            // ChosenCategoryLabel
            // 
            this.ChosenCategoryLabel.AutoSize = true;
            this.ChosenCategoryLabel.Font = new System.Drawing.Font("Arial Black", 12.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChosenCategoryLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.ChosenCategoryLabel.Location = new System.Drawing.Point(81, 67);
            this.ChosenCategoryLabel.Name = "ChosenCategoryLabel";
            this.ChosenCategoryLabel.Size = new System.Drawing.Size(122, 31);
            this.ChosenCategoryLabel.TabIndex = 12;
            this.ChosenCategoryLabel.Text = "Корзина";
            // 
            // Item2Panel
            // 
            this.Item2Panel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Item2Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Item2Panel.Controls.Add(this.Item2AmountLabel);
            this.Item2Panel.Controls.Add(this.Item2MinusButton);
            this.Item2Panel.Controls.Add(this.Item2PlusButton);
            this.Item2Panel.Controls.Add(this.Item2ModelLabel);
            this.Item2Panel.Controls.Add(this.Item2pic);
            this.Item2Panel.Controls.Add(this.Item2CostLabel);
            this.Item2Panel.Controls.Add(this.Item2DescrlLabel);
            this.Item2Panel.Location = new System.Drawing.Point(70, 290);
            this.Item2Panel.Name = "Item2Panel";
            this.Item2Panel.Size = new System.Drawing.Size(1096, 164);
            this.Item2Panel.TabIndex = 20;
            // 
            // Item2AmountLabel
            // 
            this.Item2AmountLabel.AutoSize = true;
            this.Item2AmountLabel.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Item2AmountLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.Item2AmountLabel.Location = new System.Drawing.Point(940, 118);
            this.Item2AmountLabel.Name = "Item2AmountLabel";
            this.Item2AmountLabel.Size = new System.Drawing.Size(30, 32);
            this.Item2AmountLabel.TabIndex = 19;
            this.Item2AmountLabel.Text = "1";
            // 
            // Item2MinusButton
            // 
            this.Item2MinusButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Item2MinusButton.Enabled = false;
            this.Item2MinusButton.FlatAppearance.BorderSize = 0;
            this.Item2MinusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Item2MinusButton.Image = ((System.Drawing.Image)(resources.GetObject("Item2MinusButton.Image")));
            this.Item2MinusButton.Location = new System.Drawing.Point(862, 109);
            this.Item2MinusButton.Name = "Item2MinusButton";
            this.Item2MinusButton.Size = new System.Drawing.Size(43, 48);
            this.Item2MinusButton.TabIndex = 18;
            this.Item2MinusButton.Text = " ";
            this.Item2MinusButton.UseVisualStyleBackColor = true;
            this.Item2MinusButton.Click += new System.EventHandler(this.Item2MinusButton_Click);
            // 
            // Item2PlusButton
            // 
            this.Item2PlusButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Item2PlusButton.FlatAppearance.BorderSize = 0;
            this.Item2PlusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Item2PlusButton.Image = ((System.Drawing.Image)(resources.GetObject("Item2PlusButton.Image")));
            this.Item2PlusButton.Location = new System.Drawing.Point(1001, 109);
            this.Item2PlusButton.Name = "Item2PlusButton";
            this.Item2PlusButton.Size = new System.Drawing.Size(48, 48);
            this.Item2PlusButton.TabIndex = 17;
            this.Item2PlusButton.Text = " ";
            this.Item2PlusButton.UseVisualStyleBackColor = true;
            this.Item2PlusButton.Click += new System.EventHandler(this.Item2PlusButton_Click);
            // 
            // Item2ModelLabel
            // 
            this.Item2ModelLabel.Font = new System.Drawing.Font("Arial Black", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Item2ModelLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.Item2ModelLabel.Location = new System.Drawing.Point(221, 17);
            this.Item2ModelLabel.Name = "Item2ModelLabel";
            this.Item2ModelLabel.Size = new System.Drawing.Size(444, 22);
            this.Item2ModelLabel.TabIndex = 3;
            this.Item2ModelLabel.Text = "Asus Vivobook 15 X1504ZA-BQ1120";
            // 
            // Item2pic
            // 
            this.Item2pic.Image = ((System.Drawing.Image)(resources.GetObject("Item2pic.Image")));
            this.Item2pic.Location = new System.Drawing.Point(13, 0);
            this.Item2pic.Name = "Item2pic";
            this.Item2pic.Size = new System.Drawing.Size(180, 150);
            this.Item2pic.TabIndex = 2;
            this.Item2pic.Text = " ";
            // 
            // Item2CostLabel
            // 
            this.Item2CostLabel.AutoSize = true;
            this.Item2CostLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Item2CostLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.Item2CostLabel.Location = new System.Drawing.Point(964, 22);
            this.Item2CostLabel.Name = "Item2CostLabel";
            this.Item2CostLabel.Size = new System.Drawing.Size(107, 19);
            this.Item2CostLabel.TabIndex = 0;
            this.Item2CostLabel.Text = "2049,00 BYN";
            // 
            // Item2DescrlLabel
            // 
            this.Item2DescrlLabel.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Item2DescrlLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.Item2DescrlLabel.Location = new System.Drawing.Point(222, 51);
            this.Item2DescrlLabel.Name = "Item2DescrlLabel";
            this.Item2DescrlLabel.Size = new System.Drawing.Size(534, 89);
            this.Item2DescrlLabel.TabIndex = 4;
            this.Item2DescrlLabel.Text = "15.6\" 1920 x 1080, IPS, 60 Гц, Intel Core i5 1235U, 16 ГБ DDR4, SSD 512 ГБ, видео" +
    "карта встроенная";
            // 
            // Item3Panel
            // 
            this.Item3Panel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Item3Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Item3Panel.Controls.Add(this.Item3AmountLabel);
            this.Item3Panel.Controls.Add(this.Item3MinusButton);
            this.Item3Panel.Controls.Add(this.Item3PlusButton);
            this.Item3Panel.Controls.Add(this.Item3ModelLabel);
            this.Item3Panel.Controls.Add(this.Item3pic);
            this.Item3Panel.Controls.Add(this.Item3CostLabel);
            this.Item3Panel.Controls.Add(this.Item3DescrlLabel);
            this.Item3Panel.Location = new System.Drawing.Point(70, 471);
            this.Item3Panel.Name = "Item3Panel";
            this.Item3Panel.Size = new System.Drawing.Size(1096, 164);
            this.Item3Panel.TabIndex = 21;
            // 
            // Item3AmountLabel
            // 
            this.Item3AmountLabel.AutoSize = true;
            this.Item3AmountLabel.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Item3AmountLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.Item3AmountLabel.Location = new System.Drawing.Point(940, 118);
            this.Item3AmountLabel.Name = "Item3AmountLabel";
            this.Item3AmountLabel.Size = new System.Drawing.Size(30, 32);
            this.Item3AmountLabel.TabIndex = 19;
            this.Item3AmountLabel.Text = "1";
            // 
            // Item3MinusButton
            // 
            this.Item3MinusButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Item3MinusButton.Enabled = false;
            this.Item3MinusButton.FlatAppearance.BorderSize = 0;
            this.Item3MinusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Item3MinusButton.Image = ((System.Drawing.Image)(resources.GetObject("Item3MinusButton.Image")));
            this.Item3MinusButton.Location = new System.Drawing.Point(862, 109);
            this.Item3MinusButton.Name = "Item3MinusButton";
            this.Item3MinusButton.Size = new System.Drawing.Size(43, 48);
            this.Item3MinusButton.TabIndex = 18;
            this.Item3MinusButton.Text = " ";
            this.Item3MinusButton.UseVisualStyleBackColor = true;
            this.Item3MinusButton.Click += new System.EventHandler(this.Item3MinusButton_Click);
            // 
            // Item3PlusButton
            // 
            this.Item3PlusButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Item3PlusButton.FlatAppearance.BorderSize = 0;
            this.Item3PlusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Item3PlusButton.Image = ((System.Drawing.Image)(resources.GetObject("Item3PlusButton.Image")));
            this.Item3PlusButton.Location = new System.Drawing.Point(1001, 109);
            this.Item3PlusButton.Name = "Item3PlusButton";
            this.Item3PlusButton.Size = new System.Drawing.Size(48, 48);
            this.Item3PlusButton.TabIndex = 17;
            this.Item3PlusButton.Text = " ";
            this.Item3PlusButton.UseVisualStyleBackColor = true;
            this.Item3PlusButton.Click += new System.EventHandler(this.Item3PlusButton_Click);
            // 
            // Item3ModelLabel
            // 
            this.Item3ModelLabel.Font = new System.Drawing.Font("Arial Black", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Item3ModelLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.Item3ModelLabel.Location = new System.Drawing.Point(221, 17);
            this.Item3ModelLabel.Name = "Item3ModelLabel";
            this.Item3ModelLabel.Size = new System.Drawing.Size(444, 22);
            this.Item3ModelLabel.TabIndex = 3;
            this.Item3ModelLabel.Text = "Asus Vivobook 15 X1504ZA-BQ1120";
            // 
            // Item3pic
            // 
            this.Item3pic.Image = ((System.Drawing.Image)(resources.GetObject("Item3pic.Image")));
            this.Item3pic.Location = new System.Drawing.Point(13, 0);
            this.Item3pic.Name = "Item3pic";
            this.Item3pic.Size = new System.Drawing.Size(180, 150);
            this.Item3pic.TabIndex = 2;
            this.Item3pic.Text = " ";
            // 
            // Item3CostLabel
            // 
            this.Item3CostLabel.AutoSize = true;
            this.Item3CostLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Item3CostLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.Item3CostLabel.Location = new System.Drawing.Point(964, 22);
            this.Item3CostLabel.Name = "Item3CostLabel";
            this.Item3CostLabel.Size = new System.Drawing.Size(107, 19);
            this.Item3CostLabel.TabIndex = 0;
            this.Item3CostLabel.Text = "2049,00 BYN";
            // 
            // Item3DescrlLabel
            // 
            this.Item3DescrlLabel.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Item3DescrlLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.Item3DescrlLabel.Location = new System.Drawing.Point(222, 51);
            this.Item3DescrlLabel.Name = "Item3DescrlLabel";
            this.Item3DescrlLabel.Size = new System.Drawing.Size(534, 89);
            this.Item3DescrlLabel.TabIndex = 4;
            this.Item3DescrlLabel.Text = "15.6\" 1920 x 1080, IPS, 60 Гц, Intel Core i5 1235U, 16 ГБ DDR4, SSD 512 ГБ, видео" +
    "карта встроенная";
            // 
            // OrderButton
            // 
            this.OrderButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(171)))), ((int)(((byte)(87)))));
            this.OrderButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.OrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OrderButton.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrderButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.OrderButton.Location = new System.Drawing.Point(864, 701);
            this.OrderButton.Name = "OrderButton";
            this.OrderButton.Size = new System.Drawing.Size(302, 71);
            this.OrderButton.TabIndex = 22;
            this.OrderButton.Text = "Заказать";
            this.OrderButton.UseVisualStyleBackColor = false;
            this.OrderButton.Click += new System.EventHandler(this.OrderButton_Click);
            // 
            // ClearLabel
            // 
            this.ClearLabel.AutoSize = true;
            this.ClearLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClearLabel.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClearLabel.Location = new System.Drawing.Point(83, 728);
            this.ClearLabel.Name = "ClearLabel";
            this.ClearLabel.Size = new System.Drawing.Size(158, 21);
            this.ClearLabel.TabIndex = 23;
            this.ClearLabel.Text = "Очистить корзину";
            this.ClearLabel.Click += new System.EventHandler(this.ClearLabel_Click);
            // 
            // BasketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.ClearLabel);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.OrderButton);
            this.Controls.Add(this.Item3Panel);
            this.Controls.Add(this.Item2Panel);
            this.Controls.Add(this.ChosenCategoryLabel);
            this.Controls.Add(this.Item1Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BasketForm";
            this.Text = "BasketForm";
            this.Load += new System.EventHandler(this.BasketForm_Load);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.Item1Panel.ResumeLayout(false);
            this.Item1Panel.PerformLayout();
            this.Item2Panel.ResumeLayout(false);
            this.Item2Panel.PerformLayout();
            this.Item3Panel.ResumeLayout(false);
            this.Item3Panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ExitLabel;
        private System.Windows.Forms.Label CatalogButton;
        private System.Windows.Forms.Label ExitButton;
        private System.Windows.Forms.Panel Item1Panel;
        private System.Windows.Forms.Label Item1DescrlLabel;
        private System.Windows.Forms.Label Item1ModelLabel;
        private System.Windows.Forms.Label Item1pic;
        private System.Windows.Forms.Label Item1CostLabel;
        private System.Windows.Forms.Label Item1AmountLabel;
        private System.Windows.Forms.Button Item1MinusButton;
        private System.Windows.Forms.Button Item1PlusButton;
        private System.Windows.Forms.Label ChosenCategoryLabel;
        private System.Windows.Forms.Panel Item2Panel;
        private System.Windows.Forms.Label Item2AmountLabel;
        private System.Windows.Forms.Button Item2MinusButton;
        private System.Windows.Forms.Button Item2PlusButton;
        private System.Windows.Forms.Label Item2ModelLabel;
        private System.Windows.Forms.Label Item2pic;
        private System.Windows.Forms.Label Item2CostLabel;
        private System.Windows.Forms.Label Item2DescrlLabel;
        private System.Windows.Forms.Panel Item3Panel;
        private System.Windows.Forms.Label Item3AmountLabel;
        private System.Windows.Forms.Button Item3MinusButton;
        private System.Windows.Forms.Button Item3PlusButton;
        private System.Windows.Forms.Label Item3ModelLabel;
        private System.Windows.Forms.Label Item3pic;
        private System.Windows.Forms.Label Item3CostLabel;
        private System.Windows.Forms.Label Item3DescrlLabel;
        private System.Windows.Forms.Button OrderButton;
        private System.Windows.Forms.Label ClearLabel;
    }
}