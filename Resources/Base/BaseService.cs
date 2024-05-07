using ApiBasic.Data;
using ApiBasic.Models;

namespace ApiBasic.Services
{
    public class BaseService<T> where T : Base
    {
        private readonly AppDbContext _context;

        public BaseService(AppDbContext context)
        {
            _context = context;
        }

        public void Create(T entity)
        {
            _context.Set<T>().Add(entity);
            _context.SaveChanges();
        }

        public T GetById(int id)
        {
            return _context.Set<T>().Find(id) ?? throw new Exception("Entity not found");
        }

        public void Update(T entity)
        {
            _context.Set<T>().Update(entity);
            _context.SaveChanges();
        }

        public void Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
            _context.SaveChanges();
        }

        public T[] GetAll()
        {
            return _context.Set<T>().ToArray();
        }
    }
}
