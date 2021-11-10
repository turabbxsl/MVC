using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
   public class WriterValidation:AbstractValidator<Writer>
    {
        public WriterValidation()
        {
            object c = "a";
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar Adini Bos Gecemezsiniz");
            //RuleFor(x => x.WriterName).Must("a").WithMessage("Yazar Adinda Mutlaka A harfi Bulunmalidir");
            RuleFor(x => x.WriterSurname).NotEmpty().WithMessage("Yazar Soyadini Bos Gecemezsiniz");
            RuleFor(x => x.WriterAbout).NotEmpty().WithMessage("Hakkinda Kismini Bos Gecemezsiniz");
            RuleFor(x => x.WriterTitle).NotEmpty().WithMessage("Unvan Kismini Bos Gecemezsiniz");
            RuleFor(x => x.WriterName).MinimumLength(2).WithMessage("Lutfen En Az 2 Karakter Girisi Yapin");
            RuleFor(x => x.WriterSurname).MaximumLength(50).WithMessage("Lutfen 50 karakterden fazla deger girisi yapmayin");
        }
    }
}
