using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
   public interface ITaslaklarService
    {
        List<Taslaklar> GetListTaslaklar();
        void TaslaklarAddBL(Taslaklar taslaklar);
        Taslaklar GetByID(int id);
        void TaslaklarDelete(Taslaklar taslaklar);
        void TaslaklareUpdate(Taslaklar taslaklar);
    }
}
