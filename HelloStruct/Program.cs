using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloStruct
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student() { ID = 101, Name = "Tony" };
            object obj = student;
            Student student2 = (Student)obj;
            Console.WriteLine($"#{student2.ID} Name:{student2.Name}");
        }

        //结构体使用方法和类很相似
        struct Student
        {
            public int ID { get; set; }
            public string Name { get; set; }
        }
    }
}
