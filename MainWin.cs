namespace Course_Project_GUI
{
    public partial class MainWin : Form
    {
        private CreateOrder createOrder;
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
            AddSpec addSpec = new AddSpec();
            addSpec.Show();
        }

        private void button_OpenAddClient_Click(object sender, EventArgs e)
        {
            AddClient addClient = new AddClient();
            addClient.Show();
        }

        private void button_OpenCreateOrder_Click(object sender, EventArgs e)
        {
            if (!Specialist.GetAvailableSpecsList().Any())
            {
                MessageBox.Show("Відсутні вільні майстри.", "Чогось не вистачає", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (!Client.GetClientsList().Any())
            {
                MessageBox.Show("Відсутні клієнти.", "Чогось не вистачає", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            createOrder = new CreateOrder(this);
            createOrder.Show();
        }

        public string AverageOrderCostLabelText
        {
            get { return label_AverageOrderCost.Text; }
            set { label_AverageOrderCost.Text = value; }
        }

        public string LongestWorkPeriodLabelText
        {
            get { return label_LongestWorkPeriod.Text; }
            set { label_LongestWorkPeriod.Text = value; }
        }

        public string MostExpensiveOrderLabelText
        {
            get { return label_MostExpensiveOrder.Text; }
            set { label_MostExpensiveOrder.Text = value; }
        }

        private void button_InstallOrdersList_Click(object sender, EventArgs e)
        {

        }

        private void button_RepairOrdersList_Click(object sender, EventArgs e)
        {

        }

        private void button_ClientsByServiceType_Click(object sender, EventArgs e)
        {
        }
    }
}