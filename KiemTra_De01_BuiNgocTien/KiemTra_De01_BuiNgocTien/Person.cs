using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiemTra_De01_BuiNgocTien
{
    public class Person
    {
        protected string name;
        protected string id;
        protected int ns;
        protected string gender;

        public Person()
        {
        }

        public Person(string name, string id, int ns, string gender)
        {
            this.name = name;
            this.id = id;
            this.ns = ns;
            this.gender = gender;
        }

        public void input()
        {
            Console.WriteLine("Nhap ho ten: "); this.name = Console.ReadLine();
            Console.WriteLine("Nhap id: "); this.id = Console.ReadLine();
            Console.WriteLine("Nhap nam sinh: "); this.ns = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap gioi tinh: "); this.gender = Console.ReadLine();
        }

        public void output()
        {
            Console.Write($"{this.name,20} {this.id,5} {this.ns,5} {this.gender,5}");
        }
        public int age()
        {
            return 2022 - this.ns;
        }
    }
}
