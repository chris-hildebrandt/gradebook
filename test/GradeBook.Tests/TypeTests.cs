namespace GradeBook.Tests;

public class TypeTests
{
    [Fact]
    public void ValueTypesCanPassByRef()
    {
        var x = GetInt();
        SetInt1(ref x);

        Assert.Equal(42, x);
    }
    
    [Fact]
    public void ValueTypesTest()
    {
        var x = GetInt();
        SetInt(x);

        Assert.Equal(3, x);
    }

    private void SetInt(int x)
    {
        x = 42;
    }

    private void SetInt1(ref Int32 z)
    {
        z = 42;
    }

    private int GetInt()
    {
        return 3;
    }

    [Fact]
    public void StringsBehaveLikeValueTypes()
    {
        // arrange
        string name = "chris";
        // act
        MakeUppercase(name);
        // assert
        Assert.Equal("chris", name);
    }

    [Fact]
    public void StringsBehaveLikeValueTypes2()
    {
        // arrange
        string name = "chris";
        // act
        name = MakeUppercase2(name);
        // assert
        Assert.Equal("chris", name);
    }

    private string MakeUppercase2(string name)
    {
        return name.ToUpper();
    }

    private void MakeUppercase(string name)
    {
        name.ToUpper();
    }

    [Fact]
    public void CSCanPassByRef()
    {
        // arrange
        var book1 = GetBook("Book 1");
        // act
        GetBookSetNameByRef(ref book1, "New Name");
        // assert
        Assert.Equal("New Name", book1.Name);
    }

    private void GetBookSetNameByRef(ref Book book, string name)
    {
        book = new Book(name);
        // ref needs to be in both the param and the arg to protect the original ref from being changed by accident.
    }

    [Fact]
    public void CSDefaultPassesByValue()
    {
        // arrange
        var book1 = GetBook("Book 1");
        // act
        GetBookSetName(book1, "New Name");
        // assert
        Assert.Equal("Book 1", book1.Name);
    }

    private void GetBookSetName(Book book, string name)
    {
        book = new Book(name);
    }

    [Fact]
    public void CanSetNameFromReference()
    {
        // arrange
        var book1 = GetBook("Book 1");
        // act
        SetName(book1, "New Name");
        // assert
        Assert.Equal("New Name", book1.Name);
    }

    private void SetName(Book book, string name)
    {
        book.Name = name;
    }

    [Fact]
    public void GetBookReturnsDifferentObjects()
    {
        // arrange
        var book1 = GetBook("Book 1");
        var book2 = GetBook("Book 2");

        // act


        // assert
        Assert.Equal("Book 1", book1.Name);
        Assert.Equal("Book 2", book2.Name);
        Assert.NotSame(book1, book2);
    }

    [Fact]
    public void TwoVariablesCanRefSameObject()
    {
        // arrange
        var book1 = GetBook("Book 1");
        var book2 = book1;
        // act
        // assert
        Assert.Same(book2, book1);
    }

    Book GetBook(string name)
    {
        return new Book(name);
    }
}