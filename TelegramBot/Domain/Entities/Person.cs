using Domain.Primitives;
using Domain.Validations;

namespace Domain.Entities;

public class Person : BaseEntity
{
    public Person(FullName fullName, DateTime birthDay, string phoneNumber, string telegram, Gender gender)
    {
        FullName = fullName;
        BirthDay = birthDay;
        PhoneNumber = phoneNumber;
        Telegram = telegram;
        Gender = gender;
        if (!new PersonValidation().Validate(this).IsValid)
        {
            throw new Exception("Неправильно введены данные");
        }
    }
    public FullName FullName { get; set; }
    public DateTime BirthDay { get; set; }
    public string PhoneNumber { get; set; }
    public string Telegram { get; set; }
    public Gender Gender { get; set; }
    public int Age => DateTime.Now.Year - BirthDay.Year;

}