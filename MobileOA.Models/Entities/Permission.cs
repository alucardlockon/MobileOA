using System.ComponentModel.DataAnnotations.Schema;

namespace MobileOA.Models.Entities
{
    [Table("OA_Permission")]
    public class Permission : IEntityBase
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Enabled { get; set; }
    }
}