using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebsiteSieuThiMini.Models
{
    [Table("HangHoa")]
    public class HangHoa
    {
        [Key]
        [MaxLength(10)]
        public String MaHangHoa { get; set; }
        [StringLength(50)]
        public String TenHangHoa { get; set; }
        public int Gia { get; set; }
        public DateTime NSX { get; set; }
        public DateTime HSD { get; set; }
        [MaxLength(10)]
        public String MaLoaiHangHoa { get; set; }
        [StringLength(50)]
        public String GhiChu { get; set; }

    }
}