using Seat2Gether.dto;
using Seat2Gether.Models;
using Seat2Gether.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Seat2Gether.services
{
    public class SpecialChairService
    {
        private SpecialChairRepository SpecialChairRepository = null;

        public SpecialChairService()
        {
            SpecialChairRepository = new SpecialChairRepository();
        }

        public List<BBNRUADriverChairDto> SP_BBNR_UA_Special_Chair_List(string orderId)
        {

            List<BBNRUADriverChairDto> specialChairDtoList = new List<BBNRUADriverChairDto>();
            List<BBNRUASpecialChair> specialChairList = new List<BBNRUASpecialChair>();
            specialChairList = SpecialChairRepository.SP_BBNR_UA_Special_Chair_Call(orderId);

            specialChairDtoList = specialChairList.CreateMappedList<BBNRUASpecialChair, BBNRUADriverChairDto>();

            return specialChairDtoList;
        }


        public List<BBNRUADriverChairPartsListDto> SP_BBNR_UA_Special_Chair_Part_List(string orderId)
        {

            List<BBNRUADriverChairPartsListDto> specialChairPartListDtoList = new List<BBNRUADriverChairPartsListDto>();
            List<BBNRUASpecialChairPartsList> specialChairPartList = new List<BBNRUASpecialChairPartsList>();
            specialChairPartList = SpecialChairRepository.SP_BBNR_UA_Special_Chair_Part_List_Call(orderId);

            specialChairPartListDtoList = specialChairPartList.CreateMappedList<BBNRUASpecialChairPartsList, BBNRUADriverChairPartsListDto>();

            return specialChairPartListDtoList;
        }
    }
}