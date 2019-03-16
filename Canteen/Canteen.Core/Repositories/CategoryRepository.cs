﻿using Canteen.Core.EF;
using Canteen.Data.Entities;
using Canteen.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canteen.Core.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly CanteenDbContext _context;

        public CategoryRepository(CanteenDbContext context)
        {
            _context = context;
        }

        public async Task<List<Category>> GetAllAsync()
        {
            return await _context.Categories.ToListAsync();
        }

        public async Task<Category> GetByIdAsync(Guid id)
        {
            return await _context.Categories
                .Include(x => x.Dishes).FirstAsync(c => c.Id == id);
        }

        public async Task<List<Category>> GetByCookShopAsync(Guid id)
        {
            return await _context.Categories.Where(x => x.CookShopId == id).ToListAsync();
        }
        public async Task<Category> CreateAsync(Category item)
        {
            var result = await _context.Categories.AddAsync(item);
            await _context.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<bool> UpdateAsync(Category item)
        {
            _context.Categories.Update(item);
            await _context.SaveChangesAsync();
            return true;
        }
        public async Task<bool> DeleteAsync(Guid id)
        {
            Category category = await _context.Categories.FindAsync(id);
            if (category == null)
                return false;
            _context.Categories.Remove(category);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
