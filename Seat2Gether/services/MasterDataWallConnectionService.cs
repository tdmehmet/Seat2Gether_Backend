using Seat2Gether.dto;
using Seat2Gether.Models;
using Seat2Gether.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Seat2Gether.services
{

    public class MasterDataWallConnectionService
    {
        private MasterDataWallConnectionRepository WallConnectionButtonRepository = null;
        public MasterDataWallConnectionService()
        {
            WallConnectionButtonRepository = new MasterDataWallConnectionRepository();
        }

        public List<MasterDataWallConnectionDto> WallConnectionList()
        {
            List<MasterDataWallConnectionDto> wallConnectionDtoList = new List<MasterDataWallConnectionDto>();
            List<MasterDataWallConnection> wallConnectionList = new List<MasterDataWallConnection>();
            wallConnectionList = WallConnectionButtonRepository.WallConnectionList();
            wallConnectionDtoList = wallConnectionList.CreateMappedList<MasterDataWallConnection, MasterDataWallConnectionDto>();

            return wallConnectionDtoList;
        }

        public void AddWallConnection(MasterDataWallConnectionDto wallConnection)
        {
            MasterDataWallConnection wallconnection = wallConnection.CreateMapped<MasterDataWallConnectionDto, MasterDataWallConnection>();
            WallConnectionButtonRepository.AddWallConnection(wallconnection);
        }

        public void DeleteWallConnection(MasterDataWallConnectionDto wallConnection)
        {
            MasterDataWallConnection wallconnection = wallConnection.CreateMapped<MasterDataWallConnectionDto, MasterDataWallConnection>();
            WallConnectionButtonRepository.DeleteWallConnection(wallconnection);
        }
    }

}