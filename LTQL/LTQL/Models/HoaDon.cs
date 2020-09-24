using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LTQL.Models
{
    [Table("HoaDons")]
    public class HoaDon
    {
        [Key]
        public string MaHD { get; set; }
        public DateTime NgayLap { get; set; }
        public string MaNV { get; set; }
        public string MaKH { get; set; }
    }
}