using Seat2Gether.Models.ExternalModels;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Seat2Gether.Repositories.ExternalRepositories
{
   public class MasterDataSeatFabricTypeRepository
    {
      private Seat2GetherDBContext DBContext;

      public MasterDataSeatFabricTypeRepository()
      {
         DBContext = new Seat2GetherDBContext();
      }

      public List<ExMasterDataSeatFabricType> ExMasterDataSeatFabricTypeFindList()
      {
         var exMasterDataSeatFabricTypeQuery = from exMasterDataSeatFabricType in DBContext.ExMasterDataSeatFabricType
                                    select exMasterDataSeatFabricType;

         List<ExMasterDataSeatFabricType> vehicleSeatTypeList = exMasterDataSeatFabricTypeQuery.ToList();
         return vehicleSeatTypeList;
      }

      public void AddExMasterDataSeatFabricType(ExMasterDataSeatFabricType exMasterDataSeatFabricType)
      {
         DBContext.ExMasterDataSeatFabricType.Add(exMasterDataSeatFabricType);
         DBContext.SaveChanges();
      }

      public void UpdateExMasterDataSeatFabricType(ExMasterDataSeatFabricType exMasterDataSeatFabricType)
      {
         DBContext.ExMasterDataSeatFabricType.Attach(exMasterDataSeatFabricType);
         var entry = DBContext.Entry(exMasterDataSeatFabricType);
         entry.State = EntityState.Modified;
         DBContext.SaveChanges();
      }

      public void DeleteExMasterDataSeatFabricType(ExMasterDataSeatFabricType exMasterDataSeatFabricType)
      {
         DBContext.ExMasterDataSeatFabricType.Attach(exMasterDataSeatFabricType);
         var entry = DBContext.Entry(exMasterDataSeatFabricType);
         entry.State = EntityState.Deleted;
         DBContext.SaveChanges();
      }
   }
}
