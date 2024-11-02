namespace АРМ_продавца_офисной_техники
{
    partial class OrderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderForm));
            this.TopPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.ExitLabel = new System.Windows.Forms.Label();
            this.Button = new System.Windows.Forms.Button();
            this.AddressPanel = new System.Windows.Forms.Panel();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.FIOPanel = new System.Windows.Forms.Panel();
            this.FIOLabel = new System.Windows.Forms.Label();
            this.FIOTextBox = new System.Windows.Forms.TextBox();
            this.PhonePanel = new System.Windows.Forms.Panel();
            this.PhoneLabel = new System.Windows.Forms.Label();
            this.PhoneTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TopPanel.SuspendLayout();
            this.AddressPanel.SuspendLayout();
            this.FIOPanel.SuspendLayout();
            this.PhonePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.TopPanel.Controls.Add(this.label2);
            this.TopPanel.Controls.Add(this.label1);
            this.TopPanel.Controls.Add(this.ExitLabel);
            this.TopPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(500, 50);
            this.TopPanel.TabIndex = 2;
            this.TopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseDown);
            this.TopPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseMove);
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
            // Button
            // 
            this.Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(171)))), ((int)(((byte)(87)))));
            this.Button.FlatAppearance.BorderSize = 0;
            this.Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.Button.Location = new System.Drawing.Point(150, 380);
            this.Button.Name = "Button";
            this.Button.Size = new System.Drawing.Size(200, 60);
            this.Button.TabIndex = 11;
            this.Button.Text = "Оформить";
            this.Button.UseVisualStyleBackColor = false;
            this.Button.Click += new System.EventHandler(this.Button_Click);
            // 
            // AddressPanel
            // 
            this.AddressPanel.BackColor = System.Drawing.Color.Gray;
            this.AddressPanel.Controls.Add(this.AddressLabel);
            this.AddressPanel.Controls.Add(this.AddressTextBox);
            this.AddressPanel.Location = new System.Drawing.Point(50, 190);
            this.AddressPanel.Name = "AddressPanel";
            this.AddressPanel.Size = new System.Drawing.Size(380, 60);
            this.AddressPanel.TabIndex = 13;
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.BackColor = System.Drawing.Color.Gray;
            this.AddressLabel.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddressLabel.ForeColor = System.Drawing.Color.Silver;
            this.AddressLabel.Location = new System.Drawing.Point(12, 10);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(66, 21);
            this.AddressLabel.TabIndex = 9;
            this.AddressLabel.Text = "Адрес:";
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.BackColor = System.Drawing.Color.Gray;
            this.AddressTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AddressTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.AddressTextBox.Font = new System.Drawing.Font("Arial", 11.2F);
            this.AddressTextBox.ForeColor = System.Drawing.Color.White;
            this.AddressTextBox.Location = new System.Drawing.Point(10, 32);
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(368, 22);
            this.AddressTextBox.TabIndex = 3;
            // 
            // FIOPanel
            // 
            this.FIOPanel.BackColor = System.Drawing.Color.Gray;
            this.FIOPanel.Controls.Add(this.FIOLabel);
            this.FIOPanel.Controls.Add(this.FIOTextBox);
            this.FIOPanel.Location = new System.Drawing.Point(50, 100);
            this.FIOPanel.Name = "FIOPanel";
            this.FIOPanel.Size = new System.Drawing.Size(380, 60);
            this.FIOPanel.TabIndex = 12;
            // 
            // FIOLabel
            // 
            this.FIOLabel.AutoSize = true;
            this.FIOLabel.BackColor = System.Drawing.Color.Gray;
            this.FIOLabel.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FIOLabel.ForeColor = System.Drawing.Color.Silver;
            this.FIOLabel.Location = new System.Drawing.Point(12, 10);
            this.FIOLabel.Name = "FIOLabel";
            this.FIOLabel.Size = new System.Drawing.Size(56, 21);
            this.FIOLabel.TabIndex = 8;
            this.FIOLabel.Text = "ФИО:";
            // 
            // FIOTextBox
            // 
            this.FIOTextBox.BackColor = System.Drawing.Color.Gray;
            this.FIOTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FIOTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.FIOTextBox.Font = new System.Drawing.Font("Arial", 11.2F);
            this.FIOTextBox.ForeColor = System.Drawing.Color.White;
            this.FIOTextBox.Location = new System.Drawing.Point(10, 32);
            this.FIOTextBox.Name = "FIOTextBox";
            this.FIOTextBox.Size = new System.Drawing.Size(368, 22);
            this.FIOTextBox.TabIndex = 2;
            // 
            // PhonePanel
            // 
            this.PhonePanel.BackColor = System.Drawing.Color.Gray;
            this.PhonePanel.Controls.Add(this.PhoneLabel);
            this.PhonePanel.Controls.Add(this.PhoneTextBox);
            this.PhonePanel.Location = new System.Drawing.Point(50, 280);
            this.PhonePanel.Name = "PhonePanel";
            this.PhonePanel.Size = new System.Drawing.Size(380, 60);
            this.PhonePanel.TabIndex = 14;
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.AutoSize = true;
            this.PhoneLabel.BackColor = System.Drawing.Color.Gray;
            this.PhoneLabel.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PhoneLabel.ForeColor = System.Drawing.Color.Silver;
            this.PhoneLabel.Location = new System.Drawing.Point(12, 10);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(157, 21);
            this.PhoneLabel.TabIndex = 9;
            this.PhoneLabel.Text = "Номер телефона:";
            // 
            // PhoneTextBox
            // 
            this.PhoneTextBox.BackColor = System.Drawing.Color.Gray;
            this.PhoneTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PhoneTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.PhoneTextBox.Font = new System.Drawing.Font("Arial", 11.2F);
            this.PhoneTextBox.ForeColor = System.Drawing.Color.White;
            this.PhoneTextBox.Location = new System.Drawing.Point(10, 32);
            this.PhoneTextBox.Name = "PhoneTextBox";
            this.PhoneTextBox.Size = new System.Drawing.Size(368, 22);
            this.PhoneTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(468, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = " ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Controls.Add(this.PhonePanel);
            this.Controls.Add(this.Button);
            this.Controls.Add(this.AddressPanel);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.FIOPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OrderForm";
            this.Text = "OrderForm";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            this.TopPanel.ResumeLayout(false);
            this.AddressPanel.ResumeLayout(false);
            this.AddressPanel.PerformLayout();
            this.FIOPanel.ResumeLayout(false);
            this.FIOPanel.PerformLayout();
            this.PhonePanel.ResumeLayout(false);
            this.PhonePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ExitLabel;
        private System.Windows.Forms.Button Button;
        private System.Windows.Forms.Panel AddressPanel;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.TextBox AddressTextBox;
        private System.Windows.Forms.Panel FIOPanel;
        private System.Windows.Forms.Label FIOLabel;
        private System.Windows.Forms.TextBox FIOTextBox;
        private System.Windows.Forms.Panel PhonePanel;
        private System.Windows.Forms.Label PhoneLabel;
        private System.Windows.Forms.TextBox PhoneTextBox;
        private System.Windows.Forms.Label label2;
    }
}