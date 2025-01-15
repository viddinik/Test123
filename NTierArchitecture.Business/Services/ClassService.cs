using BusinessKatmanı.Validators;
using DataAccessKatmanı.Repositories;
using FluentValidation;
using FluentValidation.Results;
using NTierArchitecture.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessKatmanı.Services
{
    public class ClassService
    {
        private readonly ClassRepository _classRepository;

        public ClassService(ClassRepository classRepository)
        {
            _classRepository = classRepository;
        }

        public IEnumerable<Class> GetAllClasses()
        {
            return _classRepository.GetAll();
        }

        public Class GetClassById(int id)
        {
            return _classRepository.GetByID(id);
        }

        public void AddClass(Class classEntity)
        {
            ClassValidator validator = new();
            ValidationResult result = validator.Validate(classEntity);

            if (!result.IsValid)
            {
                throw new ValidationException(result.Errors);
            }

            _classRepository.Add(classEntity);
        }

        public void UpdateClass(Class classEntity)
        {
            _classRepository.Update(classEntity);
        }

        public void DeleteClass(int id)
        {
            _classRepository.Delete(id);
        }

        public bool IfClassExists(int id)
        {
            return _classRepository.IfEntityExists(c => ((Class)c).Id == id);
        }
    }
}
