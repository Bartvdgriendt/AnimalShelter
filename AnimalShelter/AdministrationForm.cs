﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

// Feedback:
// Op genoeg plaatsen excepties opgevangen?
// Waarom werkt het builden en het draaien van de solution alleen als bij CPU wordt gekozen voor x86?
// Vragen:

namespace AnimalShelter
{
    public partial class fAnimalshelter : Form
    {
        /// <summary>
        /// The (only) animal in this administration (for now....)
        /// </summary>
        Administration administration = new Administration();
        Compare cp = new Compare();

        /// <summary>
        /// Creates the form for doing adminstrative tasks
        /// </summary>
        public fAnimalshelter()
        {
            InitializeComponent();
            cbAnimalType.SelectedIndex = 0;
            Cat cat = new Cat(1, new SimpleDate(01, 01, 2019), "Cat", "Is alive");
            Cat cat2 = new Cat(9, new SimpleDate(01, 01, 2019), "Cat", "Is dead");
            Dog dog = new Dog(2, new SimpleDate(01, 01, 2019), "Dog", new SimpleDate(01, 01, 2018));
            administration.AddAnimal(cat);
            administration.AddAnimal(cat2);
            administration.AddAnimal(dog);
            updateListboxes();
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

            if (cbAnimalType.SelectedIndex == 1)
            {
                int lastWalkedDay = Convert.ToInt32(nudLastWalkedDay.Value);
                int lastWalkedMonth = Convert.ToInt32(nudLastWalkedMonth.Value);
                int lastWalkedYear = Convert.ToInt32(nudLastWalkedYear.Value);
                SimpleDate lastWalkedDate = new SimpleDate(lastWalkedDay, lastWalkedMonth, lastWalkedYear);
                Dog dog = new Dog(chipRegistrationNumber, dateOfBirth, name, lastWalkedDate);
                try
                {
                    administration.AddAnimal(dog);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);                    
                }
            }
            else if (cbAnimalType.SelectedIndex == 0)
            {

                string badHabits = tbBadHabits.Text;
                Cat cat = new Cat(chipRegistrationNumber, dateOfBirth, name, badHabits);
                try
                {
                    administration.AddAnimal(cat);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }                
            }
            clearForm();
            updateListboxes();
        }

        /// <summary>
        /// Show the info of the animal referenced by the 'animal' field. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void showInfoButton_Click(object sender, EventArgs e)
        {
            if (lbNotReserved.SelectedIndex == -1 && lbReserved.SelectedIndex == -1)
            {
                MessageBox.Show("Select a(n) chip regstration number");
            }
            else if (lbNotReserved.SelectedIndex == -1)
            {
                int selectedchipnumber = Convert.ToInt32(lbReserved.SelectedItem);
                MessageBox.Show(administration.FindAnimal(selectedchipnumber).ToString());
            }
            else
            {

                int selectedchipnumber = Convert.ToInt32(lbNotReserved.SelectedItem);
                MessageBox.Show(administration.FindAnimal(selectedchipnumber).ToString());
            }

        }

