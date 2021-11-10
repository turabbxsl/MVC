using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
   public class TaslaklarManager:ITaslaklarService
    {
        ITaslakDAL _taslakDAL;

        public TaslaklarManager(ITaslakDAL taslakDAL)
        {
            _taslakDAL = taslakDAL;
        }

        public Taslaklar GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Taslaklar> GetListTaslaklar()
        {
            return _taslakDAL.List();
        }

        public void TaslaklarAddBL(Taslaklar taslaklar)
        {
            _taslakDAL.Insert(taslaklar);
        }

        public void TaslaklarDelete(Taslaklar taslaklar)
        {
            throw new NotImplementedException();
        }

        public void TaslaklareUpdate(Taslaklar taslaklar)
        {
            throw new NotImplementedException();
        }
    }
}
