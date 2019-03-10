using Seat2Gether.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Seat2Gether.Repositories
{
    public class GeneralParamRepository
    {
        private Seat2GetherDBContext DBContext;

        public GeneralParamRepository()
        {
            DBContext = new Seat2GetherDBContext();
        }

        public GeneralParam FindGeneralParamByName(String generalParamName)
        {
            var generalParamQuery = from generalParams in DBContext.GeneralParams
                                    where generalParams.Name == generalParamName
                                    select generalParams;

            GeneralParam generalParam = generalParamQuery.FirstOrDefault<GeneralParam>();
            return generalParam;
        }

        public List<GeneralParam> FindGeneralParams()
        {
            var generalParamQuery = from generalParams in DBContext.GeneralParams
                                    select generalParams;

            List<GeneralParam> generalParamList = generalParamQuery.ToList();
            return generalParamList;
        }
    }
}