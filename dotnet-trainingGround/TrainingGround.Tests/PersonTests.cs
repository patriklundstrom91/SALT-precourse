using System.Net.Sockets;

namespace TrainingGround.Tests;

public class PersonTests
{
    private Person _p;
    public PersonTests()
    {
        _p = new Person();
    }
    [Fact]
    public void ParameterlessConstructor_CreatesPerson()
    {

        //assert
        Assert.NotNull(_p);

    }
    [Fact]
    public void ConstructorWithName_CreatesPerson()
    {
        //act
        _p.SetName("Marcus");
        //assert
        Assert.NotNull(_p);
        Assert.Equal("Marcus", _p.Name);
    }
    [Fact]
    public void APersonBornIn1972_Is50_In2022()
    {
        //arrange
        _p.SetBirthYear(1972);

        //act
        var age = _p.GetAge(2022);

        //assert
        Assert.Equal(50, age);
    }
    [Fact]
    public void AnEmployeeIsAPerson()
    {
        // act
        var emp = new Employee();
        emp.LengthInMeters = 1.95;

        // assert
        Assert.IsType(typeof(Employee), emp);
        Assert.Equal(1.95, emp.LengthInMeters);
    }
    [Fact]
    public void AnEmployeeHasAnEmployeeId()
    {
        // act
        var emp = new Employee("Marcus", "234-BDAS");

        // assert
        Assert.IsType(typeof(Employee), emp);
        Assert.Equal("Marcus", emp.Name);
        Assert.Equal("234-BDAS", emp.EmployeeId);
    }
    [Fact]
    public void APersonHasAnAddress()
    {
        //arrange
        var p = new Person("Marcus");

        //act
        p.Address = new Address();
        p.Address.Street = "A Street";
        p.Address.StreetNo = 23;
        p.Address.City = "Stockholm";

        //assert

        Assert.NotNull(p.Address);
        Assert.IsType(typeof(Address), p.Address);

        Assert.Equal("A Street", p.Address.Street);
        Assert.Equal(23, p.Address.StreetNo);
        Assert.Equal("Stockholm", p.Address.City);
    }
    [Fact]
    public void AnEmployeeGetPrintString_GetsANicePrintedAddress()
    {
        // arrange
        var emp = new Employee("Marcus", "234-BDAS");
        emp.Address = new Address();
        emp.Address.Street = "A Street";
        emp.Address.StreetNo = 23;
        emp.Address.City = "Stockholm";

        // act
        var printString = emp.GetPrintString();

        // assert
        Assert.Equal(@"Marcus (234-BDAS)
        A Street 23
        Stockholm",
        printString);
    }
    public void Print(IPrintable printable)
    {
        var printString = printable.GetPrintString();
        Console.WriteLine(printString);
    }
    [Fact]
    public void CanPrintPrintables()
    {
        // arrange
        var emp = new Employee("Ossian", "234-BDAS");
        emp.Address = new Address();
        emp.Address.Street = "B Street";
        emp.Address.StreetNo = 22;
        emp.Address.City = "Malmö";

        var p = new Person("Marcus");
        p.Address = new Address();
        p.Address.Street = "A Street";
        p.Address.StreetNo = 23;
        p.Address.City = "Stockholm";

        // act
        this.Print(p);
        this.Print(emp);
    }
}
