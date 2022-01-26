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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.Label weekNoLabel;
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
            this.name = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
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
            weekNoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.modelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shiftsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shiftsBindingNavigator)).BeginInit();
            this.shiftsBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Week:";
            // 
            // weekBack
            // 
            this.weekBack.Location = new System.Drawing.Point(80, 37);
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
            this.weekFrom.Location = new System.Drawing.Point(165, 40);
            this.weekFrom.Name = "weekFrom";
            this.weekFrom.Size = new System.Drawing.Size(56, 13);
            this.weekFrom.TabIndex = 2;
            this.weekFrom.Text = "weekFrom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(236, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "to";
            // 
            // weekTo
            // 
            this.weekTo.AutoSize = true;
            this.weekTo.Location = new System.Drawing.Point(274, 40);
            this.weekTo.Name = "weekTo";
            this.weekTo.Size = new System.Drawing.Size(46, 13);
            this.weekTo.TabIndex = 4;
            this.weekTo.Text = "weekTo";
            // 
            // weekForward
            // 
            this.weekForward.Location = new System.Drawing.Point(337, 37);
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
            this.textBox0.Location = new System.Drawing.Point(28, 119);
            this.textBox0.Name = "textBox0";
            this.textBox0.Size = new System.Drawing.Size(78, 20);
            this.textBox0.TabIndex = 23;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(111, 119);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(78, 20);
            this.textBox1.TabIndex = 24;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(193, 119);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(78, 20);
            this.textBox2.TabIndex = 25;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(275, 119);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(78, 20);
            this.textBox3.TabIndex = 26;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(357, 119);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(78, 20);
            this.textBox4.TabIndex = 27;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(440, 119);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(78, 20);
            this.textBox5.TabIndex = 28;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(522, 119);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(78, 20);
            this.textBox6.TabIndex = 29;
            // 
            // totalHours
            // 
            this.totalHours.AutoSize = true;
            this.totalHours.Location = new System.Drawing.Point(630, 122);
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
            this.label4.Location = new System.Drawing.Point(387, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "The current number of hours this month:";
            // 
            // currentHours
            // 
            this.currentHours.AutoSize = true;
            this.currentHours.Location = new System.Drawing.Point(594, 182);
            this.currentHours.Name = "currentHours";
            this.currentHours.Size = new System.Drawing.Size(68, 13);
            this.currentHours.TabIndex = 34;
            this.currentHours.Text = "currentHours";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(378, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(204, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "Number of hours to be worked this month:";
            // 
            // monthlyHours
            // 
            this.monthlyHours.AutoSize = true;
            this.monthlyHours.Location = new System.Drawing.Point(594, 213);
            this.monthlyHours.Name = "monthlyHours";
            this.monthlyHours.Size = new System.Drawing.Size(71, 13);
            this.monthlyHours.TabIndex = 36;
            this.monthlyHours.Text = "monthlyHours";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(528, 244);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 37;
            this.label8.Text = "Overtime:";
            // 
            // overtime
            // 
            this.overtime.AutoSize = true;
            this.overtime.Location = new System.Drawing.Point(594, 244);
            this.overtime.Name = "overtime";
            this.overtime.Size = new System.Drawing.Size(47, 13);
            this.overtime.TabIndex = 38;
            this.overtime.Text = "overtime";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(522, 274);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 13);
            this.label10.TabIndex = 39;
            this.label10.Text = "Night shift:";
            // 
            // nightShift
            // 
            this.nightShift.AutoSize = true;
            this.nightShift.Location = new System.Drawing.Point(594, 274);
            this.nightShift.Name = "nightShift";
            this.nightShift.Size = new System.Drawing.Size(51, 13);
            this.nightShift.TabIndex = 40;
            this.nightShift.Text = "nightShift";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(28, 166);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(102, 13);
            this.name.TabIndex = 42;
            this.name.Text = "Name and surname:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(512, 311);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 20);
            this.button1.TabIndex = 43;
            this.button1.Text = "Odśwież";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(581, 311);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(64, 20);
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
            this.nameAndSurnameTextField.Location = new System.Drawing.Point(28, 182);
            this.nameAndSurnameTextField.Name = "nameAndSurnameTextField";
            this.nameAndSurnameTextField.Size = new System.Drawing.Size(320, 20);
            this.nameAndSurnameTextField.TabIndex = 46;
            // 
            // countBtn
            // 
            this.countBtn.Location = new System.Drawing.Point(619, 147);
            this.countBtn.Name = "countBtn";
            this.countBtn.Size = new System.Drawing.Size(75, 23);
            this.countBtn.TabIndex = 47;
            this.countBtn.Text = "Count hours";
            this.countBtn.UseVisualStyleBackColor = true;
            this.countBtn.Click += new System.EventHandler(this.countBtn_Click);
            // 
            // weekNoLabel
            // 
            weekNoLabel.AutoSize = true;
            weekNoLabel.Location = new System.Drawing.Point(437, 37);
            weekNoLabel.Name = "weekNoLabel";
            weekNoLabel.Size = new System.Drawing.Size(56, 13);
            weekNoLabel.TabIndex = 47;
            weekNoLabel.Text = "Week No:";
            // 
            // weekNoTextBox
            // 
            this.weekNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.shiftsBindingSource, "WeekNo", true));
            this.weekNoTextBox.Location = new System.Drawing.Point(499, 34);
            this.weekNoTextBox.Name = "weekNoTextBox";
            this.weekNoTextBox.Size = new System.Drawing.Size(100, 20);
            this.weekNoTextBox.TabIndex = 48;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 357);
            this.Controls.Add(weekNoLabel);
            this.Controls.Add(this.weekNoTextBox);
            this.Controls.Add(this.countBtn);
            this.Controls.Add(this.nameAndSurnameTextField);
            this.Controls.Add(this.shiftsBindingNavigator);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.name);
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
            ((System.ComponentModel.ISupportInitialize)(this.modelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shiftsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shiftsBindingNavigator)).EndInit();
            this.shiftsBindingNavigator.ResumeLayout(false);
            this.shiftsBindingNavigator.PerformLayout();
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
        private Label label10;
        private Label nightShift;
        private Label name;
        private Button button1;
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
    }
}