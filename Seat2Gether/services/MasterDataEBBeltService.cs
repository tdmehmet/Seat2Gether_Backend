using Seat2Gether.dto;
using Seat2Gether.Models;
using Seat2Gether.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Seat2Gether.services
{

    public class MasterDataEBBeltService
    {
        private MasterDataEBBeltRepository EBBeltButtonRepository = null;
        public MasterDataEBBeltService()
        {
            EBBeltButtonRepository = new MasterDataEBBeltRepository();
        }

        public List<MasterDataEBBeltDto> EBBeltList()
        {
            List<MasterDataEBBeltDto> eBBeltDtoList = new List<MasterDataEBBeltDto>();
            List<MasterDataEBBelt> eBBeltList = new List<MasterDataEBBelt>();
            eBBeltList = EBBeltButtonRepository.EBBelteList();
            eBBeltDtoList = eBBeltList.CreateMappedList<MasterDataEBBelt, MasterDataEBBeltDto>();
            return eBBeltDtoList;
        }

        public void AddEBBelt(MasterDataEBBelt eBBelt)
        {
            EBBeltButtonRepository.AddEBBelt(eBBelt);
        }

        public void UpdateEBBelt(MasterDataEBBelt eBBelt)
        {
            EBBeltButtonRepository.UpdateEBBelt(eBBelt);
        }

        public void DeleteEBBelt(MasterDataEBBelt eBBelt)
        {
            EBBeltButtonRepository.DeleteEBBelt(eBBelt);
        }
    }
}