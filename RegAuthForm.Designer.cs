namespace АРМ_продавца_офисной_техники
{
    partial class RegAuthForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegAuthForm));
            this.ImageLabel = new System.Windows.Forms.Label();
            this.LogTextBox = new System.Windows.Forms.TextBox();
            this.PasTextBox = new System.Windows.Forms.TextBox();
            this.Button = new System.Windows.Forms.Button();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.WTDLabel = new System.Windows.Forms.Label();
            this.LogLabel = new System.Windows.Forms.Label();
            this.PasLabel = new System.Windows.Forms.Label();
            this.LogPanel = new System.Windows.Forms.Panel();
            this.PasPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ToRegLabel = new System.Windows.Forms.Label();
            this.ToAuthLabel = new System.Windows.Forms.Label();
            this.AuthActLabel = new System.Windows.Forms.Label();
            this.RegActLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LogPanel.SuspendLayout();
            this.PasPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ImageLabel
            // 
            this.ImageLabel.BackColor = System.Drawing.Color.Gray;
            this.ImageLabel.Image = ((System.Drawing.Image)(resources.GetObject("ImageLabel.Image")));
            this.ImageLabel.Location = new System.Drawing.Point(480, 0);
            this.ImageLabel.Name = "ImageLabel";
            this.ImageLabel.Size = new System.Drawing.Size(520, 700);
            this.ImageLabel.TabIndex = 1;
            this.ImageLabel.Text = " ";
            this.ImageLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.ImageLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ImageLabel_MouseDown);
            this.ImageLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ImageLabel_MouseMove);
            // 
            // LogTextBox
            // 
            this.LogTextBox.BackColor = System.Drawing.Color.Gray;
            this.LogTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LogTextBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LogTextBox.ForeColor = System.Drawing.Color.White;
            this.LogTextBox.Location = new System.Drawing.Point(10, 30);
            this.LogTextBox.Name = "LogTextBox";
            this.LogTextBox.Size = new System.Drawing.Size(290, 23);
            this.LogTextBox.TabIndex = 2;
            // 
            // PasTextBox
            // 
            this.PasTextBox.BackColor = System.Drawing.Color.Gray;
            this.PasTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PasTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.PasTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasTextBox.ForeColor = System.Drawing.Color.White;
            this.PasTextBox.Location = new System.Drawing.Point(10, 30);
            this.PasTextBox.Name = "PasTextBox";
            this.PasTextBox.Size = new System.Drawing.Size(290, 23);
            this.PasTextBox.TabIndex = 3;
            // 
            // Button
            // 
            this.Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(171)))), ((int)(((byte)(87)))));
            this.Button.FlatAppearance.BorderSize = 0;
            this.Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.Button.Location = new System.Drawing.Point(90, 510);
            this.Button.Name = "Button";
            this.Button.Size = new System.Drawing.Size(200, 50);
            this.Button.TabIndex = 4;
            this.Button.Text = "Войти";
            this.Button.UseVisualStyleBackColor = false;
            // 
            // TopPanel
            // 
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(480, 32);
            this.TopPanel.TabIndex = 5;
            this.TopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseDown);
            this.TopPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseMove);
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.Font = new System.Drawing.Font("Arial Black", 14.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WelcomeLabel.ForeColor = System.Drawing.Color.White;
            this.WelcomeLabel.Location = new System.Drawing.Point(35, 25);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(276, 33);
            this.WelcomeLabel.TabIndex = 6;
            this.WelcomeLabel.Text = "Добро пожаловать!";
            // 
            // WTDLabel
            // 
            this.WTDLabel.AutoSize = true;
            this.WTDLabel.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WTDLabel.ForeColor = System.Drawing.Color.White;
            this.WTDLabel.Location = new System.Drawing.Point(35, 70);
            this.WTDLabel.Name = "WTDLabel";
            this.WTDLabel.Size = new System.Drawing.Size(229, 19);
            this.WTDLabel.TabIndex = 7;
            this.WTDLabel.Text = "Войдите, чтобы продолжить";
            // 
            // LogLabel
            // 
            this.LogLabel.AutoSize = true;
            this.LogLabel.BackColor = System.Drawing.Color.Gray;
            this.LogLabel.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LogLabel.ForeColor = System.Drawing.Color.Silver;
            this.LogLabel.Location = new System.Drawing.Point(15, 11);
            this.LogLabel.Name = "LogLabel";
            this.LogLabel.Size = new System.Drawing.Size(64, 21);
            this.LogLabel.TabIndex = 8;
            this.LogLabel.Text = "Логин:";
            // 
            // PasLabel
            // 
            this.PasLabel.AutoSize = true;
            this.PasLabel.BackColor = System.Drawing.Color.Gray;
            this.PasLabel.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasLabel.ForeColor = System.Drawing.Color.Silver;
            this.PasLabel.Location = new System.Drawing.Point(12, 11);
            this.PasLabel.Name = "PasLabel";
            this.PasLabel.Size = new System.Drawing.Size(79, 21);
            this.PasLabel.TabIndex = 9;
            this.PasLabel.Text = "Пароль:";
            // 
            // LogPanel
            // 
            this.LogPanel.BackColor = System.Drawing.Color.Gray;
            this.LogPanel.Controls.Add(this.LogLabel);
            this.LogPanel.Controls.Add(this.LogTextBox);
            this.LogPanel.Location = new System.Drawing.Point(35, 120);
            this.LogPanel.Name = "LogPanel";
            this.LogPanel.Size = new System.Drawing.Size(300, 60);
            this.LogPanel.TabIndex = 6;
            // 
            // PasPanel
            // 
            this.PasPanel.BackColor = System.Drawing.Color.Gray;
            this.PasPanel.Controls.Add(this.PasLabel);
            this.PasPanel.Controls.Add(this.PasTextBox);
            this.PasPanel.Location = new System.Drawing.Point(35, 190);
            this.PasPanel.Name = "PasPanel";
            this.PasPanel.Size = new System.Drawing.Size(300, 60);
            this.PasPanel.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ToRegLabel);
            this.panel1.Controls.Add(this.ToAuthLabel);
            this.panel1.Controls.Add(this.AuthActLabel);
            this.panel1.Controls.Add(this.RegActLabel);
            this.panel1.Location = new System.Drawing.Point(80, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 60);
            this.panel1.TabIndex = 11;
            // 
            // ToRegLabel
            // 
            this.ToRegLabel.Font = new System.Drawing.Font("Arial", 10.2F);
            this.ToRegLabel.ForeColor = System.Drawing.Color.Silver;
            this.ToRegLabel.Location = new System.Drawing.Point(90, 10);
            this.ToRegLabel.Name = "ToRegLabel";
            this.ToRegLabel.Size = new System.Drawing.Size(115, 25);
            this.ToRegLabel.TabIndex = 13;
            this.ToRegLabel.Text = "Регистрация";
            this.ToRegLabel.Click += new System.EventHandler(this.ToRegLabel_Click);
            // 
            // ToAuthLabel
            // 
            this.ToAuthLabel.Font = new System.Drawing.Font("Arial", 10.2F);
            this.ToAuthLabel.ForeColor = System.Drawing.Color.White;
            this.ToAuthLabel.Location = new System.Drawing.Point(15, 10);
            this.ToAuthLabel.Name = "ToAuthLabel";
            this.ToAuthLabel.Size = new System.Drawing.Size(55, 25);
            this.ToAuthLabel.TabIndex = 12;
            this.ToAuthLabel.Text = "Вход";
            this.ToAuthLabel.Click += new System.EventHandler(this.ToAuthLabel_Click);
            // 
            // AuthActLabel
            // 
            this.AuthActLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(171)))), ((int)(((byte)(87)))));
            this.AuthActLabel.Location = new System.Drawing.Point(15, 12);
            this.AuthActLabel.Name = "AuthActLabel";
            this.AuthActLabel.Size = new System.Drawing.Size(45, 25);
            this.AuthActLabel.TabIndex = 12;
            this.AuthActLabel.Text = " ";
            // 
            // RegActLabel
            // 
            this.RegActLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.RegActLabel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.RegActLabel.Location = new System.Drawing.Point(90, 12);
            this.RegActLabel.Name = "RegActLabel";
            this.RegActLabel.Size = new System.Drawing.Size(95, 25);
            this.RegActLabel.TabIndex = 14;
            this.RegActLabel.Text = " ";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.PasPanel);
            this.panel2.Controls.Add(this.WelcomeLabel);
            this.panel2.Controls.Add(this.WTDLabel);
            this.panel2.Controls.Add(this.LogPanel);
            this.panel2.Location = new System.Drawing.Point(50, 190);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(380, 290);
            this.panel2.TabIndex = 12;
            // 
            // RegAuthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.Button);
            this.Controls.Add(this.ImageLabel);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegAuthForm";
            this.Text = "Form1";
            this.LogPanel.ResumeLayout(false);
            this.LogPanel.PerformLayout();
            this.PasPanel.ResumeLayout(false);
            this.PasPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label ImageLabel;
        private System.Windows.Forms.TextBox LogTextBox;
        private System.Windows.Forms.TextBox PasTextBox;
        private System.Windows.Forms.Button Button;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.Label WTDLabel;
        private System.Windows.Forms.Label LogLabel;
        private System.Windows.Forms.Label PasLabel;
        private System.Windows.Forms.Panel LogPanel;
        private System.Windows.Forms.Panel PasPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label ToRegLabel;
        private System.Windows.Forms.Label ToAuthLabel;
        private System.Windows.Forms.Label AuthActLabel;
        private System.Windows.Forms.Label RegActLabel;
        private System.Windows.Forms.Panel panel2;
    }
}

