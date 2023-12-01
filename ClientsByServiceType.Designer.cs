namespace Course_Project_GUI
{
    partial class ClientsByServiceType
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
            radioButton_Install = new RadioButton();
            radioButton_Repair = new RadioButton();
            listBox_ClientsByServiceType = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(42, 26);
            label1.Name = "label1";
            label1.Size = new Size(231, 30);
            label1.TabIndex = 1;
            label1.Text = "Оберіть тип послуги, \r\nсписок клієнтів якої бажаєте побачити";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // radioButton_Install
            // 
            radioButton_Install.AutoSize = true;
            radioButton_Install.Checked = true;
            radioButton_Install.Location = new Point(51, 73);
            radioButton_Install.Name = "radioButton_Install";
            radioButton_Install.Size = new Size(102, 19);
            radioButton_Install.TabIndex = 2;
            radioButton_Install.TabStop = true;
            radioButton_Install.Text = "Встановлення";
            radioButton_Install.UseVisualStyleBackColor = true;
            radioButton_Install.CheckedChanged += radioButton_Repair_CheckedChanged;
            // 
            // radioButton_Repair
            // 
            radioButton_Repair.AutoSize = true;
            radioButton_Repair.Location = new Point(198, 73);
            radioButton_Repair.Name = "radioButton_Repair";
            radioButton_Repair.Size = new Size(66, 19);
            radioButton_Repair.TabIndex = 3;
            radioButton_Repair.Text = "Ремонт";
            radioButton_Repair.UseVisualStyleBackColor = true;
            radioButton_Repair.CheckedChanged += radioButton_Repair_CheckedChanged;
            // 
            // listBox_ClientsByServiceType
            // 
            listBox_ClientsByServiceType.FormattingEnabled = true;
            listBox_ClientsByServiceType.ItemHeight = 15;
            listBox_ClientsByServiceType.Location = new Point(9, 98);
            listBox_ClientsByServiceType.Name = "listBox_ClientsByServiceType";
            listBox_ClientsByServiceType.Size = new Size(300, 244);
            listBox_ClientsByServiceType.TabIndex = 4;
            listBox_ClientsByServiceType.MouseDoubleClick += listBox_ClientsByServiceType_MouseDoubleClick;
            // 
            // ClientsByServiceType
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(318, 348);
            Controls.Add(listBox_ClientsByServiceType);
            Controls.Add(radioButton_Repair);
            Controls.Add(radioButton_Install);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ClientsByServiceType";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Клієнти за типом послуги";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private RadioButton radioButton_Install;
        private RadioButton radioButton_Repair;
        private ListBox listBox_ClientsByServiceType;
    }
}