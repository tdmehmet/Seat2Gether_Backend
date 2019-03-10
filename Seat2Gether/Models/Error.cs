using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Seat2Gether.Models
{
    [Table("Tb_Errors")]
    public class Error
    {
        [Display(Name = "ID")]
        [Column("ID")]
        [Key]
        public string Id { get; set; }


        [Display(Name = "Turkish")]
        [Column("Turkish")]
        public string Turkish { get; set; }

        [Display(Name = "English")]
        [Column("English")]
        public string English { get; set; }
    }
}