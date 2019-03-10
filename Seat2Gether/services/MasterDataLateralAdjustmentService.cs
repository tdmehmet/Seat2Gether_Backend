using Seat2Gether.dto;
using Seat2Gether.Models;
using Seat2Gether.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Seat2Gether.services
{

    public class MasterDataLateralAdjustmentService
    {
        private MasterDataLateralAdjustmentRepository LateralAdjustmentButtonRepository = null;
        public MasterDataLateralAdjustmentService()
        {
            LateralAdjustmentButtonRepository = new MasterDataLateralAdjustmentRepository();
        }

        public List<MasterDataLateralAdjustmentDto> LateralAdjustmentList()
        {
            List<MasterDataLateralAdjustmentDto> lateralAdjustmentDtoList = new List<MasterDataLateralAdjustmentDto>();
            List<MasterDataLateralAdjustment> lateralAdjustmentList = new List<MasterDataLateralAdjustment>();
            lateralAdjustmentList = LateralAdjustmentButtonRepository.LateralAdjustmentList();
            lateralAdjustmentDtoList = lateralAdjustmentList.CreateMappedList<MasterDataLateralAdjustment, MasterDataLateralAdjustmentDto>();
            return lateralAdjustmentDtoList;
        }

        public void AddLateralAdjustment(MasterDataLateralAdjustment lateralAdjustment)
        {
            LateralAdjustmentButtonRepository.AddLateralAdjustment(lateralAdjustment);
        }

        public void UpdateLateralAdjustment(MasterDataLateralAdjustment lateralAdjustment)
        {
            LateralAdjustmentButtonRepository.UpdateLateralAdjustment(lateralAdjustment);
        }

        public void DeleteLateralAdjustment(MasterDataLateralAdjustment lateralAdjustment)
        {
            LateralAdjustmentButtonRepository.DeleteLateralAdjustment(lateralAdjustment);
        }
    }
}