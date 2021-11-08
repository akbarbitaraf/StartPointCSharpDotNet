using System;
using System.Collections.Generic;
using System.Text;

namespace BeginingLinq
{
    class Persons
    {
        private string lastName; 
        public string FirstName {
            get;
            set;
        }
        public string LastName { 
            
            get
            {
                Console.WriteLine($"Read: {lastName}"); 
                return lastName; 

            }

            set {
                lastName = value; 
            }
        }

        

    }
}
