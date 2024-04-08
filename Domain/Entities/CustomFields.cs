namespace Domain.Entities;

public class CustomFields<TType> : BaseEntity
{
    public string Name { get; set; }
    public TType Value { get; set; }
}