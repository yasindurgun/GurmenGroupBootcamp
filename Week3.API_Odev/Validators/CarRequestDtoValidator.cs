using FluentValidation;
using Week3.API_Odev.DTOs;

namespace Week3.API_Odev.Validators
{
    public class CarRequestDtoValidator : AbstractValidator<CarRequestDto>
    {
        //CarRequestDto benim son kullanıcıya açacağım nesne olduğundan dolayı bu dtonun valdasyon işlemlerinin kontrolü önemlidir.
        public CarRequestDtoValidator()
        {
            RuleFor(x=>x.ModelYear).NotNull().WithMessage("Model yılı boş geçilemez.").NotEmpty().WithMessage("Model yılı boş olamaz");
            RuleFor(x => x.Price).NotNull().WithMessage("Price alanı boş olamaz");
            RuleFor(x => x.Description).NotNull().WithMessage("Description alanı boş olamaz");
            RuleFor(x => x.Color).NotNull().WithMessage("Color alanı boş olamaz");
        }
    }
}
