using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
   public class ContactValidation:AbstractValidator<Contact>
    {
        public ContactValidation()
        {
            RuleFor(x => x.UserMail).NotEmpty().WithMessage("Mail Adresi Bos Gecemezsiniz");
            RuleFor(x => x.Subject).NotEmpty().WithMessage("Konu Adini Bos Gecemezsiniz");
            RuleFor(x => x.UserName).NotEmpty().WithMessage("Kullanici Adini Bos Gecemezsiniz");
            RuleFor(x => x.Subject).MinimumLength(3).WithMessage("Lutfen En Az 3 Karakter Girisi Yapin");
            RuleFor(x => x.UserName).MinimumLength(3).WithMessage("Lutfen En Az 3 Karakter Girisi Yapin");
            RuleFor(x => x.Subject).MaximumLength(50).WithMessage("Lutfen 50 Karakterden Fazla Deger Girisi Yapmayin");
        }
    }
}
