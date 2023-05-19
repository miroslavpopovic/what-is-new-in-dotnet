using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LibraryApis.DotNet8;

public class Person
{
    [Required(DisallowAllDefaultValues = true)]
    public Guid Id { get; set; }

    [Length(5, 50)]
    public string Name { get; set; }

    [AllowedValues("HR", "Development", "Management")]
    public string Department { get; set; }

    [DeniedValues("iPhone", "iPad")]
    public string DefaultDevice { get; set; }

    [Range(1000, 10000, MinimumIsExclusive = true, MaximumIsExclusive = true)]
    public decimal Sallary { get; set; }

    [Base64String]
    public string ProfileImage { get; set; }
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
            Sallary = 1500
        };

        var invalidPerson = new Person
        {
            Id = Guid.Empty,
            DefaultDevice = "iPhone",
            Department = "Transportation",
            Name = "Ben",
            ProfileImage = "Some invalid image...",
            Sallary = 1000
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
