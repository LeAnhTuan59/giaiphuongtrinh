using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace giaiphuongtrinh.Models
{
    public class Khachhang
    {
        [Key]
        public string MaKH { get; set; }
        public string TenKH { get; set; }
    }
}