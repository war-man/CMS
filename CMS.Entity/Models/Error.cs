using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CMS.Entity.Models
{
    [Table("Error", Schema = "dbo")]
    public class Error
    {
            [Key]
            [Required]
            public int ErrorId { get; set; }

            public string ControllerName { get; set; }

            public string MethodType { get; set; }

            public string MethodName { get; set; }

            [Required]
            [ForeignKey("User")]
            public int UserId { get; set; }
            public virtual User User { get; set; }

            [Required]
            [ForeignKey("Company")]
            public int CompanyId { get; set; }
            public virtual Company Company { get; set; }

            [Required]
            [ForeignKey("Branch")]
            public int BranchId { get; set; }
            public virtual Branch Branch { get; set; }

            public DateTime CreatedDate { get; set; }
            public string ErrorMessage { get; set; }
            public string Model { get; set; }
    }
}
