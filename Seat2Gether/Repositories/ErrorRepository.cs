using Seat2Gether.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Seat2Gether.Repositories
{
    public class ErrorRepository
    {
        private Seat2GetherDBContext DBContext;

        public ErrorRepository()
        {
            DBContext = new Seat2GetherDBContext();
        }

        public Error FindErrorById(string ErrorId)
        {
            var errorQuery = from Error in DBContext.Error
                                    where Error.Id == ErrorId
                                    select Error;

            Error error = errorQuery.FirstOrDefault<Error>();
            return error;
        }
    }
}