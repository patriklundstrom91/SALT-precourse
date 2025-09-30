namespace TrainingGround.Tests;

public class PersonTests
{
    [Fact]
    public void ParameterlessConstructor_CreatesPerson()
    {
        //act
        var p = new Person();

        //assert
        Assert.NotNull(p);
        
    }
    [Fact]
    public void ConstructorWithName_CreatesPerson()
    {
        //act
        var p = new Person("Marcus");
        //assert
        Assert.NotNull(p);
        Assert.Equal("Marcus", p.Name);
    }
}