using Seat2Gether.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Seat2Gether.Repositories
{

    public class MasterDataRemarkRepository
    {
        private Seat2GetherDBContext DBContext;
        public MasterDataRemarkRepository()
        {
            DBContext = new Seat2GetherDBContext();
        }

        public List<MasterDataRemark> RemarkList()
        {
            var remarkQuery = from remark in DBContext.Remark
                              select remark;
            List<MasterDataRemark> remarkList = remarkQuery.ToList();
            return remarkList;
        }

        public void AddRemark(MasterDataRemark remark)
        {
            DBContext.Remark.Add(remark);
            DBContext.SaveChanges();
        }

        public void UpdateRemark(MasterDataRemark remark)
        {
            DBContext.Remark.Attach(remark);
            var entry = DBContext.Entry(remark);
            entry.State = EntityState.Modified;
            DBContext.SaveChanges();
        }

        public void DeleteRemark(MasterDataRemark remark)
        {
            DBContext.Remark.Attach(remark);
            var entry = DBContext.Entry(remark);
            entry.State = EntityState.Deleted;
            DBContext.SaveChanges();
        }
    }

}