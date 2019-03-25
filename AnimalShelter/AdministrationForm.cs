﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AnimalShelter
{
    public partial class AdministrationForm : Form
    {
        /// <summary>
        /// The (only) animal in this administration (for now....)
        /// </summary>
        private Animal animal;

        /// <summary>
        /// Creates the form for doing adminstrative tasks
        /// </summary>
        public AdministrationForm()
        {
            InitializeComponent();
            animalTypeComboBox.SelectedIndex = 0;
            animal = null;
        }

        /// <summary>
        /// Create an Animal object and store it in the administration.
        /// If "Dog" is selected in the animalTypeCombobox then a Dog object should be created.
        /// If "Cat" is selected in the animalTypeCombobox then a Cat object should be created.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void createAnimalButton_Click(object sender, EventArgs e)
        {
            int chipRegistrationNumber = Convert.ToInt32(nudChipRegistrationNumber.Value);
            int dobDay = Convert.ToInt32(nudDay.Value);
            int dobMonth = Convert.ToInt32(nudMonth.Value);
            int dobYear = Convert.ToInt32(nudYear.Value);
            SimpleDate dateOfBirth = new SimpleDate(dobDay, dobMonth, dobYear);
            string name = tbName.Text;            

            if (animalTypeComboBox.SelectedIndex == 1)
            {
                int lastWalkedDay = Convert.ToInt32(nudLastWalkedDay.Value);
                int lastWalkedMonth = Convert.ToInt32(nudLastWalkedMonth.Value);
                int lastWalkedYear = Convert.ToInt32(nudLastWalkedYear.Value);
                SimpleDate lastWalkedDate = new SimpleDate(lastWalkedDay, lastWalkedMonth, lastWalkedYear);
                animal = new Dog(chipRegistrationNumber, dateOfBirth, name, lastWalkedDate);
            }
            else if (animalTypeComboBox.SelectedIndex == 0) 
            {
                string badHabits = tbBadHabits.Text;
                animal = new Cat(chipRegistrationNumber, dateOfBirth, name, badHabits);
            }
            clearForm();
        }

        /// <summary>
        /// Show the info of the animal referenced by the 'animal' field. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void showInfoButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(animal.ToString());            
        }

        private void animalTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (animalTypeComboBox.SelectedIndex == 1)
            {
                lBadHabitsOrLastWalkedDate.Text = "Last walked date";
                nudLastWalkedDay.Visible = true;
                nudLastWalkedMonth.Visible = true;
                nudLastWalkedYear.Visible = true;
                tbBadHabits.Visible = false;
            }
            else if (animalTypeComboBox.SelectedIndex == 0)
            {
                lBadHabitsOrLastWalkedDate.Text = "Bad habits";
                nudLastWalkedDay.Visible = false;
                nudLastWalkedMonth.Visible = false;
                nudLastWalkedYear.Visible = false;
                tbBadHabits.Visible = true;
            }
        }

        void clearForm()
        {
            nudChipRegistrationNumber.Value = nudChipRegistrationNumber.Minimum;
            nudDay.Value = nudDay.Minimum;
            nudMonth.Value = nudMonth.Minimum;
            nudYear.Value = nudYear.Minimum;
            tbName.Text = "";
            nudLastWalkedDay.Value = nudLastWalkedDay.Minimum;
            nudLastWalkedMonth.Value = nudLastWalkedMonth.Minimum;
            nudLastWalkedYear.Value = nudLastWalkedYear.Minimum;
            tbBadHabits.Text = "";
        }
    }
}
