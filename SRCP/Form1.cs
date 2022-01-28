using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace SRCP
{
    public partial class Form1 : Form
    {
        //DataService dataService = new DataService();

        int monthlyHoursNorm = 40;
        int daylyHoursMax = 24;

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
            
            int weekNoInt = int.Parse(weekNoTextBox.Text);

            SqlCommand sqlCommand = new SqlCommand("INSERT INTO Shifts (WeekNo, Shift, Hours, FullName) VALUES('" +weekNoInt+ "','" +shiftCodeComboBox.Text+ "','"+totalHours.Text+"','"+nameAndSurnameTextField.Text+"')", con);

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
            //setCurrentHours(showedWeek);
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

        private void countBtn_Click(object sender, EventArgs e)
        {
            int monday = int.Parse(textBox0.Text);
            int tuesday = int.Parse(textBox1.Text);
            int wednesday = int.Parse(textBox2.Text);
            int thursday = int.Parse(textBox3.Text);
            int friday = int.Parse(textBox4.Text);
            int saturday = int.Parse(textBox5.Text);
            int sunday = int.Parse(textBox6.Text);
            int count = monday + tuesday + wednesday + thursday + friday + saturday + sunday;
            totalHours.Text = count.ToString();
            currentHours.Text = count.ToString();


            //ilosc godzin do przepracowania
            
            int totalHoursInt = int.Parse(totalHours.Text);
            if (totalHoursInt < monthlyHoursNorm)
            {
                monthlyHours.Text = (monthlyHoursNorm - totalHoursInt).ToString();
            }
            else
                monthlyHours.Text = "None";
            //nagodziny
            if (totalHoursInt > monthlyHoursNorm)
            {
                overtime.Text = (totalHoursInt - monthlyHoursNorm).ToString();
            }
            else
                overtime.Text = "None";
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
            int box_int = 0;
            Int32.TryParse(textBox0.Text, out box_int);
            if (box_int < 0 && textBox0 != null)
            {
                textBox0.Text = "0";
            }
            else if (box_int > 24 && textBox0 != null)
            {
                textBox0.Text = "24";
                MessageBox.Show("Maximum allowed hours to work per day is 24");
            }
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
        }private void textBox2_Changed(object sender, EventArgs e)
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
        }private void textBox3_Changed(object sender, EventArgs e)
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
        }private void textBox4_Changed(object sender, EventArgs e)
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
        }private void textBox5_Changed(object sender, EventArgs e)
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
        }private void textBox6_Changed(object sender, EventArgs e)
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