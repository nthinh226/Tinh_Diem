using System;
using System.Collections.Generic;
using System.Text;

namespace Tinh_Diem
{
    class MonLyThuyet:MyPoint, Diem
    {
        double diemTieuLuan;
        double diemCuoiKy;
        public override void Input()
        {
            base.Input();
            do
            {
                Console.Write("Nhập điểm tiểu luận: ");
                this.diemTieuLuan = Convert.ToInt32(Console.ReadLine());
            } while (this.diemTieuLuan < 0 && this.diemTieuLuan >10);
            do
            {
                Console.Write("Nhập điểm cuối kỳ: ");
                this.diemCuoiKy = Convert.ToInt32(Console.ReadLine());
            } while (this.diemCuoiKy < 0 && this.diemCuoiKy > 10);
            Console.WriteLine("Đã nhập xong!");
        }
        public override void Display()
        {
            base.Display();
            Console.WriteLine("Điểm tiểu luận: {0}", this.diemTieuLuan);
            Console.WriteLine("Điểm cuối kỳ: {0}", this.diemCuoiKy);
            Console.WriteLine("Điểm trung bình môn: {0}", DTB());
            Console.WriteLine("Điểm chữ: {0}", DiemChu());
            Console.WriteLine("*****");
        }
        public double DTB() => this.diemTieuLuan* 0.3 + this.diemCuoiKy* 0.7;
        public string DiemChu()
        {
            if (DTB() >= 8.5)
                return "A";
            else if (DTB() >= 7.0)
                return "B";
            else if (DTB() >= 5.5)
                return "C";
            else if (DTB() >= 4.0)
                return "D";
            else
                return "F";
        }
    }
}
