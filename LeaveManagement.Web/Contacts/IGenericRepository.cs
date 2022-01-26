﻿namespace LeaveManagement.Web.Contacts
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> GetAsync(int? id);
        Task<List<T>> GetAllAsync();
        Task<T> AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task<bool> Exists(int id);

        Task DeleteAsync(int id);
    }
}
