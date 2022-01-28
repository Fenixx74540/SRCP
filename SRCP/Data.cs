using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRCP
{

    public enum ShiftCode
    {
        Morning,
        Evening,
        Night
    }

    //Do testowania przed podłączeniem BD
    /*public class Data
    {
        public DateTime day { get; set; }
        public ShiftCode shiftCode { get; set; }
        public int hoursWorked { get; set; }
        private string nameAndSurname { get; set; }

        public Data(DateTime day, ShiftCode shiftCode, int hoursWorked, string nameAndSurname)
        {
            this.day = day;
            this.shiftCode = shiftCode;
            this.hoursWorked = hoursWorked;
            this.nameAndSurname = nameAndSurname;
        }

        public Data(Data data)
        {
            this.day = data.day;
            this.shiftCode = data.shiftCode;
            this.hoursWorked = data.hoursWorked;
            this.nameAndSurname = data.nameAndSurname;
        }
    }*/
}
