using Seat2Gether.dto;
using Seat2Gether.Models;
using Seat2Gether.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Seat2Gether.services
{
    public class MasterDataStatusService
    {

        private MasterDataStatusRepository StatusButtonRepository = null;

        public MasterDataStatusService()
        {
            StatusButtonRepository = new MasterDataStatusRepository();
        }

        public List<MasterDataStatusDto> StatusList()
        {

            List<MasterDataStatusDto> statusDtoList = new List<MasterDataStatusDto>();
            List<MasterDataStatus> statusList = new List<MasterDataStatus>();
            statusList = StatusButtonRepository.StatusList();

            statusDtoList = statusList.CreateMappedList<MasterDataStatus, MasterDataStatusDto>();

            return statusDtoList;
        }



        public void AddStatus(MasterDataStatus status)
        {

            StatusButtonRepository.AddStatus(status);
        }


        public void DeleteStatus(MasterDataStatus status)
        {
            StatusButtonRepository.DeleteStatus(status);

        }


        public void UpdateStatus(MasterDataStatus status)
        {
            StatusButtonRepository.UpdateStatus(status);

        }
    }

}