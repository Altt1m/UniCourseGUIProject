namespace Course_Project_GUI
{
    partial class ClientsList
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
            listBox_Clients = new ListBox();
            SuspendLayout();
            // 
            // listBox_Clients
            // 
            listBox_Clients.FormattingEnabled = true;
            listBox_Clients.ItemHeight = 15;
            listBox_Clients.Location = new Point(12, 14);
            listBox_Clients.Name = "listBox_Clients";
            listBox_Clients.Size = new Size(300, 244);
            listBox_Clients.TabIndex = 0;
            listBox_Clients.MouseDoubleClick += listBox_Clients_MouseDoubleClick;
            // 
            // ClientsList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(324, 271);
            Controls.Add(listBox_Clients);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ClientsList";
            Text = "Клієнти";
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox_Clients;
    }
}