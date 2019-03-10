using Seat2Gether.dto;
using Seat2Gether.Models;
using Seat2Gether.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Seat2Gether.services
{
    public class MasterDataColourService
    {

        private MasterDataColourRepository MasterDataColourRepository = null;

        public MasterDataColourService()
        {
            MasterDataColourRepository = new MasterDataColourRepository();
        }

        public List<MasterDataColourDto> FindColors()
        {
            List<MasterDataColourDto> masterColourDtoList = new List<MasterDataColourDto>();
            List<MasterDataColour> masterColourList = new List<MasterDataColour>();
            masterColourList = MasterDataColourRepository.FindMasterDataColours();

            masterColourDtoList = masterColourList.CreateMappedList<MasterDataColour, MasterDataColourDto>();

            return masterColourDtoList;
        }

           
        

        public MasterDataColour FindColorById(Int32 Id)
        {
            return MasterDataColourRepository.FindMasterDataColour(Id);
        }

        public void SaveColour(MasterDataColour colour)
        {
            MasterDataColourRepository.SaveColor(colour);
        }

        public void DeleteColour(MasterDataColour colour)
        {
            MasterDataColourRepository.DeleteMasterDataColour(colour);
        }

        public void UpdateColour(MasterDataColour colour)
        {
            MasterDataColourRepository.updateColor(colour);

        }
    }
}