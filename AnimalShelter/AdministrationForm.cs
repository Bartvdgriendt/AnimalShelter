using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace AnimalShelter
{
    public partial class AdministrationForm : Form
    {
        /// <summary>
        /// The (only) animal in this administration (for now....)
        /// </summary>
        Administration administration = new Administration();
        Compare cp = new Compare();

        /// <summary>
        /// Creates the form for doing adminstrative tasks
        /// </summary>
        public AdministrationForm()
        {
            InitializeComponent();
            animalTypeComboBox.SelectedIndex = 0;
            Cat cat = new Cat(1, new SimpleDate(01, 01, 2019), "Cat", "Is alive");
            Cat cat2 = new Cat(9, new SimpleDate(01, 01, 2019), "Cat", "Is dead");
            Dog dog = new Dog(2, new SimpleDate(01, 01, 2019), "Dog", new SimpleDate(01, 01, 2018));
            administration.Add(cat);
            administration.Add(cat2);
            administration.Add(dog);
            updateListboxes();
        }
        private void AdministrationForm_Load(object sender, EventArgs e)
        {
            lbNotReserved.SelectedIndex = 0;
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
                Dog dog = new Dog(chipRegistrationNumber, dateOfBirth, name, lastWalkedDate);
                if (!administration.Add(dog))
                {
                    MessageBox.Show("Chip registration number is already used.");
                }
            }
            else if (animalTypeComboBox.SelectedIndex == 0)
            {

                string badHabits = tbBadHabits.Text;
                Cat cat = new Cat(chipRegistrationNumber, dateOfBirth, name, badHabits);
                if (!administration.Add(cat))
                {
                    MessageBox.Show("Chip registration number is already used.");
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
                MessageBox.Show(administration.ShowInfo(selectedchipnumber).ToString());
            }
            else
            {

                int selectedchipnumber = Convert.ToInt32(lbNotReserved.SelectedItem);
                MessageBox.Show(administration.ShowInfo(selectedchipnumber).ToString());
            }

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

        private void updateListboxes()
        {
            lbReserved.Items.Clear();
            lbNotReserved.Items.Clear();
            tbSearchByNumber.Text = " ";
            List<Animal> reserverdAnimals = administration.getReservedAnimals().Item1;
            List<Animal> notReserverdAnimals = administration.getReservedAnimals().Item2;
            reserverdAnimals.Sort(cp);
            notReserverdAnimals.Sort(cp);

            foreach (Animal animal in reserverdAnimals)
            {
                lbReserved.Items.Add(animal.ChipRegistrationNumber);
            }
            foreach (Animal animal in notReserverdAnimals)
            {
                lbNotReserved.Items.Add(animal.ChipRegistrationNumber);
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
                administration.RemoveAnimal(registrationNumber);
            }
            else if (lbNotReserved.SelectedIndex > -1)
            {
                int registrationNumber = Convert.ToInt32(lbNotReserved.SelectedItem);
                administration.RemoveAnimal(registrationNumber);
            }
            else
            {
                MessageBox.Show("You haven't selected anything.");
            }
            updateListboxes();
        }

        private void bSearchByNumber_Click(object sender, EventArgs e)
        {
            int selectednumber = Convert.ToInt32(tbSearchByNumber.Text);
            Animal selectedanimal = administration.FindAnimal(selectednumber);
            if (selectedanimal == null)
            {
                MessageBox.Show("Animal not found.");
                tbSearchByNumber.Text = "";
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
            int animalId = Convert.ToInt32(tbCheckPrice.Text);
            Animal chosenAnimal = administration.FindAnimal(animalId);
            if (chosenAnimal.IsReserved == true)
            {
                lbNotReserved.SelectedIndex = -1;
                lbReserved.SelectedItem = chosenAnimal.ChipRegistrationNumber;
                MessageBox.Show(Convert.ToString(chosenAnimal.price));
                tbCheckPrice.Text = "";
            }
            else
            {
                lbReserved.SelectedIndex = -1;
                lbNotReserved.SelectedItem = chosenAnimal.ChipRegistrationNumber;
                MessageBox.Show(Convert.ToString(chosenAnimal.price));
                tbCheckPrice.Text = "";
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
    }
}
