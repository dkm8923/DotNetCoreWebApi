using FluentValidation;
using DotNetCoreWebApi.Services.Common.Models;
using DotNetCoreWebApi.Services.Common.Dtos;

namespace DotNetCoreWebApi.Services.Common.Models.Validators 
{
    public class AddressValidator : AbstractValidator<Address>
    {
        public AddressValidator()
        {
            RuleFor(v => v.Address1).NotEmpty().WithMessage("Address1 is required.");
            RuleFor(v => v.City).NotEmpty().WithMessage("City is required.");
            RuleFor(v => v.StateId).NotEmpty().WithMessage("StateId is required.");
            RuleFor(v => v.PostalCode).NotEmpty().WithMessage("PostalCode is required.");
        }
    }
} 