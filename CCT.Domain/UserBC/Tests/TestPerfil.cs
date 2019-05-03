using CCT.Domain.UserBC.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCT.Domain.UserBC.Tests
{
    public class TestPerfil
    {
        public void PegarUsuario ()
        {
            var usertest = new UserBC.Entities.User("Jhon",
                                    "Cena",
                                    "Jhon Cena",
                                    DateTime.Today,
                                    "hisnameis@jhoncena.com.br",
                                    "153154");
            usertest.AddConquest("Conquista Mortal", "Gold");
            var NovoUsuario = new Perfil(usertest);
            NovaConquest(NovoUsuario);
            ApagarConquest(NovoUsuario);
        }

        public void NovaConquest (Perfil perfil)
        {
           perfil.AddConquest (perfil.Userp,"Conquista Mortal",perfil.VisibleConquest);
        }

        public void ApagarConquest (Perfil perfil)
        {
            perfil.Erase_Conquest(perfil.VisibleConquest, "Conquista Mortal");
        }
    }
}
