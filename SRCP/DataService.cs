using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRCP
{
    internal class DataService
    {
        private DataController dataController = new DataController();
        public Data getDataByDay(DateTime day, ShiftCode shiftCode)
        {
            List<Data> list = dataController.findByDate(day);
            list.RemoveAll(x => x.shiftCode != shiftCode);
            if (list.Any())
            {
                return list[0];
            }
            return null;
        }

        public List<Data> getDataByMonth(int month)
        {
            return dataController.findDataByMonth(month);
        }

        public void insertToDatabase(Data data)
        {
            dataController.saveToDatabase(data);
        }

        public void insertToDatabase(List<Data> dataList)
        {
            dataController.saveToDatabase(dataList);
        }
    }
}
