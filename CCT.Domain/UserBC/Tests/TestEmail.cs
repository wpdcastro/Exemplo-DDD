using CCT.Domain.User.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCT.Domain.UserBC.Tests
{
    public class TestEmail
    {
        public void CriarEmail ()
        {
            var email = new Email("teste@gmail.com"); 
        }
    }
}
