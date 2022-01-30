using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Linq;

namespace SRCP
{
    public partial class Form1 : Form
    {
        DateTime showedWeek;
        List<Label> labelsOfTheWeek = new List<Label>();
        List<TextBox> textBoxes = new List<TextBox>();
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\mateu\Source\Repos\Fenixx74540\SRCP\SRCP\Database.mdf;Integrated Security=True");

        private void button2_Click(object sender, EventArgs e)
        {
            
            SqlCommand sqlCommand = new SqlCommand("INSERT INTO Shifts (WeekNo, Shift, Hours, FullName) VALUES('" +weekNoLabel.Text+ "','" +shiftCodeComboBox.Text+ "','"+totalHours.Text+"','"+nameAndSurnameTextField.Text+"')", con);

            con.Open();
            sqlCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data saved Successfuly");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM Shifts", con);
            DataTable dtbl = new DataTable();   
            sqlDataAdapter.Fill(dtbl);
            dataGridView.DataSource = dtbl;
            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int weekNoInt = int.Parse(weekNoTB.Text);
            con.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM Shifts WHERE WeekNo = '" + weekNoInt + "' ", con);
            DataTable dtbl = new DataTable();
            sqlDataAdapter.Fill(dtbl);
            dataGridView.DataSource = dtbl;
            con.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM Shifts WHERE FullName LIKE '%" + fullNameTB.Text + "%' ", con);
            DataTable dtbl = new DataTable();
            sqlDataAdapter.Fill(dtbl);
            dataGridView.DataSource = dtbl;
            con.Close();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'modelDataSet.Shifts' . Możesz go przenieść lub usunąć.
            this.shiftsTableAdapter.Fill(this.modelDataSet.Shifts);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'modelDataSet.Shifts' . Możesz go przenieść lub usunąć.
            //this.shiftsTableAdapter.Fill(this.modelDataSet.Shifts);
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
            //setTextFields((ShiftCode)Enum.Parse(typeof(ShiftCode), shiftCodeComboBox.SelectedItem.ToString()));
            weekNoLabel.Text = currentDayOfWeek().ToString();
            totalHours.Text = countingHours().ToString();
            currentHours.Text = countingHours().ToString();
            monthlyHours.Text = weeklyHoursCount().ToString();
            overtime.Text = overtimeHoursCount().ToString();
        }

        private void weekBack_Click(object sender, EventArgs e)
        {
            showedWeek = showedWeek.AddDays(-7);
            setEdgeDates(showedWeek);
            //setTextFields((ShiftCode)Enum.Parse(typeof(ShiftCode), shiftCodeComboBox.SelectedItem.ToString()));
        }

        private void weekForward_Click(object sender, EventArgs e)
        {
            showedWeek = showedWeek.AddDays(7);
            setEdgeDates(showedWeek);
            //setTextFields((ShiftCode)Enum.Parse(typeof(ShiftCode), shiftCodeComboBox.SelectedItem.ToString()));
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
            //DateTime day = showedWeek.Date;
            foreach (TextBox tb in textBoxes)
            {
                tb.Text = "0";
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
        /*
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
            */



        //nadgodziny
        /*List<Data> overtimeHours = dataService.getDataByMonth(month);
        overtimeHours.RemoveAll(x => x.shiftCode == ShiftCode.Night);
        foreach (Data data in overtimeHours)
        {
            data.hoursWorked -= 8;
            if (data.hoursWorked < 0) data.hoursWorked = 0;
        }
        sum = overtimeHours.Sum(x => x.hoursWorked);
        overtime.Text = sum.ToString();*/

        //Nocki
        /* List<Data> nightHours = dataService.getDataByMonth(month);
         nightHours.RemoveAll(x => x.shiftCode != ShiftCode.Night);
         sum = nightHours.Sum(x => x.hoursWorked);
         nightShift.Text = sum.ToString();
    }*/

        private void shiftsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.shiftsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.modelDataSet);

        }

