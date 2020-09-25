using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LTQL.Models
{
    [Table("User")]
    public class User
    {
        [Key]
        public String TaiKhoan { get; set; }
        public String MatKhau { get; set; }
    }
}