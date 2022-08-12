using Dao.CommandDao.Interface;
using Models.Models;
using Models.Repository.ServerRepository;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Linq.Expressions;
using System.Reflection;

namespace Dao.CommandDao.Implementation
{
    public class ProjectModelDao : DataRepository<ProjectModel>, IProjectModelDao
    {

        public ProjectModel GetbyID(int ID)
        {
            var data = QuerySingle(x => x.Id == ID);
            return data;
        }
        public List<ProjectModel> VipProjects(List<int> Idlst)
        {
            var data = QueryPart(x => Idlst.Contains(x.Id)).ToList();
            return data;
        }
        public List<ProjectModel> GetProjectModelLst()
        {
            var st = QueryAll().ToList();
            return st;
        }

        public bool AddVipProject(ProjectModel dto)
        {
            dto.UpdateDate = DateTime.Now;
            var it = AddSingle(dto);
            return it > 0;
        }

     
        public bool UpdateRangeProjectModel(List<ProjectModel> entitys)
        {
            var it = UpdateRange(entitys);
            return it;
        }

        public bool UpdateProjectModel(ProjectModel dto)
        {
            dto.UpdateDate = DateTime.Now;
            var it = UpdateEntity(dto);
            return it > 0;
        }

       
    }
}
