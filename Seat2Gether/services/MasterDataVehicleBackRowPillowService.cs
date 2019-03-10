using Seat2Gether.dto;
using Seat2Gether.Models;
using Seat2Gether.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Seat2Gether.services
{
    public class MasterDataVehicleBackRowPillowService
    {
        private MasterDataVehicleBackRowPillowRepository MasterDataVehicleBackRowPillowRepository = null;

        public MasterDataVehicleBackRowPillowService()
        {
            MasterDataVehicleBackRowPillowRepository = new MasterDataVehicleBackRowPillowRepository();
        }

        public List<MasterDataVehicleBackRowPillowDto> VehicleBackRowPillowList()
        {
            List<MasterDataVehicleBackRowPillow> VehicleBackRowPillowList = new List<MasterDataVehicleBackRowPillow>();
            List<MasterDataVehicleBackRowPillowDto> VehicleBackRowPillowDtoList = new List<MasterDataVehicleBackRowPillowDto>();
            VehicleBackRowPillowList = MasterDataVehicleBackRowPillowRepository.VehicleBackRowPillowList();

            VehicleBackRowPillowDtoList = VehicleBackRowPillowList.CreateMappedList<MasterDataVehicleBackRowPillow, MasterDataVehicleBackRowPillowDto>();
            return VehicleBackRowPillowDtoList;
        }

        public void AddVehicleBackRowPillow(MasterDataVehicleBackRowPillowDto vehicleBackRowPillow)
        {
            MasterDataVehicleBackRowPillow VehicleBackRowPillowList = vehicleBackRowPillow.CreateMapped<MasterDataVehicleBackRowPillowDto, MasterDataVehicleBackRowPillow>();
            MasterDataVehicleBackRowPillowRepository.AddVehicleBackRowPillow(VehicleBackRowPillowList);
        }

        public void UpdateVehicleBackRowPillow(MasterDataVehicleBackRowPillowDto vehicleBackRowPillow)
        {
            MasterDataVehicleBackRowPillow VehicleBackRowPillowList = vehicleBackRowPillow.CreateMapped<MasterDataVehicleBackRowPillowDto, MasterDataVehicleBackRowPillow>();
            MasterDataVehicleBackRowPillowRepository.UpdateVehicleBackRowPillow(VehicleBackRowPillowList);
        }

        public void DeleteVehicleBackRowPillow(MasterDataVehicleBackRowPillowDto vehicleBackRowPillow)
        {
            MasterDataVehicleBackRowPillow VehicleBackRowPillowList = vehicleBackRowPillow.CreateMapped<MasterDataVehicleBackRowPillowDto, MasterDataVehicleBackRowPillow>();
            MasterDataVehicleBackRowPillowRepository.DeleteVehicleBackRowPillow(VehicleBackRowPillowList);
        }
    }
}