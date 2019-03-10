using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Seat2Gether.Models.ExternalModels
{
    public class ExMaterialWarehouse
    {
        public ExMaterialWarehouse()
        {
            ExVehicleMaterial = new HashSet<ExVehicleMaterial>();
        }
        [Key]
        [StringLength(50)]
        public string MaterialNumber { get; set; }
        [StringLength(50)]
        public string WarehouseNumber { get; set; }
        [StringLength(50)]
        public string UndottedMaterialNumber { get; set; }

        public virtual ICollection<ExVehicleMaterial> ExVehicleMaterial { get; set; }
    }
}