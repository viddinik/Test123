using FluentValidation;
using FluentValidation.Results;
using NTierArchitecture.DataAccess.Repositories;
using NTierArchitecture.Entities.Models;
using NTierArchitecture.Validation;
using System;
using System.Collections.Generic;

namespace NTierArchitecture.Business.Services
{
    public class CategoryService
    {
        private readonly CategoryRepository _categoryRepository;

        public CategoryService(CategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public IEnumerable<Category> GetAllCategories()
        {
            return _categoryRepository.GetAll();
        }

        public Category GetCategoryById(Guid id)
        {
            return _categoryRepository.GetByID(id);
        }

        public void AddCategory(Category category)
        {
            CategoryValidator validator = new();
            ValidationResult result = validator.Validate(category);

            if (!result.IsValid)
            {
                throw new ValidationException(result.Errors);
            }

            _categoryRepository.Add(category);
        }

        public void UpdateCategory(Category category)
        {
            _categoryRepository.Update(category);
        }

        public void DeleteCategory(Guid id)
        {
            _categoryRepository.Delete(id);
        }

        public bool IfCategoryExists(Guid id)
        {
            return _categoryRepository.IfEntityExists(c => c.Id == id);
        }
    }
}

