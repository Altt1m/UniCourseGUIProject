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
    public partial class AddSpec : Form
    {
        private MainWin mainWin;
        public AddSpec(MainWin mainWin)
        {
            InitializeComponent();
            this.mainWin = mainWin;
        }

        // Додати майстра
        private void button_addspec_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_FullName.Text)) // Якщо текстове поле порожнє або містить лише пробіли
            {
                MessageBox.Show("ПІБ відсутнє або введено некоректно.", "ПІБ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (textBox_FullName.Text.Split(" ").Length != 3) // Якщо не три слова
            {
                MessageBox.Show("ПІБ повинно складатися з трьох слів через пробіл.", "ПІБ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (textBox_FullName.Text.Length > 40) // Якщо більше 40 символів
            {
                MessageBox.Show("Задовге ПІБ. (>40)", "ПІБ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            foreach (Specialist spec in Specialist.GetAllSpecsList()) // Пошук майстра з таким ім'ям
            {
                if (textBox_FullName.Text == spec.FullName)
                {
                    MessageBox.Show("Майстер з таким ім'ям вже є у системі", "ПІБ", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            if (string.IsNullOrWhiteSpace(textBox_BranchName.Text))
            {
                MessageBox.Show("Назва філіалу відсутня або введена некоректно.", "Назва філіалу", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (textBox_BranchName.Text.Length < 3 || textBox_BranchName.Text.Length > 15) // Якщо символів менше 3 або більше 15
            {
                MessageBox.Show("Назва філіалу повинна мати від 3 до 15 символів.", "Назва філіалу", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string fN = textBox_FullName.Text; // ПІБ
            string pN = textBox_PhoneNumber.Text; // Номер телефону
            string bN = textBox_BranchName.Text; // Назва філії

            new Specialist(fN, pN, bN); // Створення майстра

            mainWin.UpdateAvailableSpecs(); // Оновлення вільних майстрів

            mainWin.AllSpecsButtonEnabled = true; // Тепер можна дивитися всіх майстрів

            if (mainWin.ClientsButtonEnabled) // Якщо є клієнти
            {
                mainWin.OpenCreateOrderButtonEnabled = true; // Можна створити замовлення
            }

            Close();
        }

    }
}