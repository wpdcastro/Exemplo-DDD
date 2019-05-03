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
                AddNotification(mailAddress, "endereço do e-mail vazio");

        }

        private void AddNotification(String v1, String v2)
        {
            new Contract()
                    .Requires()
                .IsTrue(Validate(), v1, v2);
        }
        private bool Validate()
        {
            if (!String.IsNullOrEmpty(MailAddress))
                return true;

            return false;

        }
        public string MailAddress { get; set; }

        
    }
}
