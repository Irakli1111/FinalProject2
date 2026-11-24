using FinalProject2.Models;

namespace FinalProject2.Services;

internal class StudentService : FinalProject2.UsersInterface.UserInterface
{
    private readonly List<Student> students = new List<Student>();

    private readonly FileService fileService = new FileService();

    public async Task AddStudentAsync(Student student)
    {
        bool exists = students.Any(s => s.RollNumber == student.RollNumber);

        if (exists)
        {
            Console.WriteLine("Student Already Exists!");
            return;
        }

        students.Add(student);

        await fileService.SaveStudentsAsync(students);
    }
    public async Task AddNewStudentAsync()
    {
        Console.Write("First Name: ");
        string firstname = Console.ReadLine()!;

        Console.Write("Last Name: ");
        string lastname = Console.ReadLine()!;

        Console.Write("Email: ");
        string email = Console.ReadLine()!;

        Console.Write("Phone Number: ");
        string phonenumber = Console.ReadLine()!;

        Console.Write("Address: ");
        string address = Console.ReadLine()!;

        Console.Write("BirthDate (yyyy-MM-dd): ");
        DateOnly birthdate = DateOnly.Parse(Console.ReadLine()!);

        Console.Write("Roll Number: ");
        int rollnumber = int.Parse(Console.ReadLine()!);

        Console.Write("Age: ");
        int age = int.Parse(Console.ReadLine()!);

        Console.Write("Gender: ");
        Gender gender = Enum.Parse<Gender>(Console.ReadLine()!, true);

        Console.Write("Skills: ");
        Skills skills = Enum.Parse<Skills>(Console.ReadLine()!, true);

        Console.Write("Grade: ");
        char grade = char.Parse(Console.ReadLine()!);

        Console.Write("Courses: ");
        Courses courses = Enum.Parse<Courses>(Console.ReadLine()!, true);

        Console.Write("Description: ");
        string description = Console.ReadLine()!;

        Student student = new Student(firstname, lastname, email, phonenumber, address, birthdate, rollnumber, age, gender, skills, grade, courses, description);

        await AddStudentAsync(student);

        Console.WriteLine("Student Successfully Added!");
    }
    public Task SeeAllStudentsAsync()
    {
        if(students.Count == 0)
        {
            Console.WriteLine("No Students Found!");
            return Task.CompletedTask;
        }
        foreach(Student student in students)
        {
            Console.WriteLine(student);
        }
        return Task.CompletedTask;
    }
    public Task SearchStudentByRollNumberAsync()
    {
        Console.WriteLine("Enter Roll Number: ");

        if(!int.TryParse(Console.ReadLine(), out int rollnumber))
        {
            Console.WriteLine("Invalid Roll Number!");
            return Task.CompletedTask;
        }
        Student? student = students.FirstOrDefault(s => s.RollNumber == rollnumber);

        if(student == null)
        {
            Console.WriteLine("Student Not Found!");
            return Task.CompletedTask;
        }

        Console.WriteLine(student);

        return Task.CompletedTask;
    }
    public async Task RenewStudentDescriptionAsync()
    {
        Console.WriteLine("Enter Roll Number: ");

        if (!int.TryParse(Console.ReadLine(), out int rollnumber))
        {
            Console.WriteLine("Invalid Roll Number!");
            return;
        }
        Student? student = students.FirstOrDefault(s => s.RollNumber == rollnumber);

        if (student == null)
        {
            Console.WriteLine("Student Not Found!");
            return;
        }

        Console.WriteLine("Enter New Description: ");

        student.Description = Console.ReadLine();

        await fileService.SaveStudentsAsync(students);

        Console.WriteLine("Student Description Successfully Updated!");
    }
    public async Task LogOutAsync()
    {
        await fileService.SaveStudentsAsync(students);
        Console.WriteLine("Successfully Logged Out!");
    }

    public async Task LoadStudentsAsync()
    {
        List<Student> loadedStudents = await fileService.LoadStudentsAsync();

        students.Clear();
        students.AddRange(loadedStudents);

        Console.WriteLine($"{students.Count} students loaded!");
    }

    public async Task SaveStudentsAsync()
    {
        await fileService.SaveStudentsAsync(students);
    }
}
