using Seat2Gether.dto;
using Seat2Gether.Models;
using Seat2Gether.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Seat2Gether.services
{
    public class MasterDataVehicleSeatHeaderFastenerTypeService
    {
        private MasterDataVehicleSeatHeaderFastenerTypeRepository vehicleSeatHeaderFastenerTypeRepository = null;

        public MasterDataVehicleSeatHeaderFastenerTypeService()
        {
            vehicleSeatHeaderFastenerTypeRepository = new MasterDataVehicleSeatHeaderFastenerTypeRepository();
        }

        public List<MasterDataVehicleSeatHeaderFastenerTypeDto> FindVehicleSeatHeaderFastenerType()
        {
            List<MasterDataVehicleSeatHeaderFastenerType> vehicleSeatHeaderFastenerTypeList = new List<MasterDataVehicleSeatHeaderFastenerType>();
            List<MasterDataVehicleSeatHeaderFastenerTypeDto> vehicleSeatHeaderFastenerTypeDtoList = new List<MasterDataVehicleSeatHeaderFastenerTypeDto>();
            vehicleSeatHeaderFastenerTypeList = vehicleSeatHeaderFastenerTypeRepository.VehicleSeatHeaderFastenerList();

            vehicleSeatHeaderFastenerTypeDtoList = vehicleSeatHeaderFastenerTypeList.CreateMappedList<MasterDataVehicleSeatHeaderFastenerType, MasterDataVehicleSeatHeaderFastenerTypeDto>();
            return vehicleSeatHeaderFastenerTypeDtoList;

        }

        public void AddVehicleSeatHeaderFastenerType(MasterDataVehicleSeatHeaderFastenerTypeDto vehicleSeatHeaderFastenerType)
        {
            MasterDataVehicleSeatHeaderFastenerType vehicleSeatHeaderFastenerTypeList = vehicleSeatHeaderFastenerType.CreateMapped<MasterDataVehicleSeatHeaderFastenerTypeDto, MasterDataVehicleSeatHeaderFastenerType>();
            vehicleSeatHeaderFastenerTypeRepository.AddVehicleSeatHeaderFastenerType(vehicleSeatHeaderFastenerTypeList);
        }

        public void UpdateVehicleSeatHeaderFastenerType(MasterDataVehicleSeatHeaderFastenerTypeDto vehicleSeatHeaderFastenerType)
        {
            MasterDataVehicleSeatHeaderFastenerType vehicleSeatHeaderFastenerTypeList = vehicleSeatHeaderFastenerType.CreateMapped<MasterDataVehicleSeatHeaderFastenerTypeDto, MasterDataVehicleSeatHeaderFastenerType>();
            vehicleSeatHeaderFastenerTypeRepository.UpdateVehicleSeatHeaderFastenerType(vehicleSeatHeaderFastenerTypeList);
        }

        public void DeleteVehicleSeatHeaderFastenerType(MasterDataVehicleSeatHeaderFastenerTypeDto vehicleSeatHeaderFastenerType)
        {
            MasterDataVehicleSeatHeaderFastenerType vehicleSeatHeaderFastenerTypeList = vehicleSeatHeaderFastenerType.CreateMapped<MasterDataVehicleSeatHeaderFastenerTypeDto, MasterDataVehicleSeatHeaderFastenerType>();
            vehicleSeatHeaderFastenerTypeRepository.DeleteVehicleSeatHeaderFastenerType(vehicleSeatHeaderFastenerTypeList);
        }


    }
}