        private void shiftsBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.shiftsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.modelDataSet);

        }

        //meotoda do wypisania numeru aktualnego tygodnia w Polsce
        private static int currentDayOfWeek()
        {
            CultureInfo myCI = new CultureInfo("pl-PL");
            Calendar myCal = myCI.Calendar;
            CalendarWeekRule myCWR = myCI.DateTimeFormat.CalendarWeekRule;
            DayOfWeek myFirstDOW = myCI.DateTimeFormat.FirstDayOfWeek;
            int weekNo = myCal.GetWeekOfYear(DateTime.Now, myCWR, myFirstDOW);
            return weekNo;
        }

        //obliczenie czasu pracy
        private int countingHours()
        {
            string monday = textBox0.Text;
            if (monday.Length == 0) monday = "0";
            string tuesday = textBox1.Text;
            if (tuesday.Length == 0) tuesday = "0";
            string wednesday = textBox2.Text;
            if (wednesday.Length == 0) wednesday = "0";
            string thursday = textBox3.Text;
            if (thursday.Length == 0) thursday = "0";
            string friday = textBox4.Text;
            if (friday.Length == 0) friday = "0";
            string saturday = textBox5.Text;
            if (saturday.Length == 0) saturday = "0";
            string sunday = textBox6.Text;
            if (sunday.Length == 0) sunday = "0";
            int mondayInt = int.Parse(monday);
            int tuesdayInt = int.Parse(tuesday);
            int wednesdayInt = int.Parse(wednesday);
            int thursdayInt = int.Parse(thursday);
            int fridayInt = int.Parse(friday);
            int saturdayInt = int.Parse(saturday);
            var sundayInt = int.Parse(sunday);
            int count = mondayInt + tuesdayInt + wednesdayInt + thursdayInt + fridayInt + saturdayInt + sundayInt;
            return count;
        }
        //obliczanie ile czasu pracy zostało do wyrobienia w tym tygodniu
        private int weeklyHoursCount()
        {
            int monthlyHoursNorm = 40;
            int totalHoursInt = int.Parse(totalHours.Text);
            int monthlyHoursInt = 0;
            if (totalHoursInt < monthlyHoursNorm)
            {
                monthlyHoursInt = (monthlyHoursNorm - totalHoursInt);
            }
            return monthlyHoursInt;
        }

        //obliczanie ile nadgodzin jest w tygodniu
        private int overtimeHoursCount()
        {
            int monthlyHoursNorm = 40;
            int totalHoursInt = int.Parse(totalHours.Text);
            int overtimeHoursInt = 0;
            if (totalHoursInt > monthlyHoursNorm)
            {
                overtimeHoursInt = (totalHoursInt - monthlyHoursNorm);
            }
            return overtimeHoursInt;
        }

        //mozna wpisac tylko cyfry, spacje i delete
        private void onlyDigitsKeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }
        //limit godzin od zero do 24
        private void textBox0_Changed(object sender, EventArgs e)
        {
            int daylyHoursMax = 24;
            int box_int = 0;
            Int32.TryParse(textBox0.Text, out box_int);
            if (box_int < 0 && textBox0 != null)
            {
                textBox0.Text = "0";
            }
            else if (box_int > daylyHoursMax && textBox0 != null)
            {
                textBox0.Text = "24";
                MessageBox.Show("Maximum allowed hours to work per day is 24");
            }
            totalHours.Text = countingHours().ToString();
            currentHours.Text = countingHours().ToString();
            monthlyHours.Text = weeklyHoursCount().ToString();
            overtime.Text = overtimeHoursCount().ToString();
        }
        private void textBox1_Changed(object sender, EventArgs e)
        {
            int box_int = 0;
            Int32.TryParse(textBox1.Text, out box_int);
            if (box_int < 0 && textBox1 != null)
            {
                textBox1.Text = "0";
            }
            else if (box_int > 24 && textBox1 != null)
            {
                textBox1.Text = "24";
                MessageBox.Show("Maximum allowed hours to work per day is 24");
            }
            totalHours.Text = countingHours().ToString();
            currentHours.Text = countingHours().ToString();
            monthlyHours.Text = weeklyHoursCount().ToString();
            overtime.Text = overtimeHoursCount().ToString();
        }
        private void textBox2_Changed(object sender, EventArgs e)
        {
            int box_int = 0;
            Int32.TryParse(textBox2.Text, out box_int);
            if (box_int < 0 && textBox2 != null)
            {
                textBox2.Text = "0";
            }
            else if (box_int > 24 && textBox2 != null)
            {
                textBox2.Text = "24";
                MessageBox.Show("Maximum allowed hours to work per day is 24");
            }
            totalHours.Text = countingHours().ToString();
            currentHours.Text = countingHours().ToString();
            monthlyHours.Text = weeklyHoursCount().ToString();
            overtime.Text = overtimeHoursCount().ToString();
        }
        private void textBox3_Changed(object sender, EventArgs e)
        {
            int box_int = 0;
            Int32.TryParse(textBox3.Text, out box_int);
            if (box_int < 0 && textBox3 != null)
            {
                textBox3.Text = "0";
            }
            else if (box_int > 24 && textBox3 != null)
            {
                textBox3.Text = "24";
                MessageBox.Show("Maximum allowed hours to work per day is 24");
            }
            totalHours.Text = countingHours().ToString();
            currentHours.Text = countingHours().ToString();
            monthlyHours.Text = weeklyHoursCount().ToString();
            overtime.Text = overtimeHoursCount().ToString();
        }
        private void textBox4_Changed(object sender, EventArgs e)
        {
            int box_int = 0;
            Int32.TryParse(textBox4.Text, out box_int);
            if (box_int < 0 && textBox4 != null)
            {
                textBox4.Text = "0";
            }
            else if (box_int > 24 && textBox4 != null)
            {
                textBox4.Text = "24";
                MessageBox.Show("Maximum allowed hours to work per day is 24");
            }
            totalHours.Text = countingHours().ToString();
            currentHours.Text = countingHours().ToString();
            monthlyHours.Text = weeklyHoursCount().ToString();
            overtime.Text = overtimeHoursCount().ToString();
        }
        private void textBox5_Changed(object sender, EventArgs e)
        {
            int box_int = 0;
            Int32.TryParse(textBox5.Text, out box_int);
            if (box_int < 0 && textBox5 != null)
            {
                textBox5.Text = "0";
            }
            else if (box_int > 24 && textBox5 != null)
            {
                textBox5.Text = "24";
                MessageBox.Show("Maximum allowed hours to work per day is 24");
            }
            totalHours.Text = countingHours().ToString();
            currentHours.Text = countingHours().ToString();
            monthlyHours.Text = weeklyHoursCount().ToString();
            overtime.Text = overtimeHoursCount().ToString();
        }
        private void textBox6_Changed(object sender, EventArgs e)
        {
            int box_int = 0;
            Int32.TryParse(textBox6.Text, out box_int);
            if (box_int < 0 && textBox6 != null)
            {
                textBox6.Text = "0";
            }
            else if (box_int > 24 && textBox6 != null)
            {
                textBox6.Text = "24";
                MessageBox.Show("Maximum allowed hours to work per day is 24");
            }
            totalHours.Text = countingHours().ToString();
            currentHours.Text = countingHours().ToString();
            monthlyHours.Text = weeklyHoursCount().ToString();
            overtime.Text = overtimeHoursCount().ToString();
        }

        //placeholder dla weekNoTV oraz fullNameTB 
        private void weekNoTB_Enter(object sender, EventArgs e)
        {
            if (weekNoTB.Text == "Week no.")
            {
                weekNoTB.Text = "";
                weekNoTB.ForeColor = Color.Black;
            }
        }

        private void weekNoTB_Leave(object sender, EventArgs e)
        {
            if (weekNoTB.Text == "")
            {
                weekNoTB.Text = "Week no.";
                weekNoTB.ForeColor = Color.Silver;
            }
        }

        private void fullNameTB_Enter(object sender, EventArgs e)
        {
            if (fullNameTB.Text == "Name and surname")
            {
                fullNameTB.Text = "";
                fullNameTB.ForeColor = Color.Black;
            }
        }

        private void fullNameTB_Leave(object sender, EventArgs e)
        {
            if (fullNameTB.Text == "")
            {
                fullNameTB.Text = "Name and surname";
                fullNameTB.ForeColor = Color.Silver;
            }
        }

        
        // placeholdery dla wpisywania godzin
        private void textBox0_Enter(object sender, EventArgs e)
        {
            if (textBox0.Text == "0")
            {
                textBox0.Text = "";
                textBox0.ForeColor = Color.Black;
            }
        }

        private void textBox0_Leave(object sender, EventArgs e)
        {
            if (textBox0.Text == "")
            {
                textBox0.Text = "0";
                textBox0.ForeColor = Color.Silver;
            }
        }
        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
                
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "0";
                textBox1.ForeColor = Color.Silver;
            }
        }
        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "0")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;
                
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "0";
                textBox2.ForeColor = Color.Silver;
            }
        }
        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (textBox3.Text == "0")
            {
                textBox3.Text = "";
                textBox3.ForeColor = Color.Black;
                
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                textBox3.Text = "0";
                textBox3.ForeColor = Color.Silver;
            }
        }
        private void textBox4_Enter(object sender, EventArgs e)
        {
            if (textBox4.Text == "0")
            {
                textBox4.Text = "";
                textBox4.ForeColor = Color.Black;
                
            }
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                textBox4.Text = "0";
                textBox4.ForeColor = Color.Silver;
            }
        }
        private void textBox5_Enter(object sender, EventArgs e)
        {
            if (textBox5.Text == "0")
            {
                textBox5.Text = "";
                textBox5.ForeColor = Color.Black;
                
            }
        }

        private void textBox5_Leave(object sender, EventArgs e)
        {
            if (textBox5.Text == "")
            {
                textBox5.Text = "0";
                textBox5.ForeColor = Color.Silver;
            }
        }
        private void textBox6_Enter(object sender, EventArgs e)
        {
            if (textBox6.Text == "0")
            {
                textBox6.Text = "";
                textBox6.ForeColor = Color.Black; 
            }
        }

        private void textBox6_Leave(object sender, EventArgs e)
        {
            if (textBox6.Text == "")
            {
                textBox6.Text = "0";
                textBox6.ForeColor = Color.Silver;
            }
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