using System;
using System.Collections.Generic;
using CCT.Domain.UserBC.Entities;
using CCT.Domain.UserBC.Repositories;


namespace CCT.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var fakeuser = new FakeUserRepository();
            var fakeperfil = new FakePerfilRepository();
            var fakeConquest = new FakeConquestRepository();

        }
    }
    public class FakeConquestRepository : IConquestRepository
    {
        IList<Conquest> IConquestRepository.GetConquestByUserId(int user_id)
        {
            var usuario = new CCT.Domain.UserBC.Entities.User("Jhon",
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

            return usuario.conquest;
        }


    }
    public class FakeUserRepository : IUserRepository
    {
       
        User IUserRepository.GetById(Guid id)
        {
            var usuario = new CCT.Domain.UserBC.Entities.User("Jhon",
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

            return usuario;
        }

        public void save(User user)
        {
            throw new NotImplementedException();
        }

        IEnumerable<User> IUserRepository.GetUsers()
        {
            throw new NotImplementedException();
        }
    }
}
public class FakePerfilRepository : IPerfilRepository
{
    public Perfil GetById(Guid id)
    {
        var usertest = new CCT.Domain.UserBC.Entities.User("Jhon",
                                    "Cena",
                                    "Jhon Cena",
                                    DateTime.Today,
                                    "hisnameis@jhoncena.com.br",
                                    "153154");
        usertest.AddConquest("Conquista Mortal", "Gold");
        var NovoPerfil = new Perfil(usertest);
        NovoPerfil.AddConquest(NovoPerfil.Userp, "Conquista Mortal", NovoPerfil.VisibleConquest);
        return NovoPerfil;
    }

    public IEnumerable<Perfil> GetPefis()
    {
        throw new NotImplementedException();
    }

    public void Save()
    {
        throw new NotImplementedException();
    }
}


