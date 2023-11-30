namespace Course_Project_GUI
{
    partial class OrdersList
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
            listBox_Orders = new ListBox();
            SuspendLayout();
            // 
            // listBox_Orders
            // 
            listBox_Orders.FormattingEnabled = true;
            listBox_Orders.ItemHeight = 15;
            listBox_Orders.Location = new Point(12, 12);
            listBox_Orders.Name = "listBox_Orders";
            listBox_Orders.Size = new Size(393, 259);
            listBox_Orders.TabIndex = 0;
            listBox_Orders.MouseDoubleClick += listBox1_MouseDoubleClick;
            // 
            // OrdersList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(417, 285);
            Controls.Add(listBox_Orders);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "OrdersList";
            Text = "Всі замовлення";
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox_Orders;
    }
}