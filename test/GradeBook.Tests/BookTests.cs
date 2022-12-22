namespace GradeBook.Tests;

public class BookTests
{
    [Fact]
    public void BookCalculatesStats()
    {
        // arrange
        var book = new Book("");
        book.AddGrade(89.1);
        book.AddGrade(90.5);
        book.AddGrade(77.3);

        // act
        var result = book.GetStats();

        // assert
        Assert.Equal(85.6, result.Average, 1);
        Assert.Equal(90.5, result.HighScore, 1);
        Assert.Equal(77.3, result.LowScore, 1);
    }
}