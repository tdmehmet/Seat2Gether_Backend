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
    public class VehicleService
    {
        private VehicleRepository Repository = null;

        public VehicleService()
        {
            Repository = new VehicleRepository();
        }
        public List<ExVehicleDto> GetList()
        {
            return Repository.GetList().ToList().CreateMappedList<ExVehicle, ExVehicleDto>();
        }
        public List<ExVehicleDto> GetFilteredList(ExVehicleFilterDto vehicleFilterDto)
        {
            var result = Repository.GetList();

            if (!string.IsNullOrEmpty(vehicleFilterDto.BBNumber))
            {
                result = result.Where(t => t.BBNumber.Contains(vehicleFilterDto.BBNumber));
            }

            if (vehicleFilterDto.TypeId != null)
            {
                result = result.Where(t => t.TypeId.Value == vehicleFilterDto.TypeId.Value);
            }

            if (vehicleFilterDto.ModelId != null)
            {
                result = result.Where(t => t.ModelId.Value == vehicleFilterDto.ModelId.Value);
            }

            if (vehicleFilterDto.CountryId != null)
            {
                result = result.Where(t => t.CountryId.Value == vehicleFilterDto.CountryId.Value);
            }

            return result.ToList().CreateMappedList<ExVehicle, ExVehicleDto>();
        }
        public ExVehicleDto Find(object Id)
        {
            return Repository.Find(Id)?.CreateMapped<ExVehicle, ExVehicleDto>(); ;
        }
        public void Add(ExVehicleDto entity)
        {
            var vehicle = entity.CreateMapped<ExVehicleDto, ExVehicle>();
            //vehicle.InsertUser=
            Repository.Add(vehicle);
        }
        public void AddRange(IEnumerable<ExVehicle> entity)
        {
            Repository.AddRange(entity);
        }
        public void Update(ExVehicleDto entity)
        {
            var vehicle = entity.CreateMapped<ExVehicleDto, ExVehicle>();
            vehicle.UpdateDate = DateTime.Now;
            Repository.Update(vehicle);
        }

        public void Delete(ExVehicle entity)
        {
            Repository.Delete(entity);
        }
        public void Delete(params object[] keyValue)
        {
            var entity = Repository.Find(keyValue);
            Repository.Delete(entity);
        }
    }
}