        private void animalTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbAnimalType.SelectedIndex == 1)
            {
                lBadHabitsOrLastWalkedDate.Text = "Last walked date";
                nudLastWalkedDay.Visible = true;
                nudLastWalkedMonth.Visible = true;
                nudLastWalkedYear.Visible = true;
                tbBadHabits.Visible = false;
                bCreateAnimal.Location=new Point(184,145);
            }
            else if (cbAnimalType.SelectedIndex == 0)
            {
                lBadHabitsOrLastWalkedDate.Text = "Bad habits";
                nudLastWalkedDay.Visible = false;
                nudLastWalkedMonth.Visible = false;
                nudLastWalkedYear.Visible = false;
                tbBadHabits.Visible = true;
                bCreateAnimal.Location =new Point(184, 220);
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

        private void updateListboxes()
        {
            lbReserved.Items.Clear();
            lbNotReserved.Items.Clear();
            tbSearchByChipRegistrationNumber.Text = " ";
            //Wat doet deze sort methode? 
            //reserverdAnimals.Sort(cp);
            //notReserverdAnimals.Sort(cp);

            foreach (Animal animal in administration.listOfAnimals)
            {
                if (animal.IsReserved)
                {
                    lbReserved.Items.Add(animal.ChipRegistrationNumber);
                }
                else
                {
                    lbNotReserved.Items.Add(animal.ChipRegistrationNumber);
                }
            }
        }



        private void lbReserved_Click(object sender, EventArgs e)
        {
            lbNotReserved.SelectedIndex = -1;
        }

        private void lbNotReserved_Click(object sender, EventArgs e)
        {
            lbReserved.SelectedIndex = -1;
        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            if (lbReserved.SelectedIndex > -1)
            {
                int registrationNumber = Convert.ToInt32(lbReserved.SelectedItem);
                try
                {
                    administration.RemoveAnimal(registrationNumber);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);   
                }
                
            }
            else if (lbNotReserved.SelectedIndex > -1)
            {
                int registrationNumber = Convert.ToInt32(lbNotReserved.SelectedItem);
                try
                {
                    administration.RemoveAnimal(registrationNumber);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("You haven't selected anything.");
            }
            updateListboxes();
        }

        private void bSearchByNumber_Click(object sender, EventArgs e)
        {
            int selectednumber = Convert.ToInt32(tbSearchByChipRegistrationNumber.Text);
            Animal selectedanimal = administration.FindAnimal(selectednumber);
            if (selectedanimal == null)
            {
                MessageBox.Show("Animal not found.");
                tbSearchByChipRegistrationNumber.Text = "";
            }
            else if (selectedanimal.IsReserved)
            {
                lbReserved.SelectedItem = selectedanimal.ChipRegistrationNumber;
                MessageBox.Show("Animal found and selected.");
            }
            else
            {
                lbNotReserved.SelectedItem = selectedanimal.ChipRegistrationNumber;
                MessageBox.Show("Animal founded and selected.");
            }
        }

        private void bReserve_Click(object sender, EventArgs e)
        {
            int selectedanimal = Convert.ToInt32(lbNotReserved.SelectedItem);
            if (selectedanimal <= 0)
            {
                MessageBox.Show("Selected a(n) animal to reserve");
            }
            else
            {
                Animal selectedAnimal = administration.FindAnimal(selectedanimal);
                selectedAnimal.IsReserved = true;
                updateListboxes();
            }
        }

        private void bRelease_Click(object sender, EventArgs e)
        {
            int selectedanimal = Convert.ToInt32(lbReserved.SelectedItem);
            if (selectedanimal <= 0)
            {
                MessageBox.Show("Selected a(n) animal to release");
            }
            else
            {
                Animal selectedAnimal = administration.FindAnimal(selectedanimal);
                selectedAnimal.IsReserved = false;
                updateListboxes();
            }
        }

        private void bCheckPrice_Click(object sender, EventArgs e)
        {
            int animalId = Convert.ToInt32(nudCheckPriceByChipRegistrationNumber.Value);
            Animal chosenAnimal = administration.FindAnimal(animalId);
            if (chosenAnimal.IsReserved == true)
            {
                lbNotReserved.SelectedIndex = -1;
                lbReserved.SelectedItem = chosenAnimal.ChipRegistrationNumber;
                MessageBox.Show(Convert.ToString(chosenAnimal.price));
                nudCheckPriceByChipRegistrationNumber.Value = 100000;
            }
            else
            {
                lbReserved.SelectedIndex = -1;
                lbNotReserved.SelectedItem = chosenAnimal.ChipRegistrationNumber;
                MessageBox.Show(Convert.ToString(chosenAnimal.price));
                nudCheckPriceByChipRegistrationNumber.Value = 100000;
            }
        }

        private void bExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllLines(saveFileDialog.FileName, administration.generateSaveFile());
            }
        }

        private void bImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            string[] animalImportLines = null;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                animalImportLines = File.ReadAllLines(openFileDialog.FileName);
            }

            administration.importSaveFile(animalImportLines);
            updateListboxes();
        }
    }
}
