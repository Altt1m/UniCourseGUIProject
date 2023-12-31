﻿using System;
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
    public partial class OrdersList : Form
    {
        // Список всіх замовлень
        private List<Order> orders = Order.GetOrdersList();

        // Конструктор форми
        public OrdersList()
        {
            InitializeComponent();

            // Додавання замовлень у ListBox
            for (int i = 0; i < orders.Count; i++)
            {
                listBox_Orders.Items.Add($"№{i + 1}. ID: {orders[i].OrderID}. Замовник: {orders[i].ClientInfo.FullName}");
            }
        }

        // Подвійний клік на замовленні
        private void listBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int i = listBox_Orders.IndexFromPoint(e.Location);
            if (i != ListBox.NoMatches)
            {
                // Отримання обраного замовлення
                Order selectedOrder = orders[i];

                // Виведення інформації про замовлення у MessageBox
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
                    "Інформація про замовлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
