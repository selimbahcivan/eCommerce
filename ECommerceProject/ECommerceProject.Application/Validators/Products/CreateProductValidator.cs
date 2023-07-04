using ECommerceProject.Application.ViewModels.Products;
using FluentValidation;

namespace ECommerceProject.Application.Validators.Products
{
    public class CreateProductValidator : AbstractValidator<CreateProductViewModel>
    {
        public CreateProductValidator()
        {
            RuleFor(p => p.Name)
                .NotEmpty()
                .WithMessage("Lütfen ürün adını giriniz.")
                .NotNull()
                .WithMessage("Lütfen ürün adını giriniz.")
                .MaximumLength(150)
                .MinimumLength(3)
                .WithMessage("Lütfen ürün adını 3 ile 150 karakter arasında giriniz");

            RuleFor(p => p.Stock)
                .NotEmpty()
                .WithMessage("Lütfen stok bilgisini giriniz.")
                .NotNull()
                .WithMessage("Lütfen stok bilgisini giriniz.")
                .Must(s => s >= 0)
                .WithMessage("Stok bilgisi negatif olamaz!");

            RuleFor(p => p.Price)
                .NotEmpty()
                .WithMessage("Lütfen fiyat bilgisini giriniz.")
                .NotNull()
                    .WithMessage("Lütfen fiyat bilgisini giriniz.")
                .Must(s => s >= 0)
                    .WithMessage("Fiyat bilgisi negatif olamaz!");
        }
    }
}
