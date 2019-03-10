using Seat2Gether.dto;
using Seat2Gether.Models;
using Seat2Gether.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Seat2Gether.services
{
    public class MasterDataVehicleService
    {
            private MasterDataVehicleRepository vehicleRepository = null;

            public MasterDataVehicleService()
            {
            vehicleRepository = new MasterDataVehicleRepository();
            }

            public List<MasterDataVehicleDto> VehicleList()
            {

                List<MasterDataVehicleDto> vehicleDtoList = new List<MasterDataVehicleDto>();
                List<MasterDataVehicle> vehicleList = new List<MasterDataVehicle>();
                vehicleList = vehicleRepository.VehicleList();

                vehicleDtoList = vehicleList.CreateMappedList<MasterDataVehicle,MasterDataVehicleDto>();

                return vehicleDtoList;
            }



        public void AddVehicle(MasterDataVehicleDto vehicle)
        {

            MasterDataVehicle VehicleList = vehicle.CreateMapped<MasterDataVehicleDto, MasterDataVehicle>();
            vehicleRepository.AddVehicle(VehicleList);
        }


        public void UpdateVehicle(MasterDataVehicleDto vehicle)
        {
            MasterDataVehicle VehicleList = vehicle.CreateMapped<MasterDataVehicleDto, MasterDataVehicle>();
            vehicleRepository.UpdateVehicle(VehicleList);

        }


        public void DeleteVehicle(MasterDataVehicleDto vehicle)
        {
            MasterDataVehicle VehicleList = vehicle.CreateMapped<MasterDataVehicleDto, MasterDataVehicle>();
            vehicleRepository.DeleteVehicle(VehicleList);
        }

        public List<MasterDataVehicleDto> FindVehicleByBody(MasterDataVehicleDto masterDataVehicleDto)
        {
            MasterDataVehicle masterDataVehicle = masterDataVehicleDto.CreateMapped<MasterDataVehicleDto, MasterDataVehicle>();
            
            List<MasterDataVehicle> vehicleList = vehicleRepository.FindVehicleByBody(masterDataVehicle);

            return vehicleList.CreateMappedList<MasterDataVehicle, MasterDataVehicleDto>();
        }

        public List<MasterDataVehicleDto> FindVehicleByID(decimal vehicleID)
        {

            List<MasterDataVehicleDto> vehicleDtoList = new List<MasterDataVehicleDto>();
            List<MasterDataVehicle> vehicleList = new List<MasterDataVehicle>();
            
            vehicleList = vehicleRepository.FindVehicleByID(vehicleID);
            vehicleDtoList = vehicleList.CreateMappedList<MasterDataVehicle, MasterDataVehicleDto>();


            return vehicleDtoList;
        }
    }
}