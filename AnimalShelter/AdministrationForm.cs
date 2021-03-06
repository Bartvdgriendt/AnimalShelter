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
// Vragen:
// Waarom werkt het builden en het draaien van de solution alleen als bij CPU wordt gekozen voor x86?
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

            Cat exampleCat = new Cat(10000, new SimpleDate(26, 04, 2019), "ExampleCat", false, "None");
            Cat exampleCat2 = new Cat(10001, new SimpleDate(03, 08, 2010), "ExampleCat2", false, "Aggressive");
            Dog exampleDog = new Dog(10002, new SimpleDate(01, 01, 2014), "ExampleDog", false, new SimpleDate(26, 04, 2018));
            administration.AddAnimal(exampleCat);
            administration.AddAnimal(exampleCat2);
            administration.AddAnimal(exampleDog);

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
                Dog dog = null;
                try
                {
                    dog = new Dog(chipRegistrationNumber, dateOfBirth, name, false, lastWalkedDate);
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

                try
                {
                    Cat cat = new Cat(chipRegistrationNumber, dateOfBirth, name, false, badHabits);
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
            if (lbNotReserved.SelectedIndex == -1)
            {
                int selectedchipnumber = Convert.ToInt32(lbReserved.SelectedItem);
                try
                {
                    MessageBox.Show(administration.FindAnimal(selectedchipnumber).ToString());
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
            else
            {
                int selectedchipnumber = Convert.ToInt32(lbNotReserved.SelectedItem);
                try
                {
                    MessageBox.Show(administration.FindAnimal(selectedchipnumber).ToString());
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }

        }

        private void animalTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbAnimalType.SelectedIndex == 1)
            {
                lBadHabitsOrLastWalkedDate.Text = "Last walked date";
                bAddAnimal.Location = new Point(184, 145);
                nudLastWalkedDay.Visible = true;
                nudLastWalkedMonth.Visible = true;
                nudLastWalkedYear.Visible = true;
                tbBadHabits.Visible = false;
            }
            else if (cbAnimalType.SelectedIndex == 0)
            {
                lBadHabitsOrLastWalkedDate.Text = "Bad habits";
                bAddAnimal.Location = new Point(184, 220);
                nudLastWalkedDay.Visible = false;
                nudLastWalkedMonth.Visible = false;
                nudLastWalkedYear.Visible = false;
                tbBadHabits.Visible = true;
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
                updateListboxes();
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
                updateListboxes();
            }
            else
            {
                MessageBox.Show("You haven't selected an animal.");
            }
        }

        private void bSearchByNumber_Click(object sender, EventArgs e)
        {
            Animal animal = null;

            int chipRegistrationNumber = Convert.ToInt32(tbSearchByChipRegistrationNumber.Text);
            try
            {
                animal = administration.FindAnimal(chipRegistrationNumber);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

            if (animal.IsReserved)
            {
                lbReserved.SelectedItem = animal.ChipRegistrationNumber;
                MessageBox.Show("Animal found and selected.");
            }
            else
            {
                lbNotReserved.SelectedItem = animal.ChipRegistrationNumber;
                MessageBox.Show("Animal founded and selected.");
            }
        }

        private void bReserve_Click(object sender, EventArgs e)
        {
            int chipRegistrationNumber = Convert.ToInt32(lbNotReserved.SelectedItem);

            try
            {
                Animal animal = administration.FindAnimal(chipRegistrationNumber);
                animal.IsReserved = true;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            updateListboxes();
        }

        private void bRelease_Click(object sender, EventArgs e)
        {
            int chipRegistrationNumber = Convert.ToInt32(lbReserved.SelectedItem);

            try
            {
                Animal animal = administration.FindAnimal(chipRegistrationNumber);
                animal.IsReserved = false;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            updateListboxes();
        }

        private void bCheckPrice_Click(object sender, EventArgs e)
        {
            int chipRegistrationNumber = Convert.ToInt32(nudCheckPriceByChipRegistrationNumber.Value);
            Animal animal = null;

            try
            {
                animal = administration.FindAnimal(chipRegistrationNumber);
                animal.IsReserved = false;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

            if (animal.IsReserved == true)
            {
                lbNotReserved.SelectedIndex = -1;
                lbReserved.SelectedItem = animal.ChipRegistrationNumber;
                MessageBox.Show(Convert.ToString(string.Format("This animal costs {0} euro's.", animal.price)));
            }
            else
            {
                lbReserved.SelectedIndex = -1;
                lbNotReserved.SelectedItem = animal.ChipRegistrationNumber;
                MessageBox.Show(Convert.ToString(string.Format("This animal costs {0} euro's.", animal.price)));
            }
        }

        private void bExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                FileName = "Animals " + DateTime.Now.ToString("dd/MM/yyyy"),
                Filter = "Text (*.txt)|*.txt"
            };
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    File.WriteAllLines(saveFileDialog.FileName, administration.generateSaveFile());
                }
                catch (DirectoryNotFoundException)
                {
                    MessageBox.Show("This path cannot be found. Make sure you enter a valid path.");
                }
                catch (PathTooLongException)
                {
                    MessageBox.Show("This path is too long. Please select an shorter path or rename your directory's to shorten your path.");
                }
            }
        }

        private void bImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (Path.GetExtension(openFileDialog.FileName) == ".txt")
                {
                    try
                    {
                        string[] animalImportLines = File.ReadAllLines(openFileDialog.FileName);
                        administration.importSaveFile(animalImportLines);
                    }
                    catch (DirectoryNotFoundException)
                    {
                        MessageBox.Show("This path cannot be found. Make sure you enter a valid path.");
                    }
                    catch (PathTooLongException)
                    {
                        MessageBox.Show("This path is too long. Please select an shorter path or rename your directory's to shorten your path.");
                    }
                    catch (FileNotFoundException)
                    {
                        MessageBox.Show("File not found. Make sure you select a valid file.");
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.Message);
                    }
                }
            }

            updateListboxes();
        }

        void clearForm()
        {
            foreach (Control control in this.Controls)
            {
                if (control.GetType() == typeof(TextBox))
                {
                    control.Text = "";
                }

                if (control.GetType() == typeof(NumericUpDown))
                {
                    NumericUpDown numericUpDown = (NumericUpDown)control;
                    numericUpDown.Value = numericUpDown.Minimum;
                }
            }
        }

        private void updateListboxes()
        {
            lbReserved.Items.Clear();
            lbNotReserved.Items.Clear();
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
    }
}
