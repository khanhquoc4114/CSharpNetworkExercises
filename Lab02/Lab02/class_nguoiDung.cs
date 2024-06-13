using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02
{
    public class NguoiDung
    {
        [Key]
        public int IDNCC { get; set; }

        public string HoVaTen { get; set; }

        public int QuyenHan { get; set; }

    }
    internal class class_nguoiDung
    {
    }
}
