using iqlaa3.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace iqlaa3.Data
{
    public class Iqla3DB
    {
        readonly SQLiteAsyncConnection _database;

        public Iqla3DB(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Website>().Wait();
            _database.CreateTableAsync<Category>().Wait();
        }

        public Task<List<Website>> GetWebsitesAsync()
        {
            return _database.Table<Website>().ToListAsync();
        }

        public Task<Website> GetWebsiteAsync(int id)
        {
            return _database.Table<Website>()
                            .Where(i => i.Id == id)
                            .FirstOrDefaultAsync();
        }

        public Task<int> SaveWebsiteAsync(Website  website)
        {
            if (website.Id != 0)
            {
                return _database.UpdateAsync(website);
            }
            else
            {
                return _database.InsertAsync(website);
            }
        }

        public Task<int> DeleteWebsiteAsync(Website website)
        {
            return _database.DeleteAsync(website);
        }

        //category oprations
        public Task<List<Category>> GetCategoriesAsync()
        {
            return _database.Table<Category>().ToListAsync();
        }

        public Task<Category> GetCategoryAsync(int id)
        {
            return _database.Table<Category>()
                            .Where(i => i.Id == id)
                            .FirstOrDefaultAsync();
        }

        public Task<int> SaveCategoryAsync(Category  category)
        {
            if (category.Id != 0)
            {
                return _database.UpdateAsync(category);
            }
            else
            {
                return _database.InsertAsync(category);
            }
        }

        public Task<int> DeleteCategoryAsync(Category  category)
        {
            return _database.DeleteAsync(category);
        }
    }
}
