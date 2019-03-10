using log4net;
using System;
using System.Data.Entity.Validation;
using System.Web.Http;

namespace Seat2Gether.Exceptions
{
    public class Seat2GetherExceptionWithCode : Exception
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(Seat2GetherExceptionWithCode));
        public string statusText { get; set; }

        public Seat2GetherExceptionWithCode(string ErrorId, string ClassName, string MethodName, Exception E)
        {
           

            log.Error("***********************************************************************************************");
            log.Error("ERROR ID                     : " + ErrorId);
            log.Error("CLASS NAME                   : " + ClassName);
            log.Error("METHOD NAME                  : " + MethodName);
            log.Error("EXCEPTION SOURCE             : " + E.Source);
            log.Error("EXCEPTION TARGETSITE         : " + E.TargetSite);
            log.Error("EXCEPTION MESSAGE            : " + E.Message);
            log.Error("EXCEPTION INNER EXCEPTION    : " + E.InnerException);
            log.Error("EXCEPTION STACKTRACE         : " + E.StackTrace);
            log.Error("***********************************************************************************************");
            this.statusText = E.Message;
           /* throw new Exception(
                ";errorId:" + ErrorId +
                ";className:" + ClassName +
                ";methodName:" + MethodName +
                ";source:" + E.Source +
                ";targetSite:" + E.TargetSite +
                ";message:" + E.Message +
                ";innerException:" + E.InnerException +
                ";stackTrace:" + E.StackTrace);*/
        }
    }
}
