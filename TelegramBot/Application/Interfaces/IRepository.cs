using Domain.Entities;

namespace Application.Interfaces;

/// <summary>
/// Создает доп абстракцию между фактическим репозиторием и сущностью, реализует CRUD операции
/// </summary>
/// <typeparam name="TEntity"></typeparam>
public interface IRepository<TEntity>
{
    public TEntity GetById(Guid id);
    public List<TEntity> Get();
    public TEntity Create(TEntity entity);
    public TEntity Update(TEntity entity);
    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="id"></param>
    /// <returns>возвращает true если удаление произошло успешно, и false если нет</returns>
    public bool Delete(Guid id);
}