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
    public partial class InstallOrdersList : Form
    {
        private List<Order> installOrders = Order.GetInstallOrdersList();
        public InstallOrdersList()
        {
            InitializeComponent();

            for (int i = 0; i < installOrders.Count; i++)
            {
                listBox_InstallOrders.Items.Add($"№{i + 1}. ID: {installOrders[i].OrderID}. " +
                    $"Замовник: {installOrders[i].ClientInfo.FullName}");
            }
        }

        private void listBox_InstallOrders_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int i = listBox_InstallOrders.IndexFromPoint(e.Location);
            if (i != ListBox.NoMatches)
            {
                Order selectedOrder = installOrders[i];
                MessageBox.Show($"№{i + 1}\n" +
                    $"ID: {selectedOrder.OrderID}\n" +
                    $"Майстер: {selectedOrder.MainSpecialist.FullName}\n" +
                    $"Замовник: {selectedOrder.ClientInfo.FullName}\n" +
                    $"Адреса: {selectedOrder.Address}\n" +
                    $"Тип послуги: {selectedOrder.ServiceType}\n" +
                    $"Назва прибору: {selectedOrder.DeviceName}\n" +
                    $"Виробник прибору: {selectedOrder.DeviceVendor}\n" +
                    $"Дата початку: {selectedOrder.DateOfStart}\n" +
                    $"Термін роботи (у днях): {selectedOrder.WorkPeriod}\n" +
                    $"Вартість: {selectedOrder.Cost} грн.\n",
                    "Замовлення на встановлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
