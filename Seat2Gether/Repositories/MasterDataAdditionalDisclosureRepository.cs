using Seat2Gether.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Seat2Gether.Repositories
{


    public class MasterDataAdditionalDisclosureRepository
    {
        private Seat2GetherDBContext DBContext;

        public MasterDataAdditionalDisclosureRepository()
        {
            DBContext = new Seat2GetherDBContext();
        }


        public List<MasterDataAdditionalDisclosure> AdditionalDisclosureList()
        {

            var additionalDisclosureQuery = from additionalDisclosure in DBContext.AdditionalDisclosure
                                            orderby additionalDisclosure.LfdnrSpecification descending
                                            select additionalDisclosure;

            List<MasterDataAdditionalDisclosure> additionalDisclosureList = additionalDisclosureQuery.ToList();

            return additionalDisclosureList;
        }



        public void AddAdditionalDisclosure(MasterDataAdditionalDisclosure additionalDisclosure)
        {
            DBContext.AdditionalDisclosure.Add(additionalDisclosure);
            DBContext.SaveChanges();
        }


        public void DeleteAdditionalDisclosure(MasterDataAdditionalDisclosure additionalDisclosure)
        {
            DBContext.AdditionalDisclosure.Attach(additionalDisclosure);
            var entry = DBContext.Entry(additionalDisclosure);
            entry.State = EntityState.Deleted;
            DBContext.SaveChanges();
        }


        public void UpdateAdditionalDisclosure(MasterDataAdditionalDisclosure additionalDisclosure)
        {
            DBContext.AdditionalDisclosure.Attach(additionalDisclosure);
            var entry = DBContext.Entry(additionalDisclosure);
            entry.State = EntityState.Modified;

            DBContext.SaveChanges();
        }

    }

}