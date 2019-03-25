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
            this.lChipRegistrationNumber.Size = new System.Drawing.Size(122, 13);
            this.lChipRegistrationNumber.TabIndex = 3;
            this.lChipRegistrationNumber.Text = "Chip registration nummer";
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
            this.tbBadHabits.Size = new System.Drawing.Size(179, 96);
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
            // AdministrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 228);
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
    }
}

