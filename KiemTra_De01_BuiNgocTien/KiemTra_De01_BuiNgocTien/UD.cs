using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiemTra_De01_BuiNgocTien
{
    public class UD
    {
        List<Student> lStudent;

        public UD()
        {
            lStudent = new List<Student>();
        }

        public void nhap()
        {
            Console.WriteLine("Nhap thong tin hoc vien tham du");
            string s = "";
            do
            {
                Student student = new Student();
                student.input();
                lStudent.Add(student);
                Console.WriteLine("Ban co muon nhap tiep k (c/k) ? ");
                s = Console.ReadLine();
            } while (s != "k");
        }

        public void xuat()
        {
            foreach (Student student in lStudent)
            {
                student.output();
            }
        }

        public void searchMaxAge()
        {
            int max = lStudent.ElementAt(0).age();
            foreach(Student student in lStudent)
            {
                if(student.age() > max)
                {
                    max = student.age();
                }
            }
            Console.WriteLine("Nhung thanh vien cao tuoi nhat la: ");
            foreach(Student student in lStudent)
            {
                if(student.age() == max)
                {
                    student.output();
                }
            }
        }

        public void sortByTGTG()
        {
            lStudent.Sort(
                (s1, s2) => {
                    if (s1.getTGTG() < s2.getTGTG()) return -1;
                    if(s1.getTGTG() > s2.getTGTG()) return 1;
                    return 0;
                }    
            );

            Console.WriteLine("Sau khi sap xep: ");
            xuat();
        }

        public void findMinSLTT()
        {
            int min = lStudent.ElementAt(0).getSLTT();
            foreach(Student student in lStudent)
            {
                if(student.getSLTT() < min)
                {
                    min = student.getSLTT();
                }
            }

            Console.WriteLine("Hoc vien co so luot tuong tac it nhat la: ");
            foreach (Student student in lStudent)
            {
                if(student.getSLTT() == min)
                {
                    student.output();
                }
            }
        }
    }
}
