namespace PapAPI.Abstraction
{
    public interface ICRUD<T>
    {

        T GetById(int id);
        IList<T> GetAll();


        T Save(T entity);


    }
}