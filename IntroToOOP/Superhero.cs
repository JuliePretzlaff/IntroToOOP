using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToOOP
{
    class Superhero
    {
        //fields
        private string name;
        private string power;
        private string weakness;
        private int speed;
        private int powerLevel;

        //properties
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public string Power
        {
            get { return this.power; }
            set { this.power = value; }
        }

        public string Weakness
        {
            get { return this.weakness; }
            set { this.weakness = value; }
        }

        public int Speed
        {
            get { return this.speed; }
            set { this.speed = value; }
        }

        public int PowerLevel
        {
            get { return this.powerLevel; }
            set { this.powerLevel = value; }
        }


        //constructors
        public Superhero()
        {
            //default constructor
        }


        public Superhero(string name)
        {
            this.name = name; 
        }

        public Superhero(string name, string power, string weakness, int speed)
        {
            this.name = name;
            this.power = power;
            this.weakness = weakness;
            this.speed = speed;
        }

        //methods
        public void SpeedBoost()
        {
            speed = speed + 100;
            Console.WriteLine("The hero has recieved a speedboost to increase their speed to " + speed + ".");
        }

        public void PowerDrain()
        {
            powerLevel--;
            Console.WriteLine("The hero's power level has been decreased by one!");

        }
    }
}
