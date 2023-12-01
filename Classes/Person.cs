public abstract class Person // Абстрактний клас людини для майстра та клієнта
{
    public string FullName { get; set; } // ПІБ
    public string PhoneNumber { get; set; } // Номер телефону

    public Person(string fullName, string phoneNumber)
    {
        FullName = fullName;
        PhoneNumber = phoneNumber;
    }

    public Person() { }
}