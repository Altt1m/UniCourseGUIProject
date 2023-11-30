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
    public partial class RepairOrdersList : Form
    {
        private List<Order> repairOrders = Order.GetRepairOrdersList();
        public RepairOrdersList()
        {
            InitializeComponent();

            for (int i = 0; i < repairOrders.Count; i++)
            {
                listBox_RepairOrders.Items.Add($"№{i + 1}. ID: {repairOrders[i].OrderID}. " +
                    $"Замовник: {repairOrders[i].ClientInfo.FullName}");
            }
        }

        private void listBox_RepairOrders_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int i = listBox_RepairOrders.IndexFromPoint(e.Location);
            if (i != ListBox.NoMatches)
            {
                Order selectedOrder = repairOrders[i];
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
                    $"Вартість {selectedOrder.Cost}\n",
                    "Замовлення на встановлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
