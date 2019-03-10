using Seat2Gether.dto;
using Seat2Gether.Models;
using Seat2Gether.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Seat2Gether.services
{
    public class MasterDataVehicleSeatTypeService
    {
        private MasterDataVehicleSeatTypeRepository MasterDataVehicleSeatTypeRepository = null;

        public MasterDataVehicleSeatTypeService()
        {
            MasterDataVehicleSeatTypeRepository = new MasterDataVehicleSeatTypeRepository();
        }
        public List<MasterDataVehicleSeatTypeDto> VehicleSeatTypeFindList()
        {
            List<MasterDataVehicleSeatTypeDto> vehicleSeatTypeDtoList = new List<MasterDataVehicleSeatTypeDto>();
            List<MasterDataVehicleSeatType> vehicleSeatTypeList = new List<MasterDataVehicleSeatType>();
            vehicleSeatTypeList = MasterDataVehicleSeatTypeRepository.VehicleSeatTypeFindList();

            vehicleSeatTypeDtoList = vehicleSeatTypeList.CreateMappedList<MasterDataVehicleSeatType, MasterDataVehicleSeatTypeDto>();

            return vehicleSeatTypeDtoList;
        }


        public void AddVehicleSeatType(MasterDataVehicleSeatTypeDto vehicleSeatType)
        {
            MasterDataVehicleSeatType vehicleSeatTypeList = vehicleSeatType.CreateMapped<MasterDataVehicleSeatTypeDto, MasterDataVehicleSeatType>();
            MasterDataVehicleSeatTypeRepository.AddVehicleSeatType(vehicleSeatTypeList);
        }

        public void UpdateVehicleSeatType(MasterDataVehicleSeatTypeDto vehicleSeatType)
        {
            MasterDataVehicleSeatType vehicleSeatTypeList = vehicleSeatType.CreateMapped<MasterDataVehicleSeatTypeDto, MasterDataVehicleSeatType>();
            MasterDataVehicleSeatTypeRepository.UpdateVehicleSeatType(vehicleSeatTypeList);
        }

        public void DeleteVehicleSeatType(MasterDataVehicleSeatTypeDto vehicleSeatType)
        {
            MasterDataVehicleSeatType vehicleSeatTypeList = vehicleSeatType.CreateMapped<MasterDataVehicleSeatTypeDto, MasterDataVehicleSeatType>();
            MasterDataVehicleSeatTypeRepository.DeleteVehicleSeatType(vehicleSeatTypeList);
        }
    }
}