using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Seat2Gether.dto;
using Seat2Gether.Models;
using Seat2Gether.Utils;
using Seat2Gether.Repositories;
using System.IO;

namespace Seat2Gether.services
{
    public class FileService
    {
        private FileUtility fileUtility = null;

        public FileService()
        {
            fileUtility = new FileUtility();
        }

        public void fileWriteForcam()
        {
            // TODO
            // later content and path will be read from DB
            string content = "test content write";
            string filePath = @"C:\temp\MyTest.txt";
            fileUtility.writeFile(filePath, content);
        }
    }
}