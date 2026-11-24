namespace FinalProject2.Users;

internal class Guest : Client
{
    private static int id = 1;

    public int Id2 { get; set; } = id++;

    public Guest(string name, string email) : base()
    {
        this.Name = name;
        this.Email = email;
        Console.WriteLine($"Id: {Id}, Name: {name}, Email: {email}.");
    }
    public Guest()
    {
        
    }
    public override string ToString()
    {
        return $"You Are Guest. Id: {Id}, Name: {Name}, Email: {Email}.";
    }
}
