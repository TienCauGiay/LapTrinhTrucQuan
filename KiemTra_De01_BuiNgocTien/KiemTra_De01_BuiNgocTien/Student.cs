using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiemTra_De01_BuiNgocTien
{
    public class Student : Person
    {
        private int tgtg;
        private int sltt;

        public Student()
        {
        }

        public Student(string name, string id, int ns, string gender, int tgtg, int sltt) : base(name, id, ns, gender)
        {
            this.tgtg = tgtg;
            this.sltt = sltt;
        }

        public int getTGTG()
        {
            return this.tgtg;
        }

        public int getSLTT()
        {
            return this.sltt;
        }

        public new void input()
        {
            base.input();
            Console.WriteLine("Nhap thoi gian tham gia: "); this.tgtg = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so lan tuong tac: "); this.sltt = int.Parse(Console.ReadLine());
        }

        public new void output()
        {
            base.output();
            Console.Write($"{this.tgtg,5} {this.sltt,5}");
            Console.WriteLine();
        }
    }
}
