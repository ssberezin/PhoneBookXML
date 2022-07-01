using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook.Model
{
   public class PhoneNumbers
    {      
        public PhoneNumbers() { }

        public PhoneNumbers(string mPhoneNum, string hPhoneNum)
        {
            MPhoneNum = mPhoneNum;
            HPhoneNum = hPhoneNum;
        }

        public string MPhoneNum { get; set; }
        public string HPhoneNum { get; set; }

        public override string ToString()
        {
            if (MPhoneNum == null || HPhoneNum == null ||
                MPhoneNum == "" || HPhoneNum == "")
                return null;
            return MPhoneNum + " моб.\n" + HPhoneNum+" дом."; 
        }

        public object Clone()
        {
            return new PhoneNumbers { MPhoneNum = MPhoneNum, HPhoneNum = HPhoneNum};
        }

        public static bool operator ==(PhoneNumbers obj1, PhoneNumbers obj2)
        {
            if ((obj1.MPhoneNum == obj2.MPhoneNum) && (obj1.HPhoneNum == obj2.HPhoneNum))
                return true;
            return false;
        }

        public static bool operator !=(PhoneNumbers obj1, PhoneNumbers obj2)
        {
            if ((obj1.MPhoneNum != obj2.MPhoneNum) || (obj1.HPhoneNum != obj2.HPhoneNum))
                return true;
            return false;
        }
    }
}
