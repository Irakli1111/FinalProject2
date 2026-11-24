namespace FinalProject2.Users;

internal class Client
{
    private static int id = 1;

    public int Id { get; set; } = id++;

    public string? Name { get; set; }

    public string? Email { get; set; }

    protected Client(string name, string email) : base()
    {
        this.Name = name;
        this.Email = email;
        Console.WriteLine($"Id: {Id}, Name: {name}, Email: {email}.");
    }

    public Client()
    {

    }

    public override string ToString()
    {
        return $"You Are Client. Id: {Id}, Name: {Name}, Email: {Email}.";
    }
}
