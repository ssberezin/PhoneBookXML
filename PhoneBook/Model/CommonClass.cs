using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook.Model
{
    [Serializable]
    public class CommonClass
    {       

        public CommonClass() { }

        public CommonClass(Adress adr, Person pers, PhoneNumbers phones, string email)
        {
            Adr = adr;
            Pers = pers;
            Phones = phones;
            Email = email;
        }

        public Adress Adr {get;set;}
        public Person Pers { get; set; }
        public PhoneNumbers Phones { get; set; }
        public string Email { get; set; }
                
        public object Clone()
        {
            return new CommonClass { Adr = (Adress)Adr.Clone(), Pers = (Person)Pers.Clone(), Phones = (PhoneNumbers)Phones.Clone(), Email = Email };
        }

        public static bool operator ==(CommonClass obj1, CommonClass obj2)
        {
            if ((obj1.Pers == obj2.Pers) && (obj1.Adr == obj2.Adr) && (obj1.Phones == obj2.Phones) && (obj1.Email == obj2.Email))
                return true;
            return false;
        }

        public static bool operator !=(CommonClass obj1, CommonClass obj2)
        {
            if ((obj1.Pers != obj2.Pers) || (obj1.Adr != obj2.Adr) || (obj1.Phones != obj2.Phones) || (obj1.Email != obj2.Email))
                return true;
            return false;
        }
    }
}
