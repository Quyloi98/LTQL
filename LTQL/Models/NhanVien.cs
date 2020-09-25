using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LTQL.Models
{
    [Table("NhanViens")]
    public class NhanVien
    {
        [Key]
        public string MaNV { get; set; }
        [MaxLength(20)]
        public string TenNV { get; set; }
        public DateTime NgaySinh { get; set; }
        public string QueQuan { get; set; }
        public int SDT { get; set; }
        public int Luong { get; set; }
        public string MaGH { get; set; }
        public string GioiTinh { get; set; }
    }
}