using FluentValidation;
using FluentValidation.Results;
using NTierArchitecture.DataAccess.Repositories;
using NTierArchitecture.Entities.Models;
using NTierArchitecture.Validation;
using System;
using System.Collections.Generic;

namespace NTierArchitecture.Business.Services
{
    public class EmployeeService
    {
        private readonly EmployeeRepository _employeeRepository;

        public EmployeeService(EmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return _employeeRepository.GetAll();
        }

        public Employee GetEmployeeById(Guid id)
        {
            return _employeeRepository.GetByID(id);
        }

        public void AddEmployee(Employee employee)
        {
            EmployeeValidator validator = new();
            ValidationResult result = validator.Validate(employee);

            if (!result.IsValid)
            {
                throw new ValidationException(result.Errors);
            }

            _employeeRepository.Add(employee);
        }

        public void UpdateEmployee(Employee employee)
        {
            _employeeRepository.Update(employee);
        }

        public void DeleteEmployee(Guid id)
        {
            _employeeRepository.Delete(id);
        }

        public bool IfEmployeeExists(Guid id)
        {
            return _employeeRepository.IfEntityExists(e => e.Id == id);
        }
    }
}
