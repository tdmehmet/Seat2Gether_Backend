#region Assembly Microsoft.AspNet.Identity.EntityFramework, Version=2.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// C:\Users\mehdede\Source\Repos\MBT_Bus_Dev\backend\packages\Microsoft.AspNet.Identity.EntityFramework.2.0.1\lib\net45\Microsoft.AspNet.Identity.EntityFramework.dll
#endregion

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Seat2Gether.Models
{
    public class GeneralParamDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Value1 { get; set; }
        public string Value2 { get; set; }
        public string Value3 { get; set; }
        public bool Active { get; set; }
        public string ParamGroup { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreateUser { get; set; }
        public DateTime UpdateDate { get; set; }
        public string UpdateUser { get; set; }
    }
}