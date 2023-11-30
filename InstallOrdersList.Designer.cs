namespace Course_Project_GUI
{
    partial class InstallOrdersList
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
            listBox_InstallOrders = new ListBox();
            SuspendLayout();
            // 
            // listBox_InstallOrders
            // 
            listBox_InstallOrders.FormattingEnabled = true;
            listBox_InstallOrders.ItemHeight = 15;
            listBox_InstallOrders.Location = new Point(9, 10);
            listBox_InstallOrders.Name = "listBox_InstallOrders";
            listBox_InstallOrders.Size = new Size(393, 259);
            listBox_InstallOrders.TabIndex = 1;
            listBox_InstallOrders.MouseDoubleClick += listBox_InstallOrders_MouseDoubleClick;
            // 
            // InstallOrdersList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(411, 281);
            Controls.Add(listBox_InstallOrders);
            Name = "InstallOrdersList";
            Text = "InstallOrdersList";
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox_InstallOrders;
    }
}