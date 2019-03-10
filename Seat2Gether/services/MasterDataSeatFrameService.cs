using Seat2Gether.dto;
using Seat2Gether.Models;
using Seat2Gether.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Seat2Gether.services
{
    public class MasterDataSeatFrameService
    {
        private MasterDataSeatFrameRepository MasterDataSeatFrameRepository = null;

        public MasterDataSeatFrameService()
        {
            MasterDataSeatFrameRepository = new MasterDataSeatFrameRepository();
        }

        public List<MasterDataSeatFrameDto> SeatFrameList()
        {
            List<MasterDataSeatFrame> seatFrameList = new List<MasterDataSeatFrame>();
            List<MasterDataSeatFrameDto> seatFrameDtoList = new List<MasterDataSeatFrameDto>();
            seatFrameList = MasterDataSeatFrameRepository.SeatFrameList();
            seatFrameDtoList = seatFrameList.CreateMappedList<MasterDataSeatFrame, MasterDataSeatFrameDto>();
            return seatFrameDtoList;
        }

        public void AddSeatFrame(MasterDataSeatFrameDto seatFrame)
        {
            MasterDataSeatFrame SeatFrame = seatFrame.CreateMapped<MasterDataSeatFrameDto, MasterDataSeatFrame>();
            MasterDataSeatFrameRepository.AddSeatFrame(SeatFrame);
        }

        public void UpdateSeatFrame(MasterDataSeatFrameDto seatFrame)
        {
            MasterDataSeatFrame SeatFrame = seatFrame.CreateMapped<MasterDataSeatFrameDto, MasterDataSeatFrame>();
            MasterDataSeatFrameRepository.UpdateSeatFrame(SeatFrame);
        }

        public void DeleteSeatFrame(MasterDataSeatFrameDto seatFrame)
        {
            MasterDataSeatFrame SeatFrame = seatFrame.CreateMapped<MasterDataSeatFrameDto, MasterDataSeatFrame>();
            MasterDataSeatFrameRepository.DeleteSeatFrame(SeatFrame);

        }



        public List<MasterDataSeatFramePartListDto> SeatFramePartList(string bbNumber)
        {
            List<MasterDataSeatFramePartListDto> seatFramePartList = new List<MasterDataSeatFramePartListDto>();
            //List<MasterDataSeatFramePartListDto> seatFramePartDtoList = new List<MasterDataSeatFramePartListDto>();
            seatFramePartList = MasterDataSeatFrameRepository.SeatFramePartList(bbNumber);
            //seatFramePartDtoList = seatFramePartList.CreateMappedList<MasterDataSeatFramePartList, MasterDataSeatFramePartListDto>();
            return seatFramePartList;
        }
    }
}