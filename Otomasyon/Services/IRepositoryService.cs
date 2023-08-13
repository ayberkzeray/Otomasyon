using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otomasyon.Services
{
    public interface IRepositoryService<T> 
    { 
        T GetById(int id); 
        T GetByName (string name);
        IEnumerable<T> GetAll(); 
        void Add(T entity); 
        void Update(T entity); 
        void Delete(int Id); 
    }
}
