using Seat2Gether.dto;
using Seat2Gether.Models;
using Seat2Gether.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Seat2Gether.services
{


    public class MasterDataAdditionalDisclosureService
    {

        private MasterDataAdditionalDisclosureRepository AdditionalDisclosureButtonRepository = null;

        public MasterDataAdditionalDisclosureService()
        {
            AdditionalDisclosureButtonRepository = new MasterDataAdditionalDisclosureRepository();
        }

        public List<MasterDataAdditionalDisclosureDto> AdditionalDisclosureList()
        {

            List<MasterDataAdditionalDisclosureDto> additionalDisclosureDtoList = new List<MasterDataAdditionalDisclosureDto>();
            List<MasterDataAdditionalDisclosure> additionalDisclosureList = new List<MasterDataAdditionalDisclosure>();
            additionalDisclosureList = AdditionalDisclosureButtonRepository.AdditionalDisclosureList();

            additionalDisclosureDtoList = additionalDisclosureList.CreateMappedList<MasterDataAdditionalDisclosure, MasterDataAdditionalDisclosureDto>();

            return additionalDisclosureDtoList;
        }



        public void AddAdditionalDisclosure(MasterDataAdditionalDisclosure additionalDisclosure)
        {

            AdditionalDisclosureButtonRepository.AddAdditionalDisclosure(additionalDisclosure);
        }


        public void DeleteAdditionalDisclosure(MasterDataAdditionalDisclosure additionalDisclosure)
        {
            AdditionalDisclosureButtonRepository.DeleteAdditionalDisclosure(additionalDisclosure);
        }


        public void UpdateAdditionalDisclosure(MasterDataAdditionalDisclosure additionalDisclosure)
        {
            AdditionalDisclosureButtonRepository.UpdateAdditionalDisclosure(additionalDisclosure);

        }
    }

}