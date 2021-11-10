using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
   public class MessageValidation : AbstractValidator<Message>
    {

        public MessageValidation()
        {
            RuleFor(x => x.ReceiverMail).NotEmpty().WithMessage("Alici Adresi Bos Buraxila Bilmez");
            RuleFor(x => x.Subject).NotEmpty().WithMessage("Konuyu Bos Buraxila Bilmez");
            RuleFor(x => x.MessageContent).NotEmpty().WithMessage("Mesaji Bos Buraxila Bilmez");
            RuleFor(x => x.Subject).MinimumLength(5).WithMessage("Lutfen En Az 5 Karakter Girisi Yapin");
            RuleFor(x => x.Subject).MaximumLength(100).WithMessage("En Cok 100 Karakter Girisi Yapila Bilir");
        }


    }
}
