using System;
using System.Collections.Generic;
using System.Text;

namespace OOPlab1 {
    public class Human {
        public string FirstName;
        public string LastName;
        public Animal Pet;
        public Phone Phone;
        public int Number;
        decimal _salary;
        private Car _car;

        public decimal Salary
        {
            get => _salary;
            set
            {
                if (value > 0)
                {
                    Console.WriteLine("salary is added: " + value);
                    _salary = value;
                }
            }
        }

        public Car car
        {
            get => _car;
            set
            {
                if (value.Value < Salary)
                {
                    Console.WriteLine("car is added: " + value.ToString());
                    _car = value;
                }
                else
                {
                    Console.WriteLine("car is added due to insufficient funds ");
                }
            }
        }
    }
}
