using Microsoft.AspNet.Identity.EntityFramework;
using System.ComponentModel.DataAnnotations.Schema;

namespace Seat2Gether.Models
{
    [Table("Tb_UserClaims")]
    public class UserClaim : IdentityUserClaim
    {
    }
}