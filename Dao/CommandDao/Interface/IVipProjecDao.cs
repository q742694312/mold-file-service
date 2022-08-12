using Models;
using System.Collections.Generic;
using Models.Models;

namespace Dao.CommandDao.Interface
{
    public interface IVipProjectDao
    {

        List<VipProject> GetVipProjectLst();

        //List<VipProjectDto> GetVipProjectLst2();

        //TableList<VipProjectDto> VipProjectPage(int currentPage, int pageSize, Dictionary<string, string> QueDictionary);
        bool AddVipProject(VipProject dto);

        bool UpdateRangeVipProject(List<VipProject> entitys);

        bool UpdateVipProject(VipProject dto);

        VipProject VipProject(int ID);

        List<VipProject> VipProjects(List<int> Idlst);
    }
}
