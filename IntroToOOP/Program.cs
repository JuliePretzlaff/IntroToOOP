using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat firstCat = new Cat();
            firstCat.Name = "Mr. Fuzzy";

            Cat secondCat = new Cat("Midnight", 14, "black");
            Console.WriteLine(firstCat.Name);
            Console.WriteLine(secondCat.Name);

            string lunch = "tuna";

            firstCat.Eat(lunch);

           secondCat.Meow();

            firstCat.HairLength = "nice and short";
            secondCat.HairLength = "too long";

            Console.WriteLine(firstCat.Hairball());
            Console.WriteLine(secondCat.Hairball());


            Dog dogOne = new Dog("short", 3.5, 12, 35);
            Console.WriteLine(dogOne.HairLength); //make HairLength a public property, this will print hearlength
            dogOne.Run();

            dogOne.RunningSpeed = 0;
            dogOne.Run();

            Console.WriteLine(dogOne.RunningSpeed);

            dogOne.Bark();

            dogOne.Potty();

            dogOne.Cuddle();

        }
    }
}
