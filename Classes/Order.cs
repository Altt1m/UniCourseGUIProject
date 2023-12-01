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

    public static int OrderAmount { get; set; } = 0; // Номер замовлення (потім використовується)
    public static int OrdersCreated { get; set; } = 0;
    public static int OrdersRemoved { get; set; } = 0;

    private static List<Order> orders = new List<Order>(); // Список всіх замовлень
    private static List<Order> repairOrders = new List<Order>(); // Список замовлень на ремонт
    private static List<Order> installOrders = new List<Order>(); // Список замовлень на встановлення

    // Композиція
    public Specialist MainSpecialist { get; set; } // Головний майстер
    public Client ClientInfo { get; set; } // Інформація про клієнта (зокрема адреса)

   
    public Order(Specialist spec, Client client, string serviceType, string dName, string dVendor, string dos, int wPeriod, double cost) // Конструктор
    {
        OrderAmount++;
        OrderID = "ORD" + OrderAmount;

        spec.IsFree = false;
        spec.RemoveFromSpecsList();
        spec.OrderID = OrderID;
        MainSpecialist = spec;

        ClientInfo = client;
        Address = ClientInfo.Address; // Адреса замовлення береться з адреси клієнта
        client.AddOrder(this);

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

        MessageBox.Show($"Замовлення {OrderID} успішно створено.", "Створено замовлення", MessageBoxButtons.OK, MessageBoxIcon.Information);

        orders.Add(this);
        OrdersCreated++;
    }

    public Order() { }

    /// <summary>
    /// Повератє список замовлень
    /// </summary>
    /// <returns>Список замовлень</returns>
    public static List<Order> GetOrdersList()
    {
        return orders;
    }

    public static void SetOrdersList(List<Order> ordersList)
    {
        orders = ordersList;
    }

    /// <summary>
    /// 1. Список пристроїв для ремонту
    /// </summary>
    /// <returns>Список пристроїв на ремонт</returns>
    public static List<Order> GetRepairOrdersList()
    {
        return repairOrders;
    }

    public static void SetRepairOrdersList(List<Order> repairOrdersList)
    {
        repairOrders = repairOrdersList;
    }

    /// <summary>
    /// 2. Список пристроїв для встановлення
    /// </summary>
    /// <returns>Список замовлень на встановлення</returns>
    public static List<Order> GetInstallOrdersList()
    {
        return installOrders;
    }

    public static void SetInstallOrdersList(List<Order> installOrdersList)
    {
        installOrders = installOrdersList;
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