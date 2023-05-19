namespace CSharp.Version12;

public static class PrimaryConstructorsSample
{
    public class User(string name, int age, bool isActive)
    {
        public Address Address { get; set; }

        public User(string name, int age) : this(name, age, true)
        {
        }

        public override string ToString() =>
            $"USER: Name = {name}, Age = {age}, Active = {isActive}, Address = {Address}";
    }

    public struct Address(string address, string city, int zip, string state)
    {
        // For structs, implicit parameterless constructor is always emitted, but you can override it
        //public Address() : this("N/A", "N/A", 0, "N/A")
        //{
        //}

        public override string ToString() =>
            $"{address}, {city}, {zip}, {state}";
    }

    public static void Run()
    {
        var userWithoutAddress = new User("Joan", 43);

        var userWithAddress = new User("John", 45, true)
        {
            Address = new Address("Jump street", "New York", 11000, "NY")
        };

        Console.WriteLine(userWithoutAddress.ToString());
        Console.WriteLine(userWithAddress.ToString());
    }
}
