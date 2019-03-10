using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Seat2Gether.Models
{

    [Table("dbo.Tb_Material")]
    public class MasterDataMaterial
    {
        [Display(Name = "ID")]
        [Column("ID", Order = 0)]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal ID { get; set; }

        [Display(Name = "CharacteristicName")]
        [Column("CharacteristicName")]
        public string CharacteristicName { get; set; }

        [Display(Name = "CharacteristicValue")]
        [Column("CharacteristicValue")]
        public decimal CharacteristicValue { get; set; }

        [Display(Name = "MaterialNumber")]
        [Column("MaterialNumber")]
        public string MaterialNumber { get; set; }

        [Display(Name = "MBMaterialNumber")]
        [Column("MBMaterialNumber")]
        public string MBMaterialNumber { get; set; }

        [Display(Name = "ShortDescription")]
        [Column("ShortDescription")]
        public string ShortDescription { get; set; }

        [Display(Name = "Unit")]
        [Column("Unit")]
        public string Unit { get; set; }

        [Display(Name = "PNSK2")]
        [Column("PNSK2")]
        public string PNSK2 { get; set; }

        [Display(Name = "ClassType")]
        [Column("ClassType")]
        public string ClassType { get; set; }

        [Display(Name = "Class")]
        [Column("Class")]
        public string Class { get; set; }

        [Display(Name = "ProductionArea")]
        [Column("ProductionArea")]
        public decimal ProductionArea { get; set; }

        [Display(Name = "ChangeText")]
        [Column("ChangeText")]
        public string ChangeText { get; set; }

        [Display(Name = "Comment")]
        [Column("Comment")]
        public string Comment { get; set; }
    }
}