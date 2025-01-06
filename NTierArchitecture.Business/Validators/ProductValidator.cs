using FluentValidation;
using NTierArchitecture.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierArchitecture.Business.Validators
{
    public class ProductValidator:AbstractValidator<Product>
    {
        public ProductValidator()
        {
            // ProductName: Zorunlu alan, maksimum uzunluğu kontrol ediyoruz.
            RuleFor(p => p.ProductName)
                .NotEmpty().WithMessage("Product name is required.")
                .MaximumLength(100).WithMessage("Product name must not exceed 100 characters.");

            // UnitPrice: Negatif fiyatlar kabul edilmez, 0 veya daha büyük olmalı.
            RuleFor(p => p.UnitPrice)
                .GreaterThanOrEqualTo(0).WithMessage("Unit price must be greater than or equal to 0.");

            // UnitsInStock: Negatif stok kabul edilmez.
            RuleFor(p => p.UnitsInStock)
                .GreaterThanOrEqualTo(0).WithMessage("Units in stock must be greater than or equal to 0.");

            // CategoryID: Boş olamaz.
            RuleFor(p => p.CategoryID)
                .NotEmpty().WithMessage("Category ID is required.");

            // SupplierID: Boş olamaz.
            RuleFor(p => p.SupplierID)
                .NotEmpty().WithMessage("Supplier ID is required.");

            // Discontinued: Boolean değerler için ek doğrulama genelde gerekmez.
        }
    }
}
