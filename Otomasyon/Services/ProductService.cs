using Otomasyon.Context;
using Otomasyon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otomasyon.Services
{
    public class ProductService : IRepositoryService<Product>
    {
        public void Add(Product entity)
        {
            using (OtomasyonDbContext dbContext = new OtomasyonDbContext())
            {
                dbContext.Products.Add(entity);
                dbContext.SaveChanges();
            }
        }

        public void Delete(int Id)
        {
            using (OtomasyonDbContext dbContext = new OtomasyonDbContext())
            {
                var product = dbContext.Products.FirstOrDefault(p => p.ID == Id);
                product.IsActive = false;

                dbContext.SaveChanges();
            }
        }

        public IEnumerable<Product> GetAll()
        {
            using (OtomasyonDbContext dbContext = new OtomasyonDbContext())
            {
                return dbContext.Products.ToList();
            }
        }

        public Product GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Product GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}
