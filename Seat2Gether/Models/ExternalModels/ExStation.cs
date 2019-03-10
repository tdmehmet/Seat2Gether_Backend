namespace Seat2Gether.Models.ExternalModels
{
   using System.Collections.Generic;
   using System.ComponentModel.DataAnnotations;
   using System.ComponentModel.DataAnnotations.Schema;

   [Table("ExTb_Station")]
    public partial class ExStation
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ExStation()
        {
            ExVehicleMaterial = new HashSet<ExVehicleMaterial>();
        }
       
        [Key]
        [StringLength(100)]
        public string StationNumber { get; set; }

        [StringLength(250)]
        public string StationName { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ExVehicleMaterial> ExVehicleMaterial { get; set; }
    }
}
