using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalManagement
{
    internal class UnitTest
    {
        Cat cat1 = new Cat();
        public void testName()
        {
            cat1.setName("Barry");
            if (cat1.getName() == "Barry")
            {
                Console.WriteLine("Get Name method passed");
            }
            else
            {
                Console.WriteLine("Get Name method failed");
            }
        }
        public void testBreed()
        {
            cat1.setBreed("Persian");
            if (cat1.getBreed() == "Persian")
            {
                Console.WriteLine("Get Breed method passed");
            }
            else
            {
                Console.WriteLine("Get Breed method failed");
            }
        }

        public void testGender()
        {
            cat1.setGender("Male");
            if (cat1.getGender() == "Male")
            {
                Console.WriteLine("Get Gender method passed");
            }
            else
            {
                Console.WriteLine("Get Gender method failed");
            }
        }

        public void testDOB()
        {
            cat1.setDOB("22/03/2018");
            if (cat1.getDOB() == "22/03/2018")
            {
                Console.WriteLine("Get DOB method passed");
            }
            else
            {
                Console.WriteLine("Get DOB method failed");
            }
        }

    }
}
