using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LibraryApis.DotNet8;

public class Person
{
    [Required(AllowEmptyStrings = false)]
    public Guid Id { get; set; }

    [Length(5, 50)]
    public required string Name { get; set; }

    [AllowedValues("HR", "Development", "Management")]
    public required string Department { get; set; }

    [DeniedValues("iPhone", "iPad")]
    public required string DefaultDevice { get; set; }

    [Range(1000, 10000, MinimumIsExclusive = true, MaximumIsExclusive = true)]
    public decimal Salary { get; set; }

    [Base64String]
    public required string ProfileImage { get; set; }
}

public static class DataAnnotationsImprovementsSample
{
    public static void Run()
    {
        var validPerson = new Person
        {
            Id = Guid.NewGuid(),
            DefaultDevice = "Laptop",
            Department = "HR",
            Name = "John Smith",
            ProfileImage = Convert.ToBase64String("Some valid image..."u8.ToArray()),
            Salary = 1500
        };

        var invalidPerson = new Person
        {
            Id = Guid.Empty,
            DefaultDevice = "iPhone",
            Department = "Transportation",
            Name = "Ben",
            ProfileImage = "Some invalid image...",
            Salary = 1000
        };

        var errors = GetValidationErrors(validPerson);
        Console.WriteLine($"Valid person result: {(string.IsNullOrWhiteSpace(errors) ? "VALID" : errors)}");

        errors = GetValidationErrors(invalidPerson);
        Console.WriteLine($"Invalid person result: {(string.IsNullOrWhiteSpace(errors) ? "VALID" : errors)}");
    }

    #region GetValidationErrors

    public static string GetValidationErrors(object source)
    {
        var context = new ValidationContext(source, null, null);
        var validationResults = new List<ValidationResult>();
        Validator.TryValidateObject(source, context, validationResults, true);

        if (!validationResults.Any())
        {
            return string.Empty;
        }

        var result = new StringBuilder();
        result.AppendLine("We found the next validations errors: ");

        foreach (var s in validationResults)
        {
            result.Append($"  {s.MemberNames.FirstOrDefault()} --> {s.ErrorMessage}{Environment.NewLine}");
        }

        return result.ToString();
    }

    #endregion
}
