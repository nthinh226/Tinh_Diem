using System;
using System.Collections.Generic;
using System.Text;

namespace Tinh_Diem
{
    class MonDoAn:MyPoint, Diem
    {
        double diemGVHD;
        double diemGVPB;
        public override void Input()
        {
            base.Input();
            do
            {
                Console.Write("Nhập điểm giáo viên hướng dẫn: ");
                this.diemGVHD = Convert.ToDouble(Console.ReadLine());
            } while (this.diemGVHD < 0 && this.diemGVHD > 10);
            do
            {
                Console.Write("Nhập điểm giáo viên phản biện: ");
                this.diemGVPB = Convert.ToDouble(Console.ReadLine());
            } while (this.diemGVPB < 0 && this.diemGVPB > 10);
            Console.WriteLine("Đã nhập xong!");
        }
        public override void Display()
        {
            base.Display();
            Console.WriteLine("Điểm giáo viên hướng dẫn: {0}", this.diemGVHD);
            Console.WriteLine("Điểm giáo viên phản biện: {0}", this.diemGVPB);
            Console.WriteLine("Điểm trung bình môn: {0}", DTB());
            Console.WriteLine("Điểm chữ: {0}", DiemHe4(DTB()));
            Console.WriteLine("*****");
        }
        public double DTB() => (this.diemGVHD + this.diemGVPB) / 2;
    }
}
