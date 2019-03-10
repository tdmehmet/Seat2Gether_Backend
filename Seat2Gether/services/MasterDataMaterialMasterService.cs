using Seat2Gether.dto;
using Seat2Gether.Models;
using Seat2Gether.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Seat2Gether.services
{
    public class MasterDataMaterialMasterService
    {

        private MasterDataMaterialMasterRepository MaterialMasterButtonRepository = null;

        public MasterDataMaterialMasterService()
        {
            MaterialMasterButtonRepository = new MasterDataMaterialMasterRepository();
        }

        public List<MasterDataMaterialMasterDto> MaterialMasterList()
        {

            List<MasterDataMaterialMasterDto> materialMasterDtoList = new List<MasterDataMaterialMasterDto>();
            List<MasterDataMaterialMaster> materialMasterList = new List<MasterDataMaterialMaster>();
            materialMasterList = MaterialMasterButtonRepository.MaterialMasterList();

            materialMasterDtoList = materialMasterList.CreateMappedList<MasterDataMaterialMaster, MasterDataMaterialMasterDto>();

            return materialMasterDtoList;
        }



        public void AddMaterialMaster(MasterDataMaterialMaster materialMaster)
        {

            MaterialMasterButtonRepository.AddMaterialMaster(materialMaster);
        }


        public void DeleteMaterialMaster(MasterDataMaterialMaster materialMaster)
        {
            MaterialMasterButtonRepository.DeleteMaterialMaster(materialMaster);

        }


        public void UpdateMaterialMaster(MasterDataMaterialMaster materialMaster)
        {
            MaterialMasterButtonRepository.UpdateMaterialMaster(materialMaster);

        }
    }
}