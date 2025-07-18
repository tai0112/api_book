﻿using HiNetProjectApi.Models.Domain;

namespace HiNetProjectApi.Repository.IRepository
{
    public interface ISubGenreRepository
    {
        IQueryable<SubGenre> GetAllAsync();
        Task<SubGenre?> GetByIdAsync(Guid id);
        Task<SubGenre> CreateAsync(SubGenre subGenre);
        Task<SubGenre?> UpdateAsync(Guid id, SubGenre subGenre);
        Task<SubGenre?> RemoveAsync(Guid id);
    }
}
