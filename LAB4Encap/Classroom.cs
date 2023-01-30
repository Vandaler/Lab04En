using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB4Encap
{
    internal class Classroom
    {
        private string name;
        private List<Person> persons = new List<Person>();

        public Classroom(string name)
        {
            this.name = name;
        }
        public void addPerson2Class(Person p)
        {
            persons.Add(p);
        }
        public string showAllPersononClass()
        {
            string result = "";
            foreach (Person p in persons)
            {
                result += p.getName() + "\r\n";
            }
            return result;
        }
        public void addYear2Class(Person y)
        {
            persons.Add(y);
        }
        public string SumAllYearClass()
        {
            int year = 0;
            foreach (Person y in persons)
            {
                int currentAge = year;
                int newTotalAge = currentAge + y.getAge();
                year = newTotalAge;
            }
            return year.ToString();
        }
        public void addGPA2Class(Person g)
        {
            persons.Add(g);
        }
        public string avgMaxGPA()
        {
            double totalGPA = 0;
            int count = 0;
            foreach (Person g in persons)
            {
                totalGPA += g.getGPA();
                count++;
            }
            double avgGPA = totalGPA / count;
            return avgGPA.ToString();
        }
        public string MaxGPA()
        {
            double totalGPA = 0;
            int count = 0;
            double maxGPA = 0;
            string name = "";
            foreach (Person g in persons)
            {
                double currentGPA = g.getGPA();
                totalGPA += currentGPA;
                count++;
                if (currentGPA > maxGPA)
                {
                    maxGPA = currentGPA;
                    name = g.getName();
                }
            }
            return maxGPA.ToString();
        }
        public string MinGPA()
        {
            double totalGPA = 0;
            int count = 0;
            double minGPA = double.MaxValue;
            string name = "";
            foreach (Person g in persons)
            {
                double currentGPA = g.getGPA();
                totalGPA += currentGPA;
                count++;
                if (currentGPA < minGPA)
                {
                    minGPA = currentGPA;
                    name = g.getName();
                }
            }
            return minGPA.ToString();
        }
        public string minGPAName()
        {
            double totalGPA = 0;
            int count = 0;
            double minGPA = double.MaxValue;
            string name = "";
            foreach (Person g in persons)
            {
                double currentGPA = g.getGPA();
                totalGPA += currentGPA;
                count++;
                if (currentGPA < minGPA)
                {
                    minGPA = currentGPA;
                    name = g.getName();
                }
            }
            return name;
        }
        public string maxGPAName()
        {
            double totalGPA = 0;
            int count = 0;
            double maxGPA = 0;
            string name = "";
            foreach (Person g in persons)
            {
                double currentGPA = g.getGPA();
                totalGPA += currentGPA;
                count++;
                if (currentGPA > maxGPA)
                {
                    maxGPA = currentGPA;
                    name = g.getName();
                }
            }
            return name;
        }
    }
}
