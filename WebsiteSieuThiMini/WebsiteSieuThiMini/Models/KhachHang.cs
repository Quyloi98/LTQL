using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebsiteSieuThiMini.Models
{
    [Table("KhachHangs")]
    public class KhachHang
    {
        [Key]
        public String MaKhachHang { get; set; }
        public String TenKhachHang { get; set; }
        [MaxLength(15)]
        public int SoDienThoai { get; set; }
        public String DiaChi { get; set; }
    }
}