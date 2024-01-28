namespace TechMed.Infrastructure.Persistence.Interface;
public interface IBaseCollection<T> {
    int Create(T entity);
    ICollection<T> GetAll();
    T? GetById(int id);
     void Update(int id, T obj);
    void Delete(int id);
}
