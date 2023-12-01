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
            label_AvailableSpecs = new Label();
            label_Clients = new Label();
            button_OrdersList = new Button();
            button_OpenRemoveOrder = new Button();
            button_Сlients = new Button();
            button_AllSpecs = new Button();
            SuspendLayout();
            // 
            // button_OpenAddSpec
            // 
            button_OpenAddSpec.BackColor = Color.DarkGray;
            button_OpenAddSpec.FlatStyle = FlatStyle.Flat;
            button_OpenAddSpec.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button_OpenAddSpec.Location = new Point(9, 17);
            button_OpenAddSpec.Name = "button_OpenAddSpec";
            button_OpenAddSpec.Size = new Size(150, 40);
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
            button_OpenAddClient.Location = new Point(9, 63);
            button_OpenAddClient.Name = "button_OpenAddClient";
            button_OpenAddClient.Size = new Size(149, 40);
            button_OpenAddClient.TabIndex = 2;
            button_OpenAddClient.Text = "Додати клієнта";
            button_OpenAddClient.UseVisualStyleBackColor = false;
            button_OpenAddClient.Click += button_OpenAddClient_Click;
            // 
            // button_OpenCreateOrder
            // 
            button_OpenCreateOrder.BackColor = Color.DarkGray;
            button_OpenCreateOrder.Enabled = false;
            button_OpenCreateOrder.FlatStyle = FlatStyle.Flat;
            button_OpenCreateOrder.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button_OpenCreateOrder.Location = new Point(9, 121);
            button_OpenCreateOrder.Name = "button_OpenCreateOrder";
            button_OpenCreateOrder.Size = new Size(149, 40);
            button_OpenCreateOrder.TabIndex = 4;
            button_OpenCreateOrder.Text = "Створити замовлення";
            button_OpenCreateOrder.UseVisualStyleBackColor = false;
            button_OpenCreateOrder.Click += button_OpenCreateOrder_Click;
            // 
            // button_RepairOrdersList
            // 
            button_RepairOrdersList.BackColor = Color.DarkGray;
            button_RepairOrdersList.Enabled = false;
            button_RepairOrdersList.FlatStyle = FlatStyle.Flat;
            button_RepairOrdersList.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button_RepairOrdersList.Location = new Point(164, 213);
            button_RepairOrdersList.Name = "button_RepairOrdersList";
            button_RepairOrdersList.Size = new Size(134, 40);
            button_RepairOrdersList.TabIndex = 9;
            button_RepairOrdersList.Text = "Список замовлень на ремонт";
            button_RepairOrdersList.UseVisualStyleBackColor = false;
            button_RepairOrdersList.Click += button_RepairOrdersList_Click;
            // 
            // button_InstallOrdersList
            // 
            button_InstallOrdersList.BackColor = Color.DarkGray;
            button_InstallOrdersList.Enabled = false;
            button_InstallOrdersList.FlatStyle = FlatStyle.Flat;
            button_InstallOrdersList.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button_InstallOrdersList.Location = new Point(9, 213);
            button_InstallOrdersList.Name = "button_InstallOrdersList";
            button_InstallOrdersList.Size = new Size(149, 40);
            button_InstallOrdersList.TabIndex = 8;
            button_InstallOrdersList.Text = "Список замовлень на встановлення";
            button_InstallOrdersList.UseVisualStyleBackColor = false;
            button_InstallOrdersList.Click += button_InstallOrdersList_Click;
            // 
            // button_ClientsByServiceType
            // 
            button_ClientsByServiceType.BackColor = Color.DarkGray;
            button_ClientsByServiceType.Enabled = false;
            button_ClientsByServiceType.FlatStyle = FlatStyle.Flat;
            button_ClientsByServiceType.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button_ClientsByServiceType.Location = new Point(164, 167);
            button_ClientsByServiceType.Name = "button_ClientsByServiceType";
            button_ClientsByServiceType.Size = new Size(134, 40);
            button_ClientsByServiceType.TabIndex = 7;
            button_ClientsByServiceType.Text = "Клієнти за типом послуги";
            button_ClientsByServiceType.UseVisualStyleBackColor = false;
            button_ClientsByServiceType.Click += button_ClientsByServiceType_Click;
            // 
            // label_AverageOrderCost
            // 
            label_AverageOrderCost.AutoSize = true;
            label_AverageOrderCost.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label_AverageOrderCost.Location = new Point(315, 134);
            label_AverageOrderCost.Name = "label_AverageOrderCost";
            label_AverageOrderCost.Size = new Size(206, 15);
            label_AverageOrderCost.TabIndex = 10;
            label_AverageOrderCost.Text = "Середня вартість замовлення: N/A";
            // 
            // label_LongestWorkPeriod
            // 
            label_LongestWorkPeriod.AutoSize = true;
            label_LongestWorkPeriod.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label_LongestWorkPeriod.Location = new Point(315, 180);
            label_LongestWorkPeriod.Name = "label_LongestWorkPeriod";
            label_LongestWorkPeriod.Size = new Size(260, 15);
            label_LongestWorkPeriod.TabIndex = 11;
            label_LongestWorkPeriod.Text = "Найдовший термін виконання (у днях): N/A";
            // 
            // label_MostExpensiveOrder
            // 
            label_MostExpensiveOrder.AutoSize = true;
            label_MostExpensiveOrder.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label_MostExpensiveOrder.Location = new Point(315, 226);
            label_MostExpensiveOrder.Name = "label_MostExpensiveOrder";
            label_MostExpensiveOrder.Size = new Size(183, 15);
            label_MostExpensiveOrder.TabIndex = 12;
            label_MostExpensiveOrder.Text = "Найдорожче замовлення: N/A";
            // 
            // label_AvailableSpecs
            // 
            label_AvailableSpecs.AutoSize = true;
            label_AvailableSpecs.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label_AvailableSpecs.Location = new Point(315, 30);
            label_AvailableSpecs.Name = "label_AvailableSpecs";
            label_AvailableSpecs.Size = new Size(122, 15);
            label_AvailableSpecs.TabIndex = 13;
            label_AvailableSpecs.Text = "Вільні майстри: N/A";
            // 
            // label_Clients
            // 
            label_Clients.AutoSize = true;
            label_Clients.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label_Clients.Location = new Point(315, 76);
            label_Clients.Name = "label_Clients";
            label_Clients.Size = new Size(64, 15);
            label_Clients.TabIndex = 14;
            label_Clients.Text = "Клієнти: 0";
            // 
            // button_OrdersList
            // 
            button_OrdersList.BackColor = Color.DarkGray;
            button_OrdersList.Enabled = false;
            button_OrdersList.FlatStyle = FlatStyle.Flat;
            button_OrdersList.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button_OrdersList.Location = new Point(9, 167);
            button_OrdersList.Name = "button_OrdersList";
            button_OrdersList.Size = new Size(149, 40);
            button_OrdersList.TabIndex = 6;
            button_OrdersList.Text = "Всі замовлення";
            button_OrdersList.UseVisualStyleBackColor = false;
            button_OrdersList.Click += button_OrdersList_Click;
            // 
            // button_OpenRemoveOrder
            // 
            button_OpenRemoveOrder.BackColor = Color.DarkGray;
            button_OpenRemoveOrder.Enabled = false;
            button_OpenRemoveOrder.FlatStyle = FlatStyle.Flat;
            button_OpenRemoveOrder.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button_OpenRemoveOrder.Location = new Point(164, 121);
            button_OpenRemoveOrder.Name = "button_OpenRemoveOrder";
            button_OpenRemoveOrder.Size = new Size(134, 40);
            button_OpenRemoveOrder.TabIndex = 5;
            button_OpenRemoveOrder.Text = "Прибрати замовлення";
            button_OpenRemoveOrder.UseVisualStyleBackColor = false;
            button_OpenRemoveOrder.Click += button_OpenRemoveOrder_Click;
            // 
            // button_Сlients
            // 
            button_Сlients.BackColor = Color.DarkGray;
            button_Сlients.Enabled = false;
            button_Сlients.FlatStyle = FlatStyle.Flat;
            button_Сlients.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button_Сlients.Location = new Point(164, 63);
            button_Сlients.Name = "button_Сlients";
            button_Сlients.Size = new Size(134, 40);
            button_Сlients.TabIndex = 3;
            button_Сlients.Text = "Всі клієнти";
            button_Сlients.UseVisualStyleBackColor = false;
            button_Сlients.Click += button_clients_Click;
            // 
            // button_AllSpecs
            // 
            button_AllSpecs.BackColor = Color.DarkGray;
            button_AllSpecs.Enabled = false;
            button_AllSpecs.FlatStyle = FlatStyle.Flat;
            button_AllSpecs.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button_AllSpecs.Location = new Point(165, 17);
            button_AllSpecs.Name = "button_AllSpecs";
            button_AllSpecs.Size = new Size(133, 40);
            button_AllSpecs.TabIndex = 1;
            button_AllSpecs.Text = "Всі майстри";
            button_AllSpecs.UseVisualStyleBackColor = false;
            button_AllSpecs.Click += button_allspecs_Click;
            // 
            // MainWin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(616, 270);
            Controls.Add(button_Сlients);
            Controls.Add(button_AllSpecs);
            Controls.Add(button_OpenRemoveOrder);
            Controls.Add(button_OrdersList);
            Controls.Add(label_Clients);
            Controls.Add(label_AvailableSpecs);
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
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
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
        private Label label_AvailableSpecs;
        private Label label_Clients;
        private Button button_OrdersList;
        private Button button_OpenRemoveOrder;
        private Button button_Сlients;
        private Button button_AllSpecs;
    }
}