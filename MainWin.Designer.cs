namespace Course_Project_GUI
{
    partial class MainWin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Gray;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(64, 148);
            button1.Name = "button1";
            button1.Size = new Size(114, 40);
            button1.TabIndex = 0;
            button1.Text = "AddSpec";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Gray;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(214, 148);
            button2.Name = "button2";
            button2.Size = new Size(114, 40);
            button2.TabIndex = 1;
            button2.Text = "AddClient";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Gray;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(365, 148);
            button3.Name = "button3";
            button3.Size = new Size(114, 40);
            button3.TabIndex = 2;
            button3.Text = "CreateOrder";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // MainWin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(69, 69, 69);
            ClientSize = new Size(549, 403);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            ForeColor = SystemColors.ControlText;
            Name = "MainWin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Course Project GUI";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
    }
}