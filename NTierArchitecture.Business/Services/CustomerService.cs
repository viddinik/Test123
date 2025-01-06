using FluentValidation;
using FluentValidation.Results;
using NTierArchitecture.DataAccess.Repositories;
using NTierArchitecture.Entities.Models;
using NTierArchitecture.Validation;
using System;
using System.Collections.Generic;

namespace NTierArchitecture.Business.Services
{
    public class CustomerService
    {
        private readonly CustomerRepository _customerRepository;

        public CustomerService(CustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public IEnumerable<Customer> GetAllCustomers()
        {
            return _customerRepository.GetAll();
        }

        public Customer GetCustomerById(Guid id)
        {
            return _customerRepository.GetByID(id);
        }

        public void AddCustomer(Customer customer)
        {
            CustomerValidator validator = new();
            ValidationResult result = validator.Validate(customer);

            if (!result.IsValid)
            {
                throw new ValidationException(result.Errors);
            }

            _customerRepository.Add(customer);
        }

        public void UpdateCustomer(Customer customer)
        {
            _customerRepository.Update(customer);
        }

        public void DeleteCustomer(Guid id)
        {
            _customerRepository.Delete(id);
        }

        public bool IfCustomerExists(Guid id)
        {
            return _customerRepository.IfEntityExists(c => c.Id == id);
        }
    }
}
