using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CCT.Domain.UserBC.Entities;

namespace CCT.Domain.UserBC.Repositories
{
    public interface IUserRepository
    {
        UserBC.Entities.User GetById(Guid id);
        void save(UserBC.Entities.User user);
        IEnumerable<UserBC.Entities.User> GetUsers();
    }
}
