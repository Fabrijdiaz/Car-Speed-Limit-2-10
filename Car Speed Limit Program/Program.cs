using System;

namespace Car_Speed_Limit_Program
{


    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            Car car2 = new Car();
            Car car3 = new Car();

            // Ask the User for speed limit
            Console.Write("Enter the speed limit: ");
            int speedLimit = Convert.ToInt32(Console.ReadLine());

            // Ask the user information for Car 1
            Console.Write("\nEnter the make of Car 1: ");
            car1.make = Console.ReadLine();

            Console.Write("\nEnter the model of Car 1: ");
            car1.model = Console.ReadLine();

            Console.Write("\nEnter the speed of Car 1: ");
            car1.speed = Convert.ToInt32(Console.ReadLine());

            // Ask the user information for Car 2
            Console.Write("\nEnter the make of Car 2: ");
            car2.make = Console.ReadLine();

            Console.Write("\nEnter the model of Car 2: ");
            car2.model = Console.ReadLine();

            Console.Write("\nEnter the speed of Car 2: ");
            car2.speed = Convert.ToInt32(Console.ReadLine());

            // Ask the user information for Car 3
            Console.Write("\nEnter the make of Car 3: ");
            car3.make = Console.ReadLine();

            Console.Write("\nEnter the model of Car 3: ");
            car3.model = Console.ReadLine();

            Console.Write("\nEnter the speed of Car 3: ");
            car3.speed = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("\nSpeed Limit: " + speedLimit + "mph\n");

            // Output of Car 1
            if (car1.speed < speedLimit)
            {
                Console.WriteLine(car1.make + " " + car1.model + " " + car1.speed + "mph: OK");
            }
            else if (car1.speed > speedLimit)
            {
                int demerit = (((car1.speed - speedLimit) - ((car1.speed - speedLimit) % 5)) / 5);

                if (demerit < 10)
                {
                    Console.WriteLine(car1.make + " " + car1.model + " " + car1.speed + "mph: " + demerit + " demerits");
                }

                else if(demerit >= 10)
                {
                    demerit = 10; 
                    Console.WriteLine(car1.make + " " + car1.model + " " + car1.speed + "mph " + demerit + " demerits <LICENSE SUSPENDED>");
                }
            }

            // Output of Car 2
            if (car2.speed < speedLimit)
            {
                Console.WriteLine(car2.make + " " + car2.model + " " + car2.speed + "mph: OK");
            }
            else if (car2.speed > speedLimit)
            {
                int demerit = (((car2.speed - speedLimit) - ((car2.speed - speedLimit) % 5)) / 5);

                if (demerit < 10)
                {
                    Console.WriteLine(car2.make + " " + car2.model + " " + car2.speed + "mph: " + demerit + " demerits");
                }

                if (demerit >= 10)
                {
                    demerit = 10;
                    Console.WriteLine(car2.make + " " + car2.model + " " + car2.speed + "mph " + demerit + " demerits <LICENSE SUSPENDED>");
                }
            }

            // Output of Car 3
            if (car3.speed < speedLimit)
            {
                Console.WriteLine(car3.make + " " + car3.model + " " + car3.speed + "mph: OK");
            }
            else if (car3.speed > speedLimit)
            {
                int demerit = (((car3.speed - speedLimit) - ((car3.speed - speedLimit) % 5)) / 5);

                if (demerit < 10)
                {
                    Console.WriteLine(car3.make + " " + car3.model + " " + car3.speed + "mph: " + demerit + " demerits");
                }

                if (demerit >= 10)
                {
                    demerit = 10;
                    Console.WriteLine(car3.make + " " + car3.model + " " + car3.speed + "mph: " + demerit + " demerits <LICENSE SUSPENDED>");
                }
            }
        }
    }
    public class Car
    {
        public string make;
        public string model;
        public int speed;
        public int demerit; 
    }
}


