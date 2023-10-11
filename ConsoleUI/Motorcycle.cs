using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class Motorcycle:Vehicle
    {
        public string HasSideCart { get; set; }

        public override void DriveAbstract()
        {
            Console.WriteLine("This is my abstract method. -motorcycle");
        }

        public override void DriveVirtual()
        {
            base.DriveVirtual();
            Console.WriteLine("This is my virtual method. -motorcycle");
        }


    }

    
}
