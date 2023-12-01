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
    public partial class RemoveOrder : Form
    {
        private List<Order> orders = Order.GetOrdersList();
        MainWin mainWin;
        public RemoveOrder(MainWin mainWin)
        {
            InitializeComponent();
            this.mainWin = mainWin;

            UpdateListBox();
        }

        private void UpdateListBox()
        {
            listBox_OrdersToRemove.Items.Clear(); // Очищення елементів ListBox

            // Додавання нових елементів
            foreach (Order order in orders)
            {
                listBox_OrdersToRemove.Items.Add($"ID: {order.OrderID}, Майстер: {order.MainSpecialist.FullName}, Замовник: {order.ClientInfo.FullName}");
            }
        }

        private void listBox_OrdersToRemove_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int i = listBox_OrdersToRemove.IndexFromPoint(e.Location);
            if (i != ListBox.NoMatches)
            {
                Order selectedOrder = orders[i];
                DialogResult result = MessageBox.Show($"№{i + 1}\n" +
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
                    "Прибрати замовлення?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Код для обробки натискання на Yes
                    Order.GetOrdersList().Remove(selectedOrder);
                    Order.GetRepairOrdersList().Remove(selectedOrder);
                    Order.GetInstallOrdersList().Remove(selectedOrder);

                    selectedOrder.MainSpecialist.IsFree = true;
                    Specialist.GetAvailableSpecsList().Add(selectedOrder.MainSpecialist);
                    mainWin.OpenCreateOrderButtonEnabled = true;

                    selectedOrder.ClientInfo.GetOrdersList().Remove(selectedOrder);

                    // Оновлення відображення ListBox або інших елементів
                    UpdateListBox();
                    mainWin.UpdateAvailableSpecs();

                    if (orders.Any())
                    {
                        mainWin.UpdateAverageOrderCost();
                        mainWin.UpdateLongestWorkPeriod();
                        mainWin.UpdateMostExpensiveOrder();
                    }
                    else
                    {
                        mainWin.AverageOrderCostLabelText = "Середня вартість замовлення: N/A";
                        mainWin.LongestWorkPeriodLabelText = "Найдовший термін виконання (у днях): N/A";
                        mainWin.MostExpensiveOrderLabelText = "Найдорожче замовлення: N/A";
                    }

                }
            }

            if (!orders.Any())
            {
                mainWin.OpenRemoveOrderButtonEnabled = false;
                mainWin.OrdersListButtonEnabled = false;
                mainWin.ClientsByServiceTypeButtonEnabled = false;
            }

            if (Order.GetInstallOrdersList().Count == 0)
            {
                mainWin.InstallOrdersListButtonEnabled = false;
            }

            if (Order.GetRepairOrdersList().Count == 0)
            {
                mainWin.RepairOrdersListButtonEnabled = false;
            }

        }
    }
}
