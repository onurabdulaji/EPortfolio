using Project.BLL.ManagerServices.Abstracts;
using Project.DAL.Repositories.Abstracts;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.ManagerServices.Concretes
{
    public class AppUserManager : BaseManager<AppUser>, IAppUserManager
    {
        IAppUserRepository _apRep;
        //public AppUserManager(IRepository<AppUser> iapRep, IAppUserRepository iApRep) : base(iapRep)
        //{
        //    _iapRep = iApRep;
        //}

        /// Bu sekilde kullanmak daha makuldur.
        public AppUserManager(IAppUserRepository apRep) : base(apRep)
        {
            _apRep = apRep;
        }
        public async Task<bool> CreateUser(AppUser item)
        {
            // TODO BL Yazilir
            return await _apRep.AddUser(item);
        }
    }
}
