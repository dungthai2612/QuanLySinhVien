using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien
{
    class SinhVienDienTu : SinhVien
    {
        double diemEE200;
        public double DiemEE200
        {
            get { return diemEE200; }
            set
            {
                diemEE200 = value;
            }
        }
        double diemEE201;
        public double DiemEE201
        {
            get { return diemEE201; }
            set
            {
                diemEE201 = value;
            }
        }
        double diemEE205;
        public double DiemEE205
        {
            get { return diemEE205; }
            set { diemEE205 = value; }
        }
        double diemTB;
        public double DiemTB
        {
            get { return diemTB; }
            set { diemTB = value; }
        }

        public SinhVienDienTu() : base()
        {
        }
        public SinhVienDienTu(string mssv, string hoTen, string diaChi, DateTime ngaySinh)
            : base(mssv, hoTen, diaChi, ngaySinh)
        {
            this.diemEE200 = diemEE200;
            this.diemEE201 = diemEE201;
            this.diemEE205 = diemEE205;
            this.DiemTB = diemTB;
        }

        public override void Nhap()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("******* Nhập thông tin sinh viên khoa DienTu *******");
            base.Nhap();
            Console.WriteLine("Nhập điểm EE200 : "); this.diemEE200 = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhập điểm EE201 : "); this.diemEE201 = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhập điểm EE205 : "); this.diemEE205 = double.Parse(Console.ReadLine());
            this.DiemTB = ((this.diemEE200+ this.diemEE201 + this.diemEE205) / 3);
        }
        public string TinhXepLoaiDT()
        {
            if (DiemTB >= 8)
                return "Giỏi";
            else if (DiemTB >= 6.5)
                return "Khá";
            else if (DiemTB >= 5)
                return "Trung Bình";
            else
                return "Yếu";
        }
        public override void Xuat()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("*******  Thông tin sinh viên khoa Dien Tu *******");
            base.Xuat();
            Console.WriteLine("Điểm môn EE200 :" + this.diemEE200);
            Console.WriteLine("Điểm môn EE201 :" + this.diemEE201);
            Console.WriteLine("Điểm môn EE205 : " + this.diemEE205);
            Console.WriteLine("Điểm trung bình :" + this.diemTB);
            Console.WriteLine("Xếp loại: " + TinhXepLoaiDT());
        }
    }
}

