using Domain.Primitives;
using FluentValidation;

namespace Domain.Validations;

public class FullNameValidation : AbstractValidator<FullName>
{
    public FullNameValidation()
    {
        RuleFor(x => x.FirstName)
            .NotNull().WithMessage("Имя не должно быть пустым")
            .NotEmpty().WithMessage("Имя не должно быть пустым")
            .Matches(@"^[a-zа-я]+$").WithMessage("Имя может содержать только буквы");
        RuleFor(x => x.LastName)
            .NotNull().WithMessage("Фамилия не должна быть пустой")
            .NotEmpty().WithMessage("Фамилия не должна быть пустой")
            .Matches(@"^[a-zа-я]+$").WithMessage("Фамилия может содержать только буквы");
        RuleFor(x => x.MiddleName)
            .Matches(@"^[a-zа-я]+$").WithMessage("Отчество может содержать только буквы");
    }
}