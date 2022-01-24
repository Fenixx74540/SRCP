using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SRCP
{
    public partial class Form1 : Form
    {
        DataService dataService = new DataService();

        int monthlyHoursNorm = 160;

        DateTime showedWeek;
        List<Label> labelsOfTheWeek = new List<Label>();
        List<TextBox> textBoxes = new List<TextBox>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Populate shiftCodeComboBox and set default option because it cant be null
            foreach (var item in Enum.GetValues(typeof(ShiftCode)))
            {
                shiftCodeComboBox.Items.Add(item);
            }
            shiftCodeComboBox.SelectedIndex = 0;
            //Populate list of labels
            labelsOfTheWeek.Add(labelNameDay0);
            labelsOfTheWeek.Add(labelNameDay1);
            labelsOfTheWeek.Add(labelNameDay2);
            labelsOfTheWeek.Add(labelNameDay3);
            labelsOfTheWeek.Add(labelNameDay4);
            labelsOfTheWeek.Add(labelNameDay5);
            labelsOfTheWeek.Add(labelNameDay6);
            //Populate list of textBoxes
            textBoxes.Add(textBox0);
            textBoxes.Add(textBox1);
            textBoxes.Add(textBox2);
            textBoxes.Add(textBox3);
            textBoxes.Add(textBox4);
            textBoxes.Add(textBox5);
            textBoxes.Add(textBox6);
            //show current week in window
            showedWeek = DateTime.Now.Date;
            while (showedWeek.DayOfWeek != DayOfWeek.Monday)
            {
                showedWeek = showedWeek.AddDays(-1);
            }
            setEdgeDates(showedWeek);
            setDayLabels(showedWeek);
            setTextFields((ShiftCode)Enum.Parse(typeof(ShiftCode), shiftCodeComboBox.SelectedItem.ToString()));
            setCurrentHours(showedWeek);
        }

        private void weekBack_Click(object sender, EventArgs e)
        {
            showedWeek = showedWeek.AddDays(-7);
            setEdgeDates(showedWeek);
            setTextFields((ShiftCode)Enum.Parse(typeof(ShiftCode), shiftCodeComboBox.SelectedItem.ToString()));
        }

        private void weekForward_Click(object sender, EventArgs e)
        {
            showedWeek = showedWeek.AddDays(7);
            setEdgeDates(showedWeek);
            setTextFields((ShiftCode)Enum.Parse(typeof(ShiftCode), shiftCodeComboBox.SelectedItem.ToString()));
        }

        private void setEdgeDates(DateTime week)
        {
            DateTime edgeDate = week.Date;
            weekFrom.Text = edgeDate.ToString("d");
            weekTo.Text = edgeDate.AddDays(6).ToString("d");
        }

        private void setDayLabels(DateTime week)
        {
            DateTime day = week.Date;
            int index = 0;
            do
            {
                labelsOfTheWeek[index++].Text = day.ToString("M");
                day = day.AddDays(1);
            } while (day.DayOfWeek != DayOfWeek.Sunday);
            labelsOfTheWeek[index].Text = day.ToString("M");
        }

        private void setTextFields(ShiftCode shiftCode)
        {
            DateTime day = showedWeek.Date;
            foreach (TextBox tb in textBoxes)
            {
                try
                {
                    tb.Text = dataService.getDataByDay(day, shiftCode).hoursWorked.ToString();
                }
                catch (NullReferenceException e)
                {
                    tb.Text = "0";
                }
                finally
                {
                    day = day.AddDays(1);
                }
            }
        }

        private void shiftCodeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            String selectedString = shiftCodeComboBox.SelectedItem.ToString();
            ShiftCode shiftCode = (ShiftCode)Enum.Parse(typeof(ShiftCode), selectedString);
            switch (shiftCodeComboBox.SelectedIndex)
            {
                case 0:
                    setTextFields(shiftCode);
                    break;
                case 1:
                    setTextFields(shiftCode);
                    break;
                case 2:
                    setTextFields(shiftCode);
                    break;
            }

        }

        private void setCurrentHours(DateTime week)
        {
            //miesi�c do wy�wietlenia okre�lony jest za pomoc� wi�kszo�ci dni w wyswietlanym tygodniu
            //wystarczy sprawdzi� �rodek tygodnia, aby wiedzie� kt�rego miesi�ca dni jest wi�cej w tygodniu
            DateTime pom = week.AddDays(4);
            int month = pom.Month;

            //wszystkie przepracowane godziny w stawce standardowej
            List<Data> dayHours = dataService.getDataByMonth(month);
            dayHours.RemoveAll(x => x.shiftCode == ShiftCode.Night);
            foreach (Data data in dayHours)
            {
                if (data.hoursWorked > 8)
                {
                    data.hoursWorked = 8;
                }
            }
            int sum = dayHours.Sum(x => x.hoursWorked);
            currentHours.Text = sum.ToString();

            //ilo�� godzin do przepracowania
            monthlyHours.Text = (monthlyHoursNorm - sum).ToString();

            //nadgodziny
            List<Data> overtimeHours = dataService.getDataByMonth(month);
            overtimeHours.RemoveAll(x => x.shiftCode == ShiftCode.Night);
            foreach (Data data in overtimeHours)
            {
                data.hoursWorked -= 8;
                if (data.hoursWorked < 0) data.hoursWorked = 0;
            }
            sum = overtimeHours.Sum(x => x.hoursWorked);
            overtime.Text = sum.ToString();

            //Nocki
            List<Data> nightHours = dataService.getDataByMonth(month);
            nightHours.RemoveAll(x => x.shiftCode != ShiftCode.Night);
            sum = nightHours.Sum(x => x.hoursWorked);
            nightShift.Text = sum.ToString();
        }

        

        //WIP
        /* private void button1_Click(object sender, EventArgs e)
         {
             //miesi�c do wy�wietlenia okre�lony jest za pomoc� wi�kszo�ci dni w wyswietlanym tygodniu
             //wystarczy sprawdzi� �rodek tygodnia, aby wiedzie� kt�rego miesi�ca dni jest wi�cej w tygodniu
             DateTime pom = week.AddDays(4);
             int month = pom.Month;

             //wszystkie przepracowane godziny w stawce standardowej
             List<Data> dayHours = dataService.getDataByMonth(month);
             dayHours.RemoveAll(x => x.shiftCode == ShiftCode.Night);
             foreach (Data data in dayHours)
             {
                 if (data.hoursWorked > 8)
                 {
                     data.hoursWorked = 8;
                 }
             }
             int sum = dayHours.Sum(x => x.hoursWorked);
             currentHours.Text = sum.ToString();

             //ilo�� godzin do przepracowania
             monthlyHours.Text = (monthlyHoursNorm - sum).ToString();

             //nadgodziny
             List<Data> overtimeHours = dataService.getDataByMonth(month);
             overtimeHours.RemoveAll(x => x.shiftCode == ShiftCode.Night);
             foreach (Data data in overtimeHours)
             {
                 data.hoursWorked -= 8;
                 if (data.hoursWorked < 0) data.hoursWorked = 0;
             }
             sum = overtimeHours.Sum(x => x.hoursWorked);
             overtime.Text = sum.ToString();

             //Nocki
             List<Data> nightHours = dataService.getDataByMonth(month);
             nightHours.RemoveAll(x => x.shiftCode != ShiftCode.Night);
             sum = nightHours.Sum(x => x.hoursWorked);
             nightShift.Text = sum.ToString();
         }*/
    }
}