using Seat2Gether.dto;
using Seat2Gether.Models;
using Seat2Gether.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Seat2Gether.services
{
    public class ErrorService
    {
        private ErrorRepository ErrorRepository = null;

        public ErrorService()
        {
            ErrorRepository = new ErrorRepository();
        }

        public ErrorDto FindErrorById(string ErrorId)
        {
            return ErrorRepository.FindErrorById(ErrorId).CreateMapped<Error, ErrorDto>();
        }
    }
}