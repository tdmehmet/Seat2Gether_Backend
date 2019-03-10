using Seat2Gether.dto;
using Seat2Gether.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Seat2Gether.Repositories
{

    public class MasterDataAdjustingLeverRepository
    {
        private Seat2GetherDBContext DBContext;
        public MasterDataAdjustingLeverRepository()
        {
            DBContext = new Seat2GetherDBContext();
        }

        public List<MasterDataAdjustingLever> AdjustingLeverList()
        {

            //var adjustingLeverQuery = (from y in ((from x in DBContext.AdjustingLever
            //                                       join w in DBContext.STMaterialMaster on x.PartNumber equals w.PartNumber
            //                                       select new
            //                                       {
            //                                           x.PartNumber,
            //                                           x.NumberOfBlocking,
            //                                           x.Designation,
            //                                           x.Page,
            //                                           w.Designations
            //                                       }))
            //                           select (y)).ToList();

            //List<AdjustingLeverDto> mapList = new List<AdjustingLeverDto>();

            //foreach (var i in adjustingLeverQuery)
            //{
            //    AdjustingLeverDto a = new AdjustingLeverDto();
            //    a.PartNumber = i.PartNumber;
            //    mapList.Add(a);
            //    a.NumberOfBlocking = i.NumberOfBlocking;
            //    mapList.Add(a);
            //    a.Designation = i.Designation;
            //    mapList.Add(a);
            //    a.Page = i.Page;
            //    mapList.Add(a);
            //    a.Designations = i.Designations;
            //    mapList.Add(a);
            //}
            //return mapList;
            var masterDataAdjustingLeverQuery = from adjustingLever in DBContext.AdjustingLever
                                                select adjustingLever;
            List<MasterDataAdjustingLever> masterDataAdjustingLeverList = masterDataAdjustingLeverQuery.ToList();
            return masterDataAdjustingLeverList;
        }

        public void AddAdjustingLever(MasterDataAdjustingLever adjustingLever)
        {
            DBContext.AdjustingLever.Add(adjustingLever);
            DBContext.SaveChanges();
        }

        public void UpdateAdjustingLever(MasterDataAdjustingLever adjustingLever)
        {
            DBContext.AdjustingLever.Attach(adjustingLever);
            var entry = DBContext.Entry(adjustingLever);
            entry.State = EntityState.Modified;
            DBContext.SaveChanges();
        }

        public void DeleteAdjustingLever(MasterDataAdjustingLever adjustingLever)
        {
            DBContext.AdjustingLever.Attach(adjustingLever);
            var entry = DBContext.Entry(adjustingLever);
            entry.State = EntityState.Deleted;
            DBContext.SaveChanges();
        }
    }

}