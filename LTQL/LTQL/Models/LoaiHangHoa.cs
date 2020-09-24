using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LTQL.Models
{
    [Table("LoaiHangHoas")]
    public class LoaiHangHoa
    {
        [Key]
        public string MaLHH { get; set; }
        public string TenLHH { get; set; }
        public string GhiChu { get; set; }
        public string MaGH { get; set; }
    }
}