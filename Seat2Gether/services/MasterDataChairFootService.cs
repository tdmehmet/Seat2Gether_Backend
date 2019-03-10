using Seat2Gether.dto;
using Seat2Gether.Models;
using Seat2Gether.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Seat2Gether.services
{
    public class MasterDataChairFootService
    {
        private MasterDataChairFootRepository ChairFootButtonRepository = null;
        public MasterDataChairFootService()
        {
            ChairFootButtonRepository = new MasterDataChairFootRepository();
        }

        public List<MasterDataChairFootDto> ChairFootList()
        {
            List<MasterDataChairFootDto> chairFootDtoList = new List<MasterDataChairFootDto>();
            List<MasterDataChairFoot> chairFootList = new List<MasterDataChairFoot>();
            chairFootList = ChairFootButtonRepository.ChairFootList();
            chairFootDtoList = chairFootList.CreateMappedList<MasterDataChairFoot, MasterDataChairFootDto>();
            return chairFootDtoList;
        }

        public void AddChairFoot(MasterDataChairFoot chairFoot)
        {
            //ChairFoot chairfoot_tmp = chairFoot.CreateMapped<ChairFootDto, ChairFoot>();
            ChairFootButtonRepository.AddChairFoot(chairFoot);
        }

        public void UpdateChairFoot(MasterDataChairFoot chairFoot)
        {
            //ChairFoot chairfoot_tmp = chairFoot.CreateMapped<ChairFootDto, ChairFoot>();
            ChairFootButtonRepository.UpdateChairFoot(chairFoot);

        }

        public void DeleteChairFoot(MasterDataChairFoot chairFoot)
        {
            //ChairFoot chairfoot_tmp = chairFoot.CreateMapped<ChairFootDto, ChairFoot>();
            ChairFootButtonRepository.DeleteChairFoot(chairFoot);
        }

       
    }

}