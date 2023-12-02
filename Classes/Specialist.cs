using Course_Project_GUI;
using System;

public class Specialist : Person // Майстер (наслідування від Person)
{
    public string BranchName { get; set; } // Назва філіалу
    public bool IsFree { get; set; } = true; // Чи вільний
    public static int SpecsCreated { get; set; } = 0; // Майстрів створено (за сесію)
    public string OrderID { get; set; } = "N/A"; // ID замовлення

    private static List<Specialist> availableSpecs = new List<Specialist>(); // Статичний список вільних майстрів
    private static List<Specialist> allSpecs = new List<Specialist>(); // Всі майстри

    public Specialist(string fN, string pNum, string bN)
    {
        FullName = fN;
        PhoneNumber = pNum;
        BranchName = bN;

        availableSpecs.Add(this);
        allSpecs.Add(this);

        SpecsCreated++;
    }

    public Specialist() { }

    // Додати вільного майстра
    public static void AddAvailableSpec(Specialist spec)
    {
        availableSpecs.Add(spec);
    }
    // Видалити майстра зі списку
    public void RemoveFromAvailableSpecsList()
    {
        if (availableSpecs.Contains(this))
        {
            availableSpecs.Remove(this);
        }
    }

    // Список вільних майстрів
    public static List<Specialist> GetAvailableSpecsList()
    {
        return availableSpecs;
    }
    public static void SetAvailableSpecsList(List<Specialist> avalSpecs)
    {
        availableSpecs = avalSpecs;
    }

    // Список всіх майстрів
    public static List<Specialist> GetAllSpecsList()
    {
        return allSpecs;
    }
    public static void SetAllSpecsList(List<Specialist> specs)
    {
        allSpecs = specs;
    }

}
