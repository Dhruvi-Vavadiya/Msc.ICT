
using Microsoft.EntityFrameworkCore;

namespace WebApplicationAPI.Models
{
    public class GenericImplement<T> : IGenericsClass<T> where T : class
    {
        private readonly EmployeeContext _context;
        private readonly DbSet<T> _table;

        public GenericImplement(EmployeeContext context)
        {
            _context = context;
            _table = context.Set<T>();
        }



        public IEnumerable<T> GetAll() => _table.ToList();

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
        public T GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(T obj)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update(T obj)
        {
            throw new NotImplementedException();
        }
    }
}
