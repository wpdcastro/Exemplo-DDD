using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCT.Domain.UserBC.Entities
{
    public class Conquest
    {
        //TODO: propriedades, Construtor
        public Conquest(User user, String name_conquest, String type_conquest) {
            Name_conquest = name_conquest;
            Type_conquest = type_conquest;
            user.conquest = Conquest;
        }
       
        public string Name_conquest { get; private set; }
        public string Type_conquest { get; private set; }
    }
}
