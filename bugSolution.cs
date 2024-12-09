public class MyClass
{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        int x = 10;
        int y = 0;
        try
        {
            int z = x / y;
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
            // Handle the exception appropriately, e.g., log the error, return a default value, etc.
        }
    }
}