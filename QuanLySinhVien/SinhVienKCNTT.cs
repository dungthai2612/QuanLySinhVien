using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien
{
    class SinhVienKCNTT : SinhVien
    {
        double diemCS414;
        public double DiemCS414
        {
            get { return diemCS414; }
            set
            {
                diemCS414 = value;
            }
        }
        double diemIS311;
        public double DiemIS311
        {
            get { return diemIS311; }
            set
            {
                diemIS311 = value;
            }
        }
        double diemCS311;
        public double DiemCS311
        {
            get { return diemCS311; }
            set { diemCS311 = value; }
        }
        double diemTB;
        public double DiemTB
        {
            get { return diemTB; }
            set { diemTB = value; }
        }

        public SinhVienKCNTT () : base()
        { 
        }
        public SinhVienKCNTT (string mssv, string hoTen, string diaChi, DateTime ngaySinh) 
            : base(mssv,hoTen,diaChi,ngaySinh)
        {
            this.diemCS414 =diemCS414;
            this.diemIS311 = diemIS311;
            this.diemCS311 = diemCS311;
            this.DiemTB = diemTB;
        }
        
        public override void Nhap()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("******* Nhập thông tin sinh viên khoa CNTT *******");
            base.Nhap();
            Console.WriteLine("Nhập điểm CS414 : "); this.DiemCS414 = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhập điểm IS311 : "); this.DiemIS311 = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhập điểm CS311 : "); this.DiemCS311 = double.Parse(Console.ReadLine());
            this.DiemTB= ((this.diemCS414 + this.diemCS311 + this.DiemIS311) / 3 );
        }
        public string TinhXepLoaiCNTT()
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
            Console.WriteLine("*******  Thông tin sinh viên khoa CNTT *******");
            base.Xuat();
            Console.WriteLine("Điểm môn CS414 :"+ this.diemCS414);
            Console.WriteLine("Điểm môn IS311 :"+this.diemIS311);
            Console.WriteLine("Điểm môn CS311 : "+ this.diemCS311);
            Console.WriteLine("Điểm trung bình :"+this.diemTB);
            Console.WriteLine("Xếp loại: "+TinhXepLoaiCNTT());
        }
    }
}
