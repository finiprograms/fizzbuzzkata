namespace FizzBuzzKata.Tests;

public class UnitTest1
{
    /// create a func that takes in an int and returns a string
    /// 3 returns "fizz"
    /// 5 returns "buzz"
    /// Otherwise return input as string
    
    /// ifjoifioefj
    /// Here is MPFR's change
    /// Man-Oz
    /// Bran
    [Fact]
    public void FizzBuzzNegativeTest()
    {
        // Arrange
        Random random = new Random();
        var number = random.Next(1000);

        // Act
        var result = FizzBuzzKata.FizzBuzz(number);

        // Assert
        Assert.NotNull(result);
    }
}


public static class FizzBuzzKata {

    public static string FizzBuzz(int input)
    {
        return string.Empty;
    }
}