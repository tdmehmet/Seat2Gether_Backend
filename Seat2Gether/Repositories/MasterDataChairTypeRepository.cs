using Seat2Gether.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Seat2Gether.Repositories
{
    public class MasterDataChairTypeRepository
    {
        private Seat2GetherDBContext DBContext;

        public MasterDataChairTypeRepository()
        {
            DBContext = new Seat2GetherDBContext();
        }


        public List<MasterDataChairType> ChairTypeList()
        {

            var chairTypeQuery = from chairType in DBContext.ChairType
                                 select chairType;

            List<MasterDataChairType> chairTypeList = chairTypeQuery.ToList();

            return chairTypeList;
        }



        public void AddChairType(MasterDataChairType chairType)
        {
            DBContext.ChairType.Add(chairType);
            DBContext.SaveChanges();
        }


        public void UpdateChairType(MasterDataChairType chairType)
        {
            DBContext.ChairType.Attach(chairType);
            var entry = DBContext.Entry(chairType);
            entry.State = EntityState.Modified;

            DBContext.SaveChanges();
        }


        public void DeleteChairType(MasterDataChairType chairType)
        {
            DBContext.ChairType.Attach(chairType);
            var entry = DBContext.Entry(chairType);
            entry.State = EntityState.Deleted;
            DBContext.SaveChanges();
        }




    }
}