using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    abstract class Person
    {
        public string SocialID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }

        public Person()
        {

        }

        public int CalcAge(int age)
        {
            age = DateTime.Today.Year - DateOfBirth.Year;
            return age;
        }

        public override string ToString()
        {
            return FirstName + " " + LastName;
        }
    }

    class Worker : Person
    {
        public string Title { get; set; }
        public int WorkerID { get; set; }
        public DateTime StartingDate { get; set; }
        public float Wage { get; set; }

        public Worker()
        {

        }

        virtual public float CalcWage()
        {
            return Wage;
        }

        public override string ToString()
        {
            return WorkerID + " = " + base.ToString() + ", " + Title;
        }
    }

    class FullTime : Worker
    {
        public float Salary { get; set; }

        public override float CalcWage()
        {
            Wage = Salary;
            return Wage;
        }
    }

    class PartTime : Worker
    {
        public float HourPay { get; set; }
        public int WorkedHours { get; set; }

        public override float CalcWage()
        {
            Wage = HourPay * WorkedHours;
            return Wage;
        }
    }
}
