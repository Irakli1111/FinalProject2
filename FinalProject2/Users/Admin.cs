namespace FinalProject2.Users;

internal class Admin : Client
{
    private static int id = 1;

    public int Id1 { get; set; } = id++;

    protected Admin(string name, string email) : base()
    {
        this.Name = name;
        this.Email = email;
        Console.WriteLine($"Id: {Id}, Name: {name}, Email: {email}.");
    }
    public Admin()
    {
        
    }
    public override string ToString()
    {
        return $"You Are Admin. Id: {Id}, Name: {Name}, Email: {Email}.";
    }
}
