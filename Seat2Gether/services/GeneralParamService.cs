
using Seat2Gether.dto;
using Seat2Gether.Models;
using Seat2Gether.Repositories;
using System;
using System.Collections.Generic;

namespace Seat2Gether.services
{

    public class GeneralParamService
    {
        private GeneralParamRepository generalParamRepository = null;

        public GeneralParamService()
        {
            generalParamRepository = new GeneralParamRepository();
        }

        public List<GeneralParamDto> findGeneralParams()
        {
            List<GeneralParamDto> generalParamDtoList = new List<GeneralParamDto>();
            List<GeneralParam> generalParamList = generalParamRepository.FindGeneralParams();

            generalParamDtoList = generalParamList.CreateMappedList<GeneralParam, GeneralParamDto>();
            return generalParamDtoList;
        }

        public GeneralParamDto findGeneralParamByName(String Name)
        {
            GeneralParamDto generalParamDto = new GeneralParamDto();
            GeneralParam generalParam = generalParamRepository.FindGeneralParamByName(Name);

            generalParamDto = generalParam.CreateMapped<GeneralParam, GeneralParamDto>();
            return generalParamDto;
        }
    }
}