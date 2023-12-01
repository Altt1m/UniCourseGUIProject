namespace Course_Project_GUI
{
    partial class AllSpecsList
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
            listBox_AllSpecs = new ListBox();
            SuspendLayout();
            // 
            // listBox_AllSpecs
            // 
            listBox_AllSpecs.FormattingEnabled = true;
            listBox_AllSpecs.ItemHeight = 15;
            listBox_AllSpecs.Location = new Point(12, 14);
            listBox_AllSpecs.Name = "listBox_AllSpecs";
            listBox_AllSpecs.Size = new Size(300, 244);
            listBox_AllSpecs.TabIndex = 0;
            listBox_AllSpecs.MouseDoubleClick += listBox_AllSpecs_MouseDoubleClick;
            // 
            // AllSpecsList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(324, 271);
            Controls.Add(listBox_AllSpecs);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "AllSpecsList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AllSpecsList";
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox_AllSpecs;
    }
}