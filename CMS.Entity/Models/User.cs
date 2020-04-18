using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CMS.Entity.Models
{
    [Table("User", Schema = "dbo")]
    public class User
    {
        [Key]
        [Required]
        public int UserId { get; set; }

        [Required]
        [StringLength(30, ErrorMessage = "The value cannot exceed 30 characters. ")]
        public string Name { get; set; }

        [Required]
        [StringLength(30, ErrorMessage = "The value cannot exceed 30 characters. ")]
        public string Password { get; set; }

        [StringLength(20, ErrorMessage = "The value cannot exceed 20 characters. ")]
        public string PhoneNumber { get; set; }

        [StringLength(15, ErrorMessage = "The value cannot exceed 15 characters. ")]
        public string Gender { get; set; }

        [StringLength(500, ErrorMessage = "The value cannot exceed 500 characters. ")]
        public string Address { get; set; }

        [Required]
        public DateTime CreatedDate { get; set; }

        [Required]
        public DateTime ModifiedDate { get; set; }

        [Required]
        public DateTime LastAccessedDate { get; set; }

        [Required]
        public int CreatedBy { get; set; }

        [Required]
        public int ModifiedBy { get; set; }

        [Required]
        public bool IsDeleted { get; set; }

        [Required]
        public bool IsActive { get; set; }


        [StringLength(10, ErrorMessage = "The value cannot exceed 10 characters. ")]
        public string Color { get; set; }

        [Required]
        [ForeignKey("Company")]
        public int CompanyId { get; set; }
        public virtual Company Company { get; set; }

        [Required]
        [ForeignKey("Branch")]
        public int BranchId { get; set; }
        public virtual Branch Branch { get; set; }

        [Required]
        [ForeignKey("Designation")]
        public int DesignationId { get; set; }
        public virtual Designation Designation { get; set; }

        [Required]
        [ForeignKey("Department")]
        public int DepartmentId { get; set; }
        public virtual Department Department { get; set; }

        [Required]
        [ForeignKey("Role")]
        public int RoleId { get; set; }
        public virtual Role Role { get; set; }
    }
}
