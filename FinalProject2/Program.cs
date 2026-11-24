#region
using FinalProject2.Models;
using FinalProject2.Services;
using FinalProject2.Users;
using FinalProject2.UsersInterface;

Student student = new Student();
Client client = new Client();
Admin admin = new Admin();
Guest guest = new Guest();
Console.WriteLine("Student Info: ", student.Id = 11, student.FirstName = "Johny", student.LastName = "English", 
    student.Email = "JohnyEnglish189541@gmail.com", student.PhoneNumber = "597042894", student.Address = "Tbilisi",
    student.BirthDate = new(1998, 1, 11), student.RollNumber = 593, student.Age = 28, student.Gender = Gender.Male, 
    student.Skills = Skills.Programming, student.Grade = 'A', student.Courses = Courses.APComputerSciencePrinciples, 
    student.Description = "Very good student, he is clever and very hardworking.");
Console.WriteLine(client.Name = "Johny English", client.Email = "JohnyEnglish189541@gmail.com");
Console.WriteLine(client);
StudentService studentService = new StudentService();
UserInterface userInterface = studentService;
await studentService.LoadStudentsAsync();
await userInterface.AddStudentAsync(student);


while (true)
{
    Console.WriteLine("1. Add New Student");
    Console.WriteLine("2. See All Students");
    Console.WriteLine("3. Search Student By Roll Number");
    Console.WriteLine("4. Renew Student Description");
    Console.WriteLine("5. Log Out");

    Console.WriteLine("\n Choose Option: ");

    string? choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            await userInterface.AddNewStudentAsync();
            break;
        case "2":
            await userInterface.SeeAllStudentsAsync();
            break;
        case "3":
            await userInterface.SearchStudentByRollNumberAsync();
            break;
        case "4":
            await userInterface.RenewStudentDescriptionAsync();
            break;
        case "5":
            await userInterface.LogOutAsync();
            return;
        default:
            Console.WriteLine("Invalid Option!");
            break;
    }
}

#endregion