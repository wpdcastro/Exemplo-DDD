using CCT.Domain.User.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCT.Domain.UserBC.Entities
{
    public class User
    {

        public User(string first_name, string last_name, string nickname, DateTime birth_date, string email, string password)
        {
            FirstName = first_name;
            LastName = last_name;
            Nickname = nickname;
            Email_user = validate(email) ;
            Password = password;

            if (string.IsNullOrEmpty(FirstName) || string.IsNullOrEmpty(LastName) || string.IsNullOrEmpty(Nickname) || string.IsNullOrEmpty(email))
            {
                throw new Exception("Nome, sobrenome, email, nickname, data de nascimento não devem ser nulos ou vazios");
            }

        }

        private string validate(String email)
        {
           return Email.validate();
        }

        public String Email_user { get; set; }
        public Conquest()
        {


        }
        //TODO: propriedades, Construtor
        //nome, login, email
        public String FirstName { get; private set; }
        public String LastName { get; private set; }
        public String Nickname { get; private set; }
        public String Password { get; private set; }

        public void updateUser(String email, String password, String nickname)
        {
            changeEmail(email);
            changePassword(password);
            changeNickname(nickname);
        }

        private void changeNickname(String new_nickname)
        {
            Nickname = new_nickname;
        }

        private void changePassword(String new_password)
        {
            Password = new_password;
        }
        private void changeEmail(string email)
        {
            Email.update();
        }


       



    }
}
