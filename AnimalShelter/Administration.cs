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
    class Administration
    {
        List<Animal> listOfAnimals = new List<Animal>();
        public Administration()
        {            
        }

        public bool Add(Animal Animal)
        {
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
                    foreach (Animal removedAnimal in listOfAnimals)
                    {
                        if (removedAnimal == animal)
                        {
                            return false;
                        }
                        else
                        {
                            return true;
                        }
                    }
                }
                return true;
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
                else
                {
                    return null;
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
    }
}
