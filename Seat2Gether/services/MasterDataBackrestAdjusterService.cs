using Seat2Gether.dto;
using Seat2Gether.Models;
using Seat2Gether.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Seat2Gether.services
{

    public class MasterDataBackrestAdjusterService
    {
        private MasterDataBackrestAdjusterRepository BackrestAdjusterButtonRepository = null;
        public MasterDataBackrestAdjusterService()
        {
            BackrestAdjusterButtonRepository = new MasterDataBackrestAdjusterRepository();
        }

        public List<MasterDataBackrestAdjusterDto> BackrestAdjusterList()
        {
            List<MasterDataBackrestAdjusterDto> backrestAdjusterDtoList = new List<MasterDataBackrestAdjusterDto>();
            List<MasterDataBackrestAdjuster> backrestAdjusterList = new List<MasterDataBackrestAdjuster>();
            backrestAdjusterList = BackrestAdjusterButtonRepository.BackrestAdjusterList();
            backrestAdjusterDtoList = backrestAdjusterList.CreateMappedList<MasterDataBackrestAdjuster, MasterDataBackrestAdjusterDto>();
            return backrestAdjusterDtoList;
        }

        public void AddBackrestAdjuster(MasterDataBackrestAdjusterDto backrestAdjuster)
        {
            MasterDataBackrestAdjuster backrestadjuster = backrestAdjuster.CreateMapped<MasterDataBackrestAdjusterDto, MasterDataBackrestAdjuster>();
            BackrestAdjusterButtonRepository.AddBackrestAdjuster(backrestadjuster);
        }
        
        public void UpdateBackrestAdjuster(MasterDataBackrestAdjusterDto backrestAdjuster)
        {
            MasterDataBackrestAdjuster backrestadjuster = backrestAdjuster.CreateMapped<MasterDataBackrestAdjusterDto, MasterDataBackrestAdjuster>();
            BackrestAdjusterButtonRepository.UpdateBackrestAdjuster(backrestadjuster);
        }

        public void DeleteBackrestAdjuster(MasterDataBackrestAdjusterDto backrestAdjuster)
        {
            MasterDataBackrestAdjuster backrestadjuster = backrestAdjuster.CreateMapped<MasterDataBackrestAdjusterDto, MasterDataBackrestAdjuster>();
            BackrestAdjusterButtonRepository.DeleteBackrestAdjuster(backrestadjuster);
        }
    }
}