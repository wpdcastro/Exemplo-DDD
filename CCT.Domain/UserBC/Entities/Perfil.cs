using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCT.Domain.UserBC.Entities
{
    public class Perfil
    {
        public Perfil (User user)
        {
            User = user;
        }
        public User User { get; set; }
        public List<Conquest> VisibleConquest { get; private set; }

        //conquistas
        public void AddConquest(User User, String name_conquest, List<Conquest> VisibleConquest)
        {
            foreach (var el in User.conquest)
            {
                if (el.Name_conquest == name_conquest)
                {
                    VisibleConquest.Add(el);
                }
            }
        }
        public void Erase_Conquest(List<Conquest> VisibleConquest, String name_conquest)
        {
            foreach (var el in VisibleConquest){
                if (el.Name_conquest == name_conquest){
                    VisibleConquest.Remove(el);
                }

            }
        }
    }
}
