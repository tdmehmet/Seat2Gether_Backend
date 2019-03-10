using Seat2Gether.dto;
using Seat2Gether.Models;
using Seat2Gether.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Seat2Gether.services
{

    public class MasterDataChairTypeService
    {

        private MasterDataChairTypeRepository ChairTypeButtonRepository = null;

        public MasterDataChairTypeService()
        {
            ChairTypeButtonRepository = new MasterDataChairTypeRepository();
        }

        public List<MasterDataChairTypeDto> ChairTypeList()
        {

            List<MasterDataChairTypeDto> chairTypeDtoList = new List<MasterDataChairTypeDto>();
            List<MasterDataChairType> chairTypeList = new List<MasterDataChairType>();
            chairTypeList = ChairTypeButtonRepository.ChairTypeList();

            chairTypeDtoList = chairTypeList.CreateMappedList<MasterDataChairType, MasterDataChairTypeDto>();

            return chairTypeDtoList;
        }



        public void AddChairType(MasterDataChairType chairType)
        {

            ChairTypeButtonRepository.AddChairType(chairType);
        }

        public void UpdateChairType(MasterDataChairType chairType)
        {
            ChairTypeButtonRepository.UpdateChairType(chairType);

        }

        public void DeleteChairType(MasterDataChairType chairType)
        {
            ChairTypeButtonRepository.DeleteChairType(chairType);

        }



    }

}