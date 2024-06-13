using Lab02;
using Microsoft.EntityFrameworkCore;

namespace GetStartedWinForms;

public class MonAnsContext : DbContext
{
    public DbSet<MonAn> monan { get; set; }
    public DbSet<NguoiDung> nguoidung { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlite("Data Source=MonAns.db");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {   //khoa ngoai
        modelBuilder.Entity<MonAn>()
            .HasOne<NguoiDung>()
            .WithMany()
            .HasForeignKey(m => m.IDNCC);
        // du lieu
        modelBuilder.Entity<NguoiDung>().HasData(
            new NguoiDung { IDNCC = 10001, HoVaTen = "Nguyen Van A", QuyenHan = 2 },
            new NguoiDung { IDNCC = 10002, HoVaTen = "Nguyen Van B", QuyenHan = 1  },
            new NguoiDung { IDNCC = 10003, HoVaTen = "Nguyen Van C" , QuyenHan = 1 },
            new NguoiDung { IDNCC = 10004, HoVaTen = "Nguyen Van D" , QuyenHan = 1 });

        modelBuilder.Entity<MonAn>().HasData(
            new MonAn { IDMA = 20001, TenMonAn = "Bún chả ", HinhAnh = "buncha.jpg", IDNCC = 10001 },
            new MonAn { IDMA = 20002, TenMonAn = "Bún riêu", HinhAnh = "bunrieu.jpg", IDNCC = 10002 },
            new MonAn { IDMA = 20005, TenMonAn = "Cơm  gà", HinhAnh = "comga.jpg", IDNCC = 10003 },
            new MonAn { IDMA = 20006, TenMonAn = "Cơm tấm", HinhAnh = "comtam.jpg", IDNCC = 10004 },
            new MonAn { IDMA = 20007, TenMonAn = "Cơm nhà 3 món", HinhAnh = "comnha.jpg", IDNCC = 10001 });
    }
}