using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class Car:Vehicle
    {

        public string HasTrunk { get; set; }

        public override void DriveAbstract()
        {
            Console.WriteLine("This is my abstract method - car");
        }

        
    }
}
