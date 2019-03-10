using Seat2Gether.dto;
using Seat2Gether.Models;
using Seat2Gether.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Seat2Gether.services
{

    public class MasterDataVehicleSeatFabricService
    {
        private MasterDataVehicleSeatFabricRepository vehicleSeatFabricRepository = null;

        public MasterDataVehicleSeatFabricService()
        {
            vehicleSeatFabricRepository = new MasterDataVehicleSeatFabricRepository();
        }

        public List<MasterDataVehicleSeatFabricDto> VehicleSeatFabricList()
        {

            List<MasterDataVehicleSeatFabricDto> vehicleSeatFabricDtoList = new List<MasterDataVehicleSeatFabricDto>();
            List<MasterDataVehicleSeatFabric> vehicleSeatFabricList = new List<MasterDataVehicleSeatFabric>();
            vehicleSeatFabricList = vehicleSeatFabricRepository.VehicleSeatFabricList();

            vehicleSeatFabricDtoList = vehicleSeatFabricList.CreateMappedList<MasterDataVehicleSeatFabric, MasterDataVehicleSeatFabricDto>();

            return vehicleSeatFabricDtoList;
        }



        public void AddVehicleSeatFabric(MasterDataVehicleSeatFabricDto vehicleSeatFabric)
        {

            MasterDataVehicleSeatFabric VehicleSeatFabricList = vehicleSeatFabric.CreateMapped<MasterDataVehicleSeatFabricDto, MasterDataVehicleSeatFabric>();
            vehicleSeatFabricRepository.AddVehicleSeatFabric(VehicleSeatFabricList);
        }


        public void UpdateVehicleSeatFabric(MasterDataVehicleSeatFabricDto vehicleSeatFabric)
        {
            MasterDataVehicleSeatFabric VehicleSeatFabricList = vehicleSeatFabric.CreateMapped<MasterDataVehicleSeatFabricDto, MasterDataVehicleSeatFabric>();
            vehicleSeatFabricRepository.UpdateVehicleSeatFabric(VehicleSeatFabricList);

        }


        public void DeleteVehicleSeatFabric(MasterDataVehicleSeatFabricDto vehicleSeatFabric)
        {
            MasterDataVehicleSeatFabric VehicleSeatFabricList = vehicleSeatFabric.CreateMapped<MasterDataVehicleSeatFabricDto, MasterDataVehicleSeatFabric>();
            vehicleSeatFabricRepository.DeleteVehicleSeatFabric(VehicleSeatFabricList);
        }

        public List<MasterDataVehicleSeatFabricDto> FindVehicleSeatFabricByVehicleId(decimal vehicleId)
        {

            List<MasterDataVehicleSeatFabricDto> vehicleSeatFabricDtoList = new List<MasterDataVehicleSeatFabricDto>();
            List<MasterDataVehicleSeatFabric> vehicleSeatFabricList = new List<MasterDataVehicleSeatFabric>();

            vehicleSeatFabricList = vehicleSeatFabricRepository.FindVehicleSeatFabricByVehicleId(vehicleId);
            vehicleSeatFabricDtoList = vehicleSeatFabricList.CreateMappedList<MasterDataVehicleSeatFabric, MasterDataVehicleSeatFabricDto>();


            return vehicleSeatFabricDtoList;
        }
    }
}
