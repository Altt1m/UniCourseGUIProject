namespace Course_Project_GUI
{
    partial class AddClient
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
            textBox_Address = new TextBox();
            textBox_PhoneNumber = new TextBox();
            textBox_FullName = new TextBox();
            label_BranchName = new Label();
            label_PhoneNumber = new Label();
            label_FullName = new Label();
            button_addclient = new Button();
            SuspendLayout();
            // 
            // textBox_Address
            // 
            textBox_Address.BackColor = Color.DarkGray;
            textBox_Address.BorderStyle = BorderStyle.FixedSingle;
            textBox_Address.Location = new Point(159, 123);
            textBox_Address.Name = "textBox_Address";
            textBox_Address.Size = new Size(100, 23);
            textBox_Address.TabIndex = 12;
            textBox_Address.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox_PhoneNumber
            // 
            textBox_PhoneNumber.BackColor = Color.DarkGray;
            textBox_PhoneNumber.BorderStyle = BorderStyle.FixedSingle;
            textBox_PhoneNumber.Location = new Point(159, 78);
            textBox_PhoneNumber.Name = "textBox_PhoneNumber";
            textBox_PhoneNumber.Size = new Size(100, 23);
            textBox_PhoneNumber.TabIndex = 11;
            textBox_PhoneNumber.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox_FullName
            // 
            textBox_FullName.BackColor = Color.DarkGray;
            textBox_FullName.BorderStyle = BorderStyle.FixedSingle;
            textBox_FullName.Location = new Point(159, 33);
            textBox_FullName.Name = "textBox_FullName";
            textBox_FullName.Size = new Size(100, 23);
            textBox_FullName.TabIndex = 10;
            textBox_FullName.TextAlign = HorizontalAlignment.Center;
            // 
            // label_BranchName
            // 
            label_BranchName.AutoSize = true;
            label_BranchName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label_BranchName.Location = new Point(41, 125);
            label_BranchName.Name = "label_BranchName";
            label_BranchName.Size = new Size(48, 15);
            label_BranchName.TabIndex = 9;
            label_BranchName.Text = "Адреса";
            // 
            // label_PhoneNumber
            // 
            label_PhoneNumber.AutoSize = true;
            label_PhoneNumber.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label_PhoneNumber.Location = new Point(16, 80);
            label_PhoneNumber.Name = "label_PhoneNumber";
            label_PhoneNumber.Size = new Size(104, 15);
            label_PhoneNumber.TabIndex = 8;
            label_PhoneNumber.Text = "Номер телефону";
            // 
            // label_FullName
            // 
            label_FullName.AutoSize = true;
            label_FullName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label_FullName.Location = new Point(51, 35);
            label_FullName.Name = "label_FullName";
            label_FullName.Size = new Size(28, 15);
            label_FullName.TabIndex = 7;
            label_FullName.Text = "ПІБ";
            // 
            // button_addclient
            // 
            button_addclient.BackColor = Color.DarkGray;
            button_addclient.FlatStyle = FlatStyle.Flat;
            button_addclient.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button_addclient.Location = new Point(96, 178);
            button_addclient.Name = "button_addclient";
            button_addclient.Size = new Size(88, 30);
            button_addclient.TabIndex = 13;
            button_addclient.Text = "Додати";
            button_addclient.UseVisualStyleBackColor = false;
            button_addclient.Click += button_addclient_Click;
            // 
            // AddClient
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(280, 230);
            Controls.Add(button_addclient);
            Controls.Add(textBox_Address);
            Controls.Add(textBox_PhoneNumber);
            Controls.Add(textBox_FullName);
            Controls.Add(label_BranchName);
            Controls.Add(label_PhoneNumber);
            Controls.Add(label_FullName);
            Name = "AddClient";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Додати клієнта";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox_Address;
        private TextBox textBox_PhoneNumber;
        private TextBox textBox_FullName;
        private Label label_BranchName;
        private Label label_PhoneNumber;
        private Label label_FullName;
        private Button button_addclient;
    }
}