using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Models.Repository.ServerRepository
{
    public interface IDataRepository<TModel> : IDisposable
    where TModel : class
    {


        /// <summary>
        /// 查询全部数据
        /// </summary>
        /// <returns></returns>
        IQueryable<TModel> QueryAll();


        /// <summary>
        /// 查询单条数据
        /// </summary>
        /// <param name="predicate">查询单条数据的条件</param>
        /// <returns></returns>
        TModel QuerySingle(Expression<Func<TModel, bool>> predicate);


        /// <summary>
        /// 查询部分数据
        /// </summary>
        /// <param name="predicate">查询部分数据的条件</param>
        /// <returns></returns>
        IQueryable<TModel> QueryPart(Expression<Func<TModel, bool>> predicate);


        /// <summary>
        /// 单条添加数据
        /// </summary>
        /// <param name="instance">数据实例</param>
        /// <returns></returns>
        int AddSingle(TModel instance);


        /// <summary>
        /// 批量增加数据
        /// </summary>
        /// <param name="instance"></param>
        /// <returns></returns>
        int AddRange(List<TModel> instance);


        /// <summary>
        ///  根据条件删除数据
        /// </summary>
        /// <param name="predicate">删除数据的条件</param>
        /// <returns></returns>
        int DeleteSingle(Expression<Func<TModel, bool>> predicate);



        /// <summary>
        /// 批量删除数据
        /// </summary>
        /// <param name="instance">数据实体</param>
        /// <returns></returns>
        int DeleteRange(List<TModel> instance);



        /// <summary>
        /// 更新指定字段数据
        /// </summary>
        /// <param name="instance">数据实体</param>
        /// <param name="fileds">需要更新的字段</param>
        /// <returns></returns>
        //int UpdateEntityFields(TModel entity, List<string> fileds);



        /// <summary>
        /// 批量更新数据
        /// </summary>
        /// <param name="instance">更新的数据模型</param>
        /// <returns></returns>
        bool UpdateRange(List<TModel> instance);

    }
}
