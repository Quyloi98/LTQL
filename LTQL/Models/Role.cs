using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LTQL.Models
{
    [Table("Roles")]
    public class Role
    {
        [Key]
        public string RoleID { get; set; }
        public string RoleName { get; set; }
    }
}