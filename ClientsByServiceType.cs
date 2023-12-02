using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course_Project_GUI
{
    public partial class ClientsByServiceType : Form
    {
        // Список клієнтів, отриманий з методу GetClientsList
        List<Client> clients = Client.GetClientsList();

        public ClientsByServiceType()
        {
            InitializeComponent();

            // Ініціалізація елементів форми при створенні
            for (int i = 0; i < clients.Count; i++)
            {
                foreach (Order order in clients[i].GetOrdersList())
                {
                    // Додавання елементів у listBox за умовою
                    if (order.ServiceType == "Встановлення")
                    {
                        listBox_ClientsByServiceType.Items.Add($"№{i + 1}. {clients[i].FullName}");
                    }
                }
            }
        }

        private void radioButton_Repair_CheckedChanged(object sender, EventArgs e)
        {
            // Обробник події зміни стану radioButton
            RadioButton selectedRadioButton = (RadioButton)sender;
            if (selectedRadioButton.Checked)
            {
                // Очистка listBox при зміні стану radioButton
                listBox_ClientsByServiceType.Items.Clear();

                // Визначення типу послуги
                string serviceType = selectedRadioButton == radioButton_Repair ? "Ремонт" : "Встановлення";

                int j = 1;
                // Перегляд клієнтів та їхніх замовлень
                for (int i = 0; i < clients.Count; i++)
                {
                    foreach (Order order in clients[i].GetOrdersList())
                    {
                        // Додавання елементів у listBox за умовою
                        if (order.ServiceType == serviceType)
                        {
                            listBox_ClientsByServiceType.Items.Add($"№{j}. {clients[i].FullName}");
                            j++;
                            // Вийти з циклу після знаходження першого замовлення даного типу
                            break;
                        }
                    }
                }
            }
        }

        private void listBox_ClientsByServiceType_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // Обробник події подвійного кліку мишею на listBox
            int selectedIndex = listBox_ClientsByServiceType.SelectedIndex;
            string selectedItemText = listBox_ClientsByServiceType.SelectedItem.ToString();
            // Отримання індексу клієнта з тексту елемента listBox
            int index = GetFirstNumberFromText(selectedItemText) - 1;

            if (selectedIndex != ListBox.NoMatches)
            {
                // Отримання вибраного клієнта та виведення інформації
                Client selectedClient = clients[index];
                MessageBox.Show($"№{index + 1}\n" +
                    $"ПІБ: {selectedClient.FullName}\n" +
                    $"Номер телефону: {selectedClient.PhoneNumber}\n" +
                    $"Адреса: {selectedClient.Address}\n" +
                    $"ID замовлення: {selectedClient.GetOrders()}",
                    "Інформація про клієнта", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private int GetFirstNumberFromText(string text)
        {
            // Метод для отримання першого числа з тексту
            StringBuilder numberBuilder = new StringBuilder();

            foreach (char character in text)
            {
                if (char.IsDigit(character))
                {
                    numberBuilder.Append(character);
                }
                else if (numberBuilder.Length > 0)
                {
                    // Якщо ми вже знайшли цифри, і тепер зустріли нецифровий символ, завершимо цикл
                    break;
                }
            }

            return int.Parse(numberBuilder.ToString());
        }
    }
}
