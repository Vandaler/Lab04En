using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB4Encap
{
    public class Person
    {
        private string name;
        private int age;
        private int birthyear;
        private double gpa;
        
        public Person(string Name, int Byear, double GPA)
        {
            name = Name;
            this.birthyear = Byear;
            age = 2565 - Byear;
            gpa = GPA;
            
        }
        public int getAge()
        {
            return age;
        }
        public string getName()
        {
            return name;
        }
        
        public double getGPA()
        {
            return gpa;
        }
    }
}
