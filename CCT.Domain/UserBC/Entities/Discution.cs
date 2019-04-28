using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCT.Domain.UserBC.Entities
{
    public class Discution
    {
        //TODO: propriedades, Construtor
        public Discution(String description) {
            Description_conquest = description;
        }
       
        public string Name_conquest { get; private set; }
        public string Type_conquest { get; private set; }
    }
}
