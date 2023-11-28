namespace Course_Project_GUI
{
    partial class CreateOrder
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
            label1 = new Label();
            label2 = new Label();
            comboBox_Specs = new ComboBox();
            comboBox_Clients = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            textBox_ServiceType = new TextBox();
            textBox_DeviceName = new TextBox();
            textBox_DateOfStart = new TextBox();
            textBox_DeviceVendor = new TextBox();
            textBox_Cost = new TextBox();
            button_addspec = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 15);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Мастер:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 55);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 1;
            label2.Text = "Клієнт:";
            // 
            // comboBox_Specs
            // 
            comboBox_Specs.FormattingEnabled = true;
            comboBox_Specs.Location = new Point(177, 12);
            comboBox_Specs.Name = "comboBox_Specs";
            comboBox_Specs.Size = new Size(121, 23);
            comboBox_Specs.TabIndex = 2;
            // 
            // comboBox_Clients
            // 
            comboBox_Clients.FormattingEnabled = true;
            comboBox_Clients.Location = new Point(177, 52);
            comboBox_Clients.Name = "comboBox_Clients";
            comboBox_Clients.Size = new Size(121, 23);
            comboBox_Clients.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 108);
            label3.Name = "label3";
            label3.Size = new Size(75, 15);
            label3.TabIndex = 4;
            label3.Text = "Вид послуги";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 143);
            label4.Name = "label4";
            label4.Size = new Size(90, 15);
            label4.TabIndex = 5;
            label4.Text = "Назва прибору";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 177);
            label5.Name = "label5";
            label5.Size = new Size(113, 15);
            label5.TabIndex = 6;
            label5.Text = "Виробник прибору";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(17, 210);
            label6.Name = "label6";
            label6.Size = new Size(79, 15);
            label6.TabIndex = 7;
            label6.Text = "Дата початку";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(17, 244);
            label7.Name = "label7";
            label7.Size = new Size(52, 15);
            label7.TabIndex = 8;
            label7.Text = "Вартість";
            // 
            // textBox_ServiceType
            // 
            textBox_ServiceType.Location = new Point(188, 105);
            textBox_ServiceType.Name = "textBox_ServiceType";
            textBox_ServiceType.Size = new Size(100, 23);
            textBox_ServiceType.TabIndex = 10;
            // 
            // textBox_DeviceName
            // 
            textBox_DeviceName.Location = new Point(188, 140);
            textBox_DeviceName.Name = "textBox_DeviceName";
            textBox_DeviceName.Size = new Size(100, 23);
            textBox_DeviceName.TabIndex = 11;
            // 
            // textBox_DateOfStart
            // 
            textBox_DateOfStart.Location = new Point(188, 207);
            textBox_DateOfStart.Name = "textBox_DateOfStart";
            textBox_DateOfStart.Size = new Size(100, 23);
            textBox_DateOfStart.TabIndex = 13;
            // 
            // textBox_DeviceVendor
            // 
            textBox_DeviceVendor.Location = new Point(188, 174);
            textBox_DeviceVendor.Name = "textBox_DeviceVendor";
            textBox_DeviceVendor.Size = new Size(100, 23);
            textBox_DeviceVendor.TabIndex = 12;
            // 
            // textBox_Cost
            // 
            textBox_Cost.Location = new Point(188, 241);
            textBox_Cost.Name = "textBox_Cost";
            textBox_Cost.Size = new Size(100, 23);
            textBox_Cost.TabIndex = 14;
            // 
            // button_addspec
            // 
            button_addspec.Location = new Point(113, 288);
            button_addspec.Name = "button_addspec";
            button_addspec.Size = new Size(88, 40);
            button_addspec.TabIndex = 15;
            button_addspec.Text = "Додати";
            button_addspec.UseVisualStyleBackColor = true;
            // 
            // CreateOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(322, 346);
            Controls.Add(button_addspec);
            Controls.Add(textBox_Cost);
            Controls.Add(textBox_DateOfStart);
            Controls.Add(textBox_DeviceVendor);
            Controls.Add(textBox_DeviceName);
            Controls.Add(textBox_ServiceType);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(comboBox_Clients);
            Controls.Add(comboBox_Specs);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CreateOrder";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Створити замовлення";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox comboBox_Specs;
        private ComboBox comboBox_Clients;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textBox_ServiceType;
        private TextBox textBox_DeviceName;
        private TextBox textBox_DateOfStart;
        private TextBox textBox_DeviceVendor;
        private TextBox textBox_Cost;
        private Button button_addspec;
    }
}