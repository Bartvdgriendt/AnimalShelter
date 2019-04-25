namespace AnimalShelter
{
    partial class fAnimalshelter
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
            this.cbAnimalType = new System.Windows.Forms.ComboBox();
            this.bAddAnimal = new System.Windows.Forms.Button();
            this.bShowInfo = new System.Windows.Forms.Button();
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
            this.lSearchByChipRegistrationNumber = new System.Windows.Forms.Label();
            this.bSearchByChipRegistrationNumber = new System.Windows.Forms.Button();
            this.tbSearchByChipRegistrationNumber = new System.Windows.Forms.TextBox();
            this.bCheckPrice = new System.Windows.Forms.Button();
            this.lCheckPriceWithChipRegistrationNumber = new System.Windows.Forms.Label();
            this.bExportData = new System.Windows.Forms.Button();
            this.bImportData = new System.Windows.Forms.Button();
            this.nudCheckPriceByChipRegistrationNumber = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudChipRegistrationNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLastWalkedMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLastWalkedYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLastWalkedDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCheckPriceByChipRegistrationNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // cbAnimalType
            // 
            this.cbAnimalType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAnimalType.FormattingEnabled = true;
            this.cbAnimalType.Items.AddRange(new object[] {
            "Cat",
            "Dog"});
            this.cbAnimalType.Location = new System.Drawing.Point(12, 12);
            this.cbAnimalType.Name = "cbAnimalType";
            this.cbAnimalType.Size = new System.Drawing.Size(351, 21);
            this.cbAnimalType.TabIndex = 0;
            this.cbAnimalType.SelectedIndexChanged += new System.EventHandler(this.animalTypeComboBox_SelectedIndexChanged);
            // 
            // bAddAnimal
            // 
            this.bAddAnimal.Location = new System.Drawing.Point(184, 220);
            this.bAddAnimal.Name = "bAddAnimal";
            this.bAddAnimal.Size = new System.Drawing.Size(179, 23);
            this.bAddAnimal.TabIndex = 1;
            this.bAddAnimal.Text = "Add animal to shelter";
            this.bAddAnimal.UseVisualStyleBackColor = true;
            this.bAddAnimal.Click += new System.EventHandler(this.createAnimalButton_Click);
            // 
            // bShowInfo
            // 
            this.bShowInfo.Location = new System.Drawing.Point(380, 12);
            this.bShowInfo.Name = "bShowInfo";
            this.bShowInfo.Size = new System.Drawing.Size(322, 23);
            this.bShowInfo.TabIndex = 2;
            this.bShowInfo.Text = "Show info";
            this.bShowInfo.UseVisualStyleBackColor = true;
            this.bShowInfo.Click += new System.EventHandler(this.showInfoButton_Click);
            // 
            // lChipRegistrationNumber
            // 
            this.lChipRegistrationNumber.AutoSize = true;
            this.lChipRegistrationNumber.Location = new System.Drawing.Point(12, 43);
            this.lChipRegistrationNumber.Name = "lChipRegistrationNumber";
            this.lChipRegistrationNumber.Size = new System.Drawing.Size(120, 13);
            this.lChipRegistrationNumber.TabIndex = 3;
            this.lChipRegistrationNumber.Text = "Chip registration number";
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Location = new System.Drawing.Point(12, 96);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(35, 13);
            this.lName.TabIndex = 4;
            this.lName.Text = "Name";
            // 
            // lBadHabitsOrLastWalkedDate
            // 
            this.lBadHabitsOrLastWalkedDate.AutoSize = true;
            this.lBadHabitsOrLastWalkedDate.Location = new System.Drawing.Point(12, 122);
            this.lBadHabitsOrLastWalkedDate.Name = "lBadHabitsOrLastWalkedDate";
            this.lBadHabitsOrLastWalkedDate.Size = new System.Drawing.Size(59, 13);
            this.lBadHabitsOrLastWalkedDate.TabIndex = 5;
            this.lBadHabitsOrLastWalkedDate.Text = "Bad Habits";
            // 
            // lDateOfBirth
            // 
            this.lDateOfBirth.AutoSize = true;
            this.lDateOfBirth.Location = new System.Drawing.Point(12, 69);
            this.lDateOfBirth.Name = "lDateOfBirth";
            this.lDateOfBirth.Size = new System.Drawing.Size(65, 13);
            this.lDateOfBirth.TabIndex = 6;
            this.lDateOfBirth.Text = "Date of birth";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(184, 93);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(179, 20);
            this.tbName.TabIndex = 7;
            // 
            // tbBadHabits
            // 
            this.tbBadHabits.Location = new System.Drawing.Point(184, 119);
            this.tbBadHabits.Multiline = true;
            this.tbBadHabits.Name = "tbBadHabits";
            this.tbBadHabits.Size = new System.Drawing.Size(179, 95);
            this.tbBadHabits.TabIndex = 11;
            // 
            // nudDay
            // 
            this.nudDay.Location = new System.Drawing.Point(184, 67);
            this.nudDay.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.nudDay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDay.Name = "nudDay";
            this.nudDay.Size = new System.Drawing.Size(48, 20);
            this.nudDay.TabIndex = 4;
            this.nudDay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudYear
            // 
            this.nudYear.Location = new System.Drawing.Point(290, 67);
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
            this.nudYear.TabIndex = 6;
            this.nudYear.Value = new decimal(new int[] {
            1980,
            0,
            0,
            0});
            // 
            // nudMonth
            // 
            this.nudMonth.Location = new System.Drawing.Point(238, 67);
            this.nudMonth.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nudMonth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMonth.Name = "nudMonth";
            this.nudMonth.Size = new System.Drawing.Size(46, 20);
            this.nudMonth.TabIndex = 5;
            this.nudMonth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudChipRegistrationNumber
            // 
            this.nudChipRegistrationNumber.Location = new System.Drawing.Point(184, 41);
            this.nudChipRegistrationNumber.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nudChipRegistrationNumber.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudChipRegistrationNumber.Name = "nudChipRegistrationNumber";
            this.nudChipRegistrationNumber.Size = new System.Drawing.Size(179, 20);
            this.nudChipRegistrationNumber.TabIndex = 3;
            this.nudChipRegistrationNumber.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // nudLastWalkedMonth
            // 
            this.nudLastWalkedMonth.Location = new System.Drawing.Point(238, 119);
            this.nudLastWalkedMonth.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nudLastWalkedMonth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudLastWalkedMonth.Name = "nudLastWalkedMonth";
            this.nudLastWalkedMonth.Size = new System.Drawing.Size(46, 20);
            this.nudLastWalkedMonth.TabIndex = 9;
            this.nudLastWalkedMonth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudLastWalkedMonth.Visible = false;
            // 
            // nudLastWalkedYear
            // 
            this.nudLastWalkedYear.Location = new System.Drawing.Point(290, 119);
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
            this.nudLastWalkedYear.TabIndex = 10;
            this.nudLastWalkedYear.Value = new decimal(new int[] {
            1980,
            0,
            0,
            0});
            this.nudLastWalkedYear.Visible = false;
            // 
            // nudLastWalkedDay
            // 
            this.nudLastWalkedDay.Location = new System.Drawing.Point(184, 119);
            this.nudLastWalkedDay.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.nudLastWalkedDay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudLastWalkedDay.Name = "nudLastWalkedDay";
            this.nudLastWalkedDay.Size = new System.Drawing.Size(48, 20);
            this.nudLastWalkedDay.TabIndex = 8;
            this.nudLastWalkedDay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudLastWalkedDay.Visible = false;
            // 
            // lbReserved
            // 
            this.lbReserved.FormattingEnabled = true;
            this.lbReserved.Location = new System.Drawing.Point(380, 54);
            this.lbReserved.Name = "lbReserved";
            this.lbReserved.Size = new System.Drawing.Size(158, 134);
            this.lbReserved.TabIndex = 18;
            this.lbReserved.Click += new System.EventHandler(this.lbReserved_Click);
            // 
            // lbNotReserved
            // 
            this.lbNotReserved.FormattingEnabled = true;
            this.lbNotReserved.Location = new System.Drawing.Point(544, 54);
            this.lbNotReserved.Name = "lbNotReserved";
            this.lbNotReserved.Size = new System.Drawing.Size(158, 134);
            this.lbNotReserved.TabIndex = 19;
            this.lbNotReserved.Click += new System.EventHandler(this.lbNotReserved_Click);
            // 
            // lReservedAnimals
            // 
            this.lReservedAnimals.AutoSize = true;
            this.lReservedAnimals.Location = new System.Drawing.Point(377, 38);
            this.lReservedAnimals.Name = "lReservedAnimals";
            this.lReservedAnimals.Size = new System.Drawing.Size(91, 13);
            this.lReservedAnimals.TabIndex = 20;
            this.lReservedAnimals.Text = "Reserved animals";
            // 
            // lNotReserved
            // 
            this.lNotReserved.AutoSize = true;
            this.lNotReserved.Location = new System.Drawing.Point(541, 38);
            this.lNotReserved.Name = "lNotReserved";
            this.lNotReserved.Size = new System.Drawing.Size(109, 13);
            this.lNotReserved.TabIndex = 21;
            this.lNotReserved.Text = "Not reserverd animals";
            // 
            // bDelete
            // 
            this.bDelete.Location = new System.Drawing.Point(461, 194);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(160, 23);
            this.bDelete.TabIndex = 22;
            this.bDelete.Text = "Delete";
            this.bDelete.UseVisualStyleBackColor = true;
            this.bDelete.Click += new System.EventHandler(this.bDelete_Click);
            // 
            // bRelease
            // 
            this.bRelease.Location = new System.Drawing.Point(380, 194);
            this.bRelease.Name = "bRelease";
            this.bRelease.Size = new System.Drawing.Size(75, 23);
            this.bRelease.TabIndex = 23;
            this.bRelease.Text = "Release";
            this.bRelease.UseVisualStyleBackColor = true;
            this.bRelease.Click += new System.EventHandler(this.bRelease_Click);
            // 
            // bReserve
            // 
            this.bReserve.Location = new System.Drawing.Point(627, 194);
            this.bReserve.Name = "bReserve";
            this.bReserve.Size = new System.Drawing.Size(75, 23);
            this.bReserve.TabIndex = 24;
            this.bReserve.Text = "Reserve";
            this.bReserve.UseVisualStyleBackColor = true;
            this.bReserve.Click += new System.EventHandler(this.bReserve_Click);
            // 
            // lSearchByChipRegistrationNumber
            // 
            this.lSearchByChipRegistrationNumber.AutoSize = true;
            this.lSearchByChipRegistrationNumber.Location = new System.Drawing.Point(377, 220);
            this.lSearchByChipRegistrationNumber.Name = "lSearchByChipRegistrationNumber";
            this.lSearchByChipRegistrationNumber.Size = new System.Drawing.Size(170, 13);
            this.lSearchByChipRegistrationNumber.TabIndex = 26;
            this.lSearchByChipRegistrationNumber.Text = "Search by chip registration number";
            // 
            // bSearchByChipRegistrationNumber
            // 
            this.bSearchByChipRegistrationNumber.Location = new System.Drawing.Point(380, 262);
            this.bSearchByChipRegistrationNumber.Name = "bSearchByChipRegistrationNumber";
            this.bSearchByChipRegistrationNumber.Size = new System.Drawing.Size(322, 23);
            this.bSearchByChipRegistrationNumber.TabIndex = 27;
            this.bSearchByChipRegistrationNumber.Text = "Search";
            this.bSearchByChipRegistrationNumber.UseVisualStyleBackColor = true;
            this.bSearchByChipRegistrationNumber.Click += new System.EventHandler(this.bSearchByNumber_Click);
            // 
            // tbSearchByChipRegistrationNumber
            // 
            this.tbSearchByChipRegistrationNumber.Location = new System.Drawing.Point(380, 236);
            this.tbSearchByChipRegistrationNumber.Name = "tbSearchByChipRegistrationNumber";
            this.tbSearchByChipRegistrationNumber.Size = new System.Drawing.Size(322, 20);
            this.tbSearchByChipRegistrationNumber.TabIndex = 28;
            // 
            // bCheckPrice
            // 
            this.bCheckPrice.Location = new System.Drawing.Point(15, 291);
            this.bCheckPrice.Name = "bCheckPrice";
            this.bCheckPrice.Size = new System.Drawing.Size(348, 23);
            this.bCheckPrice.TabIndex = 29;
            this.bCheckPrice.Text = "Check price";
            this.bCheckPrice.UseVisualStyleBackColor = true;
            this.bCheckPrice.Click += new System.EventHandler(this.bCheckPrice_Click);
            // 
            // lCheckPriceWithChipRegistrationNumber
            // 
            this.lCheckPriceWithChipRegistrationNumber.AutoSize = true;
            this.lCheckPriceWithChipRegistrationNumber.Location = new System.Drawing.Point(12, 249);
            this.lCheckPriceWithChipRegistrationNumber.Name = "lCheckPriceWithChipRegistrationNumber";
            this.lCheckPriceWithChipRegistrationNumber.Size = new System.Drawing.Size(218, 13);
            this.lCheckPriceWithChipRegistrationNumber.TabIndex = 31;
            this.lCheckPriceWithChipRegistrationNumber.Text = "Enter chip registration number to check price";
            // 
            // bExportData
            // 
            this.bExportData.Location = new System.Drawing.Point(552, 291);
            this.bExportData.Name = "bExportData";
            this.bExportData.Size = new System.Drawing.Size(150, 23);
            this.bExportData.TabIndex = 32;
            this.bExportData.Text = "Export data";
            this.bExportData.UseVisualStyleBackColor = true;
            this.bExportData.Click += new System.EventHandler(this.bExport_Click);
            // 
            // bImportData
            // 
            this.bImportData.Location = new System.Drawing.Point(380, 291);
            this.bImportData.Name = "bImportData";
            this.bImportData.Size = new System.Drawing.Size(150, 23);
            this.bImportData.TabIndex = 33;
            this.bImportData.Text = "Import data";
            this.bImportData.UseVisualStyleBackColor = true;
            this.bImportData.Click += new System.EventHandler(this.bImport_Click);
            // 
            // nudCheckPriceByChipRegistrationNumber
            // 
            this.nudCheckPriceByChipRegistrationNumber.Location = new System.Drawing.Point(15, 265);
            this.nudCheckPriceByChipRegistrationNumber.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nudCheckPriceByChipRegistrationNumber.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudCheckPriceByChipRegistrationNumber.Name = "nudCheckPriceByChipRegistrationNumber";
            this.nudCheckPriceByChipRegistrationNumber.Size = new System.Drawing.Size(348, 20);
            this.nudCheckPriceByChipRegistrationNumber.TabIndex = 34;
            this.nudCheckPriceByChipRegistrationNumber.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // fAnimalshelter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 326);
            this.Controls.Add(this.nudCheckPriceByChipRegistrationNumber);
            this.Controls.Add(this.bImportData);
            this.Controls.Add(this.bExportData);
            this.Controls.Add(this.lCheckPriceWithChipRegistrationNumber);
            this.Controls.Add(this.bCheckPrice);
            this.Controls.Add(this.tbSearchByChipRegistrationNumber);
            this.Controls.Add(this.bSearchByChipRegistrationNumber);
            this.Controls.Add(this.lSearchByChipRegistrationNumber);
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
            this.Controls.Add(this.bShowInfo);
            this.Controls.Add(this.bAddAnimal);
            this.Controls.Add(this.cbAnimalType);
            this.Name = "fAnimalshelter";
            this.Text = "Animalshelter";
            ((System.ComponentModel.ISupportInitialize)(this.nudDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudChipRegistrationNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLastWalkedMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLastWalkedYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLastWalkedDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCheckPriceByChipRegistrationNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbAnimalType;
        private System.Windows.Forms.Button bAddAnimal;
        private System.Windows.Forms.Button bShowInfo;
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
        private System.Windows.Forms.Label lSearchByChipRegistrationNumber;
        private System.Windows.Forms.Button bSearchByChipRegistrationNumber;
        private System.Windows.Forms.TextBox tbSearchByChipRegistrationNumber;
        private System.Windows.Forms.Button bCheckPrice;
        private System.Windows.Forms.Label lCheckPriceWithChipRegistrationNumber;
        private System.Windows.Forms.Button bExportData;
        private System.Windows.Forms.Button bImportData;
        private System.Windows.Forms.NumericUpDown nudCheckPriceByChipRegistrationNumber;
    }
}

