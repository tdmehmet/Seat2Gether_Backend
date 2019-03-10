using Seat2Gether.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Seat2Gether.Repositories
{
    public class MasterDataVehicleTypeRepository
    {
        private Seat2GetherDBContext DBContext;

        public MasterDataVehicleTypeRepository()
        {
            DBContext = new Seat2GetherDBContext();
        }

        public List<MasterDataVehicleType> FindVehicleTypes()
        {
            var masterDataVehicleTypeQuery = from masterDataVehicleType in DBContext.MasterDataVehicleType
                                             orderby masterDataVehicleType.Id ascending
                                             select masterDataVehicleType;
            List<MasterDataVehicleType> masterDataVehicleTypeList = masterDataVehicleTypeQuery.ToList();
            return masterDataVehicleTypeList;
        }
    }
}