using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien
{
    internal class Program
    {
        static void Main(string[] args)
        {
            QLSinhVien QLSV = new QLSinhVien();
            QLSV.LuaChon();
            Console.WriteLine("Chương trình kết thúc");
            Console.WriteLine();
        }
    }
}
