using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course_Project_GUI
{
    public partial class AddClient : Form
    {
        private MainWin mainWin;
        public AddClient(MainWin mainWin)
        {
            InitializeComponent();
            this.mainWin = mainWin;
        }

        private void button_addclient_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_FullName.Text)) // Якщо текстове поле порожнє або містить лише пробіли
            {
                MessageBox.Show("ПІБ відсутнє або введено некоректно.", "ПІБ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (textBox_FullName.Text.Split(" ").Length != 3) // Якщо не три слова
            {
                MessageBox.Show("ПІБ складається з трьох слів через пробіл.", "ПІБ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (textBox_FullName.Text.Length > 40) // Якщо символів більше 40
            {
                MessageBox.Show("Задовге ПІБ. (>40)", "ПІБ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            foreach (Client client in Client.GetClientsList()) // Пошук клієнта за таким ім'ям
            {
                if (textBox_FullName.Text == client.FullName)
                {
                    MessageBox.Show("Клієнт з таким ім'ям вже є у системі.", "ПІБ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if (string.IsNullOrWhiteSpace(textBox_PhoneNumber.Text))
            {
                MessageBox.Show("Номер телефону відсутній або введений некоректно.", "Номер телефону", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!Regex.IsMatch(textBox_PhoneNumber.Text, @"^\+\d{12}$")) // +380000000001
            {
                MessageBox.Show("Номер телефону не відповідає міжнародному формату.", "Номер телефону", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(textBox_Address.Text))
            {
                MessageBox.Show("Адреса відсутня або введена некоректно.", "Адреса", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (textBox_Address.Text.Length < 5 || textBox_Address.Text.Length > 30) // Якщо символів менше 5 або більше 30
            {
                MessageBox.Show("Адреса повинна мати від 5 до 30 символів.", "Адреса", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string fN = textBox_FullName.Text; // ПІБ
            string pN = textBox_PhoneNumber.Text; // Номер телефону
            string addr = textBox_Address.Text; // Адреса

            new Client(fN, pN, addr); // Створення клієнта

            mainWin.UpdateClients(); // Оновлення клієнтів

            mainWin.ClientsButtonEnabled = true; // Можна продивитися клієнтів

            if (Specialist.GetAvailableSpecsList().Any()) // Якщо є вільні майстри
            {
                mainWin.OpenCreateOrderButtonEnabled = true; // Можна створити замовлення
            }

            Close();
        }
    }
}
