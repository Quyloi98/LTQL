using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebsiteSieuThiMini.Models
{
    [Table("NhaCungCaps")]
    public class NhaCungCap
    {
        [Key]
        public String MaNhaCungCap { get; set; }
        public String TenNhaCungCap { get; set; }
        [MaxLength(15)]
        public int SoDienThoai { get; set; }
        [MaxLength()]
        public String DiaChi { get; set; }
    }
}