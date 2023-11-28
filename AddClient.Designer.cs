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
            button_addclient = new Button();
            textBox_Address = new TextBox();
            textBox_PhoneNumber = new TextBox();
            textBox_FullName = new TextBox();
            label_BranchName = new Label();
            label_PhoneNumber = new Label();
            label_FullName = new Label();
            SuspendLayout();
            // 
            // button_addclient
            // 
            button_addclient.Location = new Point(129, 178);
            button_addclient.Name = "button_addclient";
            button_addclient.Size = new Size(88, 40);
            button_addclient.TabIndex = 13;
            button_addclient.Text = "Додати";
            button_addclient.UseVisualStyleBackColor = true;
            // 
            // textBox_Address
            // 
            textBox_Address.Location = new Point(203, 133);
            textBox_Address.Name = "textBox_Address";
            textBox_Address.Size = new Size(100, 23);
            textBox_Address.TabIndex = 12;
            // 
            // textBox_PhoneNumber
            // 
            textBox_PhoneNumber.Location = new Point(203, 81);
            textBox_PhoneNumber.Name = "textBox_PhoneNumber";
            textBox_PhoneNumber.Size = new Size(100, 23);
            textBox_PhoneNumber.TabIndex = 11;
            // 
            // textBox_FullName
            // 
            textBox_FullName.Location = new Point(203, 28);
            textBox_FullName.Name = "textBox_FullName";
            textBox_FullName.Size = new Size(100, 23);
            textBox_FullName.TabIndex = 10;
            // 
            // label_BranchName
            // 
            label_BranchName.AutoSize = true;
            label_BranchName.Location = new Point(29, 136);
            label_BranchName.Name = "label_BranchName";
            label_BranchName.Size = new Size(46, 15);
            label_BranchName.TabIndex = 9;
            label_BranchName.Text = "Адреса";
            // 
            // label_PhoneNumber
            // 
            label_PhoneNumber.AutoSize = true;
            label_PhoneNumber.Location = new Point(29, 81);
            label_PhoneNumber.Name = "label_PhoneNumber";
            label_PhoneNumber.Size = new Size(101, 15);
            label_PhoneNumber.TabIndex = 8;
            label_PhoneNumber.Text = "Номер телефону";
            // 
            // label_FullName
            // 
            label_FullName.AutoSize = true;
            label_FullName.Location = new Point(29, 28);
            label_FullName.Name = "label_FullName";
            label_FullName.Size = new Size(26, 15);
            label_FullName.TabIndex = 7;
            label_FullName.Text = "ПІБ";
            // 
            // AddClient
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(338, 238);
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

        private Button button_addclient;
        private TextBox textBox_Address;
        private TextBox textBox_PhoneNumber;
        private TextBox textBox_FullName;
        private Label label_BranchName;
        private Label label_PhoneNumber;
        private Label label_FullName;
    }
}