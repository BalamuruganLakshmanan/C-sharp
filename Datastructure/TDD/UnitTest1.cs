namespace TDD;
[TestFixture]
public class Tests
{   
    Mathematics operation=null;
    Mathematics operation1=null;
    Mathematics operation2=null;


    [SetUp]
    public void Setup()
    {
        operation=new Mathematics( );
        operation1=new Mathematics( );
        operation2=new Mathematics( );
    }

    [Test]
    public void Test1()
    {
       int result=operation.Addition(10,11);
        Assert.That(result,Is.EqualsTo(21));

    }
}