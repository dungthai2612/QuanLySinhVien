using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien
{
    class SinhVien
    {
        string mssv;
        public string MSSV
        {
            get { return mssv; }
            set { mssv = value; }
        }
        string hoTen;
        public string HoTen
        {
            get { return hoTen; }
            set { hoTen = value; }
        }
        string diaChi;
        public string DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }
        DateTime ngaySinh;
        public DateTime NgaySinh
        {
            get { return ngaySinh; }
            set
            {
                ngaySinh = value;
            }
        }

        public SinhVien()
        {}
        public SinhVien(string mssv, string hoTen,string diaChi,DateTime ngaySinh)
        {
            this.mssv = mssv;
            
            this.HoTen = hoTen;
            
            this.DiaChi = diaChi;
            
            this.NgaySinh = ngaySinh;
            

        }
        public virtual void Nhap()
        {
            Console.WriteLine("Nhập mã số sinh viên : "); this.mssv = Console.ReadLine();
            Console.WriteLine("Nhập họ tên sinh viên : "); this.hoTen = Console.ReadLine();
            Console.WriteLine("Nhập địa chỉ sinh viên : "); this.DiaChi = Console.ReadLine();
            Console.WriteLine("Nhập ngày sinh của sinh viên :"); this.ngaySinh = DateTime.Parse(Console.ReadLine());

        }
        public virtual void Xuat()
        {
            Console.WriteLine("Mã số sinh viên là : {0}", this.mssv);
            Console.WriteLine("Họ tên sinh viên là :{0}", this.hoTen);
            Console.WriteLine("Địa chỉ sinh viên là :{0}", this.diaChi);
            Console.WriteLine("Ngày sinh của sinh viên là {0}:",this.ngaySinh.ToString("dd/MM/yyyy"));
      

        }
    }
}
