using Seat2Gether.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Seat2Gether.Repositories
{
    public class SpecialChairRepository
    {
        private Seat2GetherDBContext DBContext;

        public SpecialChairRepository()
        {
            DBContext = new Seat2GetherDBContext();
        }

        public List<BBNRUASpecialChair> SP_BBNR_UA_Special_Chair_Call(string orderIDParameter)
        {

            var orderID = new SqlParameter("@AuftragsNr", orderIDParameter);

            var result = DBContext.Database
                .SqlQuery<BBNRUASpecialChair>("sp_BBNR_UA_Fahrerstuhl @AuftragsNr", orderID)
                .ToList();

            return result;

        }

        public List<BBNRUASpecialChairPartsList> SP_BBNR_UA_Special_Chair_Part_List_Call(string orderIDParameter)
        {

            var orderID = new SqlParameter("@AuftragsNr", orderIDParameter);

            var result = DBContext.Database
                .SqlQuery<BBNRUASpecialChairPartsList>("sp_BBNR_UA_Fahrerstuhl_Stückliste @AuftragsNr", orderID)
                .ToList();

            return result;

        }
    }
}