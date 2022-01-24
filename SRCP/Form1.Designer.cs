using System;
using System.Windows.Forms;

namespace SRCP
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.weekBack = new System.Windows.Forms.Button();
            this.weekFrom = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.weekTo = new System.Windows.Forms.Label();
            this.weekForward = new System.Windows.Forms.Button();
            this.day0 = new System.Windows.Forms.Label();
            this.labelNameDay0 = new System.Windows.Forms.Label();
            this.day1 = new System.Windows.Forms.Label();
            this.labelNameDay1 = new System.Windows.Forms.Label();
            this.day2 = new System.Windows.Forms.Label();
            this.labelNameDay2 = new System.Windows.Forms.Label();
            this.day3 = new System.Windows.Forms.Label();
            this.labelNameDay3 = new System.Windows.Forms.Label();
            this.day5 = new System.Windows.Forms.Label();
            this.labelNameDay4 = new System.Windows.Forms.Label();
            this.day4 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.day6 = new System.Windows.Forms.Label();
            this.labelNameDay6 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.labelNameDay5 = new System.Windows.Forms.Label();
            this.textBox0 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.totalHours = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.shiftCodeComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.currentHours = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.monthlyHours = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.overtime = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.nightShift = new System.Windows.Forms.Label();
            this.nameAndSurnameTextField = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Week:";
            // 
            // btnPreviousWeek
            // 
            this.weekBack.Location = new System.Drawing.Point(79, 20);
            this.weekBack.Name = "btnPreviousWeek";
            this.weekBack.Size = new System.Drawing.Size(64, 20);
            this.weekBack.TabIndex = 1;
            this.weekBack.Text = "<--";
            this.weekBack.UseVisualStyleBackColor = true;
            this.weekBack.Click += new System.EventHandler(this.weekForward_Click);
            // 
            // weekFrom
            // 
            this.weekFrom.AutoSize = true;
            this.weekFrom.Location = new System.Drawing.Point(164, 23);
            this.weekFrom.Name = "weekFrom";
            this.weekFrom.Size = new System.Drawing.Size(56, 13);
            this.weekFrom.TabIndex = 2;
            this.weekFrom.Text = "weekFrom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(235, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "to";
            // 
            // weekTo
            // 
            this.weekTo.AutoSize = true;
            this.weekTo.Location = new System.Drawing.Point(273, 23);
            this.weekTo.Name = "weekTo";
            this.weekTo.Size = new System.Drawing.Size(46, 13);
            this.weekTo.TabIndex = 4;
            this.weekTo.Text = "weekTo";
            // 
            // btnNextWeek
            // 
            this.weekForward.Location = new System.Drawing.Point(336, 20);
            this.weekForward.Name = "btnNextWeek";
            this.weekForward.Size = new System.Drawing.Size(64, 20);
            this.weekForward.TabIndex = 5;
            this.weekForward.Text = "-->";
            this.weekForward.UseVisualStyleBackColor = true;
            this.weekForward.Click += new System.EventHandler(this.weekForward_Click);
            // 
            // day0
            // 
            this.day0.AutoSize = true;
            this.day0.Location = new System.Drawing.Point(53, 94);
            this.day0.Name = "day0";
            this.day0.Size = new System.Drawing.Size(30, 13);
            this.day0.TabIndex = 7;
            this.day0.Text = "day0";
            // 
            // labelNameDay0
            // 
            this.labelNameDay0.AutoSize = true;
            this.labelNameDay0.Location = new System.Drawing.Point(28, 70);
            this.labelNameDay0.Name = "labelNameDay0";
            this.labelNameDay0.Size = new System.Drawing.Size(82, 13);
            this.labelNameDay0.TabIndex = 8;
            this.labelNameDay0.Text = "labelNameDay0";
            // 
            // day1
            // 
            this.day1.AutoSize = true;
            this.day1.Location = new System.Drawing.Point(134, 94);
            this.day1.Name = "day1";
            this.day1.Size = new System.Drawing.Size(30, 13);
            this.day1.TabIndex = 9;
            this.day1.Text = "day1";
            // 
            // labelNameDay1
            // 
            this.labelNameDay1.AutoSize = true;
            this.labelNameDay1.Location = new System.Drawing.Point(111, 70);
            this.labelNameDay1.Name = "labelNameDay1";
            this.labelNameDay1.Size = new System.Drawing.Size(82, 13);
            this.labelNameDay1.TabIndex = 10;
            this.labelNameDay1.Text = "labelNameDay1";
            // 
            // day2
            // 
            this.day2.AutoSize = true;
            this.day2.Location = new System.Drawing.Point(215, 94);
            this.day2.Name = "day2";
            this.day2.Size = new System.Drawing.Size(30, 13);
            this.day2.TabIndex = 11;
            this.day2.Text = "day2";
            // 
            // labelNameDay2
            // 
            this.labelNameDay2.AutoSize = true;
            this.labelNameDay2.Location = new System.Drawing.Point(193, 70);
            this.labelNameDay2.Name = "labelNameDay2";
            this.labelNameDay2.Size = new System.Drawing.Size(82, 13);
            this.labelNameDay2.TabIndex = 12;
            this.labelNameDay2.Text = "labelNameDay2";
            // 
            // day3
            // 
            this.day3.AutoSize = true;
            this.day3.Location = new System.Drawing.Point(299, 94);
            this.day3.Name = "day3";
            this.day3.Size = new System.Drawing.Size(30, 13);
            this.day3.TabIndex = 13;
            this.day3.Text = "day3";
            // 
            // labelNameDay3
            // 
            this.labelNameDay3.AutoSize = true;
            this.labelNameDay3.Location = new System.Drawing.Point(275, 70);
            this.labelNameDay3.Name = "labelNameDay3";
            this.labelNameDay3.Size = new System.Drawing.Size(82, 13);
            this.labelNameDay3.TabIndex = 14;
            this.labelNameDay3.Text = "labelNameDay3";
            // 
            // day5
            // 
            this.day5.AutoSize = true;
            this.day5.Location = new System.Drawing.Point(464, 94);
            this.day5.Name = "day5";
            this.day5.Size = new System.Drawing.Size(30, 13);
            this.day5.TabIndex = 15;
            this.day5.Text = "day5";
            // 
            // labelNameDay4
            // 
            this.labelNameDay4.AutoSize = true;
            this.labelNameDay4.Location = new System.Drawing.Point(357, 70);
            this.labelNameDay4.Name = "labelNameDay4";
            this.labelNameDay4.Size = new System.Drawing.Size(82, 13);
            this.labelNameDay4.TabIndex = 16;
            this.labelNameDay4.Text = "labelNameDay4";
            // 
            // day4
            // 
            this.day4.AutoSize = true;
            this.day4.Location = new System.Drawing.Point(384, 94);
            this.day4.Name = "day4";
            this.day4.Size = new System.Drawing.Size(30, 13);
            this.day4.TabIndex = 17;
            this.day4.Text = "day4";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(411, 70);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(0, 13);
            this.label14.TabIndex = 18;
            // 
            // day6
            // 
            this.day6.AutoSize = true;
            this.day6.Location = new System.Drawing.Point(545, 94);
            this.day6.Name = "day6";
            this.day6.Size = new System.Drawing.Size(30, 13);
            this.day6.TabIndex = 19;
            this.day6.Text = "day6";
            // 
            // labelNameDay6
            // 
            this.labelNameDay6.AutoSize = true;
            this.labelNameDay6.Location = new System.Drawing.Point(522, 70);
            this.labelNameDay6.Name = "labelNameDay6";
            this.labelNameDay6.Size = new System.Drawing.Size(82, 13);
            this.labelNameDay6.TabIndex = 20;
            this.labelNameDay6.Text = "labelNameDay6";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(630, 86);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(31, 13);
            this.label17.TabIndex = 21;
            this.label17.Text = "Total";
            // 
            // labelNameDay5
            // 
            this.labelNameDay5.AutoSize = true;
            this.labelNameDay5.Location = new System.Drawing.Point(440, 70);
            this.labelNameDay5.Name = "labelNameDay5";
            this.labelNameDay5.Size = new System.Drawing.Size(82, 13);
            this.labelNameDay5.TabIndex = 22;
            this.labelNameDay5.Text = "labelNameDay5";
            // 
            // textBox0
            // 
            this.textBox0.Location = new System.Drawing.Point(28, 179);
            this.textBox0.Name = "textBox0";
            this.textBox0.Size = new System.Drawing.Size(78, 20);
            this.textBox0.TabIndex = 23;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(111, 179);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(78, 20);
            this.textBox1.TabIndex = 24;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(193, 179);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(78, 20);
            this.textBox2.TabIndex = 25;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(275, 179);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(78, 20);
            this.textBox3.TabIndex = 26;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(357, 179);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(78, 20);
            this.textBox4.TabIndex = 27;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(440, 179);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(78, 20);
            this.textBox5.TabIndex = 28;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(522, 179);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(78, 20);
            this.textBox6.TabIndex = 29;
            // 
            // totalHours
            // 
            this.totalHours.AutoSize = true;
            this.totalHours.Location = new System.Drawing.Point(630, 182);
            this.totalHours.Name = "totalHours";
            this.totalHours.Size = new System.Drawing.Size(55, 13);
            this.totalHours.TabIndex = 30;
            this.totalHours.Text = "totalHours";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Shift code:";
            // 
            // shiftCodeComboBox
            // 
            this.shiftCodeComboBox.FormattingEnabled = true;
            this.shiftCodeComboBox.Location = new System.Drawing.Point(28, 250);
            this.shiftCodeComboBox.Name = "shiftCodeComboBox";
            this.shiftCodeComboBox.Size = new System.Drawing.Size(160, 21);
            this.shiftCodeComboBox.TabIndex = 32;
            this.shiftCodeComboBox.SelectedIndexChanged += new System.EventHandler(this.shiftCodeComboBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(384, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "The current number of hours this month:";
            // 
            // currentHours
            // 
            this.currentHours.AutoSize = true;
            this.currentHours.Location = new System.Drawing.Point(591, 252);
            this.currentHours.Name = "currentHours";
            this.currentHours.Size = new System.Drawing.Size(68, 13);
            this.currentHours.TabIndex = 34;
            this.currentHours.Text = "currentHours";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(375, 283);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(204, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "Number of hours to be worked this month:";
            // 
            // monthlyHours
            // 
            this.monthlyHours.AutoSize = true;
            this.monthlyHours.Location = new System.Drawing.Point(591, 283);
            this.monthlyHours.Name = "monthlyHours";
            this.monthlyHours.Size = new System.Drawing.Size(71, 13);
            this.monthlyHours.TabIndex = 36;
            this.monthlyHours.Text = "monthlyHours";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(525, 314);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 37;
            this.label8.Text = "Overtime:";
            // 
            // overtime
            // 
            this.overtime.AutoSize = true;
            this.overtime.Location = new System.Drawing.Point(591, 314);
            this.overtime.Name = "overtime";
            this.overtime.Size = new System.Drawing.Size(47, 13);
            this.overtime.TabIndex = 38;
            this.overtime.Text = "overtime";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(519, 344);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 13);
            this.label10.TabIndex = 39;
            this.label10.Text = "Night shift:";
            // 
            // nightShift
            // 
            this.nightShift.AutoSize = true;
            this.nightShift.Location = new System.Drawing.Point(591, 344);
            this.nightShift.Name = "nightShift";
            this.nightShift.Size = new System.Drawing.Size(51, 13);
            this.nightShift.TabIndex = 40;
            this.nightShift.Text = "nightShift";
            // 
            // nameAndSurnameTextField
            // 
            this.nameAndSurnameTextField.Location = new System.Drawing.Point(193, 138);
            this.nameAndSurnameTextField.Name = "nameAndSurnameTextField";
            this.nameAndSurnameTextField.Size = new System.Drawing.Size(325, 20);
            this.nameAndSurnameTextField.TabIndex = 41;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(90, 140);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(102, 13);
            this.name.TabIndex = 42;
            this.name.Text = "Name and surname:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(552, 437);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 20);
            this.button1.TabIndex = 43;
            this.button1.Text = "Odśwież";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(621, 437);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(64, 20);
            this.button2.TabIndex = 44;
            this.button2.Text = "Zapisz";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 497);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.name);
            this.Controls.Add(this.nameAndSurnameTextField);
            this.Controls.Add(this.nightShift);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.overtime);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.monthlyHours);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.currentHours);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.shiftCodeComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.totalHours);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox0);
            this.Controls.Add(this.labelNameDay5);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.labelNameDay6);
            this.Controls.Add(this.day6);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.day4);
            this.Controls.Add(this.labelNameDay4);
            this.Controls.Add(this.day5);
            this.Controls.Add(this.labelNameDay3);
            this.Controls.Add(this.day3);
            this.Controls.Add(this.labelNameDay2);
            this.Controls.Add(this.day2);
            this.Controls.Add(this.labelNameDay1);
            this.Controls.Add(this.day1);
            this.Controls.Add(this.labelNameDay0);
            this.Controls.Add(this.day0);
            this.Controls.Add(this.weekForward);
            this.Controls.Add(this.weekTo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.weekFrom);
            this.Controls.Add(this.weekBack);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Rejestracja czasu pracy";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private System.Windows.Forms.Button weekBack;
        private System.Windows.Forms.Label weekFrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label weekTo;
        private System.Windows.Forms.Button weekForward;
        private System.Windows.Forms.Label labelNameDay0;
        private System.Windows.Forms.Label labelNameDay1;
        private System.Windows.Forms.Label labelNameDay2;
        private System.Windows.Forms.Label labelNameDay3;
        private System.Windows.Forms.Label labelNameDay4;
        private System.Windows.Forms.Label labelNameDay5;
        private TextBox textBox0;
        private System.Windows.Forms.Label labelNameDay6;
        private Label label17;
        private System.Windows.Forms.Label day0;
        private System.Windows.Forms.Label day1;
        private System.Windows.Forms.Label day2;
        private System.Windows.Forms.Label day3;
        private System.Windows.Forms.Label day4;
        private Label label14;
        private System.Windows.Forms.Label day5;
        private System.Windows.Forms.Label day6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private Label totalHours;
        private System.Windows.Forms.Label label3;
        private ComboBox shiftCodeComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label currentHours;
        private System.Windows.Forms.Label monthlyHours;
        private Label label8;
        private System.Windows.Forms.Label overtime;
        private Label label10;
        private System.Windows.Forms.Label nightShift;
        private TextBox nameAndSurnameTextField;
        private Label name;
        private Button button1;
        private Button button2;
    }
}