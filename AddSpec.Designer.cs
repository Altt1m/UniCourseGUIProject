namespace Course_Project_GUI
{
    partial class AddSpec
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
            label_FullName = new Label();
            label_PhoneNumber = new Label();
            label_BranchName = new Label();
            textBox_FullName = new TextBox();
            textBox_PhoneNumber = new TextBox();
            textBox_BranchName = new TextBox();
            button_addspec = new Button();
            SuspendLayout();
            // 
            // label_FullName
            // 
            label_FullName.AutoSize = true;
            label_FullName.Location = new Point(41, 34);
            label_FullName.Name = "label_FullName";
            label_FullName.Size = new Size(26, 15);
            label_FullName.TabIndex = 0;
            label_FullName.Text = "ПІБ";
            // 
            // label_PhoneNumber
            // 
            label_PhoneNumber.AutoSize = true;
            label_PhoneNumber.Location = new Point(41, 87);
            label_PhoneNumber.Name = "label_PhoneNumber";
            label_PhoneNumber.Size = new Size(101, 15);
            label_PhoneNumber.TabIndex = 1;
            label_PhoneNumber.Text = "Номер телефону";
            // 
            // label_BranchName
            // 
            label_BranchName.AutoSize = true;
            label_BranchName.Location = new Point(41, 142);
            label_BranchName.Name = "label_BranchName";
            label_BranchName.Size = new Size(83, 15);
            label_BranchName.TabIndex = 2;
            label_BranchName.Text = "Назва філіалу";
            // 
            // textBox_FullName
            // 
            textBox_FullName.Location = new Point(215, 34);
            textBox_FullName.Name = "textBox_FullName";
            textBox_FullName.Size = new Size(100, 23);
            textBox_FullName.TabIndex = 3;
            // 
            // textBox_PhoneNumber
            // 
            textBox_PhoneNumber.Location = new Point(215, 87);
            textBox_PhoneNumber.Name = "textBox_PhoneNumber";
            textBox_PhoneNumber.Size = new Size(100, 23);
            textBox_PhoneNumber.TabIndex = 4;
            // 
            // textBox_BranchName
            // 
            textBox_BranchName.Location = new Point(215, 139);
            textBox_BranchName.Name = "textBox_BranchName";
            textBox_BranchName.Size = new Size(100, 23);
            textBox_BranchName.TabIndex = 5;
            // 
            // button_addspec
            // 
            button_addspec.Location = new Point(141, 184);
            button_addspec.Name = "button_addspec";
            button_addspec.Size = new Size(88, 40);
            button_addspec.TabIndex = 6;
            button_addspec.Text = "Додати";
            button_addspec.UseVisualStyleBackColor = true;
            // 
            // AddSpec
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(361, 236);
            Controls.Add(button_addspec);
            Controls.Add(textBox_BranchName);
            Controls.Add(textBox_PhoneNumber);
            Controls.Add(textBox_FullName);
            Controls.Add(label_BranchName);
            Controls.Add(label_PhoneNumber);
            Controls.Add(label_FullName);
            Name = "AddSpec";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Додати майстра";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_FullName;
        private Label label_PhoneNumber;
        private Label label_BranchName;
        private TextBox textBox_FullName;
        private TextBox textBox_PhoneNumber;
        private TextBox textBox_BranchName;
        private Button button_addspec;
    }
}