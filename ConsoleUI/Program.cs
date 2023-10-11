using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        public static void Main(string[] args)
        {
            /*
             * Todo follow all comments!! 
             */

            #region Vehicles

            /*
             * Create an abstract class called Vehicle **DONE
             * The vehicle class shall have three string properties Year, Make, and Model **DONE
             * Set the defaults to something generic in the Vehicle class **DONE
             * Vehicle shall have an abstract method called DriveAbstract with no implementation **DONE
             * Vehicle shall have a virtual method called DriveVirtual with a base implementation.**DONE
             */

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle **DONE
             * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle **DONE
             * Provide the implementations for the abstract methods **DONE
             * Only in the Motorcycle class will you override the virtual drive method **DONE
            */

            // Create a list of Vehicle called vehicles **DONE
            var vehicles = new List<Vehicle>();
            //var vehicle = new Vehicle();

            // Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes **DONE
            var car = new Car(); 
            var motorcycle = new Motorcycle();

            car.Make = "Honda";
            car.Model = "Accord";
            car.Year = 2010;
            car.HasTrunk = "Yes";
            vehicles.Add(car);
            

            motorcycle.Make = "Suzuki";
            motorcycle.Model = "Katana";
            motorcycle.Year = 2024;
            motorcycle.HasSideCart = "No";
            vehicles.Add(motorcycle);

            Vehicle vehicle1 = new Car();
            vehicle1.Make = "BMW";
            vehicle1.Model = "M5";
            vehicle1.Year = 2022;
            vehicles.Add(vehicle1);
         

            Vehicle vehicle2 = new Motorcycle();
            vehicle2.Make = "Harley Davidson";
            vehicle2.Model = "Pan America 1250";
            vehicle2.Year = 2023;
            vehicles.Add(vehicle2);



            //Set the properties with object initializer syntax
            //



            /*
             * Add the 4 vehicles to the list 
             * Using a foreach loop iterate over each of the properties**DONE
             */

            foreach (var vehicle in vehicles)
            {
                Console.WriteLine(vehicle.Make);
                Console.WriteLine(vehicle.Model);
                Console.WriteLine(vehicle.Year);
                Console.WriteLine();
                
            }
            // Call each of the drive methods for one car and one motorcycle
            car.DriveAbstract();
            car.DriveVirtual();
            motorcycle.DriveVirtual();
            motorcycle.DriveAbstract();

            #endregion
            Console.ReadLine();
        }
    }
}
