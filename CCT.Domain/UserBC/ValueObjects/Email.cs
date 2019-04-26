using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flunt.Validations;

namespace CCT.Domain.User.ValueObjects
{
    public class Email 
    {
        public Email(string mailAddress)
        {
            MailAddress = mailAddress;

            if (String.IsNullOrEmpty(mailAddress))
                AddNotification("mailAddress", "endereço do e-mail vazio");

        }

        private void AddNotification(string v1, string v2)
        {
            throw new NotImplementedException();
        }

        public string MailAddress { get; set; }

        internal static string validate()
        {
            Email();
        }
    }
}
