using Seat2Gether.dto;
using Seat2Gether.Models;
using Seat2Gether.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Seat2Gether.services
{
    public class MasterDataSideCoverService
    {
        private MasterDataSideCoverRepository SideCoverButtonRepository = null;
        public MasterDataSideCoverService()
        {
            SideCoverButtonRepository = new MasterDataSideCoverRepository();
        }

        public List<MasterDataSideCoverDto> SideCoverList()
        {
            List<MasterDataSideCoverDto> sideCoverDtoList = new List<MasterDataSideCoverDto>();
            List<MasterDataSideCover> sideCoverList = new List<MasterDataSideCover>();
            sideCoverList = SideCoverButtonRepository.SideCoverList();
            sideCoverDtoList = sideCoverList.CreateMappedList<MasterDataSideCover, MasterDataSideCoverDto>();

            return sideCoverDtoList;
        }

        public void AddSideCover(MasterDataSideCoverDto sideCover)
        {
            MasterDataSideCover sidecover = sideCover.CreateMapped<MasterDataSideCoverDto, MasterDataSideCover>();
            SideCoverButtonRepository.AddSideCover(sidecover);
        }

        public void UpdateSideCover(MasterDataSideCoverDto sideCover)
        {
            MasterDataSideCover sidecover = sideCover.CreateMapped<MasterDataSideCoverDto, MasterDataSideCover>();
            SideCoverButtonRepository.UpdateSideCover(sidecover);
        }
        public void DeleteSideCover(MasterDataSideCoverDto sideCover)
        {
            MasterDataSideCover sidecover = sideCover.CreateMapped<MasterDataSideCoverDto, MasterDataSideCover>();
            SideCoverButtonRepository.DeleteSideCover(sidecover);
        }
    }

}