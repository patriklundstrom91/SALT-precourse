namespace TrainingGround.Tests;

public class TypesTests
{
    [Fact]
    public void ReferenceTypes_CanBeChangedViaReference()
    {
        // arrange
        Person a = new Person("Person A");
        a.LengthInMeters = 1.95;
        Person b = a;

        // act
        b.LengthInMeters = 1.96;

        // assert
        Assert.Equal(1.96, b.LengthInMeters);
        Assert.Equal(1.96, a.LengthInMeters);
    }
    [Fact]
    public void ValueTypes_CannotBeChangedViaReference()
    {
        // arrange
        double aLengthInMeters = 1.95;
        double bLengthInMeters = aLengthInMeters;
        long aNumber = 12452524242;
        var anotherNumber = 12452524242;

        // act
        bLengthInMeters = 1.96;

        // assert
        Assert.Equal(1.96, bLengthInMeters);
        Assert.Equal(1.95, aLengthInMeters);
    }
    [Fact]
    public void GetAgeFromPerson_ReturnsCorrectAge()
    {
        // arrange
        var p = new Person();
        p.SetBirthYear(1972);

        // act
        var age = p.GetAge(2022);

        // assert
        Assert.Equal(50, age);
        Assert.IsType(typeof(Person), p);
        Assert.IsType(typeof(int), age);
    }
}