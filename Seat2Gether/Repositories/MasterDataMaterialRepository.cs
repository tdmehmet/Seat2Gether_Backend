using Seat2Gether.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Seat2Gether.Repositories
{

        public class MasterDataMaterialRepository
        {
            private Seat2GetherDBContext DBContext;

            public MasterDataMaterialRepository()
            {
                DBContext = new Seat2GetherDBContext();
            }


            public List<MasterDataMaterial> MaterialList()
            {

                var materialQuery = from material in DBContext.Material
                                          select material;

                List<MasterDataMaterial> materialList = materialQuery.ToList();

                return materialList;
            }



        public void AddMaterial(MasterDataMaterial material)
        {
            DBContext.Material.Add(material);
            DBContext.SaveChanges();
        }


       


        public void UpdateMaterial(MasterDataMaterial material)
        {
            DBContext.Material.Attach(material);
            var entry = DBContext.Entry(material);
            entry.State = EntityState.Modified;

            DBContext.SaveChanges();
        }

        public void DeleteMaterial(MasterDataMaterial material)
        {
            DBContext.Material.Attach(material);
            var entry = DBContext.Entry(material);
            entry.State = EntityState.Deleted;
            DBContext.SaveChanges();
        }

    }
}
