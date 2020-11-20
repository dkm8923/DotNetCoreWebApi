using FluentValidation;

namespace DotNetCoreWebApi.Services.Common.Dtos.Address
{
    public class AddressCreateDtoValidator : AbstractValidator<AddressCreateDto>
    {
        public AddressCreateDtoValidator()
        {
            RuleFor(v => v.Address1).NotEmpty().WithMessage("Address1 is required.");
            RuleFor(v => v.City).NotEmpty().WithMessage("City is required.");
            RuleFor(v => v.StateId).NotEmpty().WithMessage("StateId is required.");
            RuleFor(v => v.PostalCode).NotEmpty().WithMessage("PostalCode is required.");
        }
    }

    public class AddressUpdateDtoValidator : AbstractValidator<AddressUpdateDto>
    {
        public AddressUpdateDtoValidator()
        {
            RuleFor(v => v.Address1).NotEmpty().WithMessage("Address1 is required.");
            RuleFor(v => v.City).NotEmpty().WithMessage("City is required.");
            RuleFor(v => v.StateId).NotEmpty().WithMessage("StateId is required.");
            RuleFor(v => v.PostalCode).NotEmpty().WithMessage("PostalCode is required.");
        }
    }
}
