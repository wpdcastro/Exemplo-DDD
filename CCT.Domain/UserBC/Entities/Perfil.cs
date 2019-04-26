using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCT.Domain.UserBC.Entities
{
    public class Perfil
    {
        public Perfil (User user, Conquest conquest)
        {

        }
        public User User { get; set; }
        public Conquest Conquest { get; set; }
        //conquistas
        public void addConquest(Conquest conquest) {
            list_conquest = conquest.get_conquest()
        }
    }
}
