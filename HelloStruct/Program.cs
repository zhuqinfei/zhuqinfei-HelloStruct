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
            Student stu1 = new Student() { ID = 101, Name = "Tony" };
            //结构体和类最大的区别就是，这里赋值是完全赋值过去，而不是引用，类的引用
            Student stu2 = stu1;
            stu2.ID = 1001;
            stu2.Name = "Mike";
           //打印出的内容还是之前stu1内容
            Console.WriteLine($"#{stu1.ID} Name:{stu1.Name}");
        }

        //结构体使用方法和类很相似
        struct Student
        {
            public int ID { get; set; }
            public string Name { get; set; }
        }
    }
}
