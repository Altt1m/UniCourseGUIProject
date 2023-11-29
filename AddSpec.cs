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
    public partial class AddSpec : Form
    {
        public AddSpec()
        {
            InitializeComponent();
        }

        private void button_addspec_Click(object sender, EventArgs e)
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
            else if (string.IsNullOrWhiteSpace(textBox_BranchName.Text))
            {
                MessageBox.Show("Назва філіалу відсутня або введена некоректно.");
                return;
            }

            string fN = textBox_FullName.Text;
            string pN = textBox_PhoneNumber.Text;
            string bN = textBox_BranchName.Text;

            new Specialist(fN, pN, bN);
            Close();
        }
    }
}
