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
    public class VipProjectDao : DataRepository<VipProject>, IVipProjectDao
    {

        public VipProject VipProject(int ID)
        {
            var data = QuerySingle(x => x.Id == ID);
            return data;
        }
        public List<VipProject> VipProjects(List<int> Idlst)
        {
            var data = QueryPart(x => Idlst.Contains(x.Id)).ToList();
            return data;
        }
        public List<VipProject> GetVipProjectLst()
        {
            var st = QueryAll().ToList();
            return st;
        }

        //public List<VipProjectDto> GetVipProjectLst2()
        //{
        //    var st = (from vp in _context.Set<VipProject>()
        //              join q in _context.Set<projectModel>().GroupBy(x => x.projectID).Select(x => x)
        //               on vp.ID equals q.Key into temp2
        //              from tt2 in temp2.DefaultIfEmpty()
        //              select new VipProjectDto
        //              {
        //                  ID = vp.ID,
        //                  projectName = vp.projectName,
        //                  adress = vp.projectName,
        //                  belong = vp.belong,
        //                  wgs84X = vp.wgs84X,
        //                  wgs84Y = vp.wgs84Y,
        //                  //regionid = vp.regionid,
        //                  region = vp.region,
        //                  projectType = vp.projectType,
        //                  isLinable = vp.isLinable,
        //                  PID = vp.PID,
        //                  BIMmodel=vp.BIMmodel,
        //                  state=vp.state,
        //                  isCase=vp.isCase,
        //                  projectModelList = tt2.ToList()
        //              }).ToList();
        //    return st;
        //}

        //public TableList<VipProjectDto> VipProjectPage( int currentPage,int pageSize,Dictionary<string,string> QueDictionary)
        //{
        //    var st = (from vp in _context.Set<VipProject>()
        //              join crg in _context.Set<CustomRegion>()
        //              on vp.belong equals crg.CustomRegionID into temp
        //              join q in _context.Set<projectModel>().GroupBy(x => x.projectID).Select(x => x)
        //               on vp.ID equals q.Key into temp2
        //              from tt2 in temp2.DefaultIfEmpty()
        //              where (vp.Isdelete == false)
        //              select new VipProjectDto
        //              {
        //                  ID = vp.ID,
        //                  projectName = vp.projectName,
        //                  adress = vp.projectName,
        //                  belong = vp.belong,
        //                  wgs84X = vp.wgs84X,
        //                  wgs84Y = vp.wgs84Y,
        //                  //regionid = vp.regionid,
        //                  region = vp.region,
        //                  projectType = vp.projectType,
        //                  isLinable = vp.isLinable,
        //                  PID = vp.PID,
        //                  BIMmodel = vp.BIMmodel,
        //                  Isdelete=vp.Isdelete,
        //                  RegionName = temp.FirstOrDefault().RegionName,
        //                  projectModelList = tt2.ToList()
        //              });


        //    if (QueDictionary != null)
        //    {
        //        var QueryDictionary = QueDictionary.ToList();
        //        foreach (var ke in QueryDictionary)
        //        {
        //            string Key = ke.Key;
        //            string value = ke.Value;
        //            Type classType = typeof(VipProjectDto);//类的类型
        //            PropertyInfo pro = classType.GetProperty(Key);
        //            if (pro != null)
        //            {
        //                ////
        //                ParameterExpression Parameter0 = Expression.Parameter(classType);   //Creating a parameter for the expression tree.
        //                Expression whereProperty0 = Expression.Property(Parameter0, Key);   //访问属性
        //                Type Type = whereProperty0.Type;
        //                Expression<Func<VipProjectDto, bool>> lambda;

        //                //定义2
        //                if (!value.Contains(','))
        //                {
        //                    Expression constant2 = Expression.Constant(value);
        //                    var Vvalue2 = Expression.Convert(constant2, typeof(string));
        //                    Expression greaterThanOrEqual2 = Expression.Call(whereProperty0, typeof(string).GetMethod("Contains", new Type[] { typeof(string) }), Vvalue2);
        //                    lambda = Expression.Lambda<Func<VipProjectDto, bool>>(greaterThanOrEqual2, Parameter0);
        //                }
        //                else
        //                {
        //                    //定义3
        //                    var valueArr = value.Split(',').ToList();
        //                    MethodInfo MethodContains = typeof(Enumerable).GetMethods(BindingFlags.Static | BindingFlags.Public)
        //                        .Single(m => m.Name == nameof(Enumerable.Contains) && m.GetParameters().Length == 2);
        //                    MethodInfo method = MethodContains.MakeGenericMethod(whereProperty0.Type);

        //                    Expression constant3 = Expression.Constant(value.Split(',').ToList(), typeof(List<string>));    //定义常量
        //                    var greaterThanOrEqual3 = Expression.Call(method, new Expression[] { Expression.Constant(valueArr), whereProperty0 });
        //                    lambda = Expression.Lambda<Func<VipProjectDto, bool>>(greaterThanOrEqual3, Parameter0);
        //                }
        //                ////
        //                st = st.Where(lambda);
        //                ///
        //                //ParameterExpression parameter1 = Expression.Parameter(typeof(CustomRegionDto), "item");
        //                //Expression whereProperty = Expression.Property(parameter1, Key);
        //                //Expression constant = Expression.Constant(value);
        //                //Expression condition = Expression.Equal(whereProperty, constant);
        //                //Expression<Func<CustomRegionDto, bool>> lambda2 = Expression.Lambda<Func<CustomRegionDto, bool>>(condition, parameter1);
        //                //var TEMPST = cot.AsQueryable().Where(lambda2);
        //                ///
        //            }

        //        }
        //    }

        //    var Count = st.Count();
        //    var data= st.ToList().Skip((currentPage - 1) * pageSize).Take(pageSize).ToList();
           

        //    TableList<VipProjectDto> response = new TableList<VipProjectDto>
        //    {
        //        currentPage = currentPage,
        //        pageSize = pageSize,
        //        totalResult = Count,
        //        TList = data
        //    };
        //    return response;
        //}

        public bool AddVipProject(VipProject dto)
        {
            dto.LatestTime = DateTime.Now;
            var it = AddSingle(dto);
            return it > 0;
        }

        /// <summary>
        /// 做假删除
        /// </summary>
        /// <param name="Idlst"></param>
        /// <returns></returns>
        public bool UpdateRangeVipProject(List<VipProject> entitys)
        {
            var it = UpdateRange(entitys);
            return it;
        }

        public bool UpdateVipProject(VipProject dto)
        {
            var it = UpdateEntity(dto);
            return it > 0;
        }

       
    }
}
