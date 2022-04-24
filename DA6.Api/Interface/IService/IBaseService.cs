namespace DA6.Api.Interface.IService
{
    public interface IBaseService<T>
    {
        IEnumerable<T> GetAll();
        T GetById(object id);
        int Insert(T obj);
        int Update(T obj);
        int Delete(object id);
        void Save();
    }
}
