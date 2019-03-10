using Seat2Gether.dto;
using Seat2Gether.Models;
using Seat2Gether.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Seat2Gether.services
{
    public class MasterDataVehicleSeatMainInfoService
    {
        private MasterDataVehicleMainInfoRepository vehicleSeatMainInfoRepository = null;

        public MasterDataVehicleSeatMainInfoService()
        {
            vehicleSeatMainInfoRepository = new MasterDataVehicleMainInfoRepository();
        }

        public List<MasterDataVehicleSeatMainInfoDto> VehicleSeatMainInfoList()
        {

            List<MasterDataVehicleSeatMainInfoDto> vehicleSeatMainInfoDtoList = new List<MasterDataVehicleSeatMainInfoDto>();
            List<MasterDataVehicleSeatMainInfo> vehicleSeatMainInfoList = new List<MasterDataVehicleSeatMainInfo>();
            vehicleSeatMainInfoList = vehicleSeatMainInfoRepository.VehicleMainInfoList();

            vehicleSeatMainInfoDtoList = vehicleSeatMainInfoList.CreateMappedList<MasterDataVehicleSeatMainInfo, MasterDataVehicleSeatMainInfoDto>();

            return vehicleSeatMainInfoDtoList;
        }



        public void AddVehicleSeatMainInfo(MasterDataVehicleSeatMainInfoDto vehicleSeatMainInfo)
        {

            MasterDataVehicleSeatMainInfo VehicleSeatMainInfoList = vehicleSeatMainInfo.CreateMapped<MasterDataVehicleSeatMainInfoDto, MasterDataVehicleSeatMainInfo>();
            vehicleSeatMainInfoRepository.AddVehicleSeatMainInfo(VehicleSeatMainInfoList);
        }


        public void UpdateVehicleSeatMainInfo(MasterDataVehicleSeatMainInfoDto vehicleSeatMainInfo)
        {
            MasterDataVehicleSeatMainInfo VehicleSeatMainInfoList = vehicleSeatMainInfo.CreateMapped<MasterDataVehicleSeatMainInfoDto, MasterDataVehicleSeatMainInfo>();
            vehicleSeatMainInfoRepository.UpdateVehicleSeatMainInfo(VehicleSeatMainInfoList);

        }


        public void DeleteVehicleSeatMainInfo(MasterDataVehicleSeatMainInfoDto vehicleSeatMainInfo)
        {
            MasterDataVehicleSeatMainInfo VehicleSeatMainInfoList = vehicleSeatMainInfo.CreateMapped<MasterDataVehicleSeatMainInfoDto, MasterDataVehicleSeatMainInfo>();
            vehicleSeatMainInfoRepository.DeleteVehicleSeatMainInfo(VehicleSeatMainInfoList);
        }

        public List<MasterDataVehicleSeatMainInfoDto> FindVehicleSeatMainInfoByVehicleId(decimal vehicleId)
        {

            List<MasterDataVehicleSeatMainInfoDto> vehicleSeatMainInfoDtoList = new List<MasterDataVehicleSeatMainInfoDto>();
            List<MasterDataVehicleSeatMainInfo> vehicleSeatMainInfoList = new List<MasterDataVehicleSeatMainInfo>();

            vehicleSeatMainInfoList = vehicleSeatMainInfoRepository.FindVehicleSeatMainByVehicleId(vehicleId);
            vehicleSeatMainInfoDtoList = vehicleSeatMainInfoList.CreateMappedList<MasterDataVehicleSeatMainInfo, MasterDataVehicleSeatMainInfoDto>();


            return vehicleSeatMainInfoDtoList;
        }
    }
}