using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCT.Domain.UserBC.Entities
{
    public class Comentary
    {
        //TODO: propriedades, Construtor
        public Comentary(String comentary, User user, Date data, Topic topic) {
            Description_conquest = description;
        }
       
        public string Name_conquest { get; private set; }
        public string Type_conquest { get; private set; }
    }
}
