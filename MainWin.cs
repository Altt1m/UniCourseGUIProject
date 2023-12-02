using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Course_Project_GUI
{
    public partial class MainWin : Form
    {
        public MainWin()
        {
            InitializeComponent();
            LoadData(); // ������������ �����
            FormClosing += MainWin_FormClosing; // ������� �������� ����
        }

        // ������������ �����
        private void MainWin_Load(object sender, EventArgs e)
        {
            // ³�������� ����� ��� ������� ��������
            button_OpenAddSpec.TabStop = false;

            // ��������� ��������� ����� ��� ��� �������� � ����
            foreach (Control control in Controls)
            {
                control.TabStop = false;
            }
        }

        // ������ �������
        private void button_OpenAddSpec_Click(object sender, EventArgs e)
        {
            AddSpec addSpec = new AddSpec(this);
            addSpec.Show();
        }

        // ������ �볺���
        private void button_OpenAddClient_Click(object sender, EventArgs e)
        {
            AddClient addClient = new AddClient(this);
            addClient.Show();
        }

        // �������� ����������
        private void button_OpenCreateOrder_Click(object sender, EventArgs e)
        {
            CreateOrder createOrder = new CreateOrder(this);
            createOrder.Show();
        }
        // �������� ���������� (����)
        public bool OpenCreateOrderButtonEnabled
        {
            get { return button_OpenCreateOrder.Enabled; }
            set { button_OpenCreateOrder.Enabled = value; }
        }

        // �������� ����������
        private void button_OpenRemoveOrder_Click(object sender, EventArgs e)
        {
            RemoveOrder removeOrder = new RemoveOrder(this);
            removeOrder.Show();
        }
        // �������� ���������� (����)
        public bool OpenRemoveOrderButtonEnabled
        {
            get { return button_OpenRemoveOrder.Enabled; }
            set { button_OpenRemoveOrder.Enabled = value; }
        }

        // ������� ������� ����������
        public string AverageOrderCostLabelText
        {
            get { return label_AverageOrderCost.Text; }
            set { label_AverageOrderCost.Text = value; }
        }
        // ������� ������� �������
        public void UpdateAverageOrderCost()
        {
            AverageOrderCostLabelText = $"������� ������� ����������: {Order.GetAverageOrderCost()} ���.";
        }

        // ��������� ����� ������
        public string LongestWorkPeriodLabelText
        {
            get { return label_LongestWorkPeriod.Text; }
            set { label_LongestWorkPeriod.Text = value; }
        }
        // ������� ��������� ����� ������
        public void UpdateLongestWorkPeriod()
        {
            LongestWorkPeriodLabelText = $"��������� ����� ��������� (� ����): {Order.GetLongestWorkPeriod()}";
        }

        // ���������� ����������
        public string MostExpensiveOrderLabelText
        {
            get { return label_MostExpensiveOrder.Text; }
            set { label_MostExpensiveOrder.Text = value; }
        }
        // ������� ���������� ����������
        public void UpdateMostExpensiveOrder()
        {
            MostExpensiveOrderLabelText = $"���������� ����������: {Order.GetMostExpensiveOrder().OrderID} " +
                                                                            $"({Order.GetMostExpensiveOrder().Cost} ���.)";
        }

        // ³��� �������
        public string AvailableSpecsLabelText
        {
            get { return label_AvailableSpecs.Text; }
            set { label_AvailableSpecs.Text = value; }
        }
        // ������� ������ �������
        public void UpdateAvailableSpecs()
        {
            AvailableSpecsLabelText = $"³��� �������: {Specialist.GetAvailableSpecsList().Count}";
        }
        // �볺���
        public string ClientsLabelText
        {
            get { return label_Clients.Text; }
            set { label_Clients.Text = value; }
        }

        // �� �������
        private void button_allspecs_Click(object sender, EventArgs e)
        {
            AllSpecsList allspecsList = new AllSpecsList();
            allspecsList.Show();
        }
        // �� ������� (����)
        public bool AllSpecsButtonEnabled
        {
            get { return button_AllSpecs.Enabled; }
            set { button_AllSpecs.Enabled = value; }
        }


        // �� �볺���
        private void button_clients_Click(object sender, EventArgs e)
        {
            ClientsList clientsList = new ClientsList();
            clientsList.Show();
        }
        // �� �볺��� (����)
        public bool ClientsButtonEnabled
        {
            get { return button_�lients.Enabled; }
            set { button_�lients.Enabled = value; }
        }
        // ������� �볺���
        public void UpdateClients()
        {
            ClientsLabelText = $"�볺���: {Client.GetClientsList().Count}";
        }

        private void button_ClientsByServiceType_Click(object sender, EventArgs e)
        {
            ClientsByServiceType clientsByServiceType = new ClientsByServiceType();
            clientsByServiceType.Show();
        }
        // �볺��� �� ����� ������� (����)
        public bool ClientsByServiceTypeButtonEnabled
        {
            get { return button_ClientsByServiceType.Enabled; }
            set { button_ClientsByServiceType.Enabled = value; }
        }



        // �� ����������
        private void button_OrdersList_Click(object sender, EventArgs e)
        {
            OrdersList ordersList = new OrdersList();
            ordersList.Show();
        }
        // �� ���������� (����)
        public bool OrdersListButtonEnabled
        {
            get { return button_OrdersList.Enabled; }
            set { button_OrdersList.Enabled = value; }
        }

        // ���������� �� ������������
        private void button_InstallOrdersList_Click(object sender, EventArgs e)
        {
            InstallOrdersList installOrdersList = new InstallOrdersList();
            installOrdersList.Show();
        }
        // ���������� �� ������������ (����)
        public bool InstallOrdersListButtonEnabled
        {
            get { return button_InstallOrdersList.Enabled; }
            set { button_InstallOrdersList.Enabled = value; }
        }

        // ���������� �� ������
        private void button_RepairOrdersList_Click(object sender, EventArgs e)
        {
            RepairOrdersList repairOrdersList = new RepairOrdersList();
            repairOrdersList.Show();
        }
        // ���������� �� ������ (����)
        public bool RepairOrdersListButtonEnabled
        {
            get { return button_RepairOrdersList.Enabled; }
            set { button_RepairOrdersList.Enabled = value; }
        }


        // �������� �����
        private void MainWin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Specialist.SpecsCreated > 0 || Client.ClientsCreated > 0 || Order.OrdersCreated > 0 || Order.OrdersRemoved > 0)
            {
                // ����������, �� ���������� ���� �������� ���
                DialogResult result = MessageBox.Show("������ �������� ���� ����� ���������?", "���������� ���",
                                                      MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // �������� ��� ����� ���������
                    SaveData();
                }
                else if (result == DialogResult.Cancel)
                {
                    // ��������� �������� �����
                    e.Cancel = true;
                }

            }

        }

        // ���������� �����
        private void SaveData()
        {
            // �� ���� �����
            if (!Directory.Exists("Files"))
            {
                // ��������� �����, ���� ���� �� ����
                Directory.CreateDirectory("Files");
            }

            string json = JsonSerializer.Serialize(Specialist.GetAllSpecsList());
            File.WriteAllText("Files\\specsList.json", json);

            json = JsonSerializer.Serialize(Specialist.GetAvailableSpecsList());
            File.WriteAllText("Files\\availableSpecsList.json", json);

            json = JsonSerializer.Serialize(Client.GetClientsList());
            File.WriteAllText("Files\\clientsList.json", json);

            int ordersAmount = Order.OrderAmount;
            json = JsonSerializer.Serialize(ordersAmount);
            File.WriteAllText("Files\\ordersAmount.json", json);

            json = JsonSerializer.Serialize(Order.GetOrdersList());
            File.WriteAllText("Files\\ordersList.json", json);

            json = JsonSerializer.Serialize(Order.GetInstallOrdersList());
            File.WriteAllText("Files\\installOrdersList.json", json);

            json = JsonSerializer.Serialize(Order.GetRepairOrdersList());
            File.WriteAllText("Files\\repairOrdersList.json", json);
        }

        // ������������ �����
        private void LoadData()
        {
            // �� ���� �����
            if (!Directory.Exists("Files"))
            {
                return;
            }

            if (File.Exists("Files\\specsList.json"))
            {
                string json = File.ReadAllText("Files\\specsList.json");
                List<Specialist> specialists = JsonSerializer.Deserialize<List<Specialist>>(json);
                Specialist.SetAllSpecsList(specialists);
                if (Specialist.GetAllSpecsList().Any())
                {
                    AllSpecsButtonEnabled = true;
                }

            }

            if (File.Exists("Files\\availableSpecsList.json"))
            {
                string json = File.ReadAllText("Files\\availableSpecsList.json");
                List<Specialist> avalSpecs = JsonSerializer.Deserialize<List<Specialist>>(json);
                Specialist.SetAvailableSpecsList(avalSpecs);
                if (Specialist.GetAvailableSpecsList().Any())
                {
                    AvailableSpecsLabelText = $"³��� �������: {Specialist.GetAvailableSpecsList().Count}";
                }
                else
                {
                    AvailableSpecsLabelText = "³��� �������: 0";
                }

            }

            if (File.Exists("Files\\clientsList.json"))
            {
                string json = File.ReadAllText("Files\\clientsList.json");
                List<Client> clients = JsonSerializer.Deserialize<List<Client>>(json);
                Client.SetClientsList(clients);
                if (Client.GetClientsList().Any())
                {
                    ClientsButtonEnabled = true;
                    ClientsLabelText = $"�볺���: {Client.GetClientsList().Count}";
                    if (Specialist.GetAvailableSpecsList().Any())
                    {
                        OpenCreateOrderButtonEnabled = true;
                    }
                }

            }

            if (File.Exists("Files\\ordersAmount.json"))
            {
                string json = File.ReadAllText("Files\\ordersAmount.json");
                int ordersAmount = JsonSerializer.Deserialize<int>(json);
                Order.OrderAmount = ordersAmount;
            }

            if (File.Exists("Files\\ordersList.json"))
            {
                string json = File.ReadAllText("Files\\ordersList.json");
                List<Order> orders = JsonSerializer.Deserialize<List<Order>>(json);
                Order.SetOrdersList(orders);
                if (Order.GetOrdersList().Any())
                {
                    OrdersListButtonEnabled = true;
                    ClientsByServiceTypeButtonEnabled = true;
                    OpenRemoveOrderButtonEnabled = true;
                    UpdateAverageOrderCost();
                    UpdateLongestWorkPeriod();
                    UpdateMostExpensiveOrder();
                }
                foreach (Order order in Order.GetOrdersList())
                {
                    foreach (Client client in Client.GetClientsList())
                    {
                        if (order.ClientInfo.FullName == client.FullName)
                        {
                            client.AddOrder(order);
                        }
                    }
                }

            }

            if (File.Exists("Files\\installOrdersList.json"))
            {
                string json = File.ReadAllText("Files\\installOrdersList.json");
                List<Order> installOrders = JsonSerializer.Deserialize<List<Order>>(json);
                Order.SetInstallOrdersList(installOrders);
                if (Order.GetInstallOrdersList().Any())
                {
                    InstallOrdersListButtonEnabled = true;
                }
            }

            if (File.Exists("Files\\repairOrdersList.json"))
            {
                string json = File.ReadAllText("Files\\repairOrdersList.json");
                List<Order> repairOrders = JsonSerializer.Deserialize<List<Order>>(json);
                Order.SetRepairOrdersList(repairOrders);
                if (Order.GetRepairOrdersList().Any())
                {
                    RepairOrdersListButtonEnabled = true;
                }

            }
        }


    }
}