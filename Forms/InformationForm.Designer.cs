namespace АРМ_продавца_офисной_техники
{
    partial class InformationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InformationForm));
            this.DescrlLabel = new System.Windows.Forms.Label();
            this.ModelLabel = new System.Windows.Forms.Label();
            this.ItemPic = new System.Windows.Forms.Label();
            this.Button = new System.Windows.Forms.Button();
            this.CostLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ExitLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DescrlLabel
            // 
            this.DescrlLabel.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DescrlLabel.ForeColor = System.Drawing.Color.White;
            this.DescrlLabel.Location = new System.Drawing.Point(35, 248);
            this.DescrlLabel.Name = "DescrlLabel";
            this.DescrlLabel.Size = new System.Drawing.Size(367, 102);
            this.DescrlLabel.TabIndex = 9;
            this.DescrlLabel.Text = "15.6\" 1920 x 1080, IPS, 60 Гц, Intel Core i5 1235U, 16 ГБ DDR4, SSD 512 ГБ, видео" +
    "карта встроенная";
            // 
            // ModelLabel
            // 
            this.ModelLabel.Font = new System.Drawing.Font("Arial Black", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ModelLabel.ForeColor = System.Drawing.Color.White;
            this.ModelLabel.Location = new System.Drawing.Point(34, 214);
            this.ModelLabel.Name = "ModelLabel";
            this.ModelLabel.Size = new System.Drawing.Size(381, 26);
            this.ModelLabel.TabIndex = 8;
            this.ModelLabel.Text = "Asus Vivobook 15 X1504ZA-BQ1120";
            // 
            // ItemPic
            // 
            this.ItemPic.Image = ((System.Drawing.Image)(resources.GetObject("ItemPic.Image")));
            this.ItemPic.Location = new System.Drawing.Point(136, 47);
            this.ItemPic.Name = "ItemPic";
            this.ItemPic.Size = new System.Drawing.Size(180, 150);
            this.ItemPic.TabIndex = 7;
            this.ItemPic.Text = " ";
            // 
            // Button
            // 
            this.Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(171)))), ((int)(((byte)(87)))));
            this.Button.Cursor = System.Windows.Forms.Cursors.Default;
            this.Button.FlatAppearance.BorderSize = 0;
            this.Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.Button.Location = new System.Drawing.Point(140, 380);
            this.Button.Name = "Button";
            this.Button.Size = new System.Drawing.Size(160, 45);
            this.Button.TabIndex = 6;
            this.Button.Text = "Подтвердить";
            this.Button.UseVisualStyleBackColor = false;
            this.Button.Click += new System.EventHandler(this.Button_Click);
            // 
            // CostLabel
            // 
            this.CostLabel.AutoSize = true;
            this.CostLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CostLabel.ForeColor = System.Drawing.Color.White;
            this.CostLabel.Location = new System.Drawing.Point(295, 350);
            this.CostLabel.Name = "CostLabel";
            this.CostLabel.Size = new System.Drawing.Size(107, 19);
            this.CostLabel.TabIndex = 5;
            this.CostLabel.Text = "2049,00 BYN";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ExitLabel);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 32);
            this.panel1.TabIndex = 10;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // ExitLabel
            // 
            this.ExitLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitLabel.Image = ((System.Drawing.Image)(resources.GetObject("ExitLabel.Image")));
            this.ExitLabel.Location = new System.Drawing.Point(418, 0);
            this.ExitLabel.Name = "ExitLabel";
            this.ExitLabel.Size = new System.Drawing.Size(32, 29);
            this.ExitLabel.TabIndex = 2;
            this.ExitLabel.Text = " ";
            this.ExitLabel.Click += new System.EventHandler(this.ExitLabel_Click);
            // 
            // InformationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(450, 470);
            this.Controls.Add(this.CostLabel);
            this.Controls.Add(this.ModelLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ItemPic);
            this.Controls.Add(this.Button);
            this.Controls.Add(this.DescrlLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InformationForm";
            this.Text = "InformationForm";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DescrlLabel;
        private System.Windows.Forms.Label ModelLabel;
        private System.Windows.Forms.Label ItemPic;
        private System.Windows.Forms.Button Button;
        private System.Windows.Forms.Label CostLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label ExitLabel;
    }
}