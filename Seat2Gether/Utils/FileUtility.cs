using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace Seat2Gether.Utils
{
    public class FileUtility
    {

        public void writeFile(string filePath, string content)
        {
            if (!File.Exists(filePath))
            {
                File.WriteAllText(filePath, content);
            }

        }
    }
}