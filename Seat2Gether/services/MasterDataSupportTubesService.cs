using Seat2Gether.dto;
using Seat2Gether.Models;
using Seat2Gether.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Seat2Gether.services
{
    public class MasterDataSupportTubesService
    {
        private MasterDataSupportTubesRepository MasterDataSupportTubesRepository = null;

        public MasterDataSupportTubesService()
        {
            MasterDataSupportTubesRepository = new MasterDataSupportTubesRepository();
        }

        public List<MasterDataSupportTubesDto> SupportTubesList()
        {
            List<MasterDataSupportTubes> supportTubesList = new List<MasterDataSupportTubes>();
            List<MasterDataSupportTubesDto> supportTubesDtoList = new List<MasterDataSupportTubesDto>();

            supportTubesList = MasterDataSupportTubesRepository.SupportTubesList();
            supportTubesDtoList = supportTubesList.CreateMappedList<MasterDataSupportTubes, MasterDataSupportTubesDto>();
            return supportTubesDtoList;
        }

        public void AddSupportTubes(MasterDataSupportTubesDto supportTubes)
        {
            MasterDataSupportTubes SupportTubes = supportTubes.CreateMapped<MasterDataSupportTubesDto, MasterDataSupportTubes>();
            MasterDataSupportTubesRepository.AddSupportTubes(SupportTubes);
        }

        public void UpdateSupportTubes(MasterDataSupportTubesDto supportTubes)
        {
            MasterDataSupportTubes SupportTubes = supportTubes.CreateMapped<MasterDataSupportTubesDto, MasterDataSupportTubes>();
            MasterDataSupportTubesRepository.UpdateSupportTubes(SupportTubes);
        }

        public void DeleteSupportTubes(MasterDataSupportTubesDto supportTubes)
        {
            MasterDataSupportTubes SupportTubes = supportTubes.CreateMapped<MasterDataSupportTubesDto, MasterDataSupportTubes>();
            MasterDataSupportTubesRepository.DeleteSupportTubes(SupportTubes);
        }
    }
}