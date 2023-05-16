namespace Singletone;

public static class TestClass
{
    public static string FirstName { get; set; }
    public static string LastName { get; set; }
    public static string FullName => $"{LastName} {FirstName}";
}