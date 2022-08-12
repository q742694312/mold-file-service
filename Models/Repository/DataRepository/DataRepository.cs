using Models;
using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Linq.Expressions;
using Models.DBContexts;

namespace Models.Repository.ServerRepository
{
    public class DataRepository<TModel> : IDataRepository<TModel>
    where TModel : class
    {
        protected DbContext _context;

        protected bool _isSharedContext;

        public IQueryable<TModel> tm;

        #region 构造函数
        /// <summary>
        /// 自定义构造函数
        /// </summary>
        /// <param name="context">上下文对象</param>
        /// <param name="isSharedContext">是否共享的上下文</param>
        public DataRepository(DbContext context = null, bool isSharedContext = false)
        {
            _context = context ?? new BigDataContext();
            _isSharedContext = isSharedContext;
            tm = _context.Set<TModel>();


        }
        #endregion 构造函数

        #region 数据查询

        /// <summary>
        /// 查询全部数据
        /// </summary>
        /// <returns></returns>
        public IQueryable<TModel> QueryAll()
        {
            return QueryPart(x => true);
        }

        /// <summary>
        /// 查询单条数据
        /// </summary>
        /// <param name="predicate">查询单条数据的条件</param>
        /// <returns></returns>
        public TModel QuerySingle(Expression<Func<TModel, bool>> predicate)
        {
            return _context.Set<TModel>().SingleOrDefault(predicate);
        }

        /// <summary>
        /// 查询部分数据
        /// </summary>
        /// <param name="predicate">查询部分数据的条件</param>
        /// <returns></returns>
        public IQueryable<TModel> QueryPart(Expression<Func<TModel, bool>> predicate)
        {
            return _context.Set<TModel>().Where(predicate);
        }
        #endregion 数据查询

        #region 增加数据
        /// <summary>
        /// 单条添加数据
        /// </summary>
        /// <param name="instance">数据实例</param>
        /// <returns></returns>
        public int AddSingle(TModel instance)
        {
            Contract.Requires(instance != null);
            _context.Set<TModel>().Add(instance);
            return Save();
        }

        /// <summary>
        /// 批量增加数据
        /// </summary>
        /// <param name="instance"></param>
        /// <returns></returns>
        public int AddRange(List<TModel> instance)
        {
            _context.Set<TModel>().AddRange(instance);
            return Save();
        }
        #endregion 增加数据

        #region 删除数据
        /// <summary>
        ///  根据条件删除数据
        /// </summary>
        /// <param name="predicate">删除数据的条件</param>
        /// <returns></returns>
        public int DeleteSingle(Expression<Func<TModel, bool>> predicate)
        {
            var EntityModel = QuerySingle(predicate);
            _context.Set<TModel>().Remove(EntityModel);
            return Save();
        }


        /// <summary>
        /// 批量删除数据
        /// </summary>
        /// <param name="instance">数据实体</param>
        /// <returns></returns>
        public int DeleteRange(List<TModel> instance)
        {
            _context.Set<TModel>().RemoveRange(instance);
            return Save();
        }

        #endregion 删除数据

        #region 更新数据
        /// <summary>
        /// 单个对象更新指定字段数据
        /// </summary>
        /// <param name="instance">数据实体</param>
        /// <param name="fileds">需要更新的字段</param>
        /// <returns></returns>
        //public int UpdateEntityFields(TModel entity, List<string> fileds)
        //{
        //    if (entity != null && fileds != null)
        //    {
        //        _context.Set<TModel>().Attach(entity);
        //        var SetEntry = ((IObjectContextAdapter)_context).ObjectContext.
        //            ObjectStateManager.GetObjectStateEntry(entity);
        //        foreach (var t in fileds)
        //        {
        //            SetEntry.SetModifiedProperty(t);
        //        }
        //    }
        //    return Save();
        //}


        /// <summary>
        /// 单个对象模型更新
        /// </summary>
        /// <param name="entity">新模型</param>
        /// <returns></returns>
        public int UpdateEntity(TModel entity)
        {
            _context.Set<TModel>().Update(entity);
            return Save();
        }

        public int UpdateEntity(List<TModel> entitys)
        {
            _context.Set<TModel>().UpdateRange(entitys);
            return Save();
        }


        /// <summary>
        /// 批量更新数据
        /// </summary>
        /// <param name="instance">更新的数据模型</param>
        /// <returns></returns>
        public bool UpdateRange(List<TModel> instance)
        {
            if (instance != null)
            {
                foreach (var items in instance)
                {
                    var EntityModel = _context.Entry(items);
                    _context.Set<TModel>().Attach(items);
                    EntityModel.State = EntityState.Modified;
                }
            }
            return Save() > 0;
        }

        #endregion 更新数据

        #region 保存数据
        /// <summary>
        /// 保存操作的方法
        /// </summary>
        /// <returns></returns>
        public int Save()
        {
            if (!_isSharedContext)
                return _context.SaveChanges();
            return 0;
        }
        #endregion 保存数据

        #region 分页查询
        /// <summary>
        /// 分页查询
        /// </summary>
        /// <param name="pageIndex">当前页码</param>
        /// <param name="pageSize">每页大小</param>
        /// <param name="rows">总条数</param>
        /// <param name="orderBy">排序条件（一定要有）</param>
        /// <param name="whereLambda">查询添加（可有，可无）</param>
        /// <param name="isOrder">是否是Order排序</param>
        /// <returns></returns>
        public List<TModel> Page<TKey>(int pageIndex, int pageSize, out int rows, Expression<Func<TModel, TKey>> orderBy, Expression<Func<TModel, bool>> whereLambda = null, bool isOrder = true)
        {
            IQueryable<TModel> data = isOrder ?
               _context.Set<TModel>().OrderBy(orderBy) :
               _context.Set<TModel>().OrderByDescending(orderBy);

            if (whereLambda != null)
            {
                data = data.Where(whereLambda);
            }
            rows = data.Count();
            return data.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();
        }
        #endregion 分页查询

        #region 销毁对象
        /// <summary>
        /// 对象的销毁处理 
        /// </summary>
        public void Dispose()
        {
            if (_context == null)
                return;
            _context.Dispose();
        }
        #endregion 销毁对象

    }
}

