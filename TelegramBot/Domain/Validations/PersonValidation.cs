using Domain.Entities;
using FluentValidation;

namespace Domain.Validations;

public class PersonValidation : AbstractValidator<Person>
{
    public PersonValidation()
    {
        RuleFor(x => x.FullName)
            .Cascade(FluentValidation.CascadeMode.StopOnFirstFailure)
            .NotNull().WithMessage("Имя, фамилия, или отчество не могут быть пустыми")
            .SetValidator(new FullNameValidation());
        RuleFor(x => x.BirthDay)
            .Must(ValidateBirthDay).WithMessage("Некоректный день рождения");
        RuleFor(x => x.PhoneNumber)
            .Matches(@"^\+37377[4-9][0-9]{5}$").WithMessage("Некоректный номер телефона");
        RuleFor(x => x.Telegram)
            .Must(x => !string.IsNullOrEmpty(x) && x.StartsWith("@")).WithMessage("Некоректный ник в телеграме");

    }

    private bool ValidateBirthDay(DateTime birthDay)
    {
        return (DateTime.Today - birthDay).TotalDays / 365 <= 120 && (DateTime.Today - birthDay).TotalDays > 0;
    }
}