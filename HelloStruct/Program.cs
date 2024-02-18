using System;

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

            stu1.Speak();
        }

        interface ISpeak
        {
            void Speak();
        }

        //结构体使用方法和类很相似,还能实现接口
        struct Student:ISpeak
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public void Speak()
            {
                Console.WriteLine($"#{this.ID} Name:{this.Name}");
            }
        }
    }
}
