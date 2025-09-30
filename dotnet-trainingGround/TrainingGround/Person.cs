namespace TrainingGround;

public class Person
{
    private string? Name;
    public int BirthYear;
    public double LengthInMeters;
    public Person() { }
    public Person(string name)
    {
        this.Name = name;
    }
    public string GetName()
    {
        return this.Name;
    }
    public string SetName(string nameToSet)
    {
        if (nameToSet.Length > 5)
        {
            this.Name = nameToSet;
        }
    }
}