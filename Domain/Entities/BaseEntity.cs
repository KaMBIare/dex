namespace Domain.Entities;
/// <summary>
/// базовый класс для всех сущностей
/// </summary>
public abstract class BaseEntity
{
    public Guid Id { get; set; }
    
    public override bool Equals(object? obj)
    {
        if (obj == null)
            return false;
        if (obj is not BaseEntity entity)
            return false;
        if (Id != entity.Id)
            return false;
        return true;
    }

    public override int GetHashCode()
    {
        return Id.GetHashCode();
    }
}