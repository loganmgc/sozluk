using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using Sozluk.EntityLayer.Concrete;

namespace Sozluk.BusinessLayer.ValidationRules
{
    public class CategoryValidator : AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Kategori adını boş geçemezsiniz.")
                .MinimumLength(3).WithMessage("En az 3 karakter girişi yapın.")
                .MaximumLength(50).WithMessage("20 karakterden fazla giriş yapamazsınız.");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Kategori açıklamasını boş geçemezsiniz.")
                .Length(5, 200).WithMessage("Açıklama 5-200 karakter arasında olmalıdır.");
        }
    }
}
