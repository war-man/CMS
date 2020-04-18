using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CMS.Entity.Models
{
    [Table("Company", Schema = "dbo")]
    public class Company
    {
        [Key]
        [Required]
        public int ComanyId { get; set; }

        [Required]
        [StringLength(30, ErrorMessage = "The value cannot exceed 30 characters. ")]
        public string Name { get; set; }

        [StringLength(30, ErrorMessage = "The value cannot exceed 30 characters. ")]
        public string TypeOfBusiness { get; set; }

        [StringLength(300, ErrorMessage = "The value cannot exceed 300 characters. ")]
        public string Location { get; set; }

        [StringLength(500, ErrorMessage = "The value cannot exceed 500 characters. ")]
        public string Objectives { get; set; }

        [StringLength(500, ErrorMessage = "The value cannot exceed 500 characters. ")]
        public string Mission { get; set; }

        [StringLength(300, ErrorMessage = "The value cannot exceed 300 characters. ")]
        public int Vision { get; set; }

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
    }
}
