namespace FinalProject2.Models;

public enum Courses
{
    Arts,
    APArt,
    DesignProgram,
    AP2DArtDesign,
    AP3DArtDesign,
    APDrawing,
    APArtHistory,
    APMusicTheory,
    English,
    APEnglishLanguageComposition,
    APEnglishLiteratureComposition,
    HistorySocialSciences,
    APAfricanAmericanStudies,
    APComparativeGovernmentPolitics,
    APEuropeanHistory,
    APHumanGeography,
    APMacroeconomics,
    APMicroeconomics,
    APPsychology,
    APUnitedStatesGovernmentPolitics,
    APUnitedStatesHistory,
    APWorldHistoryModern,
    MathComputerScience,
    APCalculusAB,
    APCalculusBC,
    APComputerScienceCourses,
    APComputerScienceA,
    APComputerSciencePrinciples,
    APPrecalculus,
    APStatistics,
    Sciences,
    APBiology,
    APChemistry,
    APEnvironmentalScience,
    APPhysics1AlgebraBased,
    APPhysics2AlgebraBased,
    APPhysicsCElectricityMagnetism,
    APPhysicsCMechanics,
    APWorldLanguagesCultures,
    APChineseLanguageCulture,
    APFrenchLanguageCulture,
    APGermanLanguageCulture,
    APItalianLanguageCulture,
    APJapaneseLanguageCulture,
    APLatin,
    APSpanishLanguageCulture,
    APSpanishLiteratureCulture,
    APCapstoneDiplomaProgram,
    APResearch,
    APSeminar,
    APCareerKickstart,
    APBusinessWithPersonalFinance
}
public enum Gender
{
    Male,
    Female,
    Other
}
public enum Skills
{
    Programming,
    Design,
    Communication,
    Leadership,
    ProblemSolving
}
internal class Student
{
    private static int id = 1;
    public int Id { get; set; } = id++;

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Email { get; set; }

    public string? PhoneNumber { get; set; }

    public string? Address { get; set; }

    public DateOnly BirthDate 
    {
        get => field;
        set
        {
            if (value > DateOnly.FromDateTime(DateTime.Now))
            {
                throw new ArgumentException("Birthdate cannot be in the future.");
            }
            else
            {
                field = value;
            }
        }
    }

    public int RollNumber { get; set; }

    public int Age { get; set; }

    public Gender Gender { get; set; }

    public Skills Skills { get; set; }

    public char Grade { get; set; }

    public Courses Courses { get; set; }

    public string? Description { get; set; }

    public Student(string firstname, string lastname, string email, string phonenumber, string address, 
        DateOnly birthdate, int rollnumber, int age, Gender gender, Skills skills, char grade, Courses courses, string? description)
    {
        this.FirstName = firstname;
        this.LastName = lastname;
        this.Email = email;
        this.PhoneNumber = phonenumber;
        this.Address = address;
        this.BirthDate = birthdate;
        this.RollNumber = rollnumber;
        this.Age = age;
        this.Gender = gender;
        this.Skills = skills;
        this.Grade = grade;
        this.Courses = courses;
        this.Description = description;
        Console.WriteLine($"Student created successfully. Id: {Id}, FirstName: {firstname}, LastName: {lastname}, Email: {email}, " +
            $"PhoneNumber: {phonenumber}, Address: {address}, BirthDate: {birthdate}, RollNumber: {rollnumber}," +
            $" Age: {age}, Gender: {gender}, Skills: {skills}, Grades: {grade}, Courses: {courses}, Description: {description}");
    }

    public Student()
    {
    }

    public override string ToString()
    {
        return $"Id: {Id}, FirstName: {FirstName}, LastName: {LastName}, Email: {Email}, " +
            $"PhoneNumber: {PhoneNumber}, Address: {Address}, BirthDate: {BirthDate}, RollNumber: {RollNumber}, " +
            $"Age: {Age}, Gender: {Gender}, Skills: {Skills}, Grades: {Grade}, Courses: {Courses}, Description: {Description}.";
    }
}
