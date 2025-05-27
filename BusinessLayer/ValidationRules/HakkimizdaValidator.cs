
using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.ValidationRules
{
    public class HakkimizdaValidator : AbstractValidator<Hakkimizda>
    {
        public HakkimizdaValidator()
        {
            RuleFor(x => x.Aciklama)
                .NotEmpty().WithMessage("Açıklama alanı boş geçilemez.")
                .MinimumLength(20).WithMessage("Açıklama en az 20 karakter olmalıdır.")
                .MaximumLength(1000).WithMessage("Açıklama en fazla 1000 karakter olmalıdır.");

            RuleFor(x => x.Resim)
                .NotEmpty().WithMessage("Resim URL alanı boş geçilemez.");

            RuleFor(x => x.Title)
                .Length(5, 100).WithMessage("Başlık 5 ile 100 karakter arasında olmalıdır.")
                .NotEmpty().WithMessage("Başlık alanı boş geçilemez.");
        }
    }
}
