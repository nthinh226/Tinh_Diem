using System;
using System.Collections.Generic;
using System.Text;

namespace Tinh_Diem
{
    abstract class MyPoint: IPoint
    {
        public string maMon;
        public string tenMon;
        public int soTinChi;

        public virtual void Display()
        {
            Console.WriteLine("*****");
            Console.WriteLine("Mã môn học: {0}", this.maMon);
            Console.WriteLine("Tên môn: {0}", this.tenMon);
            Console.WriteLine("Số tín chỉ: {0}", this.soTinChi);
            Console.WriteLine("*****");
        }
        public virtual void Input()
        {
            do
            {
                Console.Write("Nhập mã môn học tối thiểu 4 ký tự: ");
                this.maMon = Console.ReadLine();
            } while (this.maMon.Trim().Length < 4);
            do
            {
                Console.Write("Nhập tên môn học tối thiểu 6 ký tự: ");
                this.tenMon = Console.ReadLine();
            } while (this.tenMon.Trim().Length < 6);
            do
            {
                Console.Write("Nhập số tín chỉ: ");
                this.soTinChi = Convert.ToInt32(Console.ReadLine());
            } while (this.soTinChi < 1);
        }
    }
}
