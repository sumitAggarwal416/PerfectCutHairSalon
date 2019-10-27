/*
 * I, Sumit Aggarwal, 000793607, certify that all code submitted is my own code and I have not copied it from anywhere. I also certify that I have not allowed
 * anyone else to copy my code.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perfect_Cut_Hair_Salon
{
    /// <summary>
    /// Creates a hairdresser and tells what price they charge for their time
    /// </summary>
    class Hairdresser
    {
        public string Name { get; private set; } // name of the hairdresser

        public double Price { get; private set; } // price charged by the hairdresser

        public Hairdresser(string name, double price)
        {
            Name = name;
            Price = price;
        }
    }
}
