using Seat2Gether.dto;
using Seat2Gether.Models;
using Seat2Gether.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Seat2Gether.services
{

    public class MasterDataAdjustingLeverService
    {
        private MasterDataAdjustingLeverRepository AdjustingLeverButtonRepository = null;
        public MasterDataAdjustingLeverService()
        {
            AdjustingLeverButtonRepository = new MasterDataAdjustingLeverRepository();
        }

        public List<MasterDataAdjustingLeverDto> AdjustingLeverList()
        {
            List<MasterDataAdjustingLeverDto> adjustingLeverDtoList = new List<MasterDataAdjustingLeverDto>();
            List<MasterDataAdjustingLever> adjustingLeverList = new List<MasterDataAdjustingLever>();
            //adjustingLeverDtoList = AdjustingLeverButtonRepository.AdjustingLeverList();


            adjustingLeverList = AdjustingLeverButtonRepository.AdjustingLeverList();

            adjustingLeverDtoList = adjustingLeverList.CreateMappedList<MasterDataAdjustingLever, MasterDataAdjustingLeverDto>();

            return adjustingLeverDtoList;
        }

        public void AddAdjustingLever(MasterDataAdjustingLeverDto adjustingLever)
        {
            MasterDataAdjustingLever adjustinglever = adjustingLever.CreateMapped<MasterDataAdjustingLeverDto, MasterDataAdjustingLever>();
            AdjustingLeverButtonRepository.AddAdjustingLever(adjustinglever);
        }

        public void UpdateAdjustingLever(MasterDataAdjustingLeverDto adjustingLever)
        {
            MasterDataAdjustingLever adjustinglever = adjustingLever.CreateMapped<MasterDataAdjustingLeverDto, MasterDataAdjustingLever>();
            AdjustingLeverButtonRepository.UpdateAdjustingLever(adjustinglever);
        }

        public void DeleteAdjustingLever(MasterDataAdjustingLeverDto adjustingLever)
        {
            MasterDataAdjustingLever adjustinglever = adjustingLever.CreateMapped<MasterDataAdjustingLeverDto, MasterDataAdjustingLever>();
            AdjustingLeverButtonRepository.DeleteAdjustingLever(adjustinglever);
        }
    }

}