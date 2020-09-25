using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LTQL.Models
{
    [Table("ChiTietLoaiHangs")]
    public class ChiTietLoaiHang
    {
        [Key]
        [MaxLength(10)]
        public String MaNCC { get; set; }
        [MaxLength(10)]
        public String TenNCC { get; set; }
        public int SoLuong { get; set; }


    }
}