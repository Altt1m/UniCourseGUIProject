namespace Course_Project_GUI
{
    public partial class MainWin : Form
    {
        public MainWin()
        {
            InitializeComponent();
        }

        private void MainWin_Load(object sender, EventArgs e)
        {
            // Відключити фокус для першого елемента
            button_OpenAddSpec.TabStop = false;

            // Додатково відключимо фокус для всіх елементів у формі
            foreach (Control control in Controls)
            {
                control.TabStop = false;
            }
        }

        private void button_OpenAddSpec_Click(object sender, EventArgs e)
        {
            AddSpec addSpec = new AddSpec(this);
            addSpec.Show();
        }

        private void button_OpenAddClient_Click(object sender, EventArgs e)
        {
            AddClient addClient = new AddClient(this);
            addClient.Show();
        }

        private void button_OpenCreateOrder_Click(object sender, EventArgs e)
        {
            CreateOrder createOrder = new CreateOrder(this);
            createOrder.Show();
        }

        private void button_OpenRemoveOrder_Click(object sender, EventArgs e)
        {
            RemoveOrder removeOrder = new RemoveOrder(this);
            removeOrder.Show();
        }

        public string AverageOrderCostLabelText
        {
            get { return label_AverageOrderCost.Text; }
            set { label_AverageOrderCost.Text = value; }
        }

        public void UpdateAverageOrderCost()
        {
            AverageOrderCostLabelText = $"Середня вартість замовлення: {Order.GetAverageOrderCost()}";
        }

        public string LongestWorkPeriodLabelText
        {
            get { return label_LongestWorkPeriod.Text; }
            set { label_LongestWorkPeriod.Text = value; }
        }
        public void UpdateLongestWorkPeriod()
        {
            LongestWorkPeriodLabelText = $"Найдовший термін виконання (у днях): {Order.GetLongestWorkPeriod()}";
        }

        public string MostExpensiveOrderLabelText
        {
            get { return label_MostExpensiveOrder.Text; }
            set { label_MostExpensiveOrder.Text = value; }
        }

        public void UpdateMostExpensiveOrder()
        {
            MostExpensiveOrderLabelText = $"Найдорожче замовлення: {Order.GetMostExpensiveOrder().OrderID} " +
                                                                            $"({Order.GetMostExpensiveOrder().Cost} грн.)";
        }

        public string AvailableSpecsLabelText
        {
            get { return label_AvailableSpecs.Text; }
            set { label_AvailableSpecs.Text = value; }
        }

        public void UpdateAvailableSpecs()
        {
            AvailableSpecsLabelText = $"Вільні майстри: {Specialist.GetAvailableSpecsList().Count}";
        }

        public bool AllSpecsButtonEnabled
        {
            get { return button_AllSpecs.Enabled; }
            set { button_AllSpecs.Enabled = value; }
        }

        public string ClientsLabelText
        {
            get { return label_Clients.Text; }
            set { label_Clients.Text = value; }
        }

        public void UpdateClients()
        {
            ClientsLabelText = $"Клієнти: {Client.GetClientsList().Count}";
        }

        public bool ClientsButtonEnabled
        {
            get { return button_Сlients.Enabled; }
            set { button_Сlients.Enabled = value; }
        }

        public bool ClientsByServiceTypeButtonEnabled
        {
            get { return button_ClientsByServiceType.Enabled; }
            set { button_ClientsByServiceType.Enabled = value; }
        }

        public bool OpenCreateOrderButtonEnabled
        {
            get { return button_OpenCreateOrder.Enabled; }
            set { button_OpenCreateOrder.Enabled = value; }
        }

        public bool OpenRemoveOrderButtonEnabled
        {
            get { return button_OpenRemoveOrder.Enabled; }
            set { button_OpenRemoveOrder.Enabled = value; }
        }

        public bool OrdersListButtonEnabled
        {
            get { return button_OrdersList.Enabled; }
            set { button_OrdersList.Enabled = value; }
        }

        public bool InstallOrdersListButtonEnabled
        {
            get { return button_InstallOrdersList.Enabled; }
            set { button_InstallOrdersList.Enabled = value; }
        }

        public bool RepairOrdersListButtonEnabled
        {
            get { return button_RepairOrdersList.Enabled; }
            set { button_RepairOrdersList.Enabled = value; }
        }

        private void button_InstallOrdersList_Click(object sender, EventArgs e)
        {
            InstallOrdersList installOrdersList = new InstallOrdersList();
            installOrdersList.Show();
        }

        private void button_RepairOrdersList_Click(object sender, EventArgs e)
        {
            RepairOrdersList repairOrdersList = new RepairOrdersList();
            repairOrdersList.Show();
        }

        private void button_ClientsByServiceType_Click(object sender, EventArgs e)
        {
            ClientsByServiceType clientsByServiceType = new ClientsByServiceType();
            clientsByServiceType.Show();
        }

        private void button_allspecs_Click(object sender, EventArgs e)
        {
            AllSpecsList allspecsList = new AllSpecsList();
            allspecsList.Show();
        }
        private void button_clients_Click(object sender, EventArgs e)
        {
            ClientsList clientsList = new ClientsList();
            clientsList.Show();
        }

        private void button_OrdersList_Click(object sender, EventArgs e)
        {
            OrdersList ordersList = new OrdersList();
            ordersList.Show();
        }

        private void label_MostExpensiveOrder_Click(object sender, EventArgs e)
        {

        }

        private void label_LongestWorkPeriod_Click(object sender, EventArgs e)
        {
        }

        private void label_AverageOrderCost_Click(object sender, EventArgs e)
        {
        }

        private void label_Clients_Click(object sender, EventArgs e)
        {
        }

        private void label_AvailableSpecs_Click(object sender, EventArgs e)
        {
        }
    }
}