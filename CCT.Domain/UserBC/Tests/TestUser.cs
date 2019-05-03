using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CCT.Domain.UserBC.Entities;

namespace CCT.Domain.UserBC.Tests
{
    public class TestUser
    {
        public void CriarUser()
        {
            var usuario = new UserBC.Entities.User("Jhon",
                                    "Cena",
                                    "Jhon Cena",
                                    DateTime.Today,
                                    "hisnameis@jhoncena.com.br",
                                    "153154");
            usuario.AddConquest("Cabeleira sedutora", "NAVS");
            usuario.AddConquest("Mestre dos robots", "NAVS");
            usuario.AddConquest("Me da nota navs", "ALUNO PEDINTE");
            usuario.AddConquest("Peroda a zoeira navs", "NAVS BENEVOLENTE");
            usuario.ChangeEmail("feradorobot@certificadomicrosoft.com.br");
            usuario.Change_FirstName("Fabião");
            usuario.Change_Lastname("Navs the amazing");
            usuario.ChangeNickname("The master .NET");
            usuario.ChangePassword("1597563");
        }
    }
}
