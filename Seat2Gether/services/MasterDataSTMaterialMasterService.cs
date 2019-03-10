using Seat2Gether.dto;
using Seat2Gether.Models;
using Seat2Gether.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Seat2Gether.services
{

    public class MasterDataSTMaterialMasterService
    {
        private MasterDataSTMaterialMasterRepository STMaterialMasterButtonRepository = null;
        public MasterDataSTMaterialMasterService()
        {
            STMaterialMasterButtonRepository = new MasterDataSTMaterialMasterRepository();
        }

        public List<MasterDataSTMaterialMasterDto> STMaterialMasterList()
        {
            List<MasterDataSTMaterialMasterDto> sTMaterialMasterDtoList = new List<MasterDataSTMaterialMasterDto>();
            List<MasterDataSTMaterialMaster> sTMaterialMasterList = new List<MasterDataSTMaterialMaster>();
            sTMaterialMasterList = STMaterialMasterButtonRepository.STMaterialMasterList();
            sTMaterialMasterDtoList = sTMaterialMasterList.CreateMappedList<MasterDataSTMaterialMaster, MasterDataSTMaterialMasterDto>();
            
            return sTMaterialMasterDtoList;
        }

        public void AddSTMaterialMaster(MasterDataSTMaterialMasterDto sTMaterialMaster)
        {
            MasterDataSTMaterialMaster stMaterialMaster = sTMaterialMaster.CreateMapped<MasterDataSTMaterialMasterDto, MasterDataSTMaterialMaster>();
            STMaterialMasterButtonRepository.AddSTMaterialMaster(stMaterialMaster);
        }

        public void UpdateSTMaterialMaster(MasterDataSTMaterialMasterDto sTMaterialMaster)
        {
            MasterDataSTMaterialMaster stMaterialMaster = sTMaterialMaster.CreateMapped<MasterDataSTMaterialMasterDto, MasterDataSTMaterialMaster>();
            STMaterialMasterButtonRepository.UpdateSTMaterialMaster(stMaterialMaster);
        }

        public void DeleteSTMaterialMaster(MasterDataSTMaterialMasterDto sTMaterialMaster)
        {
            MasterDataSTMaterialMaster stMaterialMaster = sTMaterialMaster.CreateMapped<MasterDataSTMaterialMasterDto, MasterDataSTMaterialMaster>();
            STMaterialMasterButtonRepository.DeleteSTMaterialMaster(stMaterialMaster);
        }
    }

}