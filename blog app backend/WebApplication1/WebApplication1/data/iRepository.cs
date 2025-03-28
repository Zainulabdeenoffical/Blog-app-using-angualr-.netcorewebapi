﻿using System.Linq.Expressions;
using System.Runtime.InteropServices;

namespace WebApplication1.data
{
    public interface iRepository<T> where T : class
    {
        Task<List<T>> Getall();

        Task<List<T>> Getall(Expression<Func<T, bool >> filter);

        Task<T> GetbyId(int id);

        Task AddAsync(T entity);

        Task UpdateAsync(T entity);

        Task DeleteAsync(int id);

        Task SavechnagesAsync();


    }
}
