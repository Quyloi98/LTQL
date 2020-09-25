using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LTQL.Models
{
    [Table("NhaCC")]
    public class NhaCC
    {
        [Key]
        public String MaNCC { get; set; }
        public String TenNCC { get; set; }
        public String DiaChi { get; set; }
        public int SDT { get; set; }

    }
}