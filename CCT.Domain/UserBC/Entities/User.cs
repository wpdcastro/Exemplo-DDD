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
       
        public User(String first_name, String last_name, String nickname, DateTime birth_date, String email, String password)
        {
            FirstName = first_name;
            LastName = last_name;
            Nickname = nickname;
            Email_user = new Email(email) ;
            Password = password;

            if (string.IsNullOrEmpty(FirstName) || string.IsNullOrEmpty(LastName) || string.IsNullOrEmpty(Nickname) || string.IsNullOrEmpty(email))
            {
                throw new Exception("Nome, sobrenome, email, nickname, password não devem ser nulos ou vazios");
            }

        }

     

        public String FirstName { get; private set; }
        public String LastName { get; private set; }
        public String Nickname { get; private set; }
        public String Password { get; private set; }
        public Email Email_user { get; private set; }
        public List<Conquest> conquest { get; private set; }

        public void updateUser(String email, String password, String nickname, String first_name, String last_name)
        {
            Change_FirstName(first_name);
            Change_Lastname(last_name);
            ChangeEmail(email);
            ChangePassword(password);
            ChangeNickname(nickname);
        }

        private void Change_Lastname(String last_name)
        {
            LastName = last_name;
        }

        private void Change_FirstName(String first_name)
        {
            FirstName = first_name;
        }

        public void AddConquest(String conquest_name, String type_conquest)
        {
            conquest.Add(new Conquest(conquest_name, type_conquest));
        }       

        private void ChangeNickname(String new_nickname)
        {
            Nickname = new_nickname;
        }

        private void ChangePassword(String new_password)
        {
            Password = new_password;
        }
        private void ChangeEmail(string email)
        {
            Email_user = new Email(email);
        }




    }
}
