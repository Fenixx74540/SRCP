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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label weekNoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.name = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.modelDataSet = new SRCP.ModelDataSet();
            this.shiftsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shiftsTableAdapter = new SRCP.ModelDataSetTableAdapters.ShiftsTableAdapter();
            this.tableAdapterManager = new SRCP.ModelDataSetTableAdapters.TableAdapterManager();
            this.shiftsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.shiftsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.nameAndSurnameTextField = new System.Windows.Forms.TextBox();
            this.countBtn = new System.Windows.Forms.Button();
            this.weekNoTextBox = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.weekNoTB = new System.Windows.Forms.TextBox();
            weekNoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.modelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shiftsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shiftsBindingNavigator)).BeginInit();
            this.shiftsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // weekNoLabel
            // 
            weekNoLabel.AutoSize = true;
            weekNoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            weekNoLabel.Location = new System.Drawing.Point(552, 99);
            weekNoLabel.Name = "weekNoLabel";
            weekNoLabel.Size = new System.Drawing.Size(66, 13);
            weekNoLabel.TabIndex = 47;
            weekNoLabel.Text = "Week no.:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Week:";
            // 
            // weekBack
            // 
            this.weekBack.Location = new System.Drawing.Point(57, 40);
            this.weekBack.Name = "weekBack";
            this.weekBack.Size = new System.Drawing.Size(64, 20);
            this.weekBack.TabIndex = 1;
            this.weekBack.Text = "<--";
            this.weekBack.UseVisualStyleBackColor = true;
            this.weekBack.Click += new System.EventHandler(this.weekBack_Click);
            // 
            // weekFrom
            // 
            this.weekFrom.AutoSize = true;
            this.weekFrom.Location = new System.Drawing.Point(142, 43);
            this.weekFrom.Name = "weekFrom";
            this.weekFrom.Size = new System.Drawing.Size(56, 13);
            this.weekFrom.TabIndex = 2;
            this.weekFrom.Text = "weekFrom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(213, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "to";
            // 
            // weekTo
            // 
            this.weekTo.AutoSize = true;
            this.weekTo.Location = new System.Drawing.Point(251, 43);
            this.weekTo.Name = "weekTo";
            this.weekTo.Size = new System.Drawing.Size(46, 13);
            this.weekTo.TabIndex = 4;
            this.weekTo.Text = "weekTo";
            // 
            // weekForward
            // 
            this.weekForward.Location = new System.Drawing.Point(314, 40);
            this.weekForward.Name = "weekForward";
            this.weekForward.Size = new System.Drawing.Size(64, 20);
            this.weekForward.TabIndex = 5;
            this.weekForward.Text = "-->";
            this.weekForward.UseVisualStyleBackColor = true;
            this.weekForward.Click += new System.EventHandler(this.weekForward_Click);
            // 
            // day0
            // 
            this.day0.AutoSize = true;
            this.day0.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.day0.Location = new System.Drawing.Point(14, 179);
            this.day0.Name = "day0";
            this.day0.Size = new System.Drawing.Size(51, 13);
            this.day0.TabIndex = 7;
            this.day0.Text = "Monday";
            // 
            // labelNameDay0
            // 
            this.labelNameDay0.AutoSize = true;
            this.labelNameDay0.Location = new System.Drawing.Point(13, 155);
            this.labelNameDay0.Name = "labelNameDay0";
            this.labelNameDay0.Size = new System.Drawing.Size(82, 13);
            this.labelNameDay0.TabIndex = 8;
            this.labelNameDay0.Text = "labelNameDay0";
            // 
            // day1
            // 
            this.day1.AutoSize = true;
            this.day1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.day1.Location = new System.Drawing.Point(96, 179);
            this.day1.Name = "day1";
            this.day1.Size = new System.Drawing.Size(55, 13);
            this.day1.TabIndex = 9;
            this.day1.Text = "Tuesday";
            // 
            // labelNameDay1
            // 
            this.labelNameDay1.AutoSize = true;
            this.labelNameDay1.Location = new System.Drawing.Point(96, 155);
            this.labelNameDay1.Name = "labelNameDay1";
            this.labelNameDay1.Size = new System.Drawing.Size(82, 13);
            this.labelNameDay1.TabIndex = 10;
            this.labelNameDay1.Text = "labelNameDay1";
            // 
            // day2
            // 
            this.day2.AutoSize = true;
            this.day2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.day2.Location = new System.Drawing.Point(175, 179);
            this.day2.Name = "day2";
            this.day2.Size = new System.Drawing.Size(73, 13);
            this.day2.TabIndex = 11;
            this.day2.Text = "Wednesday";
            // 
            // labelNameDay2
            // 
            this.labelNameDay2.AutoSize = true;
            this.labelNameDay2.Location = new System.Drawing.Point(178, 155);
            this.labelNameDay2.Name = "labelNameDay2";
            this.labelNameDay2.Size = new System.Drawing.Size(82, 13);
            this.labelNameDay2.TabIndex = 12;
            this.labelNameDay2.Text = "labelNameDay2";
            // 
            // day3
            // 
            this.day3.AutoSize = true;
            this.day3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.day3.Location = new System.Drawing.Point(260, 179);
            this.day3.Name = "day3";
            this.day3.Size = new System.Drawing.Size(59, 13);
            this.day3.TabIndex = 13;
            this.day3.Text = "Thursday";
            // 
            // labelNameDay3
            // 
            this.labelNameDay3.AutoSize = true;
            this.labelNameDay3.Location = new System.Drawing.Point(260, 155);
            this.labelNameDay3.Name = "labelNameDay3";
            this.labelNameDay3.Size = new System.Drawing.Size(82, 13);
            this.labelNameDay3.TabIndex = 14;
            this.labelNameDay3.Text = "labelNameDay3";
            // 
            // day5
            // 
            this.day5.AutoSize = true;
            this.day5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.day5.Location = new System.Drawing.Point(425, 179);
            this.day5.Name = "day5";
            this.day5.Size = new System.Drawing.Size(57, 13);
            this.day5.TabIndex = 15;
            this.day5.Text = "Saturday";
            // 
            // labelNameDay4
            // 
            this.labelNameDay4.AutoSize = true;
            this.labelNameDay4.Location = new System.Drawing.Point(342, 155);
            this.labelNameDay4.Name = "labelNameDay4";
            this.labelNameDay4.Size = new System.Drawing.Size(82, 13);
            this.labelNameDay4.TabIndex = 16;
            this.labelNameDay4.Text = "labelNameDay4";
            // 
            // day4
            // 
            this.day4.AutoSize = true;
            this.day4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.day4.Location = new System.Drawing.Point(342, 179);
            this.day4.Name = "day4";
            this.day4.Size = new System.Drawing.Size(41, 13);
            this.day4.TabIndex = 17;
            this.day4.Text = "Friday";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(396, 155);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(0, 13);
            this.label14.TabIndex = 18;
            // 
            // day6
            // 
            this.day6.AutoSize = true;
            this.day6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.day6.Location = new System.Drawing.Point(507, 179);
            this.day6.Name = "day6";
            this.day6.Size = new System.Drawing.Size(49, 13);
            this.day6.TabIndex = 19;
            this.day6.Text = "Sunday";
            // 
            // labelNameDay6
            // 
            this.labelNameDay6.AutoSize = true;
            this.labelNameDay6.Location = new System.Drawing.Point(507, 155);
            this.labelNameDay6.Name = "labelNameDay6";
            this.labelNameDay6.Size = new System.Drawing.Size(82, 13);
            this.labelNameDay6.TabIndex = 20;
            this.labelNameDay6.Text = "labelNameDay6";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label17.Location = new System.Drawing.Point(619, 155);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(36, 13);
            this.label17.TabIndex = 21;
            this.label17.Text = "Total";
            // 
            // labelNameDay5
            // 
            this.labelNameDay5.AutoSize = true;
            this.labelNameDay5.Location = new System.Drawing.Point(425, 155);
            this.labelNameDay5.Name = "labelNameDay5";
            this.labelNameDay5.Size = new System.Drawing.Size(82, 13);
            this.labelNameDay5.TabIndex = 22;
            this.labelNameDay5.Text = "labelNameDay5";
            // 
            // textBox0
            // 
            this.textBox0.Location = new System.Drawing.Point(13, 204);
            this.textBox0.Name = "textBox0";
            this.textBox0.Size = new System.Drawing.Size(78, 20);
            this.textBox0.TabIndex = 23;
            this.textBox0.TextChanged += new System.EventHandler(this.textBox0_Changed);
            this.textBox0.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyDigitsKeyPress);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(96, 204);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(78, 20);
            this.textBox1.TabIndex = 24;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_Changed);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyDigitsKeyPress);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(178, 204);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(78, 20);
            this.textBox2.TabIndex = 25;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_Changed);
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyDigitsKeyPress);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(260, 204);
            this.textBox3.MaxLength = 2;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(78, 20);
            this.textBox3.TabIndex = 26;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_Changed);
            this.textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyDigitsKeyPress);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(342, 204);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(78, 20);
            this.textBox4.TabIndex = 27;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_Changed);
            this.textBox4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyDigitsKeyPress);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(425, 204);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(78, 20);
            this.textBox5.TabIndex = 28;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_Changed);
            this.textBox5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyDigitsKeyPress);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(507, 204);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(78, 20);
            this.textBox6.TabIndex = 29;
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_Changed);
            this.textBox6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyDigitsKeyPress);
            // 
            // totalHours
            // 
            this.totalHours.AutoSize = true;
            this.totalHours.Location = new System.Drawing.Point(615, 183);
            this.totalHours.Name = "totalHours";
            this.totalHours.Size = new System.Drawing.Size(55, 13);
            this.totalHours.TabIndex = 30;
            this.totalHours.Text = "totalHours";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(361, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Shift code:";
            // 
            // shiftCodeComboBox
            // 
            this.shiftCodeComboBox.FormattingEnabled = true;
            this.shiftCodeComboBox.Location = new System.Drawing.Point(361, 119);
            this.shiftCodeComboBox.Name = "shiftCodeComboBox";
            this.shiftCodeComboBox.Size = new System.Drawing.Size(160, 21);
            this.shiftCodeComboBox.TabIndex = 32;
            this.shiftCodeComboBox.SelectedIndexChanged += new System.EventHandler(this.shiftCodeComboBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(409, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(230, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "The current number of hours this week:";
            // 
            // currentHours
            // 
            this.currentHours.AutoSize = true;
            this.currentHours.Location = new System.Drawing.Point(635, 25);
            this.currentHours.Name = "currentHours";
            this.currentHours.Size = new System.Drawing.Size(68, 13);
            this.currentHours.TabIndex = 34;
            this.currentHours.Text = "currentHours";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(399, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(240, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "Number of hours to be worked this week:";
            // 
            // monthlyHours
            // 
            this.monthlyHours.AutoSize = true;
            this.monthlyHours.Location = new System.Drawing.Point(635, 47);
            this.monthlyHours.Name = "monthlyHours";
            this.monthlyHours.Size = new System.Drawing.Size(71, 13);
            this.monthlyHours.TabIndex = 36;
            this.monthlyHours.Text = "monthlyHours";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(578, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 37;
            this.label8.Text = "Overtime:";
            // 
            // overtime
            // 
            this.overtime.AutoSize = true;
            this.overtime.Location = new System.Drawing.Point(635, 65);
            this.overtime.Name = "overtime";
            this.overtime.Size = new System.Drawing.Size(47, 13);
            this.overtime.TabIndex = 38;
            this.overtime.Text = "overtime";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.name.Location = new System.Drawing.Point(13, 103);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(119, 13);
            this.name.TabIndex = 42;
            this.name.Text = "Name and surname:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(619, 231);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 20);
            this.button2.TabIndex = 44;
            this.button2.Text = "Zapisz";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // modelDataSet
            // 
            this.modelDataSet.DataSetName = "ModelDataSet";
            this.modelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // shiftsBindingSource
            // 
            this.shiftsBindingSource.DataMember = "Shifts";
            this.shiftsBindingSource.DataSource = this.modelDataSet;
            // 
            // shiftsTableAdapter
            // 
            this.shiftsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ShiftsTableAdapter = this.shiftsTableAdapter;
            this.tableAdapterManager.UpdateOrder = SRCP.ModelDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // shiftsBindingNavigator
            // 
            this.shiftsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.shiftsBindingNavigator.BindingSource = this.shiftsBindingSource;
            this.shiftsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.shiftsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.shiftsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.shiftsBindingNavigatorSaveItem});
            this.shiftsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.shiftsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.shiftsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.shiftsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.shiftsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.shiftsBindingNavigator.Name = "shiftsBindingNavigator";
            this.shiftsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.shiftsBindingNavigator.Size = new System.Drawing.Size(715, 25);
            this.shiftsBindingNavigator.TabIndex = 45;
            this.shiftsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Dodaj nowy";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorCountItem.Text = "z {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Suma elementów";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Usuń";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Przenieś pierwszy";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Przenieś poprzedni";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Pozycja";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Bieżąca pozycja";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Przenieś następny";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Przenieś ostatni";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // shiftsBindingNavigatorSaveItem
            // 
            this.shiftsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.shiftsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("shiftsBindingNavigatorSaveItem.Image")));
            this.shiftsBindingNavigatorSaveItem.Name = "shiftsBindingNavigatorSaveItem";
            this.shiftsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.shiftsBindingNavigatorSaveItem.Text = "Zapisz dane";
            this.shiftsBindingNavigatorSaveItem.Click += new System.EventHandler(this.shiftsBindingNavigatorSaveItem_Click_1);
            // 
            // nameAndSurnameTextField
            // 
            this.nameAndSurnameTextField.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.shiftsBindingSource, "FullName", true));
            this.nameAndSurnameTextField.Location = new System.Drawing.Point(13, 119);
            this.nameAndSurnameTextField.Name = "nameAndSurnameTextField";
            this.nameAndSurnameTextField.Size = new System.Drawing.Size(325, 20);
            this.nameAndSurnameTextField.TabIndex = 46;
            // 
            // countBtn
            // 
            this.countBtn.Location = new System.Drawing.Point(617, 202);
            this.countBtn.Name = "countBtn";
            this.countBtn.Size = new System.Drawing.Size(86, 23);
            this.countBtn.TabIndex = 47;
            this.countBtn.Text = "Count hours";
            this.countBtn.UseVisualStyleBackColor = true;
            this.countBtn.Click += new System.EventHandler(this.countBtn_Click);
            // 
            // weekNoTextBox
            // 
            this.weekNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.shiftsBindingSource, "WeekNo", true));
            this.weekNoTextBox.Location = new System.Drawing.Point(555, 119);
            this.weekNoTextBox.Name = "weekNoTextBox";
            this.weekNoTextBox.Size = new System.Drawing.Size(100, 20);
            this.weekNoTextBox.TabIndex = 48;
            this.weekNoTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyDigitsKeyPress);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(619, 257);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(84, 23);
            this.button3.TabIndex = 49;
            this.button3.Text = "Show all";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 261);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(514, 220);
            this.dataGridView.TabIndex = 50;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(594, 286);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(109, 23);
            this.button4.TabIndex = 51;
            this.button4.Text = "Search by week No";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // weekNoTB
            // 
            this.weekNoTB.Location = new System.Drawing.Point(532, 289);
            this.weekNoTB.Name = "weekNoTB";
            this.weekNoTB.Size = new System.Drawing.Size(56, 20);
            this.weekNoTB.TabIndex = 53;
            this.weekNoTB.Text = "Week no.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 491);
            this.Controls.Add(this.weekNoTB);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.button3);
            this.Controls.Add(weekNoLabel);
            this.Controls.Add(this.weekNoTextBox);
            this.Controls.Add(this.countBtn);
            this.Controls.Add(this.nameAndSurnameTextField);
            this.Controls.Add(this.shiftsBindingNavigator);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.name);
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
            ((System.ComponentModel.ISupportInitialize)(this.modelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shiftsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shiftsBindingNavigator)).EndInit();
            this.shiftsBindingNavigator.ResumeLayout(false);
            this.shiftsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button weekBack;
        private Label weekFrom;
        private Label label2;
        private Label weekTo;
        private Button weekForward;
        private Label day0;
        private Label labelNameDay0;
        private Label day1;
        private Label labelNameDay1;
        private Label day2;
        private Label labelNameDay2;
        private Label day3;
        private Label labelNameDay3;
        private Label day5;
        private Label labelNameDay4;
        private Label day4;
        private Label label14;
        private Label day6;
        private Label labelNameDay6;
        private Label label17;
        private Label labelNameDay5;
        private TextBox textBox0;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private Label totalHours;
        private Label label3;
        private ComboBox shiftCodeComboBox;
        private Label label4;
        private Label currentHours;
        private Label label6;
        private Label monthlyHours;
        private Label label8;
        private Label overtime;
        private Label name;
        private Button button2;
        private ModelDataSet modelDataSet;
        private BindingSource shiftsBindingSource;
        private ModelDataSetTableAdapters.ShiftsTableAdapter shiftsTableAdapter;
        private ModelDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private BindingNavigator shiftsBindingNavigator;
        private ToolStripButton bindingNavigatorAddNewItem;
        private ToolStripLabel bindingNavigatorCountItem;
        private ToolStripButton bindingNavigatorDeleteItem;
        private ToolStripButton bindingNavigatorMoveFirstItem;
        private ToolStripButton bindingNavigatorMovePreviousItem;
        private ToolStripSeparator bindingNavigatorSeparator;
        private ToolStripTextBox bindingNavigatorPositionItem;
        private ToolStripSeparator bindingNavigatorSeparator1;
        private ToolStripButton bindingNavigatorMoveNextItem;
        private ToolStripButton bindingNavigatorMoveLastItem;
        private ToolStripSeparator bindingNavigatorSeparator2;
        private ToolStripButton shiftsBindingNavigatorSaveItem;
        private TextBox nameAndSurnameTextField;
        private Button countBtn;
        private TextBox weekNoTextBox;
        private Button button3;
        private DataGridView dataGridView;
        private Button button4;
        private TextBox weekNoTB;
    }
}