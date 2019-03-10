using Seat2Gether.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Seat2Gether.Repositories
{
    public class MasterDataColourRepository
    {
        private Seat2GetherDBContext DBContext;

        public MasterDataColourRepository()
        {
            DBContext = new Seat2GetherDBContext();
        }

        public List<MasterDataColour> FindMasterDataColours()
        {
            var masterDataColourQuery = from masterDataColour in DBContext.MasterDataColour
                                        orderby masterDataColour.ColourIndex descending
                                        select masterDataColour;
            List<MasterDataColour> masterDataColourList = masterDataColourQuery.ToList();
            return masterDataColourList;
        }

        public MasterDataColour FindMasterDataColour(Int32 masterDataColourId)
        {
            var masterDataColourQuery = from colour in DBContext.MasterDataColour
                                        where colour.ColourIndex.Equals(masterDataColourId)
                                        select colour;
            MasterDataColour masterDataColour = masterDataColourQuery.FirstOrDefault();
            return masterDataColour;
        }

        public void DeleteMasterDataColour(MasterDataColour colour)
        {
            MasterDataColour x = FindMasterDataColour(colour.ColourIndex);
            DBContext.MasterDataColour.Attach(x);
            var entry = DBContext.Entry(x);
            entry.State = EntityState.Deleted;
            DBContext.SaveChanges();
            entry.State = EntityState.Unchanged;
        }

        public void SaveColor(MasterDataColour colour)
        {
            colour.ColourIndex = FindMinAvailableMasterDataColourId();
            
            DBContext.MasterDataColour.Add(colour);
            DBContext.SaveChanges();
        }

        private Int32 FindMinAvailableMasterDataColourId()
        {
            Int32 maxMasterDataColourId = DBContext.MasterDataColour.Max(colour => colour.ColourIndex);

            return maxMasterDataColourId + 1;

        }


        public void updateColor(MasterDataColour colour)
        {
            
            MasterDataColour x = FindMasterDataColour(colour.ColourIndex);
            x.Colour = colour.Colour;
            DBContext.MasterDataColour.Attach(x);
            var entry = DBContext.Entry(x);
            entry.State = EntityState.Unchanged;
            entry.State = EntityState.Modified;

            DBContext.SaveChanges();
            entry.State = EntityState.Unchanged;
        }
    }
}