using Seat2Gether.dto.ExternalDto;
using Seat2Gether.Models.ExternalModels;
using Seat2Gether.Repositories.ExternalRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Seat2Gether.services.ExternalServices
{
   public class ExMasterDataSeatFabricTypeService
   {
      private MasterDataSeatFabricTypeRepository ExMasterDataSeatFabricTypeRepository = null;

      public ExMasterDataSeatFabricTypeService()
      {
         ExMasterDataSeatFabricTypeRepository = new MasterDataSeatFabricTypeRepository();
      }
      public List<ExMasterDataSeatFabricTypeDto> ExMasterDataSeatFabricTypeFindList()
      {
         List<ExMasterDataSeatFabricTypeDto> exMasterDataSeatFabricTypeDtoList = new List<ExMasterDataSeatFabricTypeDto>();
         List<ExMasterDataSeatFabricType> exMasterDataSeatFabricTypeList = new List<ExMasterDataSeatFabricType>();
         exMasterDataSeatFabricTypeList = ExMasterDataSeatFabricTypeRepository.ExMasterDataSeatFabricTypeFindList();

         exMasterDataSeatFabricTypeDtoList = exMasterDataSeatFabricTypeList.CreateMappedList<ExMasterDataSeatFabricType, ExMasterDataSeatFabricTypeDto>();

         return exMasterDataSeatFabricTypeDtoList;
      }


      public void AddExMasterDataSeatFabricType(ExMasterDataSeatFabricTypeDto exMasterDataSeatFabricType)
      {
         ExMasterDataSeatFabricType exMasterDataSeatFabricTypeList = exMasterDataSeatFabricType.CreateMapped<ExMasterDataSeatFabricTypeDto, ExMasterDataSeatFabricType>();
         ExMasterDataSeatFabricTypeRepository.AddExMasterDataSeatFabricType(exMasterDataSeatFabricTypeList);
      }

      public void UpdateExMasterDataSeatFabricType(ExMasterDataSeatFabricTypeDto exMasterDataSeatFabricType)
      {
         ExMasterDataSeatFabricType exMasterDataSeatFabricTypeList = exMasterDataSeatFabricType.CreateMapped<ExMasterDataSeatFabricTypeDto, ExMasterDataSeatFabricType>();
         ExMasterDataSeatFabricTypeRepository.UpdateExMasterDataSeatFabricType(exMasterDataSeatFabricTypeList);
      }

      public void DeleteExMasterDataSeatFabricType(ExMasterDataSeatFabricTypeDto exMasterDataSeatFabricType)
      {
         ExMasterDataSeatFabricType exMasterDataSeatFabricTypeList = exMasterDataSeatFabricType.CreateMapped<ExMasterDataSeatFabricTypeDto, ExMasterDataSeatFabricType>();
         ExMasterDataSeatFabricTypeRepository.DeleteExMasterDataSeatFabricType(exMasterDataSeatFabricTypeList);
      }
   }
}