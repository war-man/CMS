using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CMS.Entity.Models
{
    [Table("Event", Schema = "dbo")]
    public class Event
    {
        [Key]
        [Required]
        public int EventId { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "The value cannot exceed 50 characters. ")]
        public string Name { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }

        [StringLength(10, ErrorMessage = "The value cannot exceed 10 characters. ")]
        public string LandingPage { get; set; }

        [StringLength(500, ErrorMessage = "The value cannot exceed 500 characters. ")]
        public string Location { get; set; }

        [StringLength(50, ErrorMessage = "The value cannot exceed 50 characters. ")]
        public string FbLink { get; set; }

        [StringLength(50, ErrorMessage = "The value cannot exceed 50 characters. ")]
        public string TwiterLink { get; set; }

        [StringLength(20, ErrorMessage = "The value cannot exceed 20 characters. ")]
        public string Email { get; set; }

        [StringLength(200, ErrorMessage = "The value cannot exceed 200 characters. ")]
        public string Speakers { get; set; }

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

    }
}
