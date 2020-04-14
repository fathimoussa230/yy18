using System.Collections.Generic;
using System.Threading.Tasks;
using yyapp.api.Models;

namespace yyapp.api.Data
{
    public interface IYyappRepository
    {
         void Add <T>(T entity) where T:class;

         void Delete <T>(T entity) where T:class;
         Task<bool> SaveAll();
         Task<IEnumerable<User>> GetUsers();
         Task<User> GetUser(int id);
         
         


    }
}