public class Client : Person // Клієнт (наслідування від Person)
{
    // На одного клієнта може приходитися багато замовлень, але на замовлення лише один клієнт
    public string Address { get; set; } // Адреса
    //public string OrderID { get; set; } // ID замовлення

    public static int ClientsCreated { get; set; } = 0;

    private List<Order> orders = new List<Order>(); // Список замовлень клієнта

    private static List<Client> clients = new List<Client>(); // Список клієнтів

    public Client() { }

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
        ClientsCreated++;
    }

    /// <summary>
    /// Повертає список клієнтів
    /// </summary>
    /// <returns>Список клієнтів</returns>
    public static List<Client> GetClientsList()
    {
        return clients;
    }

    public static void SetClientsList(List<Client> clientsList)
    {
        clients = clientsList;
    }

    /// <summary>
    /// Додавання замовлення до списку клієнта
    /// </summary>
    /// <param name="order">Замовлення клієнта</param>
    public void AddOrder(Order order)
    {
        orders.Add(order);
    }

    public void RemoveOrder(Order order)
    {
        orders.Remove(order);
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
