using Domain.Primitives;

namespace Application.Dtos;

public class PersonGetByResponce
{
    public Guid id;
    
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string? MiddleName { get; set; } = null;
    
    public Gender Gender { get; set; }
    public DateTime BirthDay { get; set; }
    public int Age => DateTime.Now.Year - BirthDay.Year;
    public string PhoneNumber { get; set; }
    public string Telegram { get; set; }
    


}