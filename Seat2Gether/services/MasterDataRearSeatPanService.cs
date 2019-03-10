using Seat2Gether.dto;
using Seat2Gether.Models;
using Seat2Gether.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Seat2Gether.services
{

    public class MasterDataRearSeatPanService
    {
        private MasterDataRearSeatPanRepository RearSeatPanButtonRepository = null;
        public MasterDataRearSeatPanService()
        {
            RearSeatPanButtonRepository = new MasterDataRearSeatPanRepository();
        }

        public List<MasterDataRearSeatPanDto> RearSeatPanList()
        {

            List<MasterDataRearSeatPanDto> rearSeatPanDtoList = new List<MasterDataRearSeatPanDto>();
            List<MasterDataRearSeatPan> rearSeatPanList = new List<MasterDataRearSeatPan>();
            rearSeatPanList = RearSeatPanButtonRepository.RearSeatPanList();

            rearSeatPanDtoList = rearSeatPanList.CreateMappedList<MasterDataRearSeatPan, MasterDataRearSeatPanDto>();

            return rearSeatPanDtoList;
        }

        public void AddRearSeatPan(MasterDataRearSeatPanDto rearSeatPan)
        {
            MasterDataRearSeatPan rearseatpan = rearSeatPan.CreateMapped<MasterDataRearSeatPanDto, MasterDataRearSeatPan>();
            RearSeatPanButtonRepository.AddRearSeatPan(rearseatpan);
        }

        public void UpdateRearSeatPan(MasterDataRearSeatPanDto rearSeatPan)
        {
            MasterDataRearSeatPan rearseatpan = rearSeatPan.CreateMapped<MasterDataRearSeatPanDto, MasterDataRearSeatPan>();
            RearSeatPanButtonRepository.UpdateRearSeatPan(rearseatpan);
        }

        public void DeleteRearSeatPan(MasterDataRearSeatPanDto rearSeatPan)
        {
            MasterDataRearSeatPan rearseatpan = rearSeatPan.CreateMapped<MasterDataRearSeatPanDto, MasterDataRearSeatPan>();
            RearSeatPanButtonRepository.DeleteRearSeatPan(rearseatpan);
        }
    }

}