using FluentValidation;
using FluentValidation.Results;
using NTierArchitecture.Business.Validators;
using NTierArchitecture.DataAccess.Repositories;
using NTierArchitecture.Entities.Models;
using System;
using System.Collections.Generic;

namespace NTierArchitecture.Business.Services
{
    public class ProductService
    {
        private readonly ProductRepository _productRepository;

        public ProductService(ProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return _productRepository.GetAll();
        }

        public Product GetProductById(Guid id)
        {
            return _productRepository.GetByID(id);
        }

        public void AddProduct(Product product)
        {
            ProductValidator validationResult = new();
            ValidationResult result = validationResult.Validate(product);

            if (!result.IsValid)
            {
                throw new ValidationException(result.Errors);
            }

            _productRepository.Add(product);
        }

        public void UpdateProduct(Product product)
        {
            _productRepository.Update(product);
        }

        public void DeleteProduct(Guid id)
        {
            _productRepository.Delete(id);
        }

        public bool IfProductExists(Guid id)
        {
            return _productRepository.IfEntityExists(p => p.Id == id);
        }
    }
}
