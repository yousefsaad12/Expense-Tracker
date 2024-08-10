using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.IRepoInterface
{
    public interface IBaseRepository<T> where T : class 
    {
        Task<T> GetById(int id);
        
    }
}