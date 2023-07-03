using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            var myBird = new Bird();
            myBird.FeatherColor = "red";
            myBird.BeakLength = 4.5;
            myBird.MakesNest = true;
            myBird.CanSing = true;

            Console.WriteLine($"My bird has {myBird.FeatherColor} feathers, it's beak is {myBird.BeakLength} inches long.It is {myBird.MakesNest} that is builds it's own nest while it is equally {myBird.CanSing} that it sings while doing so."); 

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
            var myReptile = new Reptile();
            myReptile.IsEndothermic = true;
            myReptile.HasScales = true;
            myReptile.HasDrySkin = true;
            myReptile.LaysEggs = true;

            Console.WriteLine($" It is {myReptile.IsEndothermic} that my reptile is cold blooded. It is also {myReptile.HasScales} that it has scales and {myReptile.HasDrySkin} that it's skin is particularly dry. When the time comes it will also be {myReptile.LaysEggs} that it will lay eggs.");
            
            var myAnimals = new Animal[] { myBird, myReptile };

            foreach (var animal in myAnimals)
            {
                Console.WriteLine($"Tail:{animal.HasTail}");
                Console.WriteLine($"It has {animal.Legs} legs");
                Console.WriteLine($"It has {animal.EyeColor} eyes");
                Console.WriteLine($"It lives on: {animal.LandSeaAir}");
            }
        }
    }   }
