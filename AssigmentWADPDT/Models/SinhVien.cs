using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AssigmentWADPDT.Models
{
    public class SinhVien
    {
        [Key]
        public string MaSinhVien { get; set; }
        public string HinhThuc { get; set; }
        public int SoLuong { get; set; }
        public DateTime NgayNopPhat
        {
            get { return DateTime.Now; }
        }
    }
}