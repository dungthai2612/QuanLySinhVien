using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien
{
    internal class QLSinhVien
    {
        Dictionary<string, SinhVien> danhsach = new Dictionary<string, SinhVien>();  
        internal Dictionary<string, SinhVien> Danhsach
        {
            get { return danhsach; }
            set { danhsach = value; }
        }
        public QLSinhVien()
        {

        }
        public void LuaChon()
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            while (true)
            {
                Console.WriteLine("-------****** Chương trình quản lý sinh viên ******--------- \n Nhập 0 để thoát \n Nhập 1 để nhập \n Nhập 2 để xuất danh sách sinh viên \n Nhập 3 để đếm tổng số sinh viên  \n ---------*****************************************-------");
                string luaChon = Console.ReadLine();
                if (luaChon == "0")
                    break;
                else if (luaChon == "1")
                    Nhap();
                else if (luaChon == "2")
                    Xuat();
                else if (luaChon == "3")
                    Dem();
            }
            
                
        }
        public void Nhap()
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            while (true)
            {
                Console.WriteLine("Nhập A để nhập sinh viên khoa CNTT \nNhập B để nhập sinh viên khoa điện tử \nNhập E để thoát khỏi yêu cầu nhập");
                string option = Console.ReadLine().ToUpper();
                if (option == "E") break;
                if (option == "A")
                {
                    SinhVien CNTT = new SinhVienKCNTT();
                    while (true)
                    {
                        try
                        {
                            CNTT.Nhap();
                            danhsach.Add(CNTT.MSSV, CNTT);
                            break;
                        }
                        catch
                        {
                            Console.WriteLine("Nhập bị trùng mã hoặc sai định dạng ngày tháng ");

                        }
                    }

                }
                else if (option == "B")
                {
                    SinhVien DT = new SinhVienDienTu();
                    while (true)
                    {
                        try
                        {
                            DT.Nhap();
                            danhsach.Add(DT.MSSV, DT);
                            break;
                        }
                        catch
                        {
                            Console.WriteLine("Nhập bị sai mã hoặc sai định dạng");
                        }
                    }
                }
                else Console.WriteLine("NHập sai lựa chọn!!!");
            }
        }
        public void Xuat()
        {
            foreach(SinhVien item in danhsach.Values)
            {
                item.Xuat();
            }
        }
        public void Dem()
        {
            int GioiCNTT = 0, KhaCNTT = 0, TBCNTT = 0, YeuCNTT = 0;
            int GioiDT =0, KhaDT = 0,TBDT=0, YeuDT=0;
            foreach(SinhVien item in danhsach.Values)
            {
                if(item is SinhVienKCNTT)
                {
                    if (((SinhVienKCNTT)item).TinhXepLoaiCNTT() == "Giỏi")
                    {
                        GioiCNTT++;
                    }
                    else if(((SinhVienKCNTT)item).TinhXepLoaiCNTT() == "Khá")
                    {
                        KhaCNTT += 1;
                    }
                    else if (((SinhVienKCNTT)item).TinhXepLoaiCNTT() == "Trung bình")
                    {
                        TBCNTT += 1;
                    }
                    else 
                    {
                        YeuCNTT += 1;
                    }
                }
                else 
                {
                    if (((SinhVienDienTu)item).TinhXepLoaiDT() == "Giỏi")
                    {
                        GioiDT++;
                    }
                    else if (((SinhVienDienTu)item).TinhXepLoaiDT() == "Khá")
                    {
                        KhaDT += 1;
                    }
                    else if (((SinhVienDienTu)item).TinhXepLoaiDT() == "Trung bình")
                    {
                        TBDT += 1;
                    }
                    else
                    {
                        YeuDT += 1;
                    }
                }
                
            }
            Console.WriteLine("------------ Xếp loại khoa CNTT -----------");
            Console.WriteLine("Số sinh viên Gioi khoa CNTT là:{0}", GioiCNTT);
            Console.WriteLine("Số sinh viên Khá khoa CNTT là:{0}", KhaCNTT);
            Console.WriteLine("Số sinh viên Trung Bình khoa CNTT là:{0}", TBCNTT);
            Console.WriteLine("Số sinh viên Yếu khoa CNTT là:{0}", YeuCNTT);
            Console.WriteLine("------------ Xếp loại khoa Điện Tử -----------");
            Console.WriteLine("Số sinh viên Gioi khoa ĐT là:{0}", GioiCNTT);
            Console.WriteLine("Số sinh viên Khá khoa ĐT là:{0}", KhaCNTT);
            Console.WriteLine("Số sinh viên Trung Bình khoa ĐT là:{0}", TBCNTT);
            Console.WriteLine("Số sinh viên Yếu khoa ĐT là:{0}", YeuCNTT);

        }
    }
}
