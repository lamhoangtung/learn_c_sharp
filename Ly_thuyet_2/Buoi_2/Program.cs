using System;

namespace Buoi_2
{
    class Circle
    {
        protected Double x, y, r;

        public Circle (Double x, Double y, Double r){
            this.x = x;
            this.y = y;
            this.r = r;
        }

        public Double ChuVi()
        {
            return 2 * Math.PI * this.r;
        }

        public Double DienTich()
        {
            return 2 * Math.PI * this.r * this.r;
        }
    }

    class Sphere : Circle
    {
        private Double z;
        public Sphere(Double x, Double y, Double z, Double r):base(x, y, r)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.r = r;
        }
        public new Double DienTich()
        {
            return 4 * Math.PI * this.r * this.r;
        }
        public Double TheTich()
        {
            return (4 / 3) * Math.PI * Math.Pow(this.r, 3);
        }
     }

    class Cylinder : Circle
    {
        private Double z, h;
        public Cylinder(Double x, Double y, Double r, Double z, Double h):base(x, y, r)
        {
            this.x = x;
            this.y = y;
            this.r = r;
            this.z = z;
            this.h = h;
        }
        public Double DienTichXungQuanh()
        {
            return 2 * Math.PI * r * h;
        }

        public Double DienTichToanPhan()
        {
            return 2 * Math.PI * r * (r + h);
        }

        public Double TheTich()
        {
            return Math.PI * Math.Pow(r, 2) * h;
        }
    }

    class MainClass
    { 
        public static void Main(string[] args)
        {
            Circle hinhtron = new Circle(10, 5, 2);
            Console.WriteLine("Dien tich hinh tron la {0}", hinhtron.DienTich());
            Console.WriteLine("Chu vi hinh tron la {0}", hinhtron.ChuVi());
            Sphere hinhcau = new Sphere(10, 5, 3, 7);
            Console.WriteLine("Dien tich mat cau la {0}", hinhcau.DienTich());
            Console.WriteLine("The tich hinh cau la {0}", hinhcau.TheTich());
            Cylinder hinhtru = new Cylinder(10, 5, 3, 7, 8);
            Console.WriteLine("Dien tich xung quanh hinh tru la {0}", hinhtru.DienTichXungQuanh());
            Console.WriteLine("Dien tich toan phan hinh tru la {0}", hinhtru.DienTichToanPhan());
            Console.WriteLine("The tich hinh tru la {0}", hinhtru.TheTich());
        }
    }
}
