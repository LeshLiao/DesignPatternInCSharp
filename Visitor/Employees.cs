﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Visitor
{
    public class Employees
    {
        private List<Employee> _employees = new List<Employee>();
        public void Attach(Employee employee)
        {
            _employees.Add(employee);
        }
        public void Detach(Employee employee)
        {
            _employees.Remove(employee);
        }
        public void ToRewardAllEmployees(IVisitor visitor)
        {
            foreach (Employee e in _employees)
            {
                e.Accept(visitor);
            }
            Console.WriteLine();
        }
    }
}