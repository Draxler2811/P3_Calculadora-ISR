using ISR.Core.Entities;
using ISR.Core.Services;

namespace ISR.Test;

public class PersonShould
{
    [Fact]
    public void ProcessIsr_WithSalaryLessThanMinimum_ReturnsZeroIndex()
    {
        // Arrange
        var expectedIndex = 0m;
        var person = new Person { Salario = 0m };
        var sut = new IsrService();

        // Act
        var result = sut.ProcessIsr(person);

        // Assert
        Assert.Equal(expectedIndex, result.Index);
    }
    [Fact]
    public void ProcessIsr_WithSalaryEqualToMinimum_ReturnsZeroIndex()
    {
        // Arrange
        var expectedIndex = 0m;
        var person = new Person { Salario = 0.01m };
        var sut = new IsrService();

        // Act
        var result = sut.ProcessIsr(person);

        // Assert
        Assert.Equal(expectedIndex, result.Index);
    }
    [Fact]
    public void ProcessIsr_WithSalaryEqual2000_ReturnsExpectIndex()
    {
        // Arrange
        var expectedIndex = 38.399808m;
        var person = new Person { Salario = 2000m };
        var sut = new IsrService();

        // Act
        var result = sut.ProcessIsr(person);

        // Assert
        Assert.Equal(expectedIndex, result.Index);
    }
    [Fact]
    public void ProcessIsr_WithSalaryEqual1200_ReturnsExpectIndex()
    {
        // Arrange
        var expectedIndex = 23.039808m;
        var person = new Person { Salario = 1200m };
        var sut = new IsrService();

        // Act
        var result = sut.ProcessIsr(person);

        // Assert
        Assert.Equal(expectedIndex, result.Index);
    } 
    [Fact]
    public void ProcessIsr_WithSalaryEqual4000_ReturnsExpectIndex()
    {
        // Arrange
        var expectedIndex =  76.799808m;
        var person = new Person { Salario = 4000m };
        var sut = new IsrService();

        // Act
        var result = sut.ProcessIsr(person);

        // Assert
        Assert.Equal(expectedIndex, result.Index);
    } 
    [Fact]
    public void ProcessIsr_WithSalaryEqual42222_ReturnsExpectIndex()
    {
        // Arrange
        var expectedIndex =  2355.67736m;
        var person = new Person { Salario = 42222m };
        var sut = new IsrService();

        // Act
        var result = sut.ProcessIsr(person);

        // Assert
        Assert.Equal(expectedIndex, result.Index);
    } 
    [Fact]
    public void ProcessIsr_WithSalaryEqual31313_ReturnsExpectIndex()
    {
        // Arrange
        var expectedIndex =   1657.50136m;
        var person = new Person { Salario = 31313m };
        var sut = new IsrService();

        // Act
        var result = sut.ProcessIsr(person);

        // Assert
        Assert.Equal(expectedIndex, result.Index);
    } 
    [Fact]
    public void ProcessIsr_WithSalaryEqual1111_ReturnsExpectIndex()
    {
        // Arrange
        var expectedIndex =  21.331008m;
        var person = new Person { Salario = 1111m };
        var sut = new IsrService();

        // Act
        var result = sut.ProcessIsr(person);

        // Assert
        Assert.Equal(expectedIndex, result.Index);
    } 
    [Fact]
    public void ProcessIsr_WithSalaryEqual1000_ReturnsExpectIndex()
    {
        // Arrange
        var expectedIndex =   19.199808m;
        var person = new Person { Salario = 1000m };
        var sut = new IsrService();

        // Act
        var result = sut.ProcessIsr(person);

        // Assert
        Assert.Equal(expectedIndex, result.Index);
    } 
    [Fact]
    public void ProcessIsr_WithSalaryEqual800_ReturnsExpectIndex()
    {
        // Arrange
        var expectedIndex =  15.359808m;
        var person = new Person { Salario = 800m };
        var sut = new IsrService();

        // Act
        var result = sut.ProcessIsr(person);

        // Assert
        Assert.Equal(expectedIndex, result.Index);
    } 
    [Fact]
    public void ProcessIsr_WithSalaryEqual3500_ReturnsExpectIndex()
    {
        // Arrange
        var expectedIndex =  67.199808m;
        var person = new Person { Salario = 3500m };
        var sut = new IsrService();

        // Act
        var result = sut.ProcessIsr(person);

        // Assert
        Assert.Equal(expectedIndex, result.Index);
    } 
}