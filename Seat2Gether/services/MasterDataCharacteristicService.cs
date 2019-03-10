using Seat2Gether.dto;
using Seat2Gether.Models;
using Seat2Gether.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Seat2Gether.services
{
    public class MasterDataCharacteristicService
    {
        private MasterDataCharacteristicRepository CharacteristicButtonRepository = null;

        public MasterDataCharacteristicService()
        {
            CharacteristicButtonRepository = new MasterDataCharacteristicRepository();
        }

        public List<MasterDataCharacteristicDto> TCharacteristicList()
        {

            List<MasterDataCharacteristicDto> characteristicDtoList = new List<MasterDataCharacteristicDto>();
            List<MasterDataCharacteristic> characteristicList = new List<MasterDataCharacteristic>();
            characteristicList = CharacteristicButtonRepository.TMerkmal();

            characteristicDtoList = characteristicList.CreateMappedList<MasterDataCharacteristic, MasterDataCharacteristicDto>();

            return characteristicDtoList;
        }



        public void AddCharacteristic(MasterDataCharacteristic characteristic)
        {

            CharacteristicButtonRepository.AddCharacteristic(characteristic);
        }

        
        public void DeleteCharacteristic(MasterDataCharacteristic characteristic)
        {
            CharacteristicButtonRepository.DeleteCharacteristic(characteristic);

        }


        public void UpdateCharacteristic(MasterDataCharacteristic characteristic)
        {
            CharacteristicButtonRepository.UpdateCharacteristic(characteristic);

        }
    }
}