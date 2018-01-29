using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToOOP
{
    class Dog
    {
        private string hairLength;
        private double height;
        private int runningSpeed;
        private double weight;
        private bool goToSleep = false;

        public string HairLength
        {
            get { return this.hairLength; }
        }


        public int RunningSpeed
        {
            get { return this.runningSpeed; }
            set { this.runningSpeed = value; }
        }




        public Dog()
        {
            //default constructor
        }

        public Dog(string hairLength, double height, int runningSpeed, double weight)
        {
            this.hairLength = hairLength;
            this.height = height;
            this.runningSpeed = runningSpeed;
            this.weight = weight;
        }

      
        public void Run()
        {
            runningSpeed = runningSpeed + 5;
            Console.WriteLine("The dog's running speed has increased to " + runningSpeed);
        }

        public void Bark()
        {
            Console.WriteLine("\a");
        }

        public void Potty()
        {
            weight = weight - 1;
            Console.WriteLine("The dog's weight is now " +weight);
        }

        public void Cuddle()
        {
            goToSleep = true;
            Console.WriteLine("Did the dog go to sleep? " + goToSleep);
        }

    }
}
