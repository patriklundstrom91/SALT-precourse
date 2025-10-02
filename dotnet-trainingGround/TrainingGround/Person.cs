
namespace TrainingGround;

public class Person: IPrintable
{
    public string? Name { get; private set; }
    public int BirthYear { get; private set; }

    public double LengthInMeters;
    public Person() { }
    public Person(string name)
    {
        this.Name = name;
    }
    public Person(int year)
    {
        this.BirthYear = year;
    }

    public string GetName()
    {
        return this.Name;
    }
    public void SetName(string nameToSet)
    {
        if (nameToSet.Length > 5)
        {
            this.Name = nameToSet;
        }
    }

    public int GetAge(int currentYear)
    {
        return currentYear - this.BirthYear;
    }
    public void SetBirthYear(int birthYear)
    {
        this.BirthYear = birthYear;
    }

    public string GetPrintString()
    {
        return @$"{this.Name}
        {this.Address.Street} {this.Address.StreetNo}
        {this.Address.City}";
    }

    public Address Address { get; set; }
}