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
        List<Client> clients = Client.GetClientsList();
        public ClientsByServiceType()
        {
            InitializeComponent();

            for (int i = 0; i < clients.Count; i++)
            {
                foreach (Order order in clients[i].GetOrdersList())
                {
                    if (order.ServiceType == "Встановлення")
                    {
                        listBox_ClientsByServiceType.Items.Add($"№{i + 1}. {clients[i].FullName}");
                    }
                }

            }
        }

        private void radioButton_Repair_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton selectedRadioButton = (RadioButton)sender;
            if (selectedRadioButton.Checked)
            {
                listBox_ClientsByServiceType.Items.Clear();

                string serviceType = selectedRadioButton == radioButton_Repair ? "Ремонт" : "Встановлення";

                int j = 1;
                for (int i = 0; i < clients.Count; i++)
                {
                    foreach (Order order in clients[i].GetOrdersList())
                    {
                        if (order.ServiceType == serviceType)
                        {
                            listBox_ClientsByServiceType.Items.Add($"№{j}. {clients[i].FullName}");
                            break;
                        }
                        j++;
                    }
                }
            }
        }

        private void listBox_ClientsByServiceType_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int selectedIndex = listBox_ClientsByServiceType.SelectedIndex;
            string selectedItemText = listBox_ClientsByServiceType.SelectedItem.ToString();
            int index = GetFirstNumberFromText(selectedItemText) - 1;

            if (selectedIndex != ListBox.NoMatches)
            {
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
