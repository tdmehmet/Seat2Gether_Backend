using Seat2Gether.dto;
using Seat2Gether.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Seat2Gether.Repositories
{
    public class MasterDataSeatFrameRepository
    {
        private Seat2GetherDBContext DBContext = null;

        public MasterDataSeatFrameRepository()
        {
            DBContext = new Seat2GetherDBContext();
        }

        public List<MasterDataSeatFrame> SeatFrameList()
        {
            var seatFrameQuery = from seatFrame in DBContext.SeatFrame
                                 select seatFrame;

            List<MasterDataSeatFrame> seatFrameList = seatFrameQuery.ToList();
            return seatFrameList;
        }

        public void AddSeatFrame(MasterDataSeatFrame seatFrame)
        {
            DBContext.SeatFrame.Add(seatFrame);
            DBContext.SaveChanges();
        }

        public void UpdateSeatFrame(MasterDataSeatFrame seatFrame)
        {
            DBContext.SeatFrame.Attach(seatFrame);
            var entry = DBContext.Entry(seatFrame);
            entry.State = EntityState.Modified;
            DBContext.SaveChanges();
        }

        public void DeleteSeatFrame(MasterDataSeatFrame seatFrame)
        {
            DBContext.SeatFrame.Attach(seatFrame);
            var entry = DBContext.Entry(seatFrame);
            entry.State = EntityState.Deleted;
            DBContext.SaveChanges();
        }


        public List<MasterDataSeatFramePartListDto> SeatFramePartList(string bbNumber)
        {
            //var seatFramePartListQuery = from seatFramePartList in DBContext.SeatFramePartList
            //                     select seatFramePartList;

            //List<MasterDataSeatFramePartList> seatFrameList = seatFramePartListQuery.ToList();
            //return seatFrameList;



            var query = from seatFramePart in DBContext.SeatFramePartList
                        join seatFrameCharacteristic in DBContext.SeatFrameCharacteristic on seatFramePart.Characteristic equals seatFrameCharacteristic.lfdNrCharacteristic
                        where seatFramePart.EbNumber == bbNumber
                        orderby (seatFramePart.EbNumber)
                        //select seatFrameCharacteristic;
                        select new MasterDataSeatFramePartListDto()
                        {
                            EbNumber=seatFramePart.EbNumber,
                            characteristic = seatFrameCharacteristic.characteristic,
                            TNRli =seatFramePart.TNRli,
                            TNRre=seatFramePart.TNRre,
                            Amount=seatFramePart.Amount
                            
                        };
            List<MasterDataSeatFramePartListDto> seatFrameList = query.ToList();
            return seatFrameList;

        }



    }
}