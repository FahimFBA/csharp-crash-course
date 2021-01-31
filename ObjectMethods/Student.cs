using System;

namespace ObjectMethods    
{
    class Student
    {
        public string name;
        public string major;
        public double gpa;

        public Student(string aName, String aMajor, double aGpa)
        {
            name = aName;
            major = aMajor;
            gpa = aGpa;
        }

        public bool HasHonors()
        {
            if(gpa >= 3.5)
            {
                return true;
            }
            return false;
        }

    }
}
