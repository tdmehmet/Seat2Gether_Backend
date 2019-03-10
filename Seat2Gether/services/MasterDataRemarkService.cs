using Seat2Gether.dto;
using Seat2Gether.Models;
using Seat2Gether.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Seat2Gether.services
{

    public class MasterDataRemarkService
    {
        private MasterDataRemarkRepository RemarkButtonRepository = null;
        public MasterDataRemarkService()
        {
            RemarkButtonRepository = new MasterDataRemarkRepository();
        }

        public List<RemarkDto> RemarkList()
        {

            List<RemarkDto> remarkDtoList = new List<RemarkDto>();
            List<MasterDataRemark> remarkList = new List<MasterDataRemark>();
            remarkList = RemarkButtonRepository.RemarkList();

            remarkDtoList = remarkList.CreateMappedList<MasterDataRemark, RemarkDto>();

            return remarkDtoList;
        }

        public void AddRemark(RemarkDto remark)
        {
            MasterDataRemark remarkk = remark.CreateMapped<RemarkDto, MasterDataRemark>();
            RemarkButtonRepository.AddRemark(remarkk);
        }

        public void UpdateRemark(RemarkDto remark)
        {
            MasterDataRemark remarkk = remark.CreateMapped<RemarkDto, MasterDataRemark>();
            RemarkButtonRepository.UpdateRemark(remarkk);
        }

        public void DeleteRemark(RemarkDto remark)
        {
            MasterDataRemark remarkk = remark.CreateMapped<RemarkDto, MasterDataRemark>();
            RemarkButtonRepository.DeleteRemark(remarkk);
        }
    }


}