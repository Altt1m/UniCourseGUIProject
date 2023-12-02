public class Client : Person // Клієнт (наслідування від Person)
{
    // На одного клієнта може приходитися багато замовлень, але на замовлення лише один клієнт
    public string Address { get; set; } // Адреса
    public static int ClientsCreated { get; set; } = 0;

    private List<Order> orders = new List<Order>(); // Список замовлень клієнта

    private static List<Client> clients = new List<Client>(); // Список клієнтів

    public Client() { }

    public Client(string fN, string pN, string addr)
    {
        FullName = fN;
        PhoneNumber = pN;
        Address = addr;

        clients.Add(this);
        ClientsCreated++;
    }

    // Список клієнтів
    public static List<Client> GetClientsList()
    {
        return clients;
    }
    public static void SetClientsList(List<Client> clientsList)
    {
        clients = clientsList;
    }
    
    // Додати замовлення клієнту
    public void AddOrder(Order order)
    {
        orders.Add(order);
    }
    // Прибрати замовлення у клієнта
    public void RemoveOrder(Order order)
    {
        orders.Remove(order);
    }
    // Список замовлень
    public List<Order> GetOrdersList()
    {
        return orders;
    }

    // Вивести список замовлень
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
