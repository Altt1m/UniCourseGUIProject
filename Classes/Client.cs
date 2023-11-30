public class Client : Person // Клієнт (наслідування від Person)
{
    // На одного клієнта може приходитися багато замовлень, але на замовлення лише один клієнт
    public string Address { get; set; } // Адреса
    //public string OrderID { get; set; } // ID замовлення

    private List<Order> orders = new List<Order>(); // Список замовлень клієнта

    private static List<Client> clients = new List<Client>(); // Список клієнтів

    /// <summary>
    /// Конструктор за замовчуванням
    /// </summary>
    public Client()
    {
        Console.Write("Адреса: "); Address = Console.ReadLine();
        Console.Clear();
        Console.WriteLine($"Клієнт {FullName} доданий.\n");

        clients.Add(this);
    }

    /// <summary>
    /// Конструктор з параметрами
    /// </summary>
    /// <param name="fN">ПІБ</param>
    /// <param name="pNum">Номер телефону</param>
    /// <param name="addr">Адреса</param>
    public Client(string fN, string pN, string addr)
    {
        FullName = fN;
        PhoneNumber = pN;
        Address = addr;

        clients.Add(this);
    }

    /// <summary>
    /// Повертає список клієнтів
    /// </summary>
    /// <returns>Список клієнтів</returns>
    public static List<Client> GetClientsList()
    {
        return clients;
    }

    /// <summary>
    /// Додавання замовлення до списку клієнта
    /// </summary>
    /// <param name="order">Замовлення клієнта</param>
    public void AddOrder(Order order)
    {
        orders.Add(order);
    }

    public List<Order> GetOrdersList()
    {
        return orders;
    }

    public string GetOrders()
    {
        if (!orders.Any())
        {
            return "N/A";
        }
        else if (orders.Count == 1)
        {
            return $"{orders[0].OrderID}";
        }
        else
        {
            string clientOrders = orders[0].OrderID;
            for (int i = 1; i < orders.Count; i++)
            {
                clientOrders = clientOrders + ", " + orders[i].OrderID;
            }
            return clientOrders;
        }
    }

}
