using Application.Dtos;
using AutoMapper;
using Domain.Entities;
using Domain.Primitives;

namespace Application.Mapping;

/// <summary>
/// класс маппера для Person
/// </summary>
public class PersonMapperProfile : Profile
{
    /// <summary>
    /// в конструкторе устанавливаются натсройки для мапинга
    /// </summary>
    public PersonMapperProfile()
    {
        //настройки для конвертирования из Perosn в PersonGetByResponse
        CreateMap<Person, PersonGetByResponce>()
            .ForMember(dto => dto.FirstName,
                opt => opt.MapFrom(srcPerson => srcPerson.FullName.FirstName))
            .ForMember(dto => dto.LastName,
                opt => opt.MapFrom(srcPerson => srcPerson.FullName.LastName))
            .ForMember(dto => dto.MiddleName,
                opt => opt.MapFrom(srcPerson => srcPerson.FullName.MiddleName!)); 
        
        //настройки для конвертирования из PersonGetByResponse в Perosn
        CreateMap<PersonGetByResponce, Person>()
            .ConstructUsing(dto => new Person(new FullName(dto.FirstName, dto.LastName, dto.MiddleName!), dto.BirthDay,
                dto.PhoneNumber, dto.Telegram, dto.Gender));
    }
}