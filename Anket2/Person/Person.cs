namespace Anket2;

public class Person
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public DateTime Date { get; set; }

    public Person(string name, string surname, string email, string phone, DateTime date)
    {
        Name = name;
        Surname = surname;
        Email = email;
        Phone = phone;
        Date = date;
    }

}
