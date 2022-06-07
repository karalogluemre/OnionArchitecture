﻿using EFKSystemAPI.Application.Repositories;
using EFKSystemAPI.Domain.Entities.Common;
using EFKSystemAPI.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EFKSystemAPI.Persistence.Repositories
{
    public class ReadRepository<T> : IReadRepository<T> where T : BaseEntity
    {
        private readonly ApplicationDbContext _context;

        public ReadRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public DbSet<T> Table => _context.Set<T>();

        public IQueryable<T> GetAllAsync() => Table;

        public async Task<T> GetByIdAsync(string id)
        => await Table.FirstOrDefaultAsync(data => data.Id == Guid.Parse(id));


        public async Task<T> GetSingleAsync(Expression<Func<T, bool>> method) =>
            await Table.FirstOrDefaultAsync(method);

        public IQueryable<T> GetWhereAsync(Expression<Func<T, bool>> method) => Table.Where(method);
    }
}
