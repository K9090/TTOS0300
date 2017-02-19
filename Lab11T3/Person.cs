using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    abstract public class Person
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

    public class Worker : Person
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

    public class FullTime : Worker
    {
        public bool IsFullTime { get; set; }
        public float Salary { get; set; }

        public override float CalcWage()
        {
            Wage = Salary;
            return Wage;
        }
    }

    public class PartTime : Worker
    {
        public bool IsPartTime { get; set; }
        public float HourPay { get; set; }
        public int WorkedHours { get; set; }

        public override float CalcWage()
        {
            Wage = HourPay * WorkedHours;
            return Wage;
        }
    }
}
