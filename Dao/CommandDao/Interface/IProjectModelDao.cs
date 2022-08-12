using Models;
using System.Collections.Generic;
using Models.Models;

namespace Dao.CommandDao.Interface
{
    public interface IProjectModelDao
    {

        ProjectModel GetbyID(int ID);
        List<ProjectModel> GetProjectModelLst();
 
        bool AddVipProject(ProjectModel dto);

        bool UpdateRangeProjectModel(List<ProjectModel> entitys);

        bool UpdateProjectModel(ProjectModel dto);

    

        List<ProjectModel> VipProjects(List<int> Idlst);
    }
}
