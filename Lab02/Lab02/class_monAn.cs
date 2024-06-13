using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02
{
    public class MonAn
    {
        [Key]
        public int IDMA { get; set; }

        public string TenMonAn { get; set; }

        public string HinhAnh{ get; set; }
        public int IDNCC { get; set; }

    }



    internal class class_monAn
    {
    }
}
