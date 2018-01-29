using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToOOP
{
    class Cat
    {
        //I need STATES

        //fields
        private string name;
        private int age;
        private string furColor;
        private bool isHungry = true;
        private string hairLength; 

        //properties
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }

        }

        public string HairLength
        {
            get { return this.hairLength; }
            set { this.hairLength = value; }
        }


        //I need BEHAVIORS

        //consturctors
        public Cat()
        {
            //default constructor
            //takes no parameters (nothing in parentheses)
        }

        public Cat(string name, int age, string furColor)
        {
            this.name = name;
            this.age = age;
            this.furColor = furColor;
        }


        //methods
        //if isHungry is set to true, changes isHungry to false, hence the EAT method
        public void Eat(string food)
        {
            if (isHungry)
            {
                isHungry = false;
            }

            Console.WriteLine("The cat ate " + food + ". Is the cat hungry? " + isHungry);
        }

        public void Meow()
        { 
        Console.WriteLine("\a");
        }


        public string Hairball()
        {
            if(hairLength == "too long")
            {
                return (this.name + " has a hairball.");
            }
            else
            {
                return (this.name + " is nicely groomed.");
            }
        }
    }


}
