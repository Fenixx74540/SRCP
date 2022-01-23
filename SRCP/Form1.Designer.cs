
namespace SRCP
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.Label weekNoLabel;
            this.Label1 = new System.Windows.Forms.Label();
            this.btnPreviousWeek = new System.Windows.Forms.Button();
            this.weekFrom = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.weekTo = new System.Windows.Forms.Label();
            this.btnNextWeek = new System.Windows.Forms.Button();
            this.labelNameDay0 = new System.Windows.Forms.Label();
            this.labelNameDay1 = new System.Windows.Forms.Label();
            this.labelNameDay2 = new System.Windows.Forms.Label();
            this.labelNameDay3 = new System.Windows.Forms.Label();
            this.labelNameDay4 = new System.Windows.Forms.Label();
            this.labelNameDay5 = new System.Windows.Forms.Label();
            this.labelNameDay6 = new System.Windows.Forms.Label();
            this.Total = new System.Windows.Forms.Label();
            this.day0 = new System.Windows.Forms.Label();
            this.day1 = new System.Windows.Forms.Label();
            this.day2 = new System.Windows.Forms.Label();
            this.day3 = new System.Windows.Forms.Label();
            this.day4 = new System.Windows.Forms.Label();
            this.day5 = new System.Windows.Forms.Label();
            this.day6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.shiftCode = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.currentHours = new System.Windows.Forms.Label();
            this.monthlyHours = new System.Windows.Forms.Label();
            this.overtime = new System.Windows.Forms.Label();
            this.nightShift = new System.Windows.Forms.Label();
            this.FullNameLabel = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.modelDataSet = new SRCP.ModelDataSet();
            this.shiftsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shiftsTableAdapter = new SRCP.ModelDataSetTableAdapters.ShiftsTableAdapter();
            this.tableAdapterManager = new SRCP.ModelDataSetTableAdapters.TableAdapterManager();
            this.shiftsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.shiftsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.weekNoLabel1 = new System.Windows.Forms.Label();
            this.shiftComboBox = new System.Windows.Forms.ComboBox();
            this.hoursLabel1 = new System.Windows.Forms.Label();
            this.fullNameTextBox = new System.Windows.Forms.TextBox();
            weekNoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.modelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shiftsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shiftsBindingNavigator)).BeginInit();
            this.shiftsBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(36, 36);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(39, 13);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Week:";
            this.Label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnPreviousWeek
            // 
            this.btnPreviousWeek.Location = new System.Drawing.Point(81, 31);
            this.btnPreviousWeek.Name = "btnPreviousWeek";
            this.btnPreviousWeek.Size = new System.Drawing.Size(39, 23);
            this.btnPreviousWeek.TabIndex = 1;
            this.btnPreviousWeek.Text = "<--";
            this.btnPreviousWeek.UseVisualStyleBackColor = true;
            this.btnPreviousWeek.Click += new System.EventHandler(this.button1_Click);
            // 
            // weekFrom
            // 
            this.weekFrom.AutoSize = true;
            this.weekFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.weekFrom.Location = new System.Drawing.Point(141, 36);
            this.weekFrom.Name = "weekFrom";
            this.weekFrom.Size = new System.Drawing.Size(64, 13);
            this.weekFrom.TabIndex = 2;
            this.weekFrom.Text = "weekFrom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "to";
            // 
            // weekTo
            // 
            this.weekTo.AutoSize = true;
            this.weekTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.weekTo.Location = new System.Drawing.Point(261, 36);
            this.weekTo.Name = "weekTo";
            this.weekTo.Size = new System.Drawing.Size(52, 13);
            this.weekTo.TabIndex = 4;
            this.weekTo.Text = "weekTo";
            // 
            // btnNextWeek
            // 
            this.btnNextWeek.Location = new System.Drawing.Point(346, 31);
            this.btnNextWeek.Name = "btnNextWeek";
            this.btnNextWeek.Size = new System.Drawing.Size(39, 23);
            this.btnNextWeek.TabIndex = 5;
            this.btnNextWeek.Text = "-->";
            this.btnNextWeek.UseVisualStyleBackColor = true;
            // 
            // labelNameDay0
            // 
            this.labelNameDay0.AutoSize = true;
            this.labelNameDay0.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNameDay0.Location = new System.Drawing.Point(45, 138);
            this.labelNameDay0.Name = "labelNameDay0";
            this.labelNameDay0.Size = new System.Drawing.Size(51, 13);
            this.labelNameDay0.TabIndex = 6;
            this.labelNameDay0.Text = "Monday";
            this.labelNameDay0.Click += new System.EventHandler(this.label3_Click);
            // 
            // labelNameDay1
            // 
            this.labelNameDay1.AutoSize = true;
            this.labelNameDay1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNameDay1.Location = new System.Drawing.Point(146, 138);
            this.labelNameDay1.Name = "labelNameDay1";
            this.labelNameDay1.Size = new System.Drawing.Size(55, 13);
            this.labelNameDay1.TabIndex = 7;
            this.labelNameDay1.Text = "Tuesday";
            // 
            // labelNameDay2
            // 
            this.labelNameDay2.AutoSize = true;
            this.labelNameDay2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNameDay2.Location = new System.Drawing.Point(247, 138);
            this.labelNameDay2.Name = "labelNameDay2";
            this.labelNameDay2.Size = new System.Drawing.Size(73, 13);
            this.labelNameDay2.TabIndex = 8;
            this.labelNameDay2.Text = "Wednesday";
            // 
            // labelNameDay3
            // 
            this.labelNameDay3.AutoSize = true;
            this.labelNameDay3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNameDay3.Location = new System.Drawing.Point(348, 138);
            this.labelNameDay3.Name = "labelNameDay3";
            this.labelNameDay3.Size = new System.Drawing.Size(59, 13);
            this.labelNameDay3.TabIndex = 9;
            this.labelNameDay3.Text = "Thursday";
            // 
            // labelNameDay4
            // 
            this.labelNameDay4.AutoSize = true;
            this.labelNameDay4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNameDay4.Location = new System.Drawing.Point(449, 138);
            this.labelNameDay4.Name = "labelNameDay4";
            this.labelNameDay4.Size = new System.Drawing.Size(41, 13);
            this.labelNameDay4.TabIndex = 10;
            this.labelNameDay4.Text = "Friday";
            // 
            // labelNameDay5
            // 
            this.labelNameDay5.AutoSize = true;
            this.labelNameDay5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNameDay5.Location = new System.Drawing.Point(550, 138);
            this.labelNameDay5.Name = "labelNameDay5";
            this.labelNameDay5.Size = new System.Drawing.Size(57, 13);
            this.labelNameDay5.TabIndex = 11;
            this.labelNameDay5.Text = "Saturday";
            // 
            // labelNameDay6
            // 
            this.labelNameDay6.AutoSize = true;
            this.labelNameDay6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNameDay6.Location = new System.Drawing.Point(651, 138);
            this.labelNameDay6.Name = "labelNameDay6";
            this.labelNameDay6.Size = new System.Drawing.Size(49, 13);
            this.labelNameDay6.TabIndex = 12;
            this.labelNameDay6.Text = "Sunday";
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Total.Location = new System.Drawing.Point(732, 151);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(36, 13);
            this.Total.TabIndex = 13;
            this.Total.Text = "Total";
            // 
            // day0
            // 
            this.day0.AutoSize = true;
            this.day0.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.day0.Location = new System.Drawing.Point(45, 151);
            this.day0.Name = "day0";
            this.day0.Size = new System.Drawing.Size(34, 13);
            this.day0.TabIndex = 14;
            this.day0.Text = "day0";
            // 
            // day1
            // 
            this.day1.AutoSize = true;
            this.day1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.day1.Location = new System.Drawing.Point(146, 151);
            this.day1.Name = "day1";
            this.day1.Size = new System.Drawing.Size(34, 13);
            this.day1.TabIndex = 15;
            this.day1.Text = "day1";
            // 
            // day2
            // 
            this.day2.AutoSize = true;
            this.day2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.day2.Location = new System.Drawing.Point(247, 151);
            this.day2.Name = "day2";
            this.day2.Size = new System.Drawing.Size(34, 13);
            this.day2.TabIndex = 16;
            this.day2.Text = "day2";
            // 
            // day3
            // 
            this.day3.AutoSize = true;
            this.day3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.day3.Location = new System.Drawing.Point(348, 151);
            this.day3.Name = "day3";
            this.day3.Size = new System.Drawing.Size(34, 13);
            this.day3.TabIndex = 17;
            this.day3.Text = "day3";
            // 
            // day4
            // 
            this.day4.AutoSize = true;
            this.day4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.day4.Location = new System.Drawing.Point(449, 151);
            this.day4.Name = "day4";
            this.day4.Size = new System.Drawing.Size(34, 13);
            this.day4.TabIndex = 18;
            this.day4.Text = "day4";
            // 
            // day5
            // 
            this.day5.AutoSize = true;
            this.day5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.day5.Location = new System.Drawing.Point(550, 151);
            this.day5.Name = "day5";
            this.day5.Size = new System.Drawing.Size(34, 13);
            this.day5.TabIndex = 19;
            this.day5.Text = "day5";
            // 
            // day6
            // 
            this.day6.AutoSize = true;
            this.day6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.day6.Location = new System.Drawing.Point(651, 151);
            this.day6.Name = "day6";
            this.day6.Size = new System.Drawing.Size(34, 13);
            this.day6.TabIndex = 20;
            this.day6.Text = "day6";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(47, 186);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(51, 20);
            this.textBox1.TabIndex = 22;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(148, 186);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(51, 20);
            this.textBox2.TabIndex = 23;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(250, 186);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(51, 20);
            this.textBox3.TabIndex = 24;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(350, 186);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(51, 20);
            this.textBox4.TabIndex = 25;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(453, 186);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(51, 20);
            this.textBox5.TabIndex = 26;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(553, 186);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(51, 20);
            this.textBox6.TabIndex = 27;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(654, 186);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(51, 20);
            this.textBox7.TabIndex = 28;
            // 
            // shiftCode
            // 
            this.shiftCode.AutoSize = true;
            this.shiftCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.shiftCode.Location = new System.Drawing.Point(40, 260);
            this.shiftCode.Name = "shiftCode";
            this.shiftCode.Size = new System.Drawing.Size(69, 13);
            this.shiftCode.TabIndex = 30;
            this.shiftCode.Text = "Shift code:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(447, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(234, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "The current number of hours this month:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(437, 309);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(244, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Number of hours to be worked this month:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(620, 341);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Overtime:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(612, 374);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "Night shift:";
            // 
            // currentHours
            // 
            this.currentHours.AutoSize = true;
            this.currentHours.Location = new System.Drawing.Point(687, 274);
            this.currentHours.Name = "currentHours";
            this.currentHours.Size = new System.Drawing.Size(68, 13);
            this.currentHours.TabIndex = 36;
            this.currentHours.Text = "currentHours";
            // 
            // monthlyHours
            // 
            this.monthlyHours.AutoSize = true;
            this.monthlyHours.Location = new System.Drawing.Point(687, 309);
            this.monthlyHours.Name = "monthlyHours";
            this.monthlyHours.Size = new System.Drawing.Size(71, 13);
            this.monthlyHours.TabIndex = 37;
            this.monthlyHours.Text = "monthlyHours";
            // 
            // overtime
            // 
            this.overtime.AutoSize = true;
            this.overtime.Location = new System.Drawing.Point(687, 341);
            this.overtime.Name = "overtime";
            this.overtime.Size = new System.Drawing.Size(47, 13);
            this.overtime.TabIndex = 38;
            this.overtime.Text = "overtime";
            // 
            // nightShift
            // 
            this.nightShift.AutoSize = true;
            this.nightShift.Location = new System.Drawing.Point(687, 374);
            this.nightShift.Name = "nightShift";
            this.nightShift.Size = new System.Drawing.Size(51, 13);
            this.nightShift.TabIndex = 39;
            this.nightShift.Text = "nightShift";
            // 
            // FullNameLabel
            // 
            this.FullNameLabel.AutoSize = true;
            this.FullNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FullNameLabel.Location = new System.Drawing.Point(104, 87);
            this.FullNameLabel.Name = "FullNameLabel";
            this.FullNameLabel.Size = new System.Drawing.Size(65, 13);
            this.FullNameLabel.TabIndex = 41;
            this.FullNameLabel.Text = "Full name:";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(573, 415);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(72, 23);
            this.btnRefresh.TabIndex = 42;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(666, 415);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(72, 23);
            this.btnSave.TabIndex = 43;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
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
            this.shiftsBindingNavigator.Size = new System.Drawing.Size(826, 25);
            this.shiftsBindingNavigator.TabIndex = 44;
            this.shiftsBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Bieżąca pozycja";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(29, 15);
            this.bindingNavigatorCountItem.Text = "z {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Suma elementów";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Przenieś następny";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Przenieś ostatni";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Usuń";
            // 
            // shiftsBindingNavigatorSaveItem
            // 
            this.shiftsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.shiftsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("shiftsBindingNavigatorSaveItem.Image")));
            this.shiftsBindingNavigatorSaveItem.Name = "shiftsBindingNavigatorSaveItem";
            this.shiftsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.shiftsBindingNavigatorSaveItem.Text = "Zapisz dane";
            this.shiftsBindingNavigatorSaveItem.Click += new System.EventHandler(this.shiftsBindingNavigatorSaveItem_Click);
            // 
            // weekNoLabel
            // 
            weekNoLabel.AutoSize = true;
            weekNoLabel.Location = new System.Drawing.Point(416, 41);
            weekNoLabel.Name = "weekNoLabel";
            weekNoLabel.Size = new System.Drawing.Size(56, 13);
            weekNoLabel.TabIndex = 44;
            weekNoLabel.Text = "Week No:";
            // 
            // weekNoLabel1
            // 
            this.weekNoLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.shiftsBindingSource, "WeekNo", true));
            this.weekNoLabel1.Location = new System.Drawing.Point(478, 41);
            this.weekNoLabel1.Name = "weekNoLabel1";
            this.weekNoLabel1.Size = new System.Drawing.Size(100, 23);
            this.weekNoLabel1.TabIndex = 45;
            this.weekNoLabel1.Text = "label7";
            // 
            // shiftComboBox
            // 
            this.shiftComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.shiftsBindingSource, "Shift", true));
            this.shiftComboBox.FormattingEnabled = true;
            this.shiftComboBox.Items.AddRange(new object[] {
            "Morning",
            "Evening",
            "Night"});
            this.shiftComboBox.Location = new System.Drawing.Point(43, 289);
            this.shiftComboBox.Name = "shiftComboBox";
            this.shiftComboBox.Size = new System.Drawing.Size(162, 21);
            this.shiftComboBox.TabIndex = 47;
            // 
            // hoursLabel1
            // 
            this.hoursLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.shiftsBindingSource, "Hours", true));
            this.hoursLabel1.Location = new System.Drawing.Point(732, 183);
            this.hoursLabel1.Name = "hoursLabel1";
            this.hoursLabel1.Size = new System.Drawing.Size(44, 23);
            this.hoursLabel1.TabIndex = 48;
            this.hoursLabel1.Text = "label7";
            // 
            // fullNameTextBox
            // 
            this.fullNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.shiftsBindingSource, "FullName", true));
            this.fullNameTextBox.Location = new System.Drawing.Point(175, 87);
            this.fullNameTextBox.Name = "fullNameTextBox";
            this.fullNameTextBox.Size = new System.Drawing.Size(429, 20);
            this.fullNameTextBox.TabIndex = 49;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 487);
            this.Controls.Add(this.fullNameTextBox);
            this.Controls.Add(this.hoursLabel1);
            this.Controls.Add(this.shiftComboBox);
            this.Controls.Add(weekNoLabel);
            this.Controls.Add(this.weekNoLabel1);
            this.Controls.Add(this.shiftsBindingNavigator);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.FullNameLabel);
            this.Controls.Add(this.nightShift);
            this.Controls.Add(this.overtime);
            this.Controls.Add(this.monthlyHours);
            this.Controls.Add(this.currentHours);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.shiftCode);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.day6);
            this.Controls.Add(this.day5);
            this.Controls.Add(this.day4);
            this.Controls.Add(this.day3);
            this.Controls.Add(this.day2);
            this.Controls.Add(this.day1);
            this.Controls.Add(this.day0);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.labelNameDay6);
            this.Controls.Add(this.labelNameDay5);
            this.Controls.Add(this.labelNameDay4);
            this.Controls.Add(this.labelNameDay3);
            this.Controls.Add(this.labelNameDay2);
            this.Controls.Add(this.labelNameDay1);
            this.Controls.Add(this.labelNameDay0);
            this.Controls.Add(this.btnNextWeek);
            this.Controls.Add(this.weekTo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.weekFrom);
            this.Controls.Add(this.btnPreviousWeek);
            this.Controls.Add(this.Label1);
            this.Name = "Form1";
            this.Text = "Working time registration system";
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

        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Button btnPreviousWeek;
        private System.Windows.Forms.Label weekFrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label weekTo;
        private System.Windows.Forms.Button btnNextWeek;
        private System.Windows.Forms.Label labelNameDay0;
        private System.Windows.Forms.Label labelNameDay1;
        private System.Windows.Forms.Label labelNameDay2;
        private System.Windows.Forms.Label labelNameDay3;
        private System.Windows.Forms.Label labelNameDay4;
        private System.Windows.Forms.Label labelNameDay5;
        private System.Windows.Forms.Label labelNameDay6;
        private System.Windows.Forms.Label Total;
        private System.Windows.Forms.Label day0;
        private System.Windows.Forms.Label day1;
        private System.Windows.Forms.Label day2;
        private System.Windows.Forms.Label day3;
        private System.Windows.Forms.Label day4;
        private System.Windows.Forms.Label day5;
        private System.Windows.Forms.Label day6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label shiftCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label currentHours;
        private System.Windows.Forms.Label monthlyHours;
        private System.Windows.Forms.Label overtime;
        private System.Windows.Forms.Label nightShift;
        private System.Windows.Forms.Label FullNameLabel;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSave;
        private ModelDataSet modelDataSet;
        private System.Windows.Forms.BindingSource shiftsBindingSource;
        private ModelDataSetTableAdapters.ShiftsTableAdapter shiftsTableAdapter;
        private ModelDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator shiftsBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton shiftsBindingNavigatorSaveItem;
        private System.Windows.Forms.Label weekNoLabel1;
        private System.Windows.Forms.ComboBox shiftComboBox;
        private System.Windows.Forms.Label hoursLabel1;
        private System.Windows.Forms.TextBox fullNameTextBox;
    }
}

