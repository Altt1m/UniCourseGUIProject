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
    public partial class AllSpecsList : Form
    {
        private List<Specialist> allspecs = Specialist.GetAllSpecsList();
        public AllSpecsList()
        {
            InitializeComponent();

            for (int i = 0; i < allspecs.Count; i++)
            {
                listBox_AllSpecs.Items.Add($"№{i + 1}. {allspecs[i].FullName}");
            }
        }

        private void listBox_AllSpecs_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int i = listBox_AllSpecs.IndexFromPoint(e.Location);
            if (i != ListBox.NoMatches)
            {
                Specialist selectedSpec = allspecs[i];
                MessageBox.Show($"№{i + 1}\n" +
                    $"ПІБ: {selectedSpec.FullName}\n" +
                    $"Номер телефону: {selectedSpec.PhoneNumber}\n" +
                    $"Філія: {selectedSpec.BranchName}\n" +
                    $"Стан: {(selectedSpec.IsFree ? "Вільний" : "Зайнятий")}",
                    "Інформація про майстра", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
