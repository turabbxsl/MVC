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
    public class AdminManager : IAdminService
    {
        IAdminDAL _adminDAL;

        public AdminManager(IAdminDAL adminDAL)
        {
            _adminDAL = adminDAL;
        }

        public void AdminAdd(Admin admin)
        {
            _adminDAL.Insert(admin);
        }

        public void AdminDelete(Admin admin)
        {
            throw new NotImplementedException();
        }

        public void AdminUpdate(Admin admin)
        {
            _adminDAL.Update(admin);
        }

        public Admin GetByID(int id)
        {
            return _adminDAL.Get(x => x.AdminID == id);
        }

        public List<Admin> GetList()
        {
            return _adminDAL.List();
        }
    }
}
