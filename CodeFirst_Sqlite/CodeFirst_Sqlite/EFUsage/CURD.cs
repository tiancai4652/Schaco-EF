using CodeFirst_Sqlite.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst_Sqlite.EFUsage
{
    ///https://www.cnblogs.com/yaopengfei/p/9196962.html
    /// <summary>
    /// 增删改查
    /// 有两种方式：① 通过方法操作  和  ② 通过状态控制。
    /// 方法（如果不是查出来的数据，而是创建出来的，需要Attach，新建除外）
    /// Entity.State
    /// 通过方法查到的数据都是已经被服务器追踪的，不用再Attach
    /// </summary>
    public class CURD
    {
        DBContext.DBContext context = new DBContext.DBContext();

        void Add()
        {
            ///方法
            context.Set<EMei>().Add(new Model.EMei());
            context.Set<EMei>().AddRange(new List<EMei>() { new Model.EMei() , new Model.EMei() });
            int n = context.SaveChanges();

            ///State
            context.Entry(new Model.EMei()).State = EntityState.Added;
            n = context.SaveChanges();
        }

        void Delete()
        {
            ///删除新建的实体
            var e = new Model.EMei();
            context.Set<EMei>().Attach(e);
            context.Set<EMei>().Remove(e);
            int n = context.SaveChanges();

            ///删除查询的实体
            var e1 = context.Set<EMei>().Find("some ID");
            context.Set<EMei>().Remove(e1);
            n = context.SaveChanges();

            ///State(new entity)
            context.Entry(new Model.EMei()).State = EntityState.Deleted;
            n = context.SaveChanges();

            ///State(existed entity)
            context.Entry(e1).State = EntityState.Deleted;
            n = context.SaveChanges();
        }

        void AddOrUpdate()
        {
            ///***如果是用方法执行修改操作，不能附加Attach，附加了Attach将导致修改失效，saveChange为0

            ///新实体去增加/修改
            context.Set<EMei>().AddOrUpdate(new Model.EMei());
            int n = context.SaveChanges();

            ///查询到的实体去增加/修改
            var e1 = context.Set<EMei>().Find("some ID");
            context.Set<EMei>().AddOrUpdate(e1);
            n = context.SaveChanges();

            ///新建一个已存在的实体(省去查询)Attach去修改
            var e2 = new Model.EMei() { ID = "some ID" };
            context.Set<EMei>().Attach(e2);
            e2.Name = "some Name";
            n = context.SaveChanges();

            ///查询一个已存在的实体去修改
            var e3= context.Set<EMei>().Find("some ID");
            e3.Name = "some Nmae";
            n = context.SaveChanges();

            ///State
            context.Entry(new Model.EMei()).State = EntityState.Modified;
            n = context.SaveChanges();

            ///State
            e3.Name = "some Nmae";
            context.Entry(e3).State = EntityState.Modified;
            n = context.SaveChanges();
        }
    }
}
