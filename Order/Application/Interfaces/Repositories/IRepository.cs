using Domain.Model;

namespace Application.Interfaces.Repositories;

public interface IRepository<TEntity> where TEntity : EntityBase
{
    public void Add(TEntity entity);
    public void Delete(TEntity entity);
    public TEntity FindById(int id);
    public IQueryable<TEntity> GetAll(int pageList, int pageNumber);
    public void Update(TEntity entity);

}