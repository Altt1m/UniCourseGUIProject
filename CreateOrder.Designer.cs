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
            textBox_DeviceName = new TextBox();
            textBox_DateOfStart = new TextBox();
            textBox_DeviceVendor = new TextBox();
            textBox_Cost = new TextBox();
            button_createorder = new Button();
            radioButton_Install = new RadioButton();
            radioButton_Repair = new RadioButton();
            textBox_WorkPeriod = new TextBox();
            label8 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(58, 33);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 0;
            label1.Text = "Майстер:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(65, 73);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 1;
            label2.Text = "Клієнт:";
            // 
            // comboBox_Specs
            // 
            comboBox_Specs.BackColor = Color.DarkGray;
            comboBox_Specs.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_Specs.FormattingEnabled = true;
            comboBox_Specs.Location = new Point(184, 31);
            comboBox_Specs.Name = "comboBox_Specs";
            comboBox_Specs.Size = new Size(205, 23);
            comboBox_Specs.TabIndex = 2;
            // 
            // comboBox_Clients
            // 
            comboBox_Clients.BackColor = Color.DarkGray;
            comboBox_Clients.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_Clients.FormattingEnabled = true;
            comboBox_Clients.Location = new Point(184, 71);
            comboBox_Clients.Name = "comboBox_Clients";
            comboBox_Clients.Size = new Size(205, 23);
            comboBox_Clients.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(49, 126);
            label3.Name = "label3";
            label3.Size = new Size(79, 15);
            label3.TabIndex = 4;
            label3.Text = "Вид послуги";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(42, 175);
            label4.Name = "label4";
            label4.Size = new Size(93, 15);
            label4.TabIndex = 5;
            label4.Text = "Назва прибору";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(29, 209);
            label5.Name = "label5";
            label5.Size = new Size(118, 15);
            label5.TabIndex = 6;
            label5.Text = "Виробник прибору";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(48, 243);
            label6.Name = "label6";
            label6.Size = new Size(81, 15);
            label6.TabIndex = 7;
            label6.Text = "Дата початку";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(61, 309);
            label7.Name = "label7";
            label7.Size = new Size(54, 15);
            label7.TabIndex = 8;
            label7.Text = "Вартість";
            // 
            // textBox_DeviceName
            // 
            textBox_DeviceName.BackColor = Color.DarkGray;
            textBox_DeviceName.BorderStyle = BorderStyle.FixedSingle;
            textBox_DeviceName.Location = new Point(206, 173);
            textBox_DeviceName.Name = "textBox_DeviceName";
            textBox_DeviceName.Size = new Size(160, 23);
            textBox_DeviceName.TabIndex = 11;
            textBox_DeviceName.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox_DateOfStart
            // 
            textBox_DateOfStart.BackColor = Color.DarkGray;
            textBox_DateOfStart.BorderStyle = BorderStyle.FixedSingle;
            textBox_DateOfStart.Location = new Point(206, 241);
            textBox_DateOfStart.Name = "textBox_DateOfStart";
            textBox_DateOfStart.Size = new Size(160, 23);
            textBox_DateOfStart.TabIndex = 13;
            textBox_DateOfStart.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox_DeviceVendor
            // 
            textBox_DeviceVendor.BackColor = Color.DarkGray;
            textBox_DeviceVendor.BorderStyle = BorderStyle.FixedSingle;
            textBox_DeviceVendor.Location = new Point(206, 207);
            textBox_DeviceVendor.Name = "textBox_DeviceVendor";
            textBox_DeviceVendor.Size = new Size(160, 23);
            textBox_DeviceVendor.TabIndex = 12;
            textBox_DeviceVendor.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox_Cost
            // 
            textBox_Cost.BackColor = Color.DarkGray;
            textBox_Cost.BorderStyle = BorderStyle.FixedSingle;
            textBox_Cost.Location = new Point(206, 307);
            textBox_Cost.Name = "textBox_Cost";
            textBox_Cost.Size = new Size(160, 23);
            textBox_Cost.TabIndex = 15;
            textBox_Cost.TextAlign = HorizontalAlignment.Center;
            // 
            // button_createorder
            // 
            button_createorder.BackColor = Color.DarkGray;
            button_createorder.FlatStyle = FlatStyle.Flat;
            button_createorder.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button_createorder.Location = new Point(164, 368);
            button_createorder.Name = "button_createorder";
            button_createorder.Size = new Size(88, 30);
            button_createorder.TabIndex = 16;
            button_createorder.Text = "Створити";
            button_createorder.UseVisualStyleBackColor = false;
            button_createorder.Click += button_createorder_Click;
            // 
            // radioButton_Install
            // 
            radioButton_Install.AutoSize = true;
            radioButton_Install.Checked = true;
            radioButton_Install.Location = new Point(199, 124);
            radioButton_Install.Name = "radioButton_Install";
            radioButton_Install.Size = new Size(102, 19);
            radioButton_Install.TabIndex = 16;
            radioButton_Install.TabStop = true;
            radioButton_Install.Text = "Встановлення";
            radioButton_Install.UseVisualStyleBackColor = true;
            // 
            // radioButton_Repair
            // 
            radioButton_Repair.AutoSize = true;
            radioButton_Repair.Location = new Point(307, 124);
            radioButton_Repair.Name = "radioButton_Repair";
            radioButton_Repair.Size = new Size(66, 19);
            radioButton_Repair.TabIndex = 17;
            radioButton_Repair.Text = "Ремонт";
            radioButton_Repair.UseVisualStyleBackColor = true;
            // 
            // textBox_WorkPeriod
            // 
            textBox_WorkPeriod.BackColor = Color.DarkGray;
            textBox_WorkPeriod.BorderStyle = BorderStyle.FixedSingle;
            textBox_WorkPeriod.Location = new Point(206, 274);
            textBox_WorkPeriod.Name = "textBox_WorkPeriod";
            textBox_WorkPeriod.Size = new Size(160, 23);
            textBox_WorkPeriod.TabIndex = 14;
            textBox_WorkPeriod.TextAlign = HorizontalAlignment.Center;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(43, 276);
            label8.Name = "label8";
            label8.Size = new Size(90, 15);
            label8.TabIndex = 18;
            label8.Text = "Термін роботи";
            // 
            // CreateOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(416, 413);
            Controls.Add(textBox_WorkPeriod);
            Controls.Add(label8);
            Controls.Add(radioButton_Repair);
            Controls.Add(radioButton_Install);
            Controls.Add(button_createorder);
            Controls.Add(textBox_Cost);
            Controls.Add(textBox_DateOfStart);
            Controls.Add(textBox_DeviceVendor);
            Controls.Add(textBox_DeviceName);
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
        private TextBox textBox_DeviceName;
        private TextBox textBox_DateOfStart;
        private TextBox textBox_DeviceVendor;
        private TextBox textBox_Cost;
        private Button button_createorder;
        private RadioButton radioButton_Install;
        private RadioButton radioButton_Repair;
        private TextBox textBox_WorkPeriod;
        private Label label8;
    }
}