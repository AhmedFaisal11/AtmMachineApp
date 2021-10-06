using System;
using System.IO;
using AtmMachineApp;

namespace AtmMachineApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Atm atm = new Atm(); // making an object of Atm class
            atm.StartAtm(); // this method will start the atm we dont need any method other than this    
        }
    }
}

