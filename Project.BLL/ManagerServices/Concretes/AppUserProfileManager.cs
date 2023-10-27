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
    public class AppUserProfileManager : BaseManager<AppUserProfile>, IAppUserProfileManager
    {
        IAppUserProfileRepository _iaUPR;
        public AppUserProfileManager(IAppUserProfileRepository iaUPR) : base(iaUPR)
        {
            _iaUPR = iaUPR;
        }
    }
}
