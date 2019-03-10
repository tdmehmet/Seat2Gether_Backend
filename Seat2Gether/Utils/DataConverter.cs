using HtmlAgilityPack;
using Seat2Gether.dto;
using Seat2Gether.dto.ExternalDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace Seat2Gether.Utils
{
    public class DataConverter
    {
        byte[] _binaryData;
        public DataConverter()
        {

        }
        public List<ExMaterialDto> Parse(byte[] data)
        {
            var strData = HttpUtility.HtmlDecode(Encoding.UTF8.GetString(data)
                .Replace("<colgroup>", "")
                .Replace("<tbody>", "")
                .Replace("</tbody>", ""));
            HtmlDocument doc = new HtmlDocument();
            doc.LoadHtml(HttpUtility.HtmlDecode(strData));
          
            var table = doc.DocumentNode
                .SelectNodes("//table")
                .First()
                .SelectNodes("tr")
                .Select(p => p.SelectNodes("td/font/nobr").Select(o => o.InnerText.Trim()).ToList())
                .Where((s, i) => i > 0).ToList();
           
            var list = table.Select(tr => new ExMaterialDto
            {
                VehicleBBNumber = tr[0],
                SubGroupId = tr[25],
                MaterialName=tr[28],
                Quantity = double.Parse(tr[29]),
                Unit = tr[30],
                MaterialNumber = tr[31],
                StationNumber=tr[40]
            }).ToList();

            return list;
        }
    }
}