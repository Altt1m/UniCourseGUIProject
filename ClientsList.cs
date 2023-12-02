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
    public partial class ClientsList : Form
    {
        // Список клієнтів, отриманий з методу GetClientsList
        List<Client> clients = Client.GetClientsList();

        public ClientsList()
        {
            InitializeComponent();

            // Ініціалізація елементів форми при створенні
            for (int i = 0; i < clients.Count; i++)
            {
                // Додавання елементів у listBox для кожного клієнта
                listBox_Clients.Items.Add($"№{i + 1}. {clients[i].FullName}");
            }
        }

        private void listBox_Clients_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // Обробник події подвійного кліку мишею на listBox
            int i = listBox_Clients.IndexFromPoint(e.Location);
            if (i != ListBox.NoMatches)
            {
                // Отримання вибраного клієнта та виведення інформації
                Client selectedClient = clients[i];
                MessageBox.Show($"№{i + 1}\n" +
                    $"ПІБ: {selectedClient.FullName}\n" +
                    $"Номер телефону: {selectedClient.PhoneNumber}\n" +
                    $"Адреса: {selectedClient.Address}\n" +
                    $"ID замовлення: {selectedClient.GetOrders()}",
                    "Інформація про клієнта", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
