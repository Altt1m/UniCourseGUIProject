namespace Course_Project_GUI
{
    partial class RepairOrdersList
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
            listBox_RepairOrders = new ListBox();
            SuspendLayout();
            // 
            // listBox_RepairOrders
            // 
            listBox_RepairOrders.FormattingEnabled = true;
            listBox_RepairOrders.ItemHeight = 15;
            listBox_RepairOrders.Location = new Point(9, 10);
            listBox_RepairOrders.Name = "listBox_RepairOrders";
            listBox_RepairOrders.Size = new Size(393, 259);
            listBox_RepairOrders.TabIndex = 1;
            listBox_RepairOrders.MouseDoubleClick += listBox_RepairOrders_MouseDoubleClick;
            // 
            // RepairOrdersList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(411, 281);
            Controls.Add(listBox_RepairOrders);
            Name = "RepairOrdersList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RepairOrdersList";
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox_RepairOrders;
    }
}