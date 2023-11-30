﻿public abstract class Person // Абстрактний клас людини для майстра та клієнта
{
    public string FullName { get; set; } // ПІБ
    public string PhoneNumber { get; set; } // Номер телефону

    /// <summary>
    /// Конструктор за замовчуванням
    /// </summary>
    public Person()
    {
        Console.Write("ПІБ: "); FullName = Console.ReadLine();
        Console.Write("Номер телефону: "); PhoneNumber = Console.ReadLine();
    }

}