using BookStoreAPI.Application.ViewModels.Products;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreAPI.Application.Validators.Products
{
    public class CreateProductValidator : AbstractValidator<VM_Create_Product>
    {
        public CreateProductValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .NotNull()
                .WithMessage("Ürün adı boş olmamalı!")
                .MinimumLength(2)
                .MaximumLength(150)
                .WithMessage("Ürün adı 2 ile 150 karakter arasında olmalı!");

            RuleFor(x => x.Price)
                .NotNull()
                .NotEmpty()
                .WithMessage("Fiyat boş olmamalı!")
                .Must(price => price >= 0)
                .WithMessage("Fiyat 0 veya büyük olmalı!");

            RuleFor(x => x.Stock)
                .NotEmpty()
                .NotNull()
                .WithMessage("Stok boş olmamalı!")
                .Must(stock => stock >= 0)
                .WithMessage("Stok değeri 0 veya büyük olmalı");
        }
    }
}
