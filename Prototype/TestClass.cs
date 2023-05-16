namespace Prototype;

public class TestClass : ICloneable
{
    public int Id { get; set; }

    public TestClass(int id)
    {
        Id = id;
    }

    public TestClass()
    {
    }

    public TestClass(TestClass test)
    {
        Id = test.Id;
    }

    public TestClass Clone()
    {
        return new TestClass(Id);
    }

    object ICloneable.Clone()
    {
        return Clone();
    }
}