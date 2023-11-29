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
            button_OpenAddSpec = new Button();
            button_OpenAddClient = new Button();
            button_OpenCreateOrder = new Button();
            button_RepairOrdersList = new Button();
            button_InstallOrdersList = new Button();
            button_ClientsByServiceType = new Button();
            label_AverageOrderCost = new Label();
            label_LongestWorkPeriod = new Label();
            label_MostExpensiveOrder = new Label();
            SuspendLayout();
            // 
            // button_OpenAddSpec
            // 
            button_OpenAddSpec.BackColor = Color.DarkGray;
            button_OpenAddSpec.FlatStyle = FlatStyle.Flat;
            button_OpenAddSpec.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button_OpenAddSpec.Location = new Point(18, 26);
            button_OpenAddSpec.Name = "button_OpenAddSpec";
            button_OpenAddSpec.Size = new Size(124, 40);
            button_OpenAddSpec.TabIndex = 0;
            button_OpenAddSpec.Text = "Додати майстра";
            button_OpenAddSpec.UseVisualStyleBackColor = false;
            button_OpenAddSpec.Click += button_OpenAddSpec_Click;
            // 
            // button_OpenAddClient
            // 
            button_OpenAddClient.BackColor = Color.DarkGray;
            button_OpenAddClient.FlatStyle = FlatStyle.Flat;
            button_OpenAddClient.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button_OpenAddClient.Location = new Point(18, 72);
            button_OpenAddClient.Name = "button_OpenAddClient";
            button_OpenAddClient.Size = new Size(124, 40);
            button_OpenAddClient.TabIndex = 1;
            button_OpenAddClient.Text = "Додати клієнта";
            button_OpenAddClient.UseVisualStyleBackColor = false;
            button_OpenAddClient.Click += button_OpenAddClient_Click;
            // 
            // button_OpenCreateOrder
            // 
            button_OpenCreateOrder.BackColor = Color.DarkGray;
            button_OpenCreateOrder.FlatStyle = FlatStyle.Flat;
            button_OpenCreateOrder.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button_OpenCreateOrder.Location = new Point(18, 118);
            button_OpenCreateOrder.Name = "button_OpenCreateOrder";
            button_OpenCreateOrder.Size = new Size(124, 40);
            button_OpenCreateOrder.TabIndex = 2;
            button_OpenCreateOrder.Text = "Створити замовлення";
            button_OpenCreateOrder.UseVisualStyleBackColor = false;
            button_OpenCreateOrder.Click += button_OpenCreateOrder_Click;
            // 
            // button_RepairOrdersList
            // 
            button_RepairOrdersList.BackColor = Color.DarkGray;
            button_RepairOrdersList.FlatStyle = FlatStyle.Flat;
            button_RepairOrdersList.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button_RepairOrdersList.Location = new Point(148, 26);
            button_RepairOrdersList.Name = "button_RepairOrdersList";
            button_RepairOrdersList.Size = new Size(134, 40);
            button_RepairOrdersList.TabIndex = 3;
            button_RepairOrdersList.Text = "Список замовлень на ремонт";
            button_RepairOrdersList.UseVisualStyleBackColor = false;
            button_RepairOrdersList.Click += button_RepairOrdersList_Click;
            // 
            // button_InstallOrdersList
            // 
            button_InstallOrdersList.BackColor = Color.DarkGray;
            button_InstallOrdersList.FlatStyle = FlatStyle.Flat;
            button_InstallOrdersList.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button_InstallOrdersList.Location = new Point(148, 72);
            button_InstallOrdersList.Name = "button_InstallOrdersList";
            button_InstallOrdersList.Size = new Size(134, 40);
            button_InstallOrdersList.TabIndex = 4;
            button_InstallOrdersList.Text = "Список замовлень на встановлення";
            button_InstallOrdersList.UseVisualStyleBackColor = false;
            button_InstallOrdersList.Click += button_InstallOrdersList_Click;
            // 
            // button_ClientsByServiceType
            // 
            button_ClientsByServiceType.BackColor = Color.DarkGray;
            button_ClientsByServiceType.FlatStyle = FlatStyle.Flat;
            button_ClientsByServiceType.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button_ClientsByServiceType.Location = new Point(148, 118);
            button_ClientsByServiceType.Name = "button_ClientsByServiceType";
            button_ClientsByServiceType.Size = new Size(134, 40);
            button_ClientsByServiceType.TabIndex = 5;
            button_ClientsByServiceType.Text = "Список клієнтів за типом послуги";
            button_ClientsByServiceType.UseVisualStyleBackColor = false;
            button_ClientsByServiceType.Click += button_ClientsByServiceType_Click;
            // 
            // label_AverageOrderCost
            // 
            label_AverageOrderCost.AutoSize = true;
            label_AverageOrderCost.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label_AverageOrderCost.Location = new Point(299, 39);
            label_AverageOrderCost.Name = "label_AverageOrderCost";
            label_AverageOrderCost.Size = new Size(206, 15);
            label_AverageOrderCost.TabIndex = 10;
            label_AverageOrderCost.Text = "Середня вартість замовлення: N/A";
            // 
            // label_LongestWorkPeriod
            // 
            label_LongestWorkPeriod.AutoSize = true;
            label_LongestWorkPeriod.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label_LongestWorkPeriod.Location = new Point(299, 85);
            label_LongestWorkPeriod.Name = "label_LongestWorkPeriod";
            label_LongestWorkPeriod.Size = new Size(212, 15);
            label_LongestWorkPeriod.TabIndex = 11;
            label_LongestWorkPeriod.Text = "Найдовший термін виконання: N/A";
            // 
            // label_MostExpensiveOrder
            // 
            label_MostExpensiveOrder.AutoSize = true;
            label_MostExpensiveOrder.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label_MostExpensiveOrder.Location = new Point(299, 131);
            label_MostExpensiveOrder.Name = "label_MostExpensiveOrder";
            label_MostExpensiveOrder.Size = new Size(183, 15);
            label_MostExpensiveOrder.TabIndex = 12;
            label_MostExpensiveOrder.Text = "Найдорожче замовлення: N/A";
            // 
            // MainWin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(561, 183);
            Controls.Add(label_MostExpensiveOrder);
            Controls.Add(label_LongestWorkPeriod);
            Controls.Add(label_AverageOrderCost);
            Controls.Add(button_ClientsByServiceType);
            Controls.Add(button_InstallOrdersList);
            Controls.Add(button_RepairOrdersList);
            Controls.Add(button_OpenCreateOrder);
            Controls.Add(button_OpenAddClient);
            Controls.Add(button_OpenAddSpec);
            ForeColor = SystemColors.ControlText;
            Name = "MainWin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Course Project GUI";
            Load += MainWin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_OpenAddSpec;
        private Button button_OpenAddClient;
        private Button button_OpenCreateOrder;
        private Button button_RepairOrdersList;
        private Button button_InstallOrdersList;
        private Button button_ClientsByServiceType;
        private Label label_AverageOrderCost;
        private Label label_LongestWorkPeriod;
        private Label label_MostExpensiveOrder;
    }
}