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
    public partial class AddClient : Form
    {
        public AddClient()
        {
            InitializeComponent();
        }

        private void button_addclient_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_FullName.Text))
            {
                // Якщо текстове поле порожнє або містить лише пробіли
                MessageBox.Show("ПІБ відсутнє або введено некоректно.");
                return;
            }
            else if (string.IsNullOrWhiteSpace(textBox_PhoneNumber.Text))
            {
                MessageBox.Show("Номер телефону відсутній або введений некоректно.");
                return;
            }
            else if (string.IsNullOrWhiteSpace(textBox_Address.Text))
            {
                MessageBox.Show("Адреса відсутня або введена некоректно.");
                return;
            }

            string fN = textBox_FullName.Text;
            string pN = textBox_PhoneNumber.Text;
            string addr = textBox_Address.Text;

            new Client(fN, pN, addr);
            Close();
        }
    }
}
