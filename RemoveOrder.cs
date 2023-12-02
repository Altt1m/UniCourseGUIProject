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
        // Список всіх замовлень
        private List<Order> orders = Order.GetOrdersList();

        // Змінна для збереження посилання на головне вікно
        MainWin mainWin;

        // Конструктор форми
        public RemoveOrder(MainWin mainWin)
        {
            InitializeComponent();
            this.mainWin = mainWin;

            // Оновлення ListBox
            UpdateListBox();
        }

        // Метод для оновлення елементів ListBox
        private void UpdateListBox()
        {
            listBox_OrdersToRemove.Items.Clear(); // Очищення елементів ListBox

            // Додавання нових елементів
            foreach (Order order in orders)
            {
                listBox_OrdersToRemove.Items.Add($"ID: {order.OrderID}. Замовник: {order.ClientInfo.FullName}");
            }
        }

        // Подвійний клік на елементі ListBox
        private void listBox_OrdersToRemove_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int i = listBox_OrdersToRemove.IndexFromPoint(e.Location);
            if (i != ListBox.NoMatches)
            {
                Order selectedOrder = orders[i];

                // Виведення підтвердження видалення
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
                    "Видалити замовлення?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Код для обробки натискання на Yes

                    // Додавання майстра назад до вільних
                    Specialist.AddAvailableSpec(selectedOrder.MainSpecialist);

                    // Зміна статусу майстра на вільний
                    List<Specialist> allSpecs = Specialist.GetAllSpecsList();
                    for (i = 0; i < allSpecs.Count; i++)
                    {
                        if (allSpecs[i].OrderID == selectedOrder.OrderID)
                        {
                            allSpecs[i].IsFree = true;
                            break;
                        }
                    }

                    // Зміни в головному вікні
                    mainWin.OpenCreateOrderButtonEnabled = true;

                    // Видалення замовлення із списків
                    bool removed = false;
                    foreach (Client client in Client.GetClientsList())
                    {
                        foreach (Order order in client.GetOrdersList())
                        {
                            if (order.OrderID == selectedOrder.OrderID)
                            {
                                client.RemoveOrder(selectedOrder);
                                removed = true;
                                break;
                            }
                        }
                        if (removed)
                            break;
                    }

                    Order.GetOrdersList().Remove(selectedOrder);
                    foreach (Order order in Order.GetRepairOrdersList())
                    {
                        if (order.OrderID == selectedOrder.OrderID)
                        {
                            Order.GetRepairOrdersList().Remove(order);
                            break;
                        }
                    }
                    foreach (Order order in Order.GetInstallOrdersList())
                    {
                        if (order.OrderID == selectedOrder.OrderID)
                        {
                            Order.GetInstallOrdersList().Remove(order);
                            break;
                        }
                    }

                    // Збільшення лічильника видалених замовлень
                    Order.OrdersRemoved++;

                    // Оновлення відображення ListBox або інших елементів
                    UpdateListBox();
                    mainWin.UpdateAvailableSpecs();

                    // Перевірка чи є ще замовлення
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

            // Деактивація кнопок у головному вікні, якщо більше немає замовлень
            if (!orders.Any())
            {
                mainWin.OpenRemoveOrderButtonEnabled = false;
                mainWin.OrdersListButtonEnabled = false;
                mainWin.ClientsByServiceTypeButtonEnabled = false;
            }

            // Деактивація кнопок для окремих типів замовлень, якщо їх немає
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
