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
    /// creates a services class which tells what the service is and how much that service cost
    /// </summary>
    class Services
    {
        public string Description { get; private set; }// what the service is

        public double Price { get; private set; } // how much the service costs

        public Services(string desc, double price)
        {
            Description = desc;
            Price = price;
        }
    }
}
