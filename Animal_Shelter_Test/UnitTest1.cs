using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AnimalShelter;

namespace Animal_Shelter_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAddAnimal()
        {
            Administration administration = new Administration();

            int dobDay = 09;
            int dobMonth = 02;
            int dobYear = 2012;
            SimpleDate dateOfBirth = new SimpleDate(dobDay, dobMonth, dobYear);

            int lastWalkedDay =12 ;
            int lastWalkedMonth = 10;
            int lastWalkedYear = 2017;
            SimpleDate lastWalkedDate = new SimpleDate(lastWalkedDay, lastWalkedMonth, lastWalkedYear);

            int chipRegistrationNumber = 1;
            string name = "bobby";

            Dog dog1 = new Dog(chipRegistrationNumber, dateOfBirth, name, lastWalkedDate);
            bool result = administration.AddAnimal(dog1);
            int listcount = administration.listOfAnimals.Count;

            Assert.AreEqual(true, result);
            Assert.AreEqual(1, listcount);
        }

        [TestMethod]
        public void TestAddMoreAnimal()
        {
            Administration administration = new Administration();

            int dobDay = 09;
            int dobMonth = 02;
            int dobYear = 2012;
            SimpleDate dateOfBirth = new SimpleDate(dobDay, dobMonth, dobYear);

            int lastWalkedDay = 12;
            int lastWalkedMonth = 10;
            int lastWalkedYear = 2017;
            SimpleDate lastWalkedDate = new SimpleDate(lastWalkedDay, lastWalkedMonth, lastWalkedYear);
            string name = "bobby";
            int chipRegistrationNumber;
            for (int i =0; i<10; i++)
            {
            chipRegistrationNumber = i;
            Dog dog1 = new Dog(chipRegistrationNumber, dateOfBirth, name, lastWalkedDate);
            administration.AddAnimal(dog1);
            }
            int result = administration.listOfAnimals.Count;

            
            Assert.AreEqual(10, result);
        }

        [TestMethod]
        public void TestRemoveAnimal()
        {
            Administration administration = new Administration();

            int dobDay = 09;
            int dobMonth = 02;
            int dobYear = 2012;
            SimpleDate dateOfBirth = new SimpleDate(dobDay, dobMonth, dobYear);

            int lastWalkedDay = 12;
            int lastWalkedMonth = 10;
            int lastWalkedYear = 2017;
            SimpleDate lastWalkedDate = new SimpleDate(lastWalkedDay, lastWalkedMonth, lastWalkedYear);
            string name = "bobby";
            int chipRegistrationNumber;
            for (int i = 0; i < 10; i++)
            {
                chipRegistrationNumber = i;
                Dog dog1 = new Dog(chipRegistrationNumber, dateOfBirth, name, lastWalkedDate);
                administration.AddAnimal(dog1);
            }

            chipRegistrationNumber = 3;
            administration.RemoveAnimal(chipRegistrationNumber);


            int result = administration.listOfAnimals.Count;


            Assert.AreEqual(9, result);
        }

        [TestMethod]
        public void TestRemoveMoreAnimal()
        {
            Administration administration = new Administration();

            int dobDay = 09;
            int dobMonth = 02;
            int dobYear = 2012;
            SimpleDate dateOfBirth = new SimpleDate(dobDay, dobMonth, dobYear);

            int lastWalkedDay = 12;
            int lastWalkedMonth = 10;
            int lastWalkedYear = 2017;
            SimpleDate lastWalkedDate = new SimpleDate(lastWalkedDay, lastWalkedMonth, lastWalkedYear);
            string name = "bobby";
            int chipRegistrationNumber;
            for (int i = 0; i < 10; i++)
            {
                chipRegistrationNumber = i;
                Dog dog1 = new Dog(chipRegistrationNumber, dateOfBirth, name, lastWalkedDate);
                administration.AddAnimal(dog1);
            }

            chipRegistrationNumber = 3;
            for(int x = 0; x<4; x++)
            {
                administration.RemoveAnimal(chipRegistrationNumber);
                chipRegistrationNumber++;
            }


            int result = administration.listOfAnimals.Count;


            Assert.AreEqual(6, result);
        }

    }
}
