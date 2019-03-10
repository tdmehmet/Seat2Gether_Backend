using Seat2Gether.dto.ExternalDto;
using Seat2Gether.Models.ExternalModels;
using Seat2Gether.Repositories.ExternalRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Seat2Gether.services.ExternalServices
{
    public class SeatService
    {
        private SeatRepository Repository = null;

        public SeatService()
        {
            Repository = new SeatRepository();
        }
        public List<ExSeatPlacementDto> GetList()
        {
            return Repository.GetList().ToList().CreateMappedList<ExSeatPlacement, ExSeatPlacementDto>();
        }
        public List<ExSeatPlacementDto> GetList(string BBNumber)
        {
            return Repository.GetList().Where(k=>k.BBNumber==BBNumber).ToList().CreateMappedList<ExSeatPlacement, ExSeatPlacementDto>();
        }
        public ExSeatPlacementDto Find(params object[] Id)
        {
            return Repository.Find(Id).CreateMapped<ExSeatPlacement, ExSeatPlacementDto>();
        }
        public void Add(ExSeatPlacementDto entity)
        {
            Repository.Add(entity.CreateMapped<ExSeatPlacementDto, ExSeatPlacement>());
        }
        public void AddRange(List<ExSeatPlacementDto> entity)
        {

            Repository.AddRange(entity.CreateMappedList<ExSeatPlacementDto, ExSeatPlacement>());
        }
        public void Update(ExSeatPlacementDto entity)
        {
            Repository.Update(entity.CreateMapped<ExSeatPlacementDto, ExSeatPlacement>());
        }

        public void Delete(ExSeatPlacementDto entity)
        {

            Repository.Delete(entity.CreateMapped<ExSeatPlacementDto, ExSeatPlacement>());
        }
        public void Delete(params object[] keyValue)
        {
            var entity = Repository.Find(keyValue);
            Repository.Delete(entity);
        }
    }
}