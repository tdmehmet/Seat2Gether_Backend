using Seat2Gether.dto.ExternalDto;
using Seat2Gether.Models;
using Seat2Gether.Models.ExternalModels;
using Seat2Gether.Repositories;
using Seat2Gether.Repositories.ExternalRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Seat2Gether.services.ExternalServices
{
    public class StationService
    {
        private StationRepository Repository = null;

        public StationService()
        {
            Repository = new StationRepository();
        }
        public List<ExStationDto> GetList()
        {
            return Repository.GetList().ToList().CreateMappedList<ExStation, ExStationDto>();
        }
        public List<ExStationDto> GetNamedList()
        {
            return Repository.GetList().Where (k=>!string.IsNullOrEmpty( k.StationName)).ToList().CreateMappedList<ExStation, ExStationDto>();
        }
        public bool Exist(string stationNumber)
        {
            return Repository.GetList().Any(k => k.StationNumber == stationNumber);
        }
        public ExStation Find(object Id)
        {
            return Repository.Find(Id);
        }
        public void Add(ExStationDto entity)
        {
            Repository.Add(entity.CreateMapped<ExStationDto, ExStation>());
        }
        public void AddRange(IEnumerable<ExStation> entity)
        {
            var stations = entity.Where(k => !Repository.GetList().Select(p => p.StationNumber).ToList().Contains(k.StationNumber)) ;
            Repository.AddRange(stations);
        }
        public void Update(ExStationDto entity)
        {
            var station = entity.CreateMapped<ExStationDto, ExStation>();
            Repository.Update(station);
        }

        public void Delete(ExStationDto entity)
        {
            var station = entity.CreateMapped<ExStationDto, ExStation>();
            Repository.Delete(station);
        }
        public void Delete(params object[] keyValue)
        {
            var entity = Repository.Find(keyValue);
            Repository.Delete(entity);
        }
    }
}