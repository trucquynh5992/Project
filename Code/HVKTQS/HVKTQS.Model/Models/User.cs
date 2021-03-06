using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HVKTQS.Model.Models
{
    [Table("User")]
    public partial class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserID { get; set; }

        [Required]
        [StringLength(50)]
        public string UserName { get; set; }

        [Required]
        [StringLength(50)]
        public string Password { get; set; }

        [StringLength(10)]
        public string LastIPAddress { get; set; }

        public bool? IsLock { get; set; }

        [ForeignKey("UserID")]
        public virtual Employee Employees { get; set; }

        public virtual IEnumerable<EventUser> EventUsers { get; set; }
    }
}