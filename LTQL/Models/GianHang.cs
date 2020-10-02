using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LTQL.Models
{
    [Table("GianHangs")]
    public class GianHang
    {
        [Key]
        public string MaGH { get; set; }
        public string TenGH { get; set; }
        public string ViTri { get; set; }
        public string MaNQL { get; set; }
    }
}