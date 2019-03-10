using Seat2Gether.dto;
using Seat2Gether.Models;
using Seat2Gether.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Seat2Gether.services
{
    public class MasterDataStCharacteristicService
    {
        private MasterDataStCharacteristicRepository StCharacteristicButtonRepository = null;
        public MasterDataStCharacteristicService()
        {
            StCharacteristicButtonRepository = new MasterDataStCharacteristicRepository();
        }

        public List<MasterDataSTCharacteristicDto> StCharacteristicList()
        {
            List<MasterDataSTCharacteristicDto> stCharacteristicDtoList = new List<MasterDataSTCharacteristicDto>();
            List<MasterDataSTCharacteristic> stCharacteristicList = new List<MasterDataSTCharacteristic>();
            stCharacteristicList = StCharacteristicButtonRepository.StCharacteristicList();
            stCharacteristicDtoList = stCharacteristicList.CreateMappedList<MasterDataSTCharacteristic, MasterDataSTCharacteristicDto>();

            return stCharacteristicDtoList;
        }

        public void AddStCharacteristic(MasterDataSTCharacteristicDto stCharacteristic)
        {
            MasterDataSTCharacteristic stcharacteristic = stCharacteristic.CreateMapped<MasterDataSTCharacteristicDto, MasterDataSTCharacteristic>();
            StCharacteristicButtonRepository.AddStCharacteristic(stcharacteristic);
        }
        public void UpdateStCharacteristic(MasterDataSTCharacteristicDto stCharacteristic)
        {
            MasterDataSTCharacteristic stcharacteristic = stCharacteristic.CreateMapped<MasterDataSTCharacteristicDto, MasterDataSTCharacteristic>();
            StCharacteristicButtonRepository.UpdateStCharacteristic(stcharacteristic);
        }
        public void DeleteStCharacteristic(MasterDataSTCharacteristicDto stCharacteristic)
        {
            MasterDataSTCharacteristic stcharacteristic = stCharacteristic.CreateMapped<MasterDataSTCharacteristicDto, MasterDataSTCharacteristic>();
            StCharacteristicButtonRepository.DeleteStCharacteristic(stcharacteristic);
        }
    }

}