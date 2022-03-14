using DataAccesLayer;
using System;
using System.Collections.Generic;
using CommonLayer.Models;

namespace BusinsAccessLayer
{
    public class BEmployeeBussiness
    {
        private EmployeeDataAccessDb employeeData;
        public BEmployeeBussiness()
        {
            employeeData = new EmployeeDataAccessDb();
        }
        public List<Employees> GetEmpoyee()
        {
            return employeeData.GetEmployees();
        }
    }
}
