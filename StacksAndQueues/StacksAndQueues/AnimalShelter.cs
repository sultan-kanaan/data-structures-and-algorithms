using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacksAndQueues
{
    public class AnimalShelter
    {
        public Queue<Dog> Dogs { get; set; }
        public Queue<Cat> Cats { get; set; }

        public AnimalShelter()
        {
            Dogs = new Queue<Dog>();
            Cats = new Queue<Cat>();
        }

        public void Enqueue(Animal animal)
        {
            if (animal is Cat)
            {
                Cat cat = (Cat)animal;
                Cats.Enqueue(cat);
            }
            else if (animal is Dog)
            {
                Dog dog = (Dog)animal;
                Dogs.Enqueue(dog);
            }
        }
        public Animal Dequeue(string pref)
        {
            if (pref == "cat")
            
            return Cats.Dequeue();
            
            else if (pref == "dog")
            
            return Dogs.Dequeue();
            
            else
            
            return null;
        }

       
    }
}
