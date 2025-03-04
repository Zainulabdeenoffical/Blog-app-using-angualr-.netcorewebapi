
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System.Linq.Expressions;
using WebApplication1.data;
namespace WebApplication1.data
{
 public class sqlrepository<T> : iRepository <T> where T : class
    {
        private readonly AppDbContextcs dbContextcs;

        public sqlrepository(AppDbContextcs dbContextcs) {
            this.dbContextcs = dbContextcs;
        }
        public async Task AddAsync(T entity)
        {
            await dbContextcs.Set<T>().AddAsync(entity);
        }

        public async Task DeleteAsync(int id)
        {
          var enitiy = await  dbContextcs.Set<T>().FindAsync(id);

          dbContextcs.Set<T>().Remove(enitiy);

        }

        public async Task<List<T>> Getall()
        {
           return await dbContextcs.Set<T>().ToListAsync();
        }

        public async Task<List<T>> Getall(Expression<Func<T, bool>> filter)
        {
            return await dbContextcs.Set<T>().Where(filter).ToListAsync();
        }

        public async Task<T> GetbyId(int id)
        {
           return await dbContextcs.Set<T>().FindAsync(id);
        }

        public async Task SavechnagesAsync()
        {
           await dbContextcs.SaveChangesAsync();
        }

        public async Task UpdateAsync(T entity)
        {

            dbContextcs.Set<T>().Update(entity); 
            await dbContextcs.SaveChangesAsync();
        }
    }

}