using Seat2Gether.dto;
using Seat2Gether.Models;
using Seat2Gether.Repositories;
using System.Collections.Generic;

namespace Seat2Gether.services
{
    public class MasterDataVehicleTypeService
    {

        private MasterDataVehicleTypeRepository MasterDataVehicleTypeRepository = null;

        public MasterDataVehicleTypeService()
        {
            MasterDataVehicleTypeRepository = new MasterDataVehicleTypeRepository();
        }

        public List<MasterDataVehicleTypeDto> FindVehicleTypes()
        {
            List<MasterDataVehicleTypeDto> masterDataVehicleTypeDtoList = new List<MasterDataVehicleTypeDto>();
            List<MasterDataVehicleType> masterDataVehicleTypeList = new List<MasterDataVehicleType>();
            masterDataVehicleTypeList = MasterDataVehicleTypeRepository.FindVehicleTypes();

            masterDataVehicleTypeDtoList = masterDataVehicleTypeList.CreateMappedList<MasterDataVehicleType, MasterDataVehicleTypeDto>();

            return masterDataVehicleTypeDtoList;
        }
    }
}