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

            // Отримання списку доступних майстрів та клієнтів
            availableSpecs = Specialist.GetAvailableSpecsList();
            clients = Client.GetClientsList();

            // Ініціалізація комбобоксів
            InitializeComboBox();

            // Зберігаємо посилання на головне вікно
            this.mainWin = mainWin;
        }

        private void InitializeComboBox()
        {
            // Ініціалізація властивостей комбобоксів
            comboBox_Specs.DataSource = availableSpecs;
            comboBox_Clients.DataSource = clients;
            comboBox_Specs.DisplayMember = "FullName"; // Відображення за ПІБ
            comboBox_Clients.DisplayMember = "FullName";
        }

        private void button_createorder_Click(object sender, EventArgs e)
        {
            // Отримання обраних майстра та клієнта
            Specialist spec = (Specialist)comboBox_Specs.SelectedItem;
            Client client = (Client)comboBox_Clients.SelectedItem;

            // Визначення типу послуги
            string serviceType = "Встановлення";
            if (radioButton_Repair.Checked)
            {
                serviceType = "Ремонт";
            }

            // Перевірка та отримання значень текстових полів
            if (string.IsNullOrWhiteSpace(textBox_DeviceName.Text))
            {
                MessageBox.Show("Назва прибору відсутня або введена некоректно.", "Назва прибору", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (textBox_DeviceName.Text.Length < 3 || textBox_DeviceName.Text.Length > 20)
            {
                MessageBox.Show("Назва прибору повинна містити від 3 до 20 символів.", "Назва прибору", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else if (string.IsNullOrWhiteSpace(textBox_DeviceVendor.Text))
            {
                MessageBox.Show("Виробник прибору відсутній або введений некоректно.", "Виробник пробору", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (textBox_DeviceVendor.Text.Length < 3 || textBox_DeviceVendor.Text.Length > 15)
            {
                MessageBox.Show("Назва виробника повинна мати від 3 до 15 символів.", "Виробник прибору", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else if (string.IsNullOrWhiteSpace(textBox_WorkPeriod.Text))
            {
                MessageBox.Show("Термін роботи відсутній або введений некоректно.", "Термін роботи", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (textBox_WorkPeriod.Text.Length > 2)
            {
                MessageBox.Show("Максимальний термін роботи 99 днів.", "Термін роботи", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else if (string.IsNullOrWhiteSpace(textBox_Cost.Text))
            {
                MessageBox.Show("Вартість відсутня або введена некоректно.", "Вартість", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (textBox_Cost.Text.Length > 5) // 99999
            {
                MessageBox.Show("Максимальна вартість 99999 грн.", "Вартість", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Отримання значень текстових полів
            string dName = textBox_DeviceName.Text;
            string dVendor = textBox_DeviceVendor.Text;
            string dos = dateTimePicker_DateOfStart.Text;
            int wPeriod = 0;
            double cost = 0;

            // Перевірка та конвертація терміну роботи та вартості
            try
            {
                int temp = int.Parse(textBox_WorkPeriod.Text);
                if (temp > 0)
                {
                    wPeriod = temp;
                }
                else
                {
                    MessageBox.Show("Термін роботи повинен бути більше нуля.", "Термін роботи", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Термін роботи повинен бути числом.", "Термін роботи", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                double temp = double.Parse(textBox_Cost.Text);
                if (temp > 0)
                {
                    cost = temp;
                }
                else
                {
                    MessageBox.Show("Вартість повинна бути більше нуля.", "Вартість", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Вартість повинна бути числом.", "Вартість", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Створення нового замовлення та оновлення відомостей у головному вікні
            new Order(spec, client, serviceType, dName, dVendor, dos, wPeriod, cost);
            mainWin.UpdateAverageOrderCost();
            mainWin.UpdateLongestWorkPeriod();
            mainWin.UpdateMostExpensiveOrder();
            mainWin.UpdateAvailableSpecs();

            // Встановлення доступності кнопок у головному вікні
            mainWin.OrdersListButtonEnabled = true;
            mainWin.OpenRemoveOrderButtonEnabled = true;
            mainWin.ClientsByServiceTypeButtonEnabled = true;

            if (serviceType == "Встановлення")
            {
                mainWin.InstallOrdersListButtonEnabled = true;
            }
            else
            {
                mainWin.RepairOrdersListButtonEnabled = true;
            }

            // Відключення кнопки створення замовлення, якщо немає доступних майстрів
            if (!availableSpecs.Any())
            {
                mainWin.OpenCreateOrderButtonEnabled = false;
            }

            // Закриття вікна
            Close();
        }

        private void button_ShowSpecInfo_Click(object sender, EventArgs e)
        {
            // Відображення інформації про обраного майстра
            Specialist selectedSpec = (Specialist)comboBox_Specs.SelectedItem;
            MessageBox.Show($"ПІБ: {selectedSpec.FullName}\n" +
                          $"Номер телефону: {selectedSpec.PhoneNumber}\n" +
                          $"Назва філіалу: {selectedSpec.BranchName}", "Інформація про майстра");
        }

        private void button_ShowClientInfo_Click(object sender, EventArgs e)
        {
            // Відображення інформації про обраного клієнта
            Client selectedClient = (Client)comboBox_Clients.SelectedItem;
            MessageBox.Show($"ПІБ: {selectedClient.FullName}\n" +
                        $"Номер телефону: {selectedClient.PhoneNumber}\n" +
                        $"Адреса: {selectedClient.Address}\n" +
                        $"ID замовлення: {selectedClient.GetOrders()}", "Інформація про клієнта");
        }
    }
}
