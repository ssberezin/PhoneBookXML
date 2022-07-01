using PhoneBook.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace PhoneBook.Helps
{
  public    class Library
    {
        //==================================XML operations ==================================================
        public void FillDataToXML(BindingList<CommonClass> lst)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(BindingList<CommonClass>));
            using (FileStream fs = new FileStream("DB.xml", FileMode.Create))
            {
                formatter.Serialize(fs, lst);
            }
        }

        //===================================Validation operations ===========================================

        private static readonly Regex someReg = new Regex(@"\D"); //regex that matches disallowed text
        public string PhoneNumValidation(string phone)
        {
            phone = someReg.Replace(phone, "");
            if (phone.Length > 13)
                phone = phone.Remove(phone.Length - 1, 1);
            return phone == "" ? "" : "+" + phone;
        }

        

        //input data validation from controls of PersonalDataEditForm and  PhonesDataEdittingForm
        public bool CheckValidationAdressData(string street, string houseNum)
        {
            if (street == "" || houseNum == "" )
            {
                MessageBox.Show("Все поля должны быть заполненными.");
                return false;
            }
            return true;
        }

        //input data validation from controls of PersonalDataEditForm
        public bool CheckValidationPersonalData(string firstName, string lastName, string patronimic)
        {
            if (firstName == "" || lastName == "" || patronimic == "")
            {
                MessageBox.Show("Все поля должны быть заполненными.");
                return false;
            }
            return true;
        }

        //collecting existing text data from controls on PhonesDataEdittingForm
        public void CopyNewdataToPhonesRecord(CommonClass rec, string mPh, string hPh)
        {
            rec.Phones.MPhoneNum = mPh;
            rec.Phones.HPhoneNum = hPh;            
        }

        //collecting existing text data from controls on AdressDataEdittingForm
        public void CopyNewdataToAdressRecord(CommonClass rec, string street, string housNum, int? appNum)
        {
            rec.Adr.Street = street;
            rec.Adr.HouseNumber = housNum;
            rec.Adr.AppNumber = appNum;            
        }

        //collecting existing text data from controls on PersonalDataEditForm
        public void CopyNewdataToRecord(CommonClass rec, string firstName, string lastName, string patronimic, int inpYear, bool sex)
        {            
            rec.Pers.FirstName = firstName;
            rec.Pers.LastName = lastName;
            rec.Pers.Patronimic = patronimic;
            rec.Pers.BirthYear = inpYear;
            rec.Pers.Sex = sex;
        }
        public Adress GetRndAdress(Random rnd)
        {
            string[] StreetName = new string[] { "Ивановская", "Петровская", "Пушкина", "Городская", "Полозова", "Гоголя", "Зинченка", "Киевская", "Львовская",
                                                  "Мичурина", "Победы","Освободителей","Героев войны"};

            Adress adr = new Adress();

            adr.Street = StreetName[rnd.Next(StreetName.Length)];
            adr.HouseNumber = rnd.Next(0, 100).ToString();
            adr.AppNumber = rnd.Next(0, 100);
            return adr;
        }

        public PhoneNumbers GetRndPhoneNumbers(Random rnd, BindingList<CommonClass> records)
        {
            bool ready=false;
            string phone1=null, phone2=null;
            do
            {
                phone1 = GetPhoneNumber(rnd, records);
                phone2 = GetPhoneNumber(rnd, records);
                if(phone1==phone2)
                    ready=true;
            } while (ready);

            return   new PhoneNumbers { HPhoneNum = phone2, MPhoneNum = phone1 };
        }

        public string GetPhoneNumber(Random rnd, BindingList<CommonClass> records)
        {
            bool ready = true;
            string phone = null;
            do
            {
                phone = "+38097" + rnd.Next(1000000,10000000).ToString();
                CommonClass tmp = records.Where(r => r.Phones.MPhoneNum == phone || r.Phones.HPhoneNum == phone).FirstOrDefault();
                if (tmp == null)
                    return phone;                         
                
            } while (!ready);

            return phone;
        }


        public string GetEmail(Random rnd, BindingList<CommonClass> records)
        {
            bool ready = true;
            string email = null;
            do
            {
                email = GetrandomEmail(rnd);
                CommonClass tmp = records.Where(r => r.Email == email ).FirstOrDefault();
                if (tmp == null)
                    return email;

            } while (!ready);

            return email;

        }

        public string GetrandomEmail(Random rnd)
        {
            string[] EmailNames = new string[] { "ouuu77", "olo4747", "sirius99", "6525ololo", "pork", "loli" };
            string[] EmailSecNames = new string[] { "@gmail", "@i", "@yandex", "@lo", "@pro", "@dp", "@ok", "@plo", "@kilo" };
            string[] EmailThirdNames = new string[] { ".com", ".ua", ".pl", ".uk", ".br", ".pp" };
            return EmailNames[rnd.Next(EmailNames.Length)] + EmailSecNames[rnd.Next(EmailSecNames.Length)] + EmailThirdNames[rnd.Next(EmailThirdNames.Length)];
        }

        public Person GetRndPerson(bool sex, Random rnd)
        {
            string[] MaleNames = new string[] { "Иван", "Петр", "Евгений", "Игорь", "Андрей", "Илья" };
            string[] FemaleNames = new string[] { "Иванна", "Оксана", "Евгения", "Ирина", "Анастасия", "Илона" };
            string[] MalePatronimic = new string[] { "Григорьевич", "Русланович", "Александрович", "Адреевич", "Рамзанович", "Романович" };
            string[] FemalePatronimic = new string[] { "Ивановна", "Петровна", "Евгениевна", "Игоревна", "Андреевна", "Николавевна" };
            string[] MaleSurnames = new string[] { "Гргорян", "Жеваго", "Румбов", "Пронин", "Кривов", "Дмитриев", "Адаменко", "Гирик", "Виноградов", "Зорин" };
            string[] FemaleSurnames = new string[] { "Иванова", "Петрова", "Сидорчук", "Капустина", "Шавлий", "Кириенко", "Рогозина", "Злива", "Лопухова", "Тройкина" };
            Person pers = new Person();
         


            if (sex == true) //male person
            {
                pers.FirstName = MaleNames[rnd.Next(MaleNames.Length)];
                pers.LastName = MaleSurnames[rnd.Next(MaleSurnames.Length)];
                pers.Patronimic = MalePatronimic[rnd.Next(MalePatronimic.Length)];
                pers.Sex = true;
            }
            else
            {
                pers.FirstName = FemaleNames[rnd.Next(FemaleNames.Length)];
                pers.LastName = FemaleSurnames[rnd.Next(FemaleSurnames.Length)];
                pers.Patronimic = FemalePatronimic[rnd.Next(FemalePatronimic.Length)];
                pers.Sex = false;
            }
            pers.BirthYear = rnd.Next(1955, 2010);

            return pers;
        }

        public void CopyValues(CommonClass OriginalObj, CommonClass PrevObj)
        {
            OriginalObj.Pers.FirstName = PrevObj.Pers.FirstName;
            OriginalObj.Pers.LastName = PrevObj.Pers.LastName;
            OriginalObj.Pers.Patronimic = PrevObj.Pers.Patronimic;
            OriginalObj.Pers.BirthYear = PrevObj.Pers.BirthYear;
            OriginalObj.Pers.Sex = PrevObj.Pers.Sex;

            OriginalObj.Adr.Street = PrevObj.Adr.Street;
            OriginalObj.Adr.HouseNumber = PrevObj.Adr.HouseNumber;
            OriginalObj.Adr.AppNumber = PrevObj.Adr.AppNumber;

            OriginalObj.Phones.MPhoneNum = PrevObj.Phones.MPhoneNum;
            OriginalObj.Phones.HPhoneNum = PrevObj.Phones.HPhoneNum;            
        }

    }
}
