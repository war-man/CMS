using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CMS.Entity.Models
{
    [Table("Branch", Schema = "dbo")]
    public class Branch
    {
        [Key]
        [Required]
        public int BranchId { get; set; }

        [Required]
        [StringLength(30, ErrorMessage = "The value cannot exceed 30 characters. ")]
        public string Code { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "The value cannot exceed 50 characters. ")]
        public string Name { get; set; }

        
        [StringLength(300, ErrorMessage = "The value cannot exceed 300 characters. ")]
        public string Description { get; set; }

        [Required]
        public int BranchTypeId { get; set; }

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
    }
}
