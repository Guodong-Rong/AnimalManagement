using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalManagement
{
    internal class Cat
    {
        private string name;
        private string breed;
        private string gender;
        private string DOB;

        public void setName(string name)
        {
            this.name = name;
        }

        public string getName()
        {
            return name;
        }
        public void setBreed(string breed)
        {
            this.breed = breed;
        }

        public string getBreed()
        {
            return breed;
        }

        public void setGender(string gender)
        {
            this.gender = gender;
        }

        public string getGender()
        {
            return gender;
        }

        public void setDOB(string DOB)
        {
            this.DOB = DOB;
        }

        public string getDOB()
        {
            return DOB;
        }

    }
}
