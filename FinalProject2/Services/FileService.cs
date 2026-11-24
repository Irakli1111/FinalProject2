using FinalProject2.Models;
using System.Text.Json;

namespace FinalProject2.Services;

internal class FileService
{
    private readonly string FilePath = Path.Combine(AppContext.BaseDirectory, "Data", "students.json");

    public async Task SaveStudentsAsync(List<Student> students)
    {
        using StreamWriter sw = new StreamWriter(FilePath);
        JsonSerializerOptions options = new JsonSerializerOptions
        {
            WriteIndented = true
        };
        string jsonString = JsonSerializer.Serialize(students, options);
        await sw.WriteLineAsync(jsonString);

        Console.WriteLine("Students successfully saved!");
    }
    public async Task<List<Student>> LoadStudentsAsync()
    {
        if (!File.Exists(FilePath))
        {
            return new List<Student>();
        }

        try
        {
            using FileStream stream = new FileStream(FilePath, FileMode.Open, FileAccess.Read, FileShare.Read, 4096, true);
            JsonSerializerOptions options = new JsonSerializerOptions
            {
                WriteIndented = true
            };
            return await JsonSerializer.DeserializeAsync<List<Student>>(stream, options) ?? new List<Student>();
        }
        catch (JsonException ex)
        {
            Console.WriteLine($"JSON Error: {ex.Message}");
            return new List<Student>();
        }
        catch (IOException ex)
        {
            Console.WriteLine($"File Error: {ex.Message}");
            return new List<Student>();
        }
    }
}
