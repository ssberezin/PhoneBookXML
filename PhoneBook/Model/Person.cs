using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook.Model
{
    public class Person
    {
        public Person() { }

        public Person(string firstName, string lastName, string patronimic, int birthYear, bool sex)
        {
            FirstName = firstName;
            LastName = lastName;
            Patronimic = patronimic;
            BirthYear = birthYear;
            Sex = sex;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Patronimic { get; set; }
        public int BirthYear { get; set; }
        public bool Sex{ get; set; }


        public override string ToString()
        {
            string sex = Sex ? "муж" : "жен";
            if (LastName == null || FirstName == null || Patronimic == null ||
                LastName == "" || FirstName == "" || Patronimic == "")
                return null;
            return LastName + " " + FirstName + " " + Patronimic + ". Пол: " + sex + ". Год рождения: "+BirthYear;
        }

        public object  Clone()
        {
            return new Person { FirstName = FirstName, LastName = LastName, Patronimic = Patronimic, Sex = Sex, BirthYear = BirthYear };
        }

        public static bool operator ==(Person obj1, Person obj2)
        {
            if ((obj1.FirstName == obj2.FirstName) && (obj1.LastName == obj2.LastName) && (obj1.Patronimic == obj2.Patronimic)&&
                (obj1.BirthYear==obj2.BirthYear)&&(obj1.Sex==obj2.Sex))
                return true;
            return false;
        }
                
        public static bool operator !=(Person obj1, Person obj2)
        {
            if ((obj1.FirstName != obj2.FirstName) || (obj1.LastName != obj2.LastName) || (obj1.Patronimic != obj2.Patronimic) ||
                (obj1.BirthYear != obj2.BirthYear) || (obj1.Sex != obj2.Sex))
                return true;
            return false;
        }
    }
}
