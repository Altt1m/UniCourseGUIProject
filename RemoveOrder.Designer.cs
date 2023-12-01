namespace Course_Project_GUI
{
    partial class RemoveOrder
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
            listBox_OrdersToRemove = new ListBox();
            SuspendLayout();
            // 
            // listBox_OrdersToRemove
            // 
            listBox_OrdersToRemove.FormattingEnabled = true;
            listBox_OrdersToRemove.ItemHeight = 15;
            listBox_OrdersToRemove.Location = new Point(9, 11);
            listBox_OrdersToRemove.Name = "listBox_OrdersToRemove";
            listBox_OrdersToRemove.Size = new Size(393, 259);
            listBox_OrdersToRemove.TabIndex = 1;
            listBox_OrdersToRemove.MouseDoubleClick += listBox_OrdersToRemove_MouseDoubleClick;
            // 
            // RemoveOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(411, 281);
            Controls.Add(listBox_OrdersToRemove);
            Name = "RemoveOrder";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RemoveOrder";
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox_OrdersToRemove;
    }
}