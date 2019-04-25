using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// FEEDBACK:
// Lijst instantieren in constructor of daarboven?
// Hoe checken of toevoegen aan lijst succesvol is?
// Methode om animal te verwijderen en methode om animal te zoeken: returns onlogisch

namespace AnimalShelter
{
    public class Administration
    {
        public List<Animal> listOfAnimals = new List<Animal>();
      
        
        public Administration()
        {
            
        }

        public bool Add(Animal Animal)
        {
            foreach (Animal animal in listOfAnimals)
            {
                if (animal.ChipRegistrationNumber == Animal.ChipRegistrationNumber)
                {
                    return false;
                }
            }
            listOfAnimals.Add(Animal);

            if (listOfAnimals.Contains(Animal))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool RemoveAnimal(int chipRegistrationNumber)
        {


            foreach (Animal animal in listOfAnimals)
            {
                if (animal.ChipRegistrationNumber == chipRegistrationNumber)
                {
                    listOfAnimals.Remove(animal);
                    return true;
                }
            }
            return false;
        }

        public Animal FindAnimal(int chipRegistrationNumber)
        {
            foreach (Animal animal in listOfAnimals)
            {
                if (animal.ChipRegistrationNumber == chipRegistrationNumber)
                {
                    return animal;
                }
            }
            return null;
        }

        public Tuple<List<Animal>, List<Animal>> getReservedAnimals()
        {
            List<Animal> ReservedAnimal = new List<Animal>();
            List<Animal> notReserverdAnimal = new List<Animal>();
            

            foreach (Animal animal in listOfAnimals)
            {
                if (animal.IsReserved)
                {
                    ReservedAnimal.Add(animal);
                }
                else
                {
                    notReserverdAnimal.Add(animal);
                }
            }
            return new Tuple<List<Animal>, List<Animal>>(ReservedAnimal, notReserverdAnimal);
        }

        public Animal ShowInfo(int chipnumber)
        {
            foreach (Animal animal in listOfAnimals)
            {
                if (animal.ChipRegistrationNumber == chipnumber)
                {
                    return animal;
                }
            }
            return null;
        }
        public List<string> generateSaveFile()
        {
            List<string> SaveFile = new List<string>();

            string animalLine;

            foreach (Animal animal in listOfAnimals)
            {
                if (animal is Cat)
                {
                    Cat cat = animal as Cat;

                    animalLine =        "Cat|"+
                                        cat.ChipRegistrationNumber.ToString() + "|"+
                                        cat.DateOfBirth.ToString() + "|" +
                                        cat.Name.ToString() + "|" +
                                        cat.IsReserved.ToString() + "|" +
                                        cat.BadHabits.ToString();
                    SaveFile.Add(animalLine);
                }
                else
                {
                    Dog dog = animal as Dog;

                    animalLine =        "Dog|"+
                                        dog.ChipRegistrationNumber.ToString() + "|"+
                                        dog.DateOfBirth.ToString() + "|" +
                                        dog.Name.ToString() + "|" +
                                        dog.IsReserved.ToString() + "|" +
                                        dog.LastWalkDate.ToString();
                    SaveFile.Add(animalLine);
                }
            }

            return SaveFile;
        }

        public bool importSaveFile(string[] lineArray)
        {
            foreach (string line in lineArray)
            {
                string[] animalProperties = line.Split('|');
                if (animalProperties[0] == "Cat")
                {
                    string[] date = animalProperties[2].Split('-');
                    int[] dateInt = Array.ConvertAll(date, int.Parse);
                    SimpleDate simpleDate = new SimpleDate(dateInt[0], dateInt[1], dateInt[2]);
                    Cat cat = new Cat(Convert.ToInt32(animalProperties[1]), simpleDate, animalProperties[3], animalProperties[4]);
                    Add(cat);
                }
                else if (animalProperties[0] == "Dog")
                {
                    string[] date = animalProperties[2].Split('-');
                    int[] dateInt = Array.ConvertAll(date, int.Parse);
                    SimpleDate simpleDate = new SimpleDate(dateInt[0], dateInt[1], dateInt[2]);

                    string[] lastWalkDate = animalProperties[2].Split('-');
                    int[] lastWalkDateInt = Array.ConvertAll(lastWalkDate, int.Parse);
                    SimpleDate simpleLastWalkDateInt = new SimpleDate(dateInt[0], dateInt[1], dateInt[2]);

                    Dog dog = new Dog(Convert.ToInt32(animalProperties[1]), simpleDate, animalProperties[3], simpleLastWalkDateInt);
                    Add(dog);
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
    }

    class Compare : IComparer<Animal>
    {
        int IComparer<Animal>.Compare(Animal x, Animal y)
        {
            if (x.ChipRegistrationNumber > y.ChipRegistrationNumber)
            {
                return 1;
            }
            else if(x.ChipRegistrationNumber == y.ChipRegistrationNumber)
            {
                return 0;
            }
            else if (x.ChipRegistrationNumber < y.ChipRegistrationNumber)
            {
                return -1;
            }
            else
            {
                throw new NotImplementedException();
            }
        }
    }




}
