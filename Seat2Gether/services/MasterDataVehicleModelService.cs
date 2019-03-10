using Seat2Gether.dto;
using Seat2Gether.Models;
using Seat2Gether.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Seat2Gether.services
{
    public class MasterDataVehicleModelService
    {
        private MasterDataVehicleModelRepository MasterDataVehicleRepository = null;

        public MasterDataVehicleModelService()
        {
            MasterDataVehicleRepository = new MasterDataVehicleModelRepository();
        }
        public List<MasterDataVehicleModelDto> VehicleModelFindList()
        {
            List<MasterDataVehicleModelDto> vehicleModelDtoList = new List<MasterDataVehicleModelDto>();
            List<MasterDataVehicleModel> vehicleModelList = new List<MasterDataVehicleModel>();
            vehicleModelList = MasterDataVehicleRepository.VehicleModelFindList();

            vehicleModelDtoList = vehicleModelList.CreateMappedList<MasterDataVehicleModel, MasterDataVehicleModelDto>();

            return vehicleModelDtoList;
        }


        public void AddVehicleModel(MasterDataVehicleModelDto vehicleModel)
        {
            MasterDataVehicleModel vehicleModelList = vehicleModel.CreateMapped<MasterDataVehicleModelDto, MasterDataVehicleModel>();
            MasterDataVehicleRepository.AddVehicleModel(vehicleModelList);
        }

        public void UpdateVehicleModel(MasterDataVehicleModelDto vehicleModel)
        {
            MasterDataVehicleModel vehicleModelList = vehicleModel.CreateMapped<MasterDataVehicleModelDto, MasterDataVehicleModel>();
            MasterDataVehicleRepository.UpdateVehicleModel(vehicleModelList);
        }

        public void DeleteVehicleModel(MasterDataVehicleModelDto vehicleModel)
        {
            MasterDataVehicleModel vehicleModelList = vehicleModel.CreateMapped<MasterDataVehicleModelDto, MasterDataVehicleModel>();
            MasterDataVehicleRepository.DeleteVehicleModel(vehicleModelList);
        }
    }
}