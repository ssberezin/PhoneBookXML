using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook.Model
{
    public class Adress
    {
        public Adress(){}
              
        public Adress(string street, string houseNumber, int? appNumber)
        {
            Street = street;
            HouseNumber = houseNumber;
            AppNumber = appNumber;
        }

        public string Street { get; set; }
        public string HouseNumber { get; set; }
        public int? AppNumber { get; set; }


        public override string ToString()
        {
            if (Street == null || HouseNumber == null || AppNumber <= 0 ||
                Street == "" || HouseNumber == "" )

                return null;
            return "ул. " + Street + ", д." + HouseNumber + ", кв. " + AppNumber;
        }

        public object Clone()
        {
            return new Adress { Street = Street, HouseNumber = HouseNumber, AppNumber = AppNumber };
        }

        public static bool operator ==(Adress obj1, Adress obj2)
        {
            if ((obj1.Street == obj2.Street) && (obj1.HouseNumber == obj2.HouseNumber) && (obj1.AppNumber == obj2.AppNumber))
                return true;
            return false;
        }

        public static bool operator !=(Adress obj1, Adress obj2)
        {
            if ((obj1.Street != obj2.Street) || (obj1.HouseNumber != obj2.HouseNumber) || (obj1.AppNumber != obj2.AppNumber))
                return true;
            return false;
        }

    }
}
