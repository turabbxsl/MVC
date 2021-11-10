using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
   public class CategoryValidatior:AbstractValidator<Category>
    {

        public CategoryValidatior()
        {
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Kategoriya Adini Bos Gecemezsiniz");
            RuleFor(x => x.CategoryDescription).NotEmpty().WithMessage("Aciklamayi Bos Gecemezsiniz");
            RuleFor(x => x.CategoryName).MinimumLength(3).WithMessage("Lutfen En Az 3 Karakter Girisi Yapin");
            RuleFor(x => x.CategoryName).MaximumLength(20).WithMessage("Lutfen 20 karakterden fazla deger girisi yapmayin");
        }

    }
}
