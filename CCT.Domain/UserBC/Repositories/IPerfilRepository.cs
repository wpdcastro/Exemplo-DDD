using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CCT.Domain.UserBC.Entities;

namespace CCT.Domain.UserBC.Repositories
{
     public interface IPerfilRepository
    {
        Perfil GetById(Guid id);
        void Save();

        IEnumerable<Perfil> GetPefis();
    }
}
