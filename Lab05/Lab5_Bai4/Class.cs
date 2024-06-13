using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Lab4_Bai7
{
    public class MonAn
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("ten_mon_an")]
        public string TenMonAn { get; set; }

        [JsonProperty("gia")]
        public double Gia { get; set; }

        [JsonProperty("mo_ta")]
        public string MoTa { get; set; }

        [JsonProperty("hinh_anh")]
        public string HinhAnh { get; set; }

        [JsonProperty("dia_chi")]
        public string DiaChi { get; set; }

        [JsonProperty("nguoi_dong_gop")]
        public string NguoiDongGop { get; set; }
    }

    public class ApiResponse
    {
        [JsonProperty("data")]
        public List<MonAn> Data { get; set; }

        [JsonProperty("pagination")]
        public Pagination Pagination { get; set; }
    }

    public class Pagination
    {
        [JsonProperty("current")]
        public int Current { get; set; }

        [JsonProperty("pageSize")]
        public int PageSize { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }
    }


}
