using Seat2Gether.dto;
using Seat2Gether.Models;
using Seat2Gether.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Seat2Gether.services
{
    public class MasterDataMaterialService
    {

        private MasterDataMaterialRepository materialRepository = null;

        public MasterDataMaterialService()
        {
            materialRepository = new MasterDataMaterialRepository();
        }

        public List<MasterDataMaterialDto> MaterialList()
        {

            List<MasterDataMaterialDto> materialDtoList = new List<MasterDataMaterialDto>();
            List<MasterDataMaterial> materialList = new List<MasterDataMaterial>();
            materialList = materialRepository.MaterialList();

            materialDtoList = materialList.CreateMappedList<MasterDataMaterial, MasterDataMaterialDto>();

            return materialDtoList;
        }



        public void AddMaterial(MasterDataMaterialDto material)
        {

            MasterDataMaterial MaterialList = material.CreateMapped<MasterDataMaterialDto, MasterDataMaterial>();
            materialRepository.AddMaterial(MaterialList);
        }


        public void UpdateMaterial(MasterDataMaterialDto material)
        {
            MasterDataMaterial MaterialList = material.CreateMapped<MasterDataMaterialDto, MasterDataMaterial>();
            materialRepository.UpdateMaterial(MaterialList);

        }


        public void DeleteMaterial(MasterDataMaterialDto material)
        {
            MasterDataMaterial MaterialList = material.CreateMapped<MasterDataMaterialDto, MasterDataMaterial>();
            materialRepository.DeleteMaterial(MaterialList);
        }
    }
}