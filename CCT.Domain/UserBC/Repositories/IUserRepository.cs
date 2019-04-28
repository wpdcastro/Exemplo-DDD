using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CCT.Domain.UserBC.Entities;

namespace CCT.Domain.UserBC.Repositories
{
    public class IUserRepository
    {
        User getById(Guid id);
        void Save(Customer customer);
        IEnumerable<User> GetUsers(); 
    }
}
