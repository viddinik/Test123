using FluentValidation;
using FluentValidation.Results;
using NTierArchitecture.DataAccess.Repositories;
using NTierArchitecture.Entities.Models;
using NTierArchitecture.Validation;
using System;
using System.Collections.Generic;

namespace NTierArchitecture.Business.Services
{
    public class SupplierService
    {
        private readonly SupplierRepository _supplierRepository;

        public SupplierService(SupplierRepository supplierRepository)
        {
            _supplierRepository = supplierRepository;
        }

        public IEnumerable<Supplier> GetAllSuppliers()
        {
            return _supplierRepository.GetAll();
        }

        public Supplier GetSupplierById(Guid id)
        {
            return _supplierRepository.GetByID(id);
        }

        public void AddSupplier(Supplier supplier)
        {
            SupplierValidator validator = new();
            ValidationResult result = validator.Validate(supplier);

            if (!result.IsValid)
            {
                throw new ValidationException(result.Errors);
            }

            _supplierRepository.Add(supplier);
        }

        public void UpdateSupplier(Supplier supplier)
        {
            _supplierRepository.Update(supplier);
        }

        public void DeleteSupplier(Guid id)
        {
            _supplierRepository.Delete(id);
        }

        public bool IfSupplierExists(Guid id)
        {
            return _supplierRepository.IfEntityExists(s => s.Id == id);
        }
    }
}
