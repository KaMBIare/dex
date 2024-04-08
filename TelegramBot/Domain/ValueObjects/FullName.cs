using Domain.Validations;

namespace Domain.Primitives;
/// <summary>
/// полное имя человека
/// </summary>
public class FullName
{
    public FullName(string firstName, string lastName, string middleName)
    {
        FirstName = firstName;
        LastName = lastName;
        MiddleName = middleName;
        if (new FullNameValidation().Validate(this).IsValid)
        {
            throw new Exception("FullName validation exeption");
        }
    }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string? MiddleName { get; set; } = null;
}