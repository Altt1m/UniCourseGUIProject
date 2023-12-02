public class Order // Замовлення на ремонт та встановлення
{
    public string Address { get; set; } // Адреса (береться у клієнта)
    public string ServiceType { get; set; } // Тип послуги (Встановлення/Ремонт)
    public string DeviceName { get; set; } // Назва пристрою (для встановлення/ремонту)
    public string DeviceVendor { get; set; } // Виробник пристрою
    public string DateOfStart { get; set; } // Дата початку роботи
    public int WorkPeriod { get; set; } // Термін роботи (у днях)
    public double Cost { get; set; } // Вартість
    public string OrderID { get; set; } // ID замовлення

    public static int OrderAmount { get; set; } = 0; // Номер замовлення (потім використовується)
    public static int OrdersCreated { get; set; } = 0; // Замовлень створено (за сесію)
    public static int OrdersRemoved { get; set; } = 0; // Замовлень прибрано (за сесію)

    private static List<Order> orders = new List<Order>(); // Список всіх замовлень
    private static List<Order> repairOrders = new List<Order>(); // Список замовлень на ремонт
    private static List<Order> installOrders = new List<Order>(); // Список замовлень на встановлення

    // Композиція
    public Specialist MainSpecialist { get; set; } // Призначений майстер
    public Client ClientInfo { get; set; } // Інформація про клієнта (зокрема адреса)

   
    public Order(Specialist spec, Client client, string serviceType, string dName, string dVendor, string dos, int wPeriod, double cost) // Конструктор
    {
        // ID замовлення
        OrderAmount++;
        OrderID = "ORD" + OrderAmount;

        // Майстер
        spec.IsFree = false;
        spec.RemoveFromAvailableSpecsList();
        spec.OrderID = OrderID;
        MainSpecialist = spec;

        // Клієнт і адреса
        ClientInfo = client;
        Address = ClientInfo.Address; // Адреса замовлення береться з адреси клієнта
        client.AddOrder(this);

        // Тип послуги
        ServiceType = serviceType;
        if (ServiceType == "Встановлення")
        {
            installOrders.Add(this); // Якщо замовлення на встановлення
        }
        else if (ServiceType == "Ремонт")
        {
            repairOrders.Add(this); // Якщо замовлення на ремонт
        }

        // Все інше
        DeviceName = dName;
        DeviceVendor = dVendor;
        DateOfStart = dos;
        WorkPeriod = wPeriod;
        Cost = cost;

        // Повідомлення
        MessageBox.Show($"Замовлення {OrderID} успішно створено.", "Створено замовлення", MessageBoxButtons.OK, MessageBoxIcon.Information);

        orders.Add(this); // Додавання до списку всіх замовлень
        OrdersCreated++;
    }

    public Order() { }

    // Список всіх замовлень
    public static List<Order> GetOrdersList()
    {
        return orders;
    }
    public static void SetOrdersList(List<Order> ordersList)
    {
        orders = ordersList;
    }

    // Список замовлень на ремонт
    public static List<Order> GetRepairOrdersList()
    {
        return repairOrders;
    }
    public static void SetRepairOrdersList(List<Order> repairOrdersList)
    {
        repairOrders = repairOrdersList;
    }

    // Список замовлень на встановлення
    public static List<Order> GetInstallOrdersList()
    {
        return installOrders;
    }
    public static void SetInstallOrdersList(List<Order> installOrdersList)
    {
        installOrders = installOrdersList;
    }

    // Середня вартість замовлень
    public static double GetAverageOrderCost()
    {
        return orders.Average(o => o.Cost);
    }

    // Найдовший термін виконання
    public static int GetLongestWorkPeriod()
    {
        return orders.OrderByDescending(o => o.WorkPeriod).First().WorkPeriod;
    }

    // Найдорожче замовлення
    public static Order GetMostExpensiveOrder()
    {
        return orders.OrderByDescending(o => o.Cost).First();
    }


    
}