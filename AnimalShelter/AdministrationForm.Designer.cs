namespace AnimalShelter
{
    partial class AdministrationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.animalTypeComboBox = new System.Windows.Forms.ComboBox();
            this.createAnimalButton = new System.Windows.Forms.Button();
            this.showInfoButton = new System.Windows.Forms.Button();
            this.lChipRegistrationNumber = new System.Windows.Forms.Label();
            this.lName = new System.Windows.Forms.Label();
            this.lBadHabitsOrLastWalkedDate = new System.Windows.Forms.Label();
            this.lDateOfBirth = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbBadHabits = new System.Windows.Forms.TextBox();
            this.nudDay = new System.Windows.Forms.NumericUpDown();
            this.nudYear = new System.Windows.Forms.NumericUpDown();
            this.nudMonth = new System.Windows.Forms.NumericUpDown();
            this.nudChipRegistrationNumber = new System.Windows.Forms.NumericUpDown();
            this.nudLastWalkedMonth = new System.Windows.Forms.NumericUpDown();
            this.nudLastWalkedYear = new System.Windows.Forms.NumericUpDown();
            this.nudLastWalkedDay = new System.Windows.Forms.NumericUpDown();
            this.lbReserved = new System.Windows.Forms.ListBox();
            this.lbNotReserved = new System.Windows.Forms.ListBox();
            this.lReservedAnimals = new System.Windows.Forms.Label();
            this.lNotReserved = new System.Windows.Forms.Label();
            this.bDelete = new System.Windows.Forms.Button();
            this.bRelease = new System.Windows.Forms.Button();
            this.bReserve = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bSearchByNumber = new System.Windows.Forms.Button();
            this.tbSearchByNumber = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudChipRegistrationNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLastWalkedMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLastWalkedYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLastWalkedDay)).BeginInit();
            this.SuspendLayout();
            // 
            // animalTypeComboBox
            // 
            this.animalTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.animalTypeComboBox.FormattingEnabled = true;
            this.animalTypeComboBox.Items.AddRange(new object[] {
            "Cat",
            "Dog"});
            this.animalTypeComboBox.Location = new System.Drawing.Point(12, 12);
            this.animalTypeComboBox.Name = "animalTypeComboBox";
            this.animalTypeComboBox.Size = new System.Drawing.Size(121, 21);
            this.animalTypeComboBox.TabIndex = 0;
            this.animalTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.animalTypeComboBox_SelectedIndexChanged);
            // 
            // createAnimalButton
            // 
            this.createAnimalButton.Location = new System.Drawing.Point(139, 10);
            this.createAnimalButton.Name = "createAnimalButton";
            this.createAnimalButton.Size = new System.Drawing.Size(64, 23);
            this.createAnimalButton.TabIndex = 1;
            this.createAnimalButton.Text = "Create";
            this.createAnimalButton.UseVisualStyleBackColor = true;
            this.createAnimalButton.Click += new System.EventHandler(this.createAnimalButton_Click);
            // 
            // showInfoButton
            // 
            this.showInfoButton.Location = new System.Drawing.Point(209, 10);
            this.showInfoButton.Name = "showInfoButton";
            this.showInfoButton.Size = new System.Drawing.Size(75, 23);
            this.showInfoButton.TabIndex = 2;
            this.showInfoButton.Text = "Show info";
            this.showInfoButton.UseVisualStyleBackColor = true;
            this.showInfoButton.Click += new System.EventHandler(this.showInfoButton_Click);
            // 
            // lChipRegistrationNumber
            // 
            this.lChipRegistrationNumber.AutoSize = true;
            this.lChipRegistrationNumber.Location = new System.Drawing.Point(12, 42);
            this.lChipRegistrationNumber.Name = "lChipRegistrationNumber";
            this.lChipRegistrationNumber.Size = new System.Drawing.Size(120, 13);
            this.lChipRegistrationNumber.TabIndex = 3;
            this.lChipRegistrationNumber.Text = "Chip registration number";
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Location = new System.Drawing.Point(12, 94);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(35, 13);
            this.lName.TabIndex = 4;
            this.lName.Text = "Name";
            // 
            // lBadHabitsOrLastWalkedDate
            // 
            this.lBadHabitsOrLastWalkedDate.AutoSize = true;
            this.lBadHabitsOrLastWalkedDate.Location = new System.Drawing.Point(12, 120);
            this.lBadHabitsOrLastWalkedDate.Name = "lBadHabitsOrLastWalkedDate";
            this.lBadHabitsOrLastWalkedDate.Size = new System.Drawing.Size(59, 13);
            this.lBadHabitsOrLastWalkedDate.TabIndex = 5;
            this.lBadHabitsOrLastWalkedDate.Text = "Bad Habits";
            // 
            // lDateOfBirth
            // 
            this.lDateOfBirth.AutoSize = true;
            this.lDateOfBirth.Location = new System.Drawing.Point(12, 68);
            this.lDateOfBirth.Name = "lDateOfBirth";
            this.lDateOfBirth.Size = new System.Drawing.Size(65, 13);
            this.lDateOfBirth.TabIndex = 6;
            this.lDateOfBirth.Text = "Date of birth";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(184, 91);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(179, 20);
            this.tbName.TabIndex = 9;
            // 
            // tbBadHabits
            // 
            this.tbBadHabits.Location = new System.Drawing.Point(184, 117);
            this.tbBadHabits.Multiline = true;
            this.tbBadHabits.Name = "tbBadHabits";
            this.tbBadHabits.Size = new System.Drawing.Size(179, 101);
            this.tbBadHabits.TabIndex = 10;
            // 
            // nudDay
            // 
            this.nudDay.Location = new System.Drawing.Point(184, 66);
            this.nudDay.Name = "nudDay";
            this.nudDay.Size = new System.Drawing.Size(46, 20);
            this.nudDay.TabIndex = 11;
            // 
            // nudYear
            // 
            this.nudYear.Location = new System.Drawing.Point(290, 66);
            this.nudYear.Maximum = new decimal(new int[] {
            2019,
            0,
            0,
            0});
            this.nudYear.Minimum = new decimal(new int[] {
            1980,
            0,
            0,
            0});
            this.nudYear.Name = "nudYear";
            this.nudYear.Size = new System.Drawing.Size(73, 20);
            this.nudYear.TabIndex = 12;
            this.nudYear.Value = new decimal(new int[] {
            1980,
            0,
            0,
            0});
            // 
            // nudMonth
            // 
            this.nudMonth.Location = new System.Drawing.Point(238, 66);
            this.nudMonth.Name = "nudMonth";
            this.nudMonth.Size = new System.Drawing.Size(46, 20);
            this.nudMonth.TabIndex = 13;
            // 
            // nudChipRegistrationNumber
            // 
            this.nudChipRegistrationNumber.Location = new System.Drawing.Point(184, 42);
            this.nudChipRegistrationNumber.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudChipRegistrationNumber.Name = "nudChipRegistrationNumber";
            this.nudChipRegistrationNumber.Size = new System.Drawing.Size(179, 20);
            this.nudChipRegistrationNumber.TabIndex = 14;
            // 
            // nudLastWalkedMonth
            // 
            this.nudLastWalkedMonth.Location = new System.Drawing.Point(238, 118);
            this.nudLastWalkedMonth.Name = "nudLastWalkedMonth";
            this.nudLastWalkedMonth.Size = new System.Drawing.Size(46, 20);
            this.nudLastWalkedMonth.TabIndex = 17;
            this.nudLastWalkedMonth.Visible = false;
            // 
            // nudLastWalkedYear
            // 
            this.nudLastWalkedYear.Location = new System.Drawing.Point(290, 118);
            this.nudLastWalkedYear.Maximum = new decimal(new int[] {
            2019,
            0,
            0,
            0});
            this.nudLastWalkedYear.Minimum = new decimal(new int[] {
            1980,
            0,
            0,
            0});
            this.nudLastWalkedYear.Name = "nudLastWalkedYear";
            this.nudLastWalkedYear.Size = new System.Drawing.Size(73, 20);
            this.nudLastWalkedYear.TabIndex = 16;
            this.nudLastWalkedYear.Value = new decimal(new int[] {
            1980,
            0,
            0,
            0});
            this.nudLastWalkedYear.Visible = false;
            // 
            // nudLastWalkedDay
            // 
            this.nudLastWalkedDay.Location = new System.Drawing.Point(184, 118);
            this.nudLastWalkedDay.Name = "nudLastWalkedDay";
            this.nudLastWalkedDay.Size = new System.Drawing.Size(46, 20);
            this.nudLastWalkedDay.TabIndex = 15;
            this.nudLastWalkedDay.Visible = false;
            // 
            // lbReserved
            // 
            this.lbReserved.FormattingEnabled = true;
            this.lbReserved.Location = new System.Drawing.Point(380, 58);
            this.lbReserved.Name = "lbReserved";
            this.lbReserved.Size = new System.Drawing.Size(158, 160);
            this.lbReserved.TabIndex = 18;
            this.lbReserved.Click += new System.EventHandler(this.lbReserved_Click);
            // 
            // lbNotReserved
            // 
            this.lbNotReserved.FormattingEnabled = true;
            this.lbNotReserved.Location = new System.Drawing.Point(544, 58);
            this.lbNotReserved.Name = "lbNotReserved";
            this.lbNotReserved.Size = new System.Drawing.Size(158, 160);
            this.lbNotReserved.TabIndex = 19;
            this.lbNotReserved.Click += new System.EventHandler(this.lbNotReserved_Click);
            // 
            // lReservedAnimals
            // 
            this.lReservedAnimals.AutoSize = true;
            this.lReservedAnimals.Location = new System.Drawing.Point(377, 42);
            this.lReservedAnimals.Name = "lReservedAnimals";
            this.lReservedAnimals.Size = new System.Drawing.Size(94, 13);
            this.lReservedAnimals.TabIndex = 20;
            this.lReservedAnimals.Text = "Reserverd animals";
            // 
            // lNotReserved
            // 
            this.lNotReserved.AutoSize = true;
            this.lNotReserved.Location = new System.Drawing.Point(541, 42);
            this.lNotReserved.Name = "lNotReserved";
            this.lNotReserved.Size = new System.Drawing.Size(109, 13);
            this.lNotReserved.TabIndex = 21;
            this.lNotReserved.Text = "Not reserverd animals";
            // 
            // bDelete
            // 
            this.bDelete.Location = new System.Drawing.Point(461, 224);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(160, 23);
            this.bDelete.TabIndex = 22;
            this.bDelete.Text = "Delete";
            this.bDelete.UseVisualStyleBackColor = true;
            this.bDelete.Click += new System.EventHandler(this.bDelete_Click);
            // 
            // bRelease
            // 
            this.bRelease.Location = new System.Drawing.Point(380, 224);
            this.bRelease.Name = "bRelease";
            this.bRelease.Size = new System.Drawing.Size(75, 23);
            this.bRelease.TabIndex = 23;
            this.bRelease.Text = "Release";
            this.bRelease.UseVisualStyleBackColor = true;
            this.bRelease.Click += new System.EventHandler(this.bRelease_Click);
            // 
            // bReserve
            // 
            this.bReserve.Location = new System.Drawing.Point(627, 224);
            this.bReserve.Name = "bReserve";
            this.bReserve.Size = new System.Drawing.Size(75, 23);
            this.bReserve.TabIndex = 24;
            this.bReserve.Text = "Reserve";
            this.bReserve.UseVisualStyleBackColor = true;
            this.bReserve.Click += new System.EventHandler(this.bReserve_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(377, 252);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Search by chip registration number";
            // 
            // bSearchByNumber
            // 
            this.bSearchByNumber.Location = new System.Drawing.Point(380, 295);
            this.bSearchByNumber.Name = "bSearchByNumber";
            this.bSearchByNumber.Size = new System.Drawing.Size(322, 23);
            this.bSearchByNumber.TabIndex = 27;
            this.bSearchByNumber.Text = "Search";
            this.bSearchByNumber.UseVisualStyleBackColor = true;
            this.bSearchByNumber.Click += new System.EventHandler(this.bSearchByNumber_Click);
            // 
            // tbSearchByNumber
            // 
            this.tbSearchByNumber.Location = new System.Drawing.Point(380, 269);
            this.tbSearchByNumber.Name = "tbSearchByNumber";
            this.tbSearchByNumber.Size = new System.Drawing.Size(322, 20);
            this.tbSearchByNumber.TabIndex = 28;
            // 
            // AdministrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 455);
            this.Controls.Add(this.tbSearchByNumber);
            this.Controls.Add(this.bSearchByNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bReserve);
            this.Controls.Add(this.bRelease);
            this.Controls.Add(this.bDelete);
            this.Controls.Add(this.lNotReserved);
            this.Controls.Add(this.lReservedAnimals);
            this.Controls.Add(this.lbNotReserved);
            this.Controls.Add(this.lbReserved);
            this.Controls.Add(this.nudLastWalkedMonth);
            this.Controls.Add(this.nudLastWalkedYear);
            this.Controls.Add(this.nudLastWalkedDay);
            this.Controls.Add(this.nudChipRegistrationNumber);
            this.Controls.Add(this.nudMonth);
            this.Controls.Add(this.nudYear);
            this.Controls.Add(this.nudDay);
            this.Controls.Add(this.tbBadHabits);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lDateOfBirth);
            this.Controls.Add(this.lBadHabitsOrLastWalkedDate);
            this.Controls.Add(this.lName);
            this.Controls.Add(this.lChipRegistrationNumber);
            this.Controls.Add(this.showInfoButton);
            this.Controls.Add(this.createAnimalButton);
            this.Controls.Add(this.animalTypeComboBox);
            this.Name = "AdministrationForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.AdministrationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudChipRegistrationNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLastWalkedMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLastWalkedYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLastWalkedDay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox animalTypeComboBox;
        private System.Windows.Forms.Button createAnimalButton;
        private System.Windows.Forms.Button showInfoButton;
        private System.Windows.Forms.Label lChipRegistrationNumber;
        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.Label lBadHabitsOrLastWalkedDate;
        private System.Windows.Forms.Label lDateOfBirth;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbBadHabits;
        private System.Windows.Forms.NumericUpDown nudDay;
        private System.Windows.Forms.NumericUpDown nudYear;
        private System.Windows.Forms.NumericUpDown nudMonth;
        private System.Windows.Forms.NumericUpDown nudChipRegistrationNumber;
        private System.Windows.Forms.NumericUpDown nudLastWalkedMonth;
        private System.Windows.Forms.NumericUpDown nudLastWalkedYear;
        private System.Windows.Forms.NumericUpDown nudLastWalkedDay;
        private System.Windows.Forms.ListBox lbReserved;
        private System.Windows.Forms.ListBox lbNotReserved;
        private System.Windows.Forms.Label lReservedAnimals;
        private System.Windows.Forms.Label lNotReserved;
        private System.Windows.Forms.Button bDelete;
        private System.Windows.Forms.Button bRelease;
        private System.Windows.Forms.Button bReserve;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bSearchByNumber;
        private System.Windows.Forms.TextBox tbSearchByNumber;
    }
}

