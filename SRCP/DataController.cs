using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SRCP
{
    internal class DataController
    {


        public List<Data> findAll()
        {
            List<Data> list = new List<Data>();
            DateTime now = DateTime.Now;
            list.Add(new Data(now, ShiftCode.Morning, 9, "SzymonKorpusinski"));
            list.Add(new Data(now, ShiftCode.Night, 7, "SzymonKorpusinski"));
            return list;
            //SELECT * FROM Shifts
        }

        public List<Data> findByDate(DateTime date)
        {
            List<Data> list = new List<Data>();
            DateTime now = DateTime.Now;
            list.Add(new Data(now, ShiftCode.Morning, 1, "SzymonKorpusinski"));
            list.Add(new Data(now, ShiftCode.Evening, 11, "SzymonKorpusinski"));
            list.Add(new Data(now, ShiftCode.Night, 111, "SzymonKorpusinski"));
            now = now.AddDays(-1);
            list.Add(new Data(now, ShiftCode.Morning, 2, "SzymonKorpusinski"));
            list.Add(new Data(now, ShiftCode.Evening, 22, "SzymonKorpusinski"));
            list.Add(new Data(now, ShiftCode.Night, 222, "SzymonKorpusinski"));
            now = now.AddDays(-1);
            list.Add(new Data(now, ShiftCode.Morning, 3, "SzymonKorpusinski"));
            list.Add(new Data(now, ShiftCode.Evening, 33, "SzymonKorpusinski"));
            list.Add(new Data(now, ShiftCode.Night, 333, "SzymonKorpusinski"));
            now = now.AddDays(-1);
            list.Add(new Data(now, ShiftCode.Morning, 4, "SzymonKorpusinski"));
            list.Add(new Data(now, ShiftCode.Evening, 44, "SzymonKorpusinski"));
            list.Add(new Data(now, ShiftCode.Night, 444, "SzymonKorpusinski"));
            now = now.AddDays(-1);
            list.Add(new Data(now, ShiftCode.Morning, 5, "SzymonKorpusinski"));
            list.Add(new Data(now, ShiftCode.Evening, 55, "SzymonKorpusinski"));
            list.Add(new Data(now, ShiftCode.Night, 555, "SzymonKorpusinski"));
            now = now.AddDays(-1);
            list.Add(new Data(now, ShiftCode.Morning, 6, "SzymonKorpusinski"));
            list.Add(new Data(now, ShiftCode.Evening, 66, "SzymonKorpusinski"));
            list.Add(new Data(now, ShiftCode.Night, 666, "SzymonKorpusinski"));
            now = now.AddDays(-1);
            list.Add(new Data(now, ShiftCode.Morning, 7, "SzymonKorpusinski"));
            list.Add(new Data(now, ShiftCode.Evening, 77, "SzymonKorpusinski"));
            list.Add(new Data(now, ShiftCode.Night, 777, "SzymonKorpusinski"));
            now = now.AddDays(-1);
            list.Add(new Data(now, ShiftCode.Morning, 8, "SzymonKorpusinski"));
            list.Add(new Data(now, ShiftCode.Evening, 88, "SzymonKorpusinski"));
            list.Add(new Data(now, ShiftCode.Night, 888, "SzymonKorpusinski"));
            now = now.AddDays(-1);
            list.Add(new Data(now, ShiftCode.Morning, 9, "SzymonKorpusinski"));
            list.Add(new Data(now, ShiftCode.Evening, 99, "SzymonKorpusinski"));
            list.Add(new Data(now, ShiftCode.Night, 999, "SzymonKorpusinski"));
            now = now.AddDays(-1);
            list.Add(new Data(now, ShiftCode.Morning, 10, "SzymonKorpusinski"));
            list.Add(new Data(now, ShiftCode.Evening, 1010, "SzymonKorpusinski"));
            list.Add(new Data(now, ShiftCode.Night, 101010, "SzymonKorpusinski"));
            now = now.AddDays(-1);
            list.Add(new Data(now, ShiftCode.Morning, 11, "SzymonKorpusinski"));
            list.Add(new Data(now, ShiftCode.Evening, 1111, "SzymonKorpusinski"));
            list.Add(new Data(now, ShiftCode.Night, 111111, "SzymonKorpusinski"));
            now = now.AddDays(-1);
            list.Add(new Data(now, ShiftCode.Morning, 12, "SzymonKorpusinski"));
            list.Add(new Data(now, ShiftCode.Evening, 1212, "SzymonKorpusinski"));
            list.Add(new Data(now, ShiftCode.Night, 121212, "SzymonKorpusinski"));
            now = now.AddDays(-1);
            list.Add(new Data(now, ShiftCode.Morning, 13, "SzymonKorpusinski"));
            list.Add(new Data(now, ShiftCode.Evening, 1313, "SzymonKorpusinski"));
            list.Add(new Data(now, ShiftCode.Night, 131313, "SzymonKorpusinski"));
            now = now.AddDays(-1);
            list.Add(new Data(now, ShiftCode.Morning, 14, "SzymonKorpusinski"));
            list.Add(new Data(now, ShiftCode.Evening, 1414, "SzymonKorpusinski"));
            list.Add(new Data(now, ShiftCode.Night, 141414, "SzymonKorpusinski"));
            list.RemoveAll(x => x.day.Date != date.Date);
            //wszystko wyżej zastąpić jednym dobrze napsianym SQL
            //SELECT* FROM Shifts WHERE WeekNo = 2
            return list;
        }

        public List<Data> findDataByMonth(int month)
        {
            List<Data> list = new List<Data>();
            DateTime now = DateTime.Now;
            list.Add(new Data(now, ShiftCode.Morning, 1, "SzymonKorpusinski"));
            list.Add(new Data(now, ShiftCode.Evening, 11, "SzymonKorpusinski"));
            list.Add(new Data(now, ShiftCode.Night, 111, "SzymonKorpusinski"));
            now = now.AddDays(-1);
            list.Add(new Data(now, ShiftCode.Morning, 2, "SzymonKorpusinski"));
            list.Add(new Data(now, ShiftCode.Evening, 22, "SzymonKorpusinski"));
            list.Add(new Data(now, ShiftCode.Night, 222, "SzymonKorpusinski"));
            now = now.AddDays(-1);
            list.Add(new Data(now, ShiftCode.Morning, 3, "SzymonKorpusinski"));
            list.Add(new Data(now, ShiftCode.Evening, 33, "SzymonKorpusinski"));
            list.Add(new Data(now, ShiftCode.Night, 333, "SzymonKorpusinski"));
            now = now.AddDays(-1);
            list.Add(new Data(now, ShiftCode.Morning, 4, "SzymonKorpusinski"));
            list.Add(new Data(now, ShiftCode.Evening, 44, "SzymonKorpusinski"));
            list.Add(new Data(now, ShiftCode.Night, 444, "SzymonKorpusinski"));
            now = now.AddDays(-1);
            list.Add(new Data(now, ShiftCode.Morning, 5, "SzymonKorpusinski"));
            list.Add(new Data(now, ShiftCode.Evening, 55, "SzymonKorpusinski"));
            list.Add(new Data(now, ShiftCode.Night, 555, "SzymonKorpusinski"));
            now = now.AddDays(-1);
            list.Add(new Data(now, ShiftCode.Morning, 6, "SzymonKorpusinski"));
            list.Add(new Data(now, ShiftCode.Evening, 66, "SzymonKorpusinski"));
            list.Add(new Data(now, ShiftCode.Night, 666, "SzymonKorpusinski"));
            now = now.AddDays(-1);
            list.Add(new Data(now, ShiftCode.Morning, 7, "SzymonKorpusinski"));
            list.Add(new Data(now, ShiftCode.Evening, 77, "SzymonKorpusinski"));
            list.Add(new Data(now, ShiftCode.Night, 777, "SzymonKorpusinski"));
            now = now.AddDays(-1);
            list.Add(new Data(now, ShiftCode.Morning, 8, "SzymonKorpusinski"));
            list.Add(new Data(now, ShiftCode.Evening, 88, "SzymonKorpusinski"));
            list.Add(new Data(now, ShiftCode.Night, 888, "SzymonKorpusinski"));
            now = now.AddDays(-1);
            list.Add(new Data(now, ShiftCode.Morning, 9, "SzymonKorpusinski"));
            list.Add(new Data(now, ShiftCode.Evening, 99, "SzymonKorpusinski"));
            list.Add(new Data(now, ShiftCode.Night, 999, "SzymonKorpusinski"));
            now = now.AddDays(-1);
            list.Add(new Data(now, ShiftCode.Morning, 10, "SzymonKorpusinski"));
            list.Add(new Data(now, ShiftCode.Evening, 1010, "SzymonKorpusinski"));
            list.Add(new Data(now, ShiftCode.Night, 101010, "SzymonKorpusinski"));
            now = now.AddDays(-1);
            list.Add(new Data(now, ShiftCode.Morning, 11, "SzymonKorpusinski"));
            list.Add(new Data(now, ShiftCode.Evening, 1111, "SzymonKorpusinski"));
            list.Add(new Data(now, ShiftCode.Night, 111111, "SzymonKorpusinski"));
            now = now.AddDays(-1);
            list.Add(new Data(now, ShiftCode.Morning, 12, "SzymonKorpusinski"));
            list.Add(new Data(now, ShiftCode.Evening, 1212, "SzymonKorpusinski"));
            list.Add(new Data(now, ShiftCode.Night, 121212, "SzymonKorpusinski"));
            now = now.AddDays(-1);
            list.Add(new Data(now, ShiftCode.Morning, 13, "SzymonKorpusinski"));
            list.Add(new Data(now, ShiftCode.Evening, 1313, "SzymonKorpusinski"));
            list.Add(new Data(now, ShiftCode.Night, 131313, "SzymonKorpusinski"));
            now = now.AddDays(-1);
            list.Add(new Data(now, ShiftCode.Morning, 14, "SzymonKorpusinski"));
            list.Add(new Data(now, ShiftCode.Evening, 1414, "SzymonKorpusinski"));
            list.Add(new Data(now, ShiftCode.Night, 141414, "SzymonKorpusinski"));
            list.RemoveAll(x => x.day.Month != month);
            //wszystko wyżej zastąpić jednym dobrze napsianym SQL (jesli się da, :D)
            return list;
        }

        public void saveToDatabase(Data data)
        {

        }

        public void saveToDatabase(List<Data> dataList)
        {

        }
    }
}

