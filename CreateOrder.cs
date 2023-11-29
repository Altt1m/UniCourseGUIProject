using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Course_Project_GUI
{
    public partial class CreateOrder : Form
    {
        private List<Specialist> availableSpecs;
        private List<Client> clients;
        private MainWin mainWin;

        public CreateOrder(MainWin mainWin)
        {
            InitializeComponent();
            availableSpecs = Specialist.GetAvailableSpecsList(); // Отримуємо список майстрів
            clients = Client.GetClientsList(); // Отримуємо список клієнтів
            InitializeComboBox();
            this.mainWin = mainWin;
        }

        private void InitializeComboBox()
        {
            // Встановлюємо властивості комбобокса
            comboBox_Specs.DataSource = availableSpecs;
            comboBox_Clients.DataSource = clients;
            comboBox_Specs.DisplayMember = "FullName"; // Відображення за ПІБ
            comboBox_Clients.DisplayMember = "FullName";
        }

        private void button_createorder_Click(object sender, EventArgs e)
        {
            Specialist spec = (Specialist)comboBox_Specs.SelectedItem;
            Client client = (Client)comboBox_Clients.SelectedItem;

            string serviceType = "Встановлення";
            if (radioButton_Repair.Checked)
            {
                serviceType = "Ремонт";
            }

            if (string.IsNullOrWhiteSpace(textBox_DeviceName.Text))
            {
                // Якщо текстове поле порожнє або містить лише пробіли
                MessageBox.Show("Назва прибору відсутня або введена некоректно.");
                return;
            }
            else if (string.IsNullOrWhiteSpace(textBox_DeviceVendor.Text))
            {
                MessageBox.Show("Виробник прибору відсутній або введений некоректно.");
                return;
            }
            else if (string.IsNullOrWhiteSpace(textBox_DateOfStart.Text))
            {
                MessageBox.Show("Дата початку відсутня або введена некоректно.");
                return;
            }
            else if (string.IsNullOrWhiteSpace(textBox_WorkPeriod.Text))
            {
                MessageBox.Show("Термін роботи відсутній або введений некоректно.");
                return;
            }
            else if (string.IsNullOrWhiteSpace(textBox_Cost.Text))
            {
                MessageBox.Show("Вартість відсутня або введена некоректно.");
                return;
            }

            string dName = textBox_DeviceName.Text;
            string dVendor = textBox_DeviceVendor.Text;
            string dos = textBox_DateOfStart.Text;
            int wPeriod;
            double cost;
            try
            {
                wPeriod = int.Parse(textBox_WorkPeriod.Text);
            }
            catch
            {
                MessageBox.Show("Термін роботи повинен бути числом.");
                return;
            }
            try
            {
                cost = double.Parse(textBox_Cost.Text);
            }
            catch
            {
                MessageBox.Show("Вартість повинна бути числом.");
                return;
            }


            new Order(spec, client, serviceType, dName, dVendor, dos, wPeriod, cost);
            UpdateAverageOrderCost();
            UpdateLongestWorkPeriod();
            UpdateMostExpensiveOrder();

            Close();
        }

        private void UpdateAverageOrderCost()
        {
            mainWin.AverageOrderCostLabelText = $"Середня вартість замовлення: {Order.GetAverageOrderCost()}";
        }

        private void UpdateLongestWorkPeriod()
        {
            mainWin.LongestWorkPeriodLabelText = $"Найдовший термін виконання: {Order.GetLongestWorkPeriod()} годин";
        }

        private void UpdateMostExpensiveOrder()
        {
            mainWin.MostExpensiveOrderLabelText = $"Найдорожче замовлення: {Order.GetMostExpensiveOrder().OrderID}" +
                                                                            $"({Order.GetMostExpensiveOrder().Cost})";
        }

        //private void button_ShowSelectedSpec_Click(object sender, EventArgs e)
        //{
        //    // Отримуємо обраний об'єкт з комбобокса
        //    Specialist selectedSpec = (Specialist)comboBox_Specs.SelectedItem;

        //    // Перевірка на null (якщо нічого не обрано)
        //    if (selectedSpec != null)
        //    {
        //        // Виведення інформації про обраного майстра
        //        MessageBox.Show($"Обраний майстер: {selectedSpec.FullName} з філіалу {selectedSpec.BranchName}");
        //    }
        //    else
        //    {
        //        MessageBox.Show("Оберіть майстра зі списку.");
        //    }
        //}
    }
}
