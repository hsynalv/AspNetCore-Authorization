using AuthServer.Core.DTOs;
using FluentValidation;

namespace AuthServer.API.Validations
{
    public class CreateProductDtoValidator : AbstractValidator<ProductDto>
    {
        public CreateProductDtoValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Name is required");

            RuleFor(x => x.Stock).NotEmpty().WithMessage("Stock is required");

            RuleFor(x => x.Price).NotEmpty().WithMessage("Price is required");
        }
    }
}
