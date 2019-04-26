using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimalShelter
{
    public class Administration
    {
        public List<Animal> listOfAnimals = new List<Animal>();      
        
        public Administration()
        {                     
        }

        public void AddAnimal(Animal Animal)
        {
            foreach (Animal animal in listOfAnimals)
            {
                if (animal.ChipRegistrationNumber == Animal.ChipRegistrationNumber)
                {
                    throw new ChipRegistrationNumberAlreadyTakenException(string.Format("Chip registration number {0} is already taken. " +
                        "Please select an other chip registration number.", animal.ChipRegistrationNumber));
                }
            }
            listOfAnimals.Add(Animal);
        }

        public void RemoveAnimal(int chipRegistrationNumber)
        {
            listOfAnimals.Remove(FindAnimal(chipRegistrationNumber));
        }

        public Animal FindAnimal(int chipRegistrationNumber)
        {
            if (chipRegistrationNumber == 0)
            {
                throw new NoAnimalSelectedException("You haven't selected an animal, please select one.");
            }
            else
            {
               foreach (Animal animal in listOfAnimals)
               {
                    if (animal.ChipRegistrationNumber == chipRegistrationNumber)
                    {
                        return animal;
                    }
               }
                throw new NoAnimalFoundException(string.Format("We couldn't find a animal with chip registration number {0}. " +
                    "Are you sure you have entered a valid chip registration number?", chipRegistrationNumber));
            } 
        }

        public List<string> generateSaveFile()
        {
            List<string> SaveFile = new List<string>();
            SaveFile.Add("Type|Chip registration number|Date of birth|Name|Is reserved|Bad habits/Last walk date");

            foreach (Animal animal in listOfAnimals)
            {
                if (animal is Cat)
                {
                    Cat cat = animal as Cat;

                    string animalLine = "Cat|"+
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

                    string animalLine = "Dog|"+
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

        public void importSaveFile(string[] saveFile)
        {
            // simpleDate vervangen door dateTime indien we dat veranderen.
            for (int i = 1; i < saveFile.Length; i++)
            {
                string[] animalProperties = saveFile[i].Split('|');
                if (animalProperties[0] == "Cat")
                {
                    string[] date = animalProperties[2].Split('-');
                    int[] dateInIntes = Array.ConvertAll(date, int.Parse);
                    SimpleDate simpleDate = new SimpleDate(dateInIntes[0], dateInIntes[1], dateInIntes[2]);
                    try
                    {
                        Cat cat = new Cat(Convert.ToInt32(animalProperties[1]), simpleDate, animalProperties[3], Convert.ToBoolean(animalProperties[4]),animalProperties[5]);
                        AddAnimal(cat);
                    }
                    catch(Exception exception)
                    {
                        throw exception;
                    }
                }
                else if (animalProperties[0] == "Dog")
                {
                    string[] date = animalProperties[2].Split('-');
                    int[] dateInInts = Array.ConvertAll(date, int.Parse);
                    SimpleDate simpleDate = new SimpleDate(dateInInts[0], dateInInts[1], dateInInts[2]);

                    string[] lastWalkDate = animalProperties[2].Split('-');
                    int[] lastWalkDateInInts = Array.ConvertAll(lastWalkDate, int.Parse);
                    SimpleDate simpleLastWalkDateInt = new SimpleDate(lastWalkDateInInts[0], lastWalkDateInInts[1], lastWalkDateInInts[2]);

                    Dog dog = new Dog(Convert.ToInt32(animalProperties[1]), simpleDate, animalProperties[3],Convert.ToBoolean(animalProperties[4]), simpleLastWalkDateInt);
                    AddAnimal(dog);
                }
                else
                {
                    throw new ImportFileNotValidException("Import file is not valid and can not be loaded.");
                }
            }             
        }

        public class ChipRegistrationNumberAlreadyTakenException : Exception
        {
            public ChipRegistrationNumberAlreadyTakenException(string message)
               : base(message)
            {
            }
        }

        public class NoAnimalFoundException : Exception
        {
            public NoAnimalFoundException(string message)
               : base(message)
            {
            }
        }

        public class NoAnimalSelectedException : Exception
        {
            public NoAnimalSelectedException(string message)
               : base(message)
            {
            }
        }

        public class ImportFileNotValidException : Exception
        {
            public ImportFileNotValidException(string message)
               : base(message)
            {
            }
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
