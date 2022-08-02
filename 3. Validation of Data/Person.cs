using System;
using System.Collections.Generic;
using System.Text;

namespace PersonsInfo
{
    public class Person
    {
        private string firstName;
        private string lasteName;
        private int age;
        private decimal salary;
        public Person(string firstName, string lasteName, int age, decimal salary)
        {
            this.FirstName = firstName;
            this.LastName = lasteName;
            this.Age = age;
            this.Salary = salary;
        }

        public string FirstName 
        {
            get
            {
                return this.firstName;
            }
            private set
            {
                if (value.Length<3)
                {
                    throw new ArgumentException ("First name cannot contain fewer than 3 symbols!");
                }
                value = this.firstName;
            }
        }
        public string LastName
        {
            get
            {
                return this.lasteName;
            }
            private set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Last name cannot contain fewer than 3 symbols!");
                }
                this.lasteName = value;
            }
        }
        public int Age
        {
            get
            {
                return this.age;
            }
            private set
            {
                if (value<1)
                {
                    throw new ArgumentException("Age cannot be zero or a negative integer!");
                }
                this.age = value;
            }
        }
        public decimal Salary 
        {
            get 
            {
                return this.salary;
            }
            private set
            {
                if (value<650)
                {
                    throw new ArgumentException("Salary cannot be less than 650 leva!");
                }
                this.salary = value;
            }
        }

        public void IncreaseSalary(decimal percentage)
        {
            if (this.age > 30)
            {
                this.salary += this.salary * percentage / 100;
            }
            else
            {
                this.salary += this.salary * percentage / 200;

            }
        }
        public override string ToString()
        {
            return $"{this.firstName} {this.lasteName} receives {this.salary:f2} leva.";
        }

    }
}
