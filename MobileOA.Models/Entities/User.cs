using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace MobileOA.Models.Entities
{
    [Table("OA_User")]
    public class User : IEntityBase
    {
        public User()
        {
            Permissions = new List<Permission>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Permission> Permissions { get; set; }
    }
}