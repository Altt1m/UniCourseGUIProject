using System;

public class Specialist : Person // Майстер (наслідування від Person)
{
    public string BranchName { get; set; } // Назва філіалу
    public bool IsFree { get; set; } = true;

    //private Order assignedOrder;
    private static List<Specialist> availableSpecs = new List<Specialist>(); // Статичний список майстрів
    private static List<Specialist> allSpecs = new List<Specialist>();

    /// <summary>
    /// Конструктор з параметрами
    /// </summary>
    /// <param name="fN">ПІБ</param>
    /// <param name="pNum">Номер телефону</param>
    /// <param name="bN">Назва філіалу</param>
    public Specialist(string fN, string pNum, string bN)
    {
        FullName = fN;
        PhoneNumber = pNum;
        BranchName = bN;
        availableSpecs.Add(this);

        allSpecs.Add(this);
    }

    /// <summary>
    /// Повертає список доступних майстрів
    /// </summary>
    /// <returns>Список вільних майстрів</returns>
    public static List<Specialist> GetAvailableSpecsList()
    {
        return availableSpecs;
    }

    public static List<Specialist> GetAllSpecsList()
    {
        return allSpecs;
    }

    /// <summary>
    /// Видаляє майстра зі списку доступних
    /// </summary>
    public void RemoveFromSpecsList()
    {
        if (availableSpecs.Contains(this))
        {
            availableSpecs.Remove(this);
        }
    }

    /// <summary>
    /// Приписує майстру замовлення
    /// </summary>
    /// <param name="order">Приписуване замовлення</param>
    //public void SetAssignedOrder(Order order)
    //{
    //    assignedOrder = order;
    //}

}
