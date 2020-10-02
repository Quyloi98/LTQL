using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LTQL.Models
{
    [Table("HangHoas")]
    public class HangHoa
    {
        [Key]
        [MaxLength(10)]
        public String MaHH { get; set; }
        [MaxLength(50)]
        public String TenHH { get; set; }
        public int Gia { get; set; }
        public DateTime NSX { get; set; }
        public DateTime HSD { get; set; }
        [MaxLength(10)]
        public String MaLHH { get; set; }
        [MaxLength(50)]
        public String GhiChu { get; set; }
    }
}