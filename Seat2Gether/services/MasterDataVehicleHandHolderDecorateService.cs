using Seat2Gether.dto;
using Seat2Gether.Models;
using Seat2Gether.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Seat2Gether.services
{
    public class MasterDataVehicleHandHolderDecorateService
    {
        private MasterDataVehicleHandHolderDecorateRepository MasterDataVehicleHandHolderDecorateRepository = null;

        public MasterDataVehicleHandHolderDecorateService()
        {
            MasterDataVehicleHandHolderDecorateRepository = new MasterDataVehicleHandHolderDecorateRepository();
        }

        public List<MasterDataVehicleHandHolderDecorateDto> VehicleHandHolderDecorateList()
        {
            List<MasterDataVehicleHandHolderDecorate> VehicleHandHolderDecorateList = new List<MasterDataVehicleHandHolderDecorate>();
            List<MasterDataVehicleHandHolderDecorateDto> VehicleHandHolderDecorateDtoList = new List<MasterDataVehicleHandHolderDecorateDto>();
            VehicleHandHolderDecorateList = MasterDataVehicleHandHolderDecorateRepository.VehicleHandHolderDecorateList();

            VehicleHandHolderDecorateDtoList = VehicleHandHolderDecorateList.CreateMappedList<MasterDataVehicleHandHolderDecorate, MasterDataVehicleHandHolderDecorateDto>();
            return VehicleHandHolderDecorateDtoList;

        }

        public void  AddMasterDataVehicleHandHolderDecorate(MasterDataVehicleHandHolderDecorateDto VehicleHandHolderDecorate)
        {
            MasterDataVehicleHandHolderDecorate VehicleHandHolderDecorateList = VehicleHandHolderDecorate.CreateMapped<MasterDataVehicleHandHolderDecorateDto, MasterDataVehicleHandHolderDecorate>();
            MasterDataVehicleHandHolderDecorateRepository.AddVehicleHandHolderDecorate(VehicleHandHolderDecorateList);
        }

        public void UpdateMasterDataVehicleHandHolderDecorate(MasterDataVehicleHandHolderDecorateDto VehicleHandHolderDecorate)
        {
            MasterDataVehicleHandHolderDecorate VehicleHandHolderDecorateList = VehicleHandHolderDecorate.CreateMapped<MasterDataVehicleHandHolderDecorateDto, MasterDataVehicleHandHolderDecorate>();
            MasterDataVehicleHandHolderDecorateRepository.UpdateVehicleHandHolderDecorate(VehicleHandHolderDecorateList);
        }

        public void DeleteMasterDataVehicleHandHolderDecorate(MasterDataVehicleHandHolderDecorateDto VehicleHandHolderDecorate)
        {
            MasterDataVehicleHandHolderDecorate VehicleHandHolderDecorateList = VehicleHandHolderDecorate.CreateMapped<MasterDataVehicleHandHolderDecorateDto, MasterDataVehicleHandHolderDecorate>();
            MasterDataVehicleHandHolderDecorateRepository.DeleteVehicleHandHolderDecorate(VehicleHandHolderDecorateList);
        }
    }
}