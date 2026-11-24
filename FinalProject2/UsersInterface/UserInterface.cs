using FinalProject2.Models;

namespace FinalProject2.UsersInterface;

internal interface UserInterface
{

    Task AddStudentAsync(Student student);

    Task AddNewStudentAsync();

    Task SeeAllStudentsAsync();

    Task SearchStudentByRollNumberAsync();

    Task RenewStudentDescriptionAsync();

    Task LogOutAsync();
}
