using Otomasyon.Context;
using Otomasyon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otomasyon.Services
{
    public class CategoryService : IRepositoryService<Category>
    {
        //OtomasyonDbContext dbContext = new OtomasyonDbContext();
        public void Add(Category entity)
        {
            using (OtomasyonDbContext dbContext = new OtomasyonDbContext())
            {
                dbContext.Categories.Add(entity);
                dbContext.SaveChanges();
            }
        }
        public void Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Category> GetAll()
        {
            using (OtomasyonDbContext dbContext = new OtomasyonDbContext())
            {
                return dbContext.Categories.ToList();
            }
        }

        public Category GetById(int id)
        {
            using (OtomasyonDbContext dbContext = new OtomasyonDbContext())
            {
                return dbContext.Categories.FirstOrDefault(c => c.ID == id);
            }
        }

        public Category GetByName(string name)
        {
            using (OtomasyonDbContext dbContext = new OtomasyonDbContext())
            {
                return dbContext.Categories.FirstOrDefault(c => c.Name == name);
            }
        }

        public void Update(Category entity)
        {
            throw new NotImplementedException();
        }
    }
}
