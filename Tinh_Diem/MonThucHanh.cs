﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Tinh_Diem
{
    class MonThucHanh : MyPoint, Diem
    {
        double cot1;
        double cot2;
        double cot3;
        double cot4;

        public override void Input()
        {
            base.Input();
            do
            {
                Console.Write("Nhập điểm cột 1: ");
                this.cot1 = Convert.ToInt32(Console.ReadLine());
            } while (this.cot1 < 0 && this.cot1 > 10);
            do
            {
                Console.Write("Nhập điểm cột 2: ");
                this.cot2 = Convert.ToInt32(Console.ReadLine());
            } while (this.cot2 < 0 && this.cot2 > 10);
            do
            {
                Console.Write("Nhập điểm cột 3: ");
                this.cot3 = Convert.ToInt32(Console.ReadLine());
            } while (this.cot3 < 0 && this.cot3 > 10);
            do
            {
                Console.Write("Nhập điểm cột 4: ");
                this.cot4 = Convert.ToInt32(Console.ReadLine());
            } while (this.cot4 < 0 && this.cot4 > 10);
            Console.WriteLine("Đã nhập xong!");
        }
        public override void Display()
        {
            base.Display();
            Console.WriteLine("Điểm cột 1: {0}", this.cot1);
            Console.WriteLine("Điểm cột 2: {0}", this.cot2);
            Console.WriteLine("Điểm cột 3: {0}", this.cot3);
            Console.WriteLine("Điểm cột 4: {0}", this.cot4);
            Console.WriteLine("Điểm trung bình môn: {0}", DTB());
            Console.WriteLine("Điểm chữ: {0}", DiemChu());
            Console.WriteLine("*****");
        }
        public double DTB() => (this.cot1 + this.cot2 + this.cot3 + this.cot4) / 4;
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
