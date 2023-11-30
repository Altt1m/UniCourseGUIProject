public class Order // Замовлення на ремонт та встановлення
{
    public string Address { get; set; } // Адреса (береться у клієнта)
    public string ServiceType { get; set; } // Тип послуги (Встановлення/Ремонт)
    public string DeviceName { get; set; } // Назва пристрою (для встановлення/ремонту)
    public string DeviceVendor { get; set; } // Виробник пристрою
    public string DateOfStart { get; set; } // Дата початку роботи
    public int WorkPeriod { get; set; } // Термін роботи (у днях)
    public double Cost { get; set; } // Вартість
    public string OrderID { get; set; } // ID замовлення *(у клієнта)

    private static int orderAmount = 0; // Номер замовлення (потім використовується)
    private static List<Order> orders = new List<Order>(); // Список всіх замовлень
    private static List<Order> repairOrders = new List<Order>(); // Список замовлень на ремонт
    private static List<Order> installOrders = new List<Order>(); // Список замовлень на встановлення

    // Композиція
    public Specialist MainSpecialist { get; set; } // Головний майстер
    public Client ClientInfo { get; set; } // Інформація про клієнта (зокрема адреса)

   
    public Order(Specialist spec, Client client, string serviceType, string dName, string dVendor, string dos, int wPeriod, double cost) // Конструктор
    {
        spec.IsFree = false;
        spec.RemoveFromSpecsList();
        spec.SetAssignedOrder(this);
        MainSpecialist = spec;

        ClientInfo = client;
        Address = ClientInfo.Address; // Адреса замовлення береться з адреси клієнта

        ServiceType = serviceType;
        if (ServiceType == "Встановлення")
        {
            installOrders.Add(this); // Якщо замовлення на встановлення
        }
        else if (ServiceType == "Ремонт")
        {
            repairOrders.Add(this); // Якщо замовлення на ремонт
        }

        DeviceName = dName;
        DeviceVendor = dVendor;
        DateOfStart = dos;
        WorkPeriod = wPeriod;
        Cost = cost;

        OrderID = "ORD" + ++orderAmount;
        if (client.OrderID != null) // Якщо вже є замовлення
        {
            client.OrderID = client.OrderID + ", " + this.OrderID;
        }
        else
        {
            client.OrderID = OrderID;
        }

        MessageBox.Show($"Замовлення {OrderID} успішно створено.", "Створено замовлення", MessageBoxButtons.OK, MessageBoxIcon.Information);

        orders.Add(this);
        client.AddOrder(this);

    }

    /// <summary>
    /// Повератє список замовлень
    /// </summary>
    /// <returns>Список замовлень</returns>
    public static List<Order> GetOrdersList()
    {
        return orders;
    }

    /// <summary>
    /// 1. Список пристроїв для ремонту
    /// </summary>
    /// <returns>Список пристроїв на ремонт</returns>
    public static List<Order> GetRepairOrdersList()
    {
        return repairOrders;
    }

    /// <summary>
    /// 2. Список пристроїв для встановлення
    /// </summary>
    /// <returns>Список замовлень на встановлення</returns>
    public static List<Order> GetInstallOrdersList()
    {
        return installOrders;
    }

    /// <summary>
    /// 3. Список клієнтів, які вибрали певний тип послуги
    /// </summary>
    /// <param name="serviceType">Тип послуги</param>
    /// <returns>Список клієнтів, які обрали певний тип послуги</returns>
    public static List<Client> GetClientsByServiceType(string serviceType)
    {
        return orders
            .Where(order => order.ServiceType == serviceType)
            .Select(order => order.ClientInfo)
            .Distinct() // Щоб уникнути дублікатів клієнтів
            .ToList();
    }

    /// <summary>
    /// Виводить список клієнтів, які обрали певний тип послуги
    /// </summary>
    /// <param name="serviceType"></param>
    public static void ShowClientsByServiceTypeList(string serviceType)
    {
        List<Client> clients = GetClientsByServiceType(serviceType);
        foreach (Client client in clients)
        {
            client.Show();
        }
        if (!clients.Any())
        {
            Console.Clear();
            Console.WriteLine($"Не знайдено жодного клієнта з типом послуги \"{serviceType}\"\n");
        }
    }


    /// <summary>
    /// 4. Середня вартість замовлень
    /// </summary>
    /// <returns>Середня вартість замовлень</returns>
    public static double GetAverageOrderCost()
    {
        return orders.Average(o => o.Cost);
    }

    /// <summary>
    /// 5. Найдовший термін виконання роботи
    /// </summary>
    /// <returns>Найдовший термін виконання роботи</returns>
    public static int GetLongestWorkPeriod()
    {
        return orders.OrderByDescending(o => o.WorkPeriod).First().WorkPeriod;
    }

    /// <summary>
    /// 6. Найдорожче замовлення
    /// </summary>
    /// <returns>Об'єкт класу Order з найбільшим Cost</returns>
    public static Order GetMostExpensiveOrder()
    {
        return orders.OrderByDescending(o => o.Cost).First();
    }


    